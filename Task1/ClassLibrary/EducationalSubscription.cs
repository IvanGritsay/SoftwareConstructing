using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class EducationalSubscription : ISubscription
    {
        public string Name {
            get { 
                return "Educational"; 
            } 
        }
        public decimal MonthlyFee { 
            get 
            { 
                return 15; 
            } 
        }
        public int MinimumPeriod { 
            get 
            { 
                return 3; 
            } 
        }
        public List<string> Channels { 
            get { 
                return new List<string> { 
                    "Science", "History", "Animals World" 
                }; 
            } 
        }
        public void ShowDetails() { 
            Console.WriteLine(Name + " Subscription: $" + MonthlyFee + "/month, Min " + MinimumPeriod + " months, Channels: " + string.Join(", ", Channels)); 
        }
    }
}
