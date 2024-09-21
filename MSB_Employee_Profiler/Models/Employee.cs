using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace MSB_Employee_Profiler.Models;

public partial class  Employee : ObservableObject
{
    [ObservableProperty] private string name;
    [ObservableProperty] private string address;
    [ObservableProperty] private string city;
    [ObservableProperty] private string religion;
    [ObservableProperty] private string country;
    [ObservableProperty] private string uniformInfractions;
    [ObservableProperty] private string promotedTo;
    [ObservableProperty] private string demotedTo;
    [ObservableProperty] private decimal currentPay;
    [ObservableProperty] private decimal overtime;
    [ObservableProperty] private decimal vacationDays;
    [ObservableProperty] private decimal raiseAmount;
    [ObservableProperty] private int nib;
    [ObservableProperty] private int employeeID;
    [ObservableProperty] private int holidaysReceived;
    [ObservableProperty] private int cameInLate;
    [ObservableProperty] private int cameInEarly;
    [ObservableProperty] private int callOutSick;
    [ObservableProperty] private int leaveOfAbsents;
    [ObservableProperty] private int requestForDays;
    [ObservableProperty] private int timesWalkedOffJob;
    [ObservableProperty] private int misconductCount;
    [ObservableProperty] private int suspensionCount;
    [ObservableProperty] private DateTime dob;
    [ObservableProperty] private DateTime startDate;
    [ObservableProperty] private DateTime endDate;
    [ObservableProperty] private DateTime terminationDate;
    [ObservableProperty] private DateTime reinstatedDate;
    [ObservableProperty] private bool isCitizen;
    [ObservableProperty] private bool knowsJob;
    [ObservableProperty] private bool reinsteaded;
    [ObservableProperty] private bool hasCriminalBackground;
    [ObservableProperty] private bool hadRaise;
    [ObservableProperty] private bool hadPromotion;
    [ObservableProperty] private bool hadDemotion;
    [ObservableProperty] private bool returnedToMSB;
    [ObservableProperty] private bool meetingBeforeSuspension;
    [ObservableProperty] private bool hadMisconduct;
    [ObservableProperty] private bool hadsuspension;
    [ObservableProperty] private bool hadverbalWarnings;
    [ObservableProperty] private bool hadwrittenWarnings;
    [ObservableProperty] private bool terminated;
    [ObservableProperty] private Image profilePhoto;
    [ObservableProperty] private ObservableCollection<string> verbalWarnings;
    [ObservableProperty] private ObservableCollection<string> writtenWarnings;
    [ObservableProperty] private ObservableCollection<string> infractionWarnings;
}
