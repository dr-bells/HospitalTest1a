using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTest1a
{
    class Nurse : Employee
    {
        public Nurse(string userName, string password, string firstName, string lastName, string peselNumber) : base(userName, password, firstName, lastName, peselNumber)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " - Nurse";
        }
    }
}
