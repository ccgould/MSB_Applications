using MSB_Employee_Profiler.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSB_Employee_Profiler;
public interface IEmployeeService
{
    ObservableCollection<Employee> Employees { get; set; }
    void AddNewPerson(Employee employee);
    void RemovePerson(Employee employee);
}
