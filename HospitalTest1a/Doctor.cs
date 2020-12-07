using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTest1a
{
    class Doctor : Employee
    {
        private string employeeType;

        public Doctor (string employeeType, string firstName, string lastName, int peselNumber) : base(firstName,  lastName, peselNumber)
        {
            employeeType =  "Doctor";
        }

         public override string  Info()
        {
           return (employeeType + " " + firstName);
        }
        
    }
}
