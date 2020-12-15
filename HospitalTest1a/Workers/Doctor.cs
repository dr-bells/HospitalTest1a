using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTest1a
{
    class Doctor : Employee
    {
        public enum Specialty { cardiologist, urologist, neurologist, laryngologist };
        string pwzNumber;
        Specialty specialty;
        public Doctor(string userName, string password, string firstName, string lastName, string peselNumber, string PWZNumber, Specialty specialty) : base(userName, password, firstName, lastName, peselNumber)
        {
            this.pwzNumber = PWZNumber;
            this.specialty = specialty;
        }
        public override string ToString()
        {
            return base.ToString() + " - Doctor: " + specialty;
        }
    }
}
