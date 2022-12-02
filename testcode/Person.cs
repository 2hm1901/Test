using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcode
{
    public class Person
    {
        public string name;
        public string address;
        public string Name { get; set; }
        public string Address { get; set; }

        public Person()
        {

        }

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public void DisplayInfor()
        {
            Console.WriteLine($"{name} live in {address}");
        }
    }
}
