namespace MsbSlipManagerWinForm.Models;
public class Slip
{
    public string SlipId { get; set; }
    public int EmployeeID { get; set; }
    public string FlightNumber { get; set; } = string.Empty;
    public string Airline { get; set; } = string.Empty;
    public string CustomerName { get; set; } = string.Empty;
    public string AgentName { get; set; } = string.Empty;
    public string GuardName { get; set; } = string.Empty;
    public DateTime DateTime { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IWillWalk { get; internal set; }
    public bool ServiceNoLongerNeeded { get; internal set; }
    public bool Holiday { get; set; }
    public bool Overtime { get; set; }
}
