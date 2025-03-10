using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WebSite : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            Console.WriteLine("Subscription succesfully purchased!");
            ISubscription subscription = new DomesticSubscription();
            return subscription;
        }
    }
}
