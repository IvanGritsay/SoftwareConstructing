using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    public class Program
    {
        static void Main()
        {
            ISubscriptionFactory websitePurchase = new WebSite();
            ISubscription websiteSubscription = websitePurchase.CreateSubscription();
            websiteSubscription.ShowDetails();

            ISubscriptionFactory mobileAppPurchase = new MobileApp();
            ISubscription mobileAppSubscription = mobileAppPurchase.CreateSubscription();
            mobileAppSubscription.ShowDetails();

            ISubscriptionFactory managerCallPurchase = new ManagerCall();
            ISubscription managerCallSubscription = managerCallPurchase.CreateSubscription();
            managerCallSubscription.ShowDetails();
            Console.ReadLine();
        }
    }
}
