using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface ISubscription
    {
        string Name { get; }
        decimal MonthlyFee { get; }
        int MinimumPeriod { get; }
        List<string> Channels { get; }
        void ShowDetails();
    }
}
