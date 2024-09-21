using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MsbSlipManagerWinForm.Models;
internal class SlipsDAO
{
    private string connectionString;

    public SlipsDAO()
    {
        connectionString = "datasource=localhost;port=3306;username=root;password=www##2846;database=msbslips;";
    }

    public List<Slip> getAllSlips()
    {
        List<Slip> returnThese = new List<Slip>();

        MySqlConnection connection = new MySqlConnection(connectionString);

        connection.Open();

        MySqlCommand command = new MySqlCommand("SELECT * FROM slips", connection);

        GetSlips(returnThese, command);

        connection.Close();

        return returnThese;
    }

    public List<GeneratedSlip> getGeneratedSlips(bool isReceived)
    {
        List<GeneratedSlip> returnThese = new List<GeneratedSlip>();

        MySqlConnection connection = new MySqlConnection(connectionString);

        connection.Open();

        MySqlCommand command = new MySqlCommand("SELECT * FROM generatedslips WHERE received = @received", connection);
        command.Parameters.AddWithValue("@received", isReceived);
        GetGenSlips(returnThese, command);

        connection.Close();

        return returnThese;
    }

    public List<GeneratedSlip> getGeneratedSlips()
    {
        List<GeneratedSlip> returnThese = new List<GeneratedSlip>();

        MySqlConnection connection = new MySqlConnection(connectionString);

        connection.Open();

        MySqlCommand command = new MySqlCommand("SELECT * FROM generatedslips;", connection);
        GetGenSlips(returnThese, command);

        connection.Close();

        return returnThese;
    }

    internal int AddOneSlip(Slip slip)
    {
        List<Slip> returnThese = new List<Slip>();

        MySqlConnection connection = new MySqlConnection(connectionString);

        connection.Open();

        var dateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        MySqlCommand command = new MySqlCommand("INSERT INTO `msbslips`.`slips` (`slipId`, `date`, `startTime`, `endTime`, `customerName`, `agentName`, `guardID`, `guardName`, `airline`, `flightNumber`,`overtime`,`holiday`,`iwillwalk`,`servicenolongerneeded`) VALUES (@slipId, @date, @startTime, @endTime, @customerName, @agentName, @guardId, @guardName, @airline, @flightNumber, @overtime, @holiday, @iwillwalk, @servicenolongerneeded)", connection);
        command.Parameters.AddWithValue("@slipId", slip.SlipId);
        command.Parameters.AddWithValue("@date", slip.DateTime.ToString("yyyy-MM-dd"));
        command.Parameters.AddWithValue("@startTime", slip.StartTime.ToString(dateTimeFormat));
        command.Parameters.AddWithValue("@endTime", slip.EndTime.ToString(dateTimeFormat));
        command.Parameters.AddWithValue("@customerName", slip.CustomerName);
        command.Parameters.AddWithValue("@agentName", slip.AgentName);
        command.Parameters.AddWithValue("@guardId", slip.EmployeeID);
        command.Parameters.AddWithValue("@guardName", slip.GuardName);
        command.Parameters.AddWithValue("@airline", slip.Airline);
        command.Parameters.AddWithValue("@flightNumber", slip.FlightNumber);
        command.Parameters.AddWithValue("@overtime", slip.Overtime);
        command.Parameters.AddWithValue("@holiday", slip.Holiday);
        command.Parameters.AddWithValue("@servicenolongerneeded", slip.ServiceNoLongerNeeded);
        command.Parameters.AddWithValue("@iwillwalk", slip.IWillWalk);


        int newRows = command.ExecuteNonQuery();


        RecieveSlip(slip.SlipId,slip.EmployeeID);


        connection.Close();

       return newRows;
    }

    private void RecieveSlip(string slipId,int employeeID)
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();
        
        MySqlCommand command = new MySqlCommand("Update `msbslips`.`generatedSlips` SET received = @received, receivedDate = NOW(), employeeID = @employeeID WHERE slipID = @slipID;", connection);
        command.Parameters.AddWithValue("@received", true);
        command.Parameters.AddWithValue("@slipID", slipId);
        command.Parameters.AddWithValue("@employeeID", employeeID);
        command.ExecuteNonQuery();
        connection.Close();
    }

    internal void UnRecieveSlip(string slipId)
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        MySqlCommand command = new MySqlCommand("Update `msbslips`.`generatedSlips` SET received = @received, receivedDate = @receivedDate, employeeID = @employeeID WHERE slipID = @slipID;", connection);
        command.Parameters.AddWithValue("@received", false);
        command.Parameters.AddWithValue("@slipID", slipId);
        command.Parameters.AddWithValue("@employeeID", null);
        command.Parameters.AddWithValue("@receivedDate", null);
        command.ExecuteNonQuery();
        connection.Close();
    }

    internal List<Slip> searchSlips(int employeeID, string selectedText,DateTime date, DateTime date2)
    {
        List<Slip> returnThese = new List<Slip>();

        MySqlConnection connection = new MySqlConnection(connectionString);

        connection.Open();

        if(selectedText.Equals("All"))
        {
            selectedText = string.Empty;
        }

        var searchWildPhrase = "%" + selectedText + "%";
        var dateWildPhrase = date.ToString("yyyy-MM-dd");
        var dateWildPhrase2 = date2.ToString("yyyy-MM-dd");

        MySqlCommand command = new MySqlCommand();

        //command.CommandText = "SELECT * FROM slips WHERE (airline LIKE @search AND date LIKE @date)";
        if(employeeID == -1)
        {
            command.CommandText = "SELECT * FROM slips WHERE (airline LIKE @search AND date >= @date AND date <= @date2)";
        }
        else
        {
            command.CommandText = "SELECT * FROM slips WHERE (guardId = @employeeID AND airline LIKE @search AND date >= @date AND date <= @date2)";
        }

        command.Parameters.AddWithValue("@search", searchWildPhrase);
        command.Parameters.AddWithValue("@date", dateWildPhrase);
        command.Parameters.AddWithValue("@date2", dateWildPhrase2);
        command.Parameters.AddWithValue("@employeeID", employeeID);
        command.Connection = connection;
        GetSlips(returnThese, command);

        connection.Close();

        return returnThese;
    }

    private static void GetSlips(List<Slip> returnThese, MySqlCommand command)
    {
        try
        {
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Slip slip = GenerateSlipObject(reader);

                    returnThese.Add(slip);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message} {ex.StackTrace}");
        }
    }

    private void GetGenSlips(List<GeneratedSlip> returnThese, MySqlCommand command)
    {
        var employees = GetEmployees();
        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                GeneratedSlip slip = new GeneratedSlip
                {
                    SlipID = reader.IsDBNull("slipID") ? string.Empty : reader.GetString("slipID"),
                    CreatedDate = reader.IsDBNull("createdDate") ? string.Empty : reader.GetDateTime("createdDate").ToString(),
                    ReceivedDate = reader.IsDBNull("receivedDate") ? string.Empty : reader.GetDateTime("receivedDate").ToString(),
                    Received = reader.GetBoolean("received"),
                    EmployeeID = reader.IsDBNull("employeeID") ? -1 : reader.GetInt32("employeeID"),
                    EmployeeName = reader.IsDBNull("employeeID") ? "N/A" : employees.FirstOrDefault(x => x.EmployeeId == reader.GetInt32("employeeID")).FullName
                };

                returnThese.Add(slip);
            }
        }
    }

    internal List<JObject> getSlipsForGuard(int guardID)
    {
        List<JObject> returnThese = new List<JObject>();

        MySqlConnection connection = new MySqlConnection(connectionString);

        connection.Open();

        var searchWildPhrase = "%" + guardID + "%";
        //var dateWildPhrase = "%" + date.ToString("yyyy-MM-dd") + "%";

        MySqlCommand command = new MySqlCommand();

        command.CommandText = "SELECT * FROM slips WHERE guardId = @guardId)";
        command.Parameters.AddWithValue("@guardId", searchWildPhrase);
        //command.Parameters.AddWithValue("@date", dateWildPhrase);
        command.Connection = connection;

        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                JObject jObject = new JObject();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    jObject.Add(reader.GetName(i),reader.GetValue(i).ToString());
                }
                returnThese.Add(jObject);
            }
        }

        connection.Close();

        return returnThese;
    }

    internal BindingList<Employee> GetEmployees()
    {
        BindingList<Employee> returnThese = new BindingList<Employee>();

        MySqlConnection connection = new MySqlConnection(connectionString);

        connection.Open();

        MySqlCommand command = new MySqlCommand("SELECT * FROM employees", connection);

        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Employee slip = new Employee
                {
                    EmployeeId = reader.GetInt32("employeeID"),
                    FirstName = reader.GetString("firstName"),
                    LastName = reader.GetString("lastName"),
                };
                    returnThese.Add(slip);
            }
        }

        connection.Close();

        return returnThese;
    }

    internal void AddNewEmployee(Employee emplee)
    {
        MySqlConnection connection = new MySqlConnection(connectionString);

        connection.Open();

        MySqlCommand command = new MySqlCommand("INSERT INTO `msbslips`.`employees` (`employeeID`, `firstName`, `lastName`) VALUES (@employeeID, @firstName, @lastName)", connection);
        command.Parameters.AddWithValue("@employeeID", emplee.EmployeeId);
        command.Parameters.AddWithValue("@firstName", emplee.FirstName);
        command.Parameters.AddWithValue("@lastName", emplee.LastName);

        int newRows = command.ExecuteNonQuery();
        connection.Close();
    }

    internal List<Tuple<string,string>> AddNewGeneratedSlip(int amount)
    {
        List<Tuple<string, string>> ids = new();
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        string item = string.Empty;

        for (int i = 1; i < amount + 1; i++)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `msbslips`.`generatedSlips` (`slipID`, `createdDate`) VALUES (@slipID, @createdDate)", connection);

            var slipID = PinGenerator(10);
            command.Parameters.AddWithValue("@slipID", slipID);
            command.Parameters.AddWithValue("@createdDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            command.ExecuteNonQuery();

            if(i % 2 == 0)
            {
                ids.Add(new Tuple<string, string>(item, slipID));   
            }
            else
            {
                item = slipID;
            }
        }

        return ids;
    }

    private static readonly Random _rdm = new Random();
    private string PinGenerator(int digits)
    {
        if (digits <= 1) return "";

        var _min = (int)Math.Pow(10, digits - 1);
        var _max = (int)Math.Pow(10, digits) - 1;
        return _rdm.Next(_min, _max).ToString();
    }

    IEnumerable<DateTime> Payday(DateTime startDate, int howMany)
    {
        int count = 0, mondays = 0;

        while (count < howMany)
        {
            startDate = startDate.AddDays(1);

            if (startDate.DayOfWeek == DayOfWeek.Monday && mondays == 0)
            {
                mondays++;
            }
            else if (startDate.DayOfWeek == DayOfWeek.Monday)
            {
                mondays = 0;
                count++;
                yield return startDate;
            }
        }
    }

    internal void DeleteSlipWithID(string? historySlipID)
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        MySqlCommand command = new MySqlCommand("DELETE FROM `msbslips`.`slips` WHERE slipid=@slipID",connection);

        command.Parameters.AddWithValue("@slipID", historySlipID);

        command.ExecuteNonQuery();

        connection.Close();
    }

    internal bool CheckIfExist(string data,out Slip slip)
    {
        slip = null;
        string sql = "SELECT * FROM `msbslips`.`slips` WHERE slipid = @a";

        using (MySqlConnection cn = new MySqlConnection(connectionString))
        {
            cn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@a", data);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        slip = GenerateSlipObject(reader);
                        return true;
                    }
                }
            }
        }

        return false;

    }

    private static Slip GenerateSlipObject(MySqlDataReader reader)
    {
        return new Slip
        {
            SlipId = reader.GetString("slipID"),
            StartTime = reader.GetDateTime("startTime"),
            EndTime = reader.GetDateTime("endTime"),
            DateTime = reader.GetDateTime("date"),
            CustomerName = reader.GetString("customerName"),
            AgentName = reader.GetString("agentName"),
            GuardName = reader.GetString("guardName"),
            FlightNumber = reader.GetString("flightNumber"),
            Airline = reader.GetString("airline"),
            EmployeeID = reader.GetInt32("guardId"),
            IWillWalk = reader.GetBoolean("iwillwalk"),
            ServiceNoLongerNeeded = reader.GetBoolean("servicenolongerneeded"),
            Overtime = reader.GetBoolean("overtime"),
            Holiday = reader.GetBoolean("holiday")

        };
    }

    internal void UpdateSlip(Slip slip)
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        var dateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        MySqlCommand command = new MySqlCommand("UPDATE `msbslips`.`slips` SET `slipId` = @slipId, `date`=@date, `startTime`=@startTime, `endTime`=@endTime, `customerName`=@customerName, `agentName`=@agentName, `guardID`=@guardID, `guardName`=@guardName, `airline`=@airline, `flightNumber`=@flightNumber,`overtime`=@overtime,`holiday`=@holiday,`iwillwalk`=@iwillwalk,`servicenolongerneeded`=@servicenolongerneeded WHERE slipId=@slipId;", connection);
        command.Parameters.AddWithValue("@slipId", slip.SlipId);
        command.Parameters.AddWithValue("@date", slip.DateTime.ToString("yyyy-MM-dd"));
        command.Parameters.AddWithValue("@startTime", slip.StartTime.ToString(dateTimeFormat));
        command.Parameters.AddWithValue("@endTime", slip.EndTime.ToString(dateTimeFormat));
        command.Parameters.AddWithValue("@customerName", slip.CustomerName);
        command.Parameters.AddWithValue("@agentName", slip.AgentName);
        command.Parameters.AddWithValue("@guardId", slip.EmployeeID);
        command.Parameters.AddWithValue("@guardName", slip.GuardName);
        command.Parameters.AddWithValue("@airline", slip.Airline);
        command.Parameters.AddWithValue("@flightNumber", slip.FlightNumber);
        command.Parameters.AddWithValue("@overtime", slip.Overtime);
        command.Parameters.AddWithValue("@holiday", slip.Holiday);
        command.Parameters.AddWithValue("@servicenolongerneeded", slip.ServiceNoLongerNeeded);
        command.Parameters.AddWithValue("@iwillwalk", slip.IWillWalk);


        int newRows = command.ExecuteNonQuery();
    }
}
