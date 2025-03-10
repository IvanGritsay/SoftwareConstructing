using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DomesticSubscription : ISubscription
    {
        public string Name { 
            get 
            { 
                return "Domestic"; 
            } 
        }
        public decimal MonthlyFee { 
            get 
            { 
                return 10; 
            } 
        }
        public int MinimumPeriod { 
            get { 
                return 6; 
            } 
        }
        public List<string> Channels { 
            get 
            { 
                return new List<string> { 
                    "News", "Entertainment", "Sports" 
                }; 
            } 
        }
        public void ShowDetails() { 
            Console.WriteLine(Name + " Subscription: $" + MonthlyFee + "/month, Min " + MinimumPeriod + " months, Channels: " + string.Join(", ", Channels)); 
        }
    }
}
