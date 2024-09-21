using CommunityToolkit.Mvvm.ComponentModel;

namespace MSB_Employee_Profiler.Models;

partial class Log : ObservableObject
{
    [ObservableProperty] private int empolyeeID;
    [ObservableProperty] private DateTime date;
    [ObservableProperty] private RecordType date;
    [ObservableProperty] private string comment;
}
