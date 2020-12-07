using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTest1a
{
    class Nurse : Employee
    {
        private string employeeType;

        public Nurse(string employeeType, string firstName, string lastName, int peselNumber) : base(firstName, lastName, peselNumber)
        {
            employeeType = "Nurse";
        }
    }
}
