using CsvHelper.Configuration;
using CsvHelper;
using MsbSlipManagerWinForm.Models;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO.Ports;
using System.Windows.Forms;
using CsvHelper.Configuration.Attributes;
using System.Text;
using CsvHelper.TypeConversion;
using Syncfusion.XlsIO;

namespace MsbSlipManagerWinForm;

public partial class Form1 : Form
{

    BindingSource bindingSource = new BindingSource();

    private SerialPort serialPort;
    private bool _isDirty;
    private string _data;
    private string? _historySlipID;

    private StringBuilder sb = new();
    private string _filePath;

    public BindingList<Slip> Slips { get; set; } = new();
    public BindingList<Employee> Employees { get; set; } = new();
    public BindingList<Employee> FilterOptionsEmployees { get; set; } = new();
    //public BindingList<string> GuardNames { get; set; } = new();
    public BindingList<string> AgentNames { get; set; } = new();

    public Form1()
    {
        InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        SlipsDAO slipsDAO = new SlipsDAO();
        //slipsDAO.getAllSlips();


        Employees = slipsDAO.GetEmployees();
        FilterOptionsEmployees = slipsDAO.GetEmployees();
        FilterOptionsEmployees.Insert(0, new("All"));
        employeeCmb2.DisplayMember = "FullName";
        employeeCmb2.ValueMember = "EmployeeID";
        employeeCmb2.DataSource = FilterOptionsEmployees;

        guardNameCmbBox.DataSource = Employees;
        guardNameCmbBox.DisplayMember = "FullName";
        guardNameCmbBox.ValueMember = "EmployeeID";

        bindingSource.DataSource = slipsDAO.getAllSlips();

        historyListDataGrid.DataSource = bindingSource;

        //ag.DataSource = GuardNames;

        serialPort = new SerialPort("COM6");

        if (SerialPort.GetPortNames().Any(x => x == "COM6"))
        {
            serialPort.Open();
        }
        serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataRecieved);

        dataGridView2.AutoGenerateColumns = false;
        dataGridView2.DataSource = slipsDAO.getGeneratedSlips();

        historyListDataGrid.ContextMenuStrip = contextMenuStrip1;
    }

    private void port_DataRecieved(object sender, SerialDataReceivedEventArgs e)
    {
        if (_isDirty)
        {
            var result = MessageBox.Show($"You have not saved the data. Are You sure you would like to replace this unsaved data?", "Unsaved edits", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                _isDirty = false;
                return;
            }
        }

        //Show all Incoming Data in the port's buffer;
        _data = serialPort.ReadExisting();


        if (!string.IsNullOrWhiteSpace(_data))
        {

            SlipsDAO slipsDAO = new SlipsDAO();

            if (slipsDAO.CheckIfExist(_data, out Slip slip))
            {
                var result = MessageBox.Show($"The slip with id {_data} already exists. Would you like to see the slip information?", "Slip found", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    if (InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {

                            startTime.Value = slip.StartTime;
                            endTime.Value = slip.EndTime;
                            dateTimePicker1.Value = slip.DateTime;
                            fltNumTxtBox.Text = slip.FlightNumber;
                            airlineCmbBox.SelectedItem = slip.Airline;
                            passengerNameTxtBox.Text = slip.CustomerName;
                            agentNameTxtBox.Text = slip.AgentName;
                            guardNameCmbBox.Text = slip.GuardName;
                            slipIdTxtB.Text = slip.SlipId;
                            holidayChkB.Checked = slip.Holiday;
                            overTimeChbK.Checked = slip.Overtime;
                            serviceNoLongerNeededChkB.Checked = slip.ServiceNoLongerNeeded;
                            iWillWalkChkB.Checked = slip.IWillWalk;
                        }));
                    }
                }
                return;
            }

            WriteTextSafe(_data);

            //DataRow[] queryResult = _dataTable.Select(string.Format("Barcode ='{0}' ", _data));

            //if (queryResult.Length > 0)
            //{
            //    var product = queryResult[0].ItemArray;
            //    MessageBox.Show($"Product: {product[3]} Barcode: {product[2]} Amount: {product[4]}", "Item Exists", MessageBoxButtons.OK);
            //    _isDirty = false;
            //    var index = Convert.ToInt32(product[0]);
            //    dataGridView1.Rows[index - 1].Selected = true;

            //    this.Invoke((MethodInvoker)delegate
            //    {
            //        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
            //    });
            //    return;
            //}
        }
    }

    public void WriteTextSafe(string text)
    {
        if (slipIdTxtB.InvokeRequired)
        {
            // Call this same method but append THREAD2 to the text
            Action safeWrite = delegate { WriteTextSafe(text); };
            slipIdTxtB.Invoke(safeWrite);
        }
        else
            slipIdTxtB.Text = text;
    }

    private void submitBTN_Click(object sender, EventArgs e)
    {
        var employee = guardNameCmbBox.SelectedItem as Employee;

        if (employee is null)
        {
            MessageBox.Show("Cannot find employee with that name", "Employee Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        var slip = new Slip
        {
            StartTime = startTime.Value,
            EndTime = endTime.Value,
            DateTime = dateTimePicker1.Value,
            FlightNumber = fltNumTxtBox.Text,
            Airline = airlineCmbBox.SelectedItem.ToString(),
            CustomerName = passengerNameTxtBox.Text,
            AgentName = agentNameTxtBox.Text,
            GuardName = guardNameCmbBox.Text,
            SlipId = slipIdTxtB.Text,
            EmployeeID = employee.EmployeeId,
            Holiday = holidayChkB.Checked,
            Overtime = overTimeChbK.Checked,
            ServiceNoLongerNeeded = serviceNoLongerNeededChkB.Checked,
            IWillWalk = iWillWalkChkB.Checked
        };

        SlipsDAO slipsDAO = new SlipsDAO();


        if (slipsDAO.CheckIfExist(slipIdTxtB.Text, out Slip slip1))
        {
            var msgResult = MessageBox.Show("This slip is already in the system would you like to update this slip with these values?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (msgResult == DialogResult.Yes)
            {
                slipsDAO.UpdateSlip(slip);
            }
            else
            {
                return;
            }
        }
        else
        {
            slipsDAO.AddOneSlip(slip);
        }


        filterBTN_Click(sender, e);

        //MessageBox.Show($"{result} new row(s) inserted");

        dataGridView2.DataSource = slipsDAO.getGeneratedSlips();

        ResetForms();



    }

    private void historyListDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            _historySlipID = historyListDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

        }
    }

    private void ResetForms()
    {
        airlineCmbBox.SelectedIndex = -1;
        guardNameCmbBox.SelectedIndex = -1;
        fltNumTxtBox.Text = string.Empty;
        slipIdTxtB.Text = string.Empty;
        passengerNameTxtBox.Text = string.Empty;
        agentNameTxtBox.Text = string.Empty;
        startTime.Value = DateTime.Now;
        endTime.Value = DateTime.Now;
        dateTimePicker.Value = DateTime.Now;
        iWillWalkChkB.Checked = false;
        holidayChkB.Checked = false;
        overTimeChbK.Checked = false;
    }

    private void addNewEmpleeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var newEmployee = new AddNewEmployee();
        var result = newEmployee.ShowDialog();

        if (result == DialogResult.OK)
        {
            if (!Employees.Any(x => x.FirstName == newEmployee.FirstName && x.LastName == newEmployee.LastName))
            {
                var emplee = new Employee();
                emplee.FirstName = newEmployee.FirstName;
                emplee.LastName = newEmployee.LastName;
                emplee.EmployeeId = newEmployee.EmployeeID;

                SlipsDAO slipsDAO = new SlipsDAO();

                slipsDAO.AddNewEmployee(emplee);

                Employees.Add(emplee);
                FilterOptionsEmployees.Add(emplee);
            }
        }
    }

    private void airlineFilterCmbBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        //CreateDoc();
    }

    private void filterBTN_Click(object sender, EventArgs e)
    {
        SlipsDAO slipsDAO = new SlipsDAO();

        var employee = employeeCmb2.SelectedItem as Employee;
        int employeeID = -1;
        if (employee != null)
        {
            employeeID = employee.EmployeeId;
        }

        var list = slipsDAO.searchSlips(employeeID, airlineFilterCmbBox.SelectedItem?.ToString(), dateTimePicker.Value, dateTimePicker2.Value);

        bindingSource.DataSource = list;

        historyListDataGrid.DataSource = bindingSource;

        slipCntLBL.Text = $"Slip Count = {list.Count}";
    }

    private void employeeSlipDataToolStripMenuItem_Click(object sender, EventArgs e)
    {
        EmployeeSlipDetails employeeSlipDetails = new EmployeeSlipDetails();
        employeeSlipDetails.ShowDialog();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void radioButton_CheckedChanged(object sender, EventArgs e)
    {
        SlipsDAO slipsDAO = new SlipsDAO();

        var radioBtn = (RadioButton)sender;

        if (radioBtn.Checked)
        {
            switch (radioBtn.Text)
            {
                case "All":
                    dataGridView2.DataSource = slipsDAO.getGeneratedSlips();
                    break;
                case "Received":
                    dataGridView2.DataSource = slipsDAO.getGeneratedSlips(true);
                    break;
                case "Not Received":
                    dataGridView2.DataSource = slipsDAO.getGeneratedSlips(false);
                    break;
                default:
                    break;
            }
        }
    }

    private void printSlipsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var genSlip = new slipCountPicker();
        genSlip.ShowDialog();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void guardNameCmbBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SlipsDAO slipsDAO = new SlipsDAO();

        if (!string.IsNullOrWhiteSpace(_historySlipID))
        {
            slipsDAO.DeleteSlipWithID(_historySlipID);
            filterBTN_Click(sender, e);
            slipsDAO.UnRecieveSlip(_historySlipID);
        }
    }

    private void csvBtn_Click(object sender, EventArgs e)
    {
        try
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    _filePath = openFileDialog.FileName;
                    csvPathTxtb.Text = _filePath;
                }
            }
        }
        catch (Exception ex)
        {
            sb.Append($"Error: {ex.Message}");
            sb.Append(Environment.NewLine);
            logsTxtB.Text = sb.ToString();
        }
    }

    private void importBTN_Click(object sender, EventArgs e)
    {
        try
        {
            logsTxtB.Text = string.Empty;
            sb.Clear();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
                HeaderValidated = null,
                MissingFieldFound = null,
                IgnoreBlankLines = false,
                BadDataFound = null,
            };

            using (var reader = new StreamReader(_filePath))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<PessoaCSVMap>();

                var records = csv.GetRecords<SlipEx>().ToList();

                foreach (var record in records)
                {
                    sb.Append($"Added slip: {record.Date?.ToLongDateString()} | {record.FlightNumber} | {record.PassengerName} | {record.StartTime?.ToString("hh:mm tt")} | {record.EndTime?.ToString("hh:mm tt")} | {record.AgentName} | {record.GuardName}");
                    sb.Append(Environment.NewLine);
                    logsTxtB.Text = sb.ToString();
                }
            }
        }
        catch (CsvHelperException ex2)
        {
            sb.Append($"Error: {ex2.Message}");
            sb.Append($"Index: {ex2.Context.Reader.CurrentIndex}");
            sb.Append($"Index: {ex2.Context}");
            sb.Append(Environment.NewLine);
            logsTxtB.Text = sb.ToString();
        }
        catch (Exception ex)
        {
            sb.Append($"Error: {ex.Message}");
            sb.Append(Environment.NewLine);
            logsTxtB.Text = sb.ToString();
        }
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(_historySlipID))
        {

            SlipsDAO slipsDAO = new SlipsDAO();

            if (slipsDAO.CheckIfExist(_historySlipID, out Slip slip))
            {
                startTime.Value = slip.StartTime;
                endTime.Value = slip.EndTime;
                dateTimePicker1.Value = slip.DateTime;
                fltNumTxtBox.Text = slip.FlightNumber;
                airlineCmbBox.SelectedItem = slip.Airline;
                passengerNameTxtBox.Text = slip.CustomerName;
                agentNameTxtBox.Text = slip.AgentName;
                guardNameCmbBox.Text = slip.GuardName;
                slipIdTxtB.Text = slip.SlipId;
                holidayChkB.Checked = slip.Holiday;
                overTimeChbK.Checked = slip.Overtime;
                serviceNoLongerNeededChkB.Checked = slip.ServiceNoLongerNeeded;
                iWillWalkChkB.Checked = slip.IWillWalk;
            }
        }
    }

    private void excelToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ExportExcel export = new ExportExcel();
        export.ShowDialog();
    }
}

public sealed class PessoaCSVMap : ClassMap<SlipEx>
{
    public PessoaCSVMap()
    {
        //use the converter on double or decimal types
        Map(x => x.Date).Index(0);
        Map(x => x.FlightNumber);
        Map(x => x.PassengerName);
        Map(x => x.StartTime).Index(3); //.TypeConverter<EmptyConverter>();
        Map(x => x.EndTime).Index(4);//.TypeConverter<EmptyConverter>();
        Map(x => x.AgentName).Index(5);
        Map(x => x.GuardName).Index(6);
    }
}

public class EmptyConverter : DefaultTypeConverter
{
    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    {
        if (DateTime.TryParse(text, out var result))
            return result;      
        return DateTime.Now;
    }
}

public class SlipEx
{
    public DateTime? Date { get; set; }
    public string FlightNumber { get; set; }
    public string PassengerName { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string AgentName { get; set; }
    public string GuardName { get; set; }
}