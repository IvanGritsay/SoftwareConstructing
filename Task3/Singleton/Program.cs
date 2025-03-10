using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> _instance = new Lazy<Authenticator>(() => new Authenticator());

        private Authenticator() { }

        public static Authenticator Instance => _instance.Value;

        public void Authenticate()
        {
            Console.WriteLine("Authentication successful!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Authenticator auth1 = Authenticator.Instance;
            Authenticator auth2 = Authenticator.Instance;

            if (auth1 == auth2)
            {
                Console.WriteLine("Singleton works, both instances are the same.");
            }
            else
            {
                Console.WriteLine("Singleton failed, instances are different.");
            }

            auth1.Authenticate();
        }
    }
}
