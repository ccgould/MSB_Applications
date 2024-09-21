namespace MsbSlipManagerWinForm;
public partial class AddNewEmployee : Form
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int EmployeeID { get; set; }

    public AddNewEmployee()
    {
        InitializeComponent();
    }

    private void nameTxtb_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        var name = nameTxtb.Text.Split(" ");
        FirstName = name[0];
        LastName = name[1];
        EmployeeID = Convert.ToInt32(numericUpDown1.Value);
    }
}
