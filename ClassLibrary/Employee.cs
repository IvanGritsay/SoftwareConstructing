using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Employee : IEmployee
    {
        public string Name { get; }
        public string Role { get; }

        public Employee(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}
