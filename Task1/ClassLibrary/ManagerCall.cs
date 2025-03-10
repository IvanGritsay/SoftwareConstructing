using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ManagerCall : ISubscriptionFactory
    {
        public ISubscription CreateSubscription()
        {
            Console.WriteLine("Subscription successfully purchased");
            ISubscription subscription = new PremiumSubscription();
            return subscription;
        }
    }
}
