using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsbSlipManagerWinForm.Models;
internal class Airline
{
    public string Name { get; set; }
    public List<string> FlightNumbers { get; set; }
    public List<string> Agents { get; set; }
    public List<Slip> SLips { get; set; }
}
