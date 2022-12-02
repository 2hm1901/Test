using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcode
{
    public class Employee:Person
    {
        public string company;
        public Employee()
        {

        }
        public Employee(string company)
        {           
            this.company = company;           
        }

    }
}
