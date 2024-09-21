using MsbSlipManagerWinForm.Models;

namespace MsbSlipManagerWinForm;
public partial class EmployeeSlipDetails : Form
{
    public EmployeeSlipDetails()
    {
        InitializeComponent();
        SlipsDAO slipsDAO = new SlipsDAO();
        employeeCmb.DataSource = slipsDAO.GetEmployees();
        employeeCmb.DisplayMember = "FullName";
        employeeCmb.ValueMember = "EmployeeID";
    }

    private void searchBtn_Click(object sender, EventArgs e)
    {
        SlipsDAO slipsDAO = new SlipsDAO();
        var employee = employeeCmb.SelectedItem as Employee;
        var slips = slipsDAO.searchSlips(employee.EmployeeId, "", fromDateTimePicker.Value, toDateTimePicker.Value);
        dataGridView1.DataSource = slips;

        List<KeyValuePair<string, string>> d = new List<KeyValuePair<string, string>>();
        Dictionary<string, int> slipsDict = new();

        foreach (var slip in slips)
        {
            if (slipsDict.ContainsKey(slip.Airline))
            {
                slipsDict[slip.Airline] += 1;
            }
            else
            {
                slipsDict.Add(slip.Airline, 1);
            }
        }
        resultsDataGridView.DataSource = slipsDict.ToList();
    }

    private void employeeCmb_SelectedIndexChanged(object sender, EventArgs e)
    {
        searchBtn_Click(sender, e);
    }

    private void printSlipsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var genSlip = new slipCountPicker();
        genSlip.ShowDialog();
    }
}


public class SlipObj
{
    public string Airline { get; set; }
    public int Count { get; set; }
}