namespace MsbSlipManagerWinForm.Models;
public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int EmployeeId { get; set; } = -1;
    public int SlipCount { get; set; }

    private string fullName;

	public string FullName
	{
		get { return $"{FirstName} {LastName}"; }
	}

    public Employee()
    {
        
    }

    public Employee(string name)
    {
        FirstName = name;
    }

}
