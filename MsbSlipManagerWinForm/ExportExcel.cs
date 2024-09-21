using MsbSlipManagerWinForm.Models;
using Syncfusion.XlsIO;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace MsbSlipManagerWinForm;
public partial class ExportExcel : Form
{
    BindingSource bindingSource = new BindingSource();
    public BindingList<Employee> FilterOptionsEmployees { get; set; } = new();

    public BindingList<Employee> Employees { get; set; } = new();


    public ExportExcel()
    {
        InitializeComponent();
    }

    private void ExportExcel_Load(object sender, EventArgs e)
    {
        SlipsDAO slipsDAO = new SlipsDAO();
        //slipsDAO.getAllSlips();


        Employees = slipsDAO.GetEmployees();
        FilterOptionsEmployees = slipsDAO.GetEmployees();
        employeeCmb2.DisplayMember = "FullName";
        employeeCmb2.ValueMember = "EmployeeID";
        employeeCmb2.DataSource = FilterOptionsEmployees;

    }

    private void exportBTN_Click(object sender, EventArgs e)
    {
        using (ExcelEngine excelEngine = new ExcelEngine())
        {
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Xlsx;
            IWorkbook workbook = application.Workbooks.Create(1);
            IWorksheet worksheet = workbook.Worksheets[0];

            ////Initialize the DataTable
            //DataTable table = ;

            //Export data from DataTable to the worksheet
            worksheet.ImportDataTable((DataTable)dataGridView1.DataSource, true, 1, 1);

            //Save the document into a stream
            using (MemoryStream outputStream = new MemoryStream())
            {
                workbook.SaveAs(outputStream);
            }
        }
    }

    private void employeeCmb2_SelectedIndexChanged(object sender, EventArgs e)
    {
        RefreshGrid();
    }

    private void RefreshGrid()
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

        dataGridView1.DataSource = bindingSource;
    }
}
