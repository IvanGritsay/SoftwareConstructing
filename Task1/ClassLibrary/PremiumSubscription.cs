using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class PremiumSubscription : ISubscription
    {
        public string Name { 
            get { 
                return "Premium"; 
            } 
        }
        public decimal MonthlyFee { 
            get 
            { 
                return 25; 
            } 
        }
        public int MinimumPeriod { 
            get { 
                return 12; 
            } 
        }
        public List<string> Channels { 
            get { 
                return new List<string> { 
                    "All Channels", "Movies", "4K Streaming" 
                }; 
            } 
        }
        public void ShowDetails() { 
            Console.WriteLine(Name + " Subscription: $" + MonthlyFee + "/month, Min " + MinimumPeriod + " months, Channels: " + string.Join(", ", Channels)); 
        }
    }
}
