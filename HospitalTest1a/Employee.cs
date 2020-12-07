using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTest1a
{
    class Employee
    {
        protected string firstName;
        private string lastName;
        private int peselNumber;

        public Employee(string newFirstName, string newLastName, int newPeselNumber)
        {
            this.firstName = newFirstName;
            this.lastName = newLastName;
            this.peselNumber = newPeselNumber;
        }

        public virtual string  Info ()
        {
            return (firstName + " " + lastName);
        }
    }
}
