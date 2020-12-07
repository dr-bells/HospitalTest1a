using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTest1a
{
    class Adminstrator : Employee
    {
        private string employeeType;
        public Adminstrator(string employeeType, string firstName, string lastName, int peselNumber) : base(firstName, lastName, peselNumber)
        {
            employeeType = "Administrator";
        }
    }
}
