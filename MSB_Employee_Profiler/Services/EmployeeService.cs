using MSB_Employee_Profiler.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSB_Employee_Profiler.Services;
public partial class EmployeeService : ObservableObject, IEmployeeService
{
    [ObservableProperty] ObservableCollection<Employee> employees;

    public EmployeeService()
    {
        Employees =
        [
            new Employee
            {
                Name = "Creswell Gould",
                Dob = new DateTime(1993, 12, 21)
            },
            new Employee
            {
                Name = "Sascha Hall",
                Dob = new DateTime(1991, 9, 4)
            },
            new Employee
            {
                Name = "Laterrah Gould",
                Dob = new DateTime(1992, 9, 5)
            },
        ];
    }

    public void AddNewPerson(Employee employee)
    {
        if(!Employees.Any(x => x.EmployeeID == employee.EmployeeID))
        {
            Employees.Add(employee);
        }
    }

    public void RemovePerson(Employee employee)
    {
        Employees.Remove(employee);
    }
}
