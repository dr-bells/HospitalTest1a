using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTest1a
{
    public abstract class Employee
    {
        string userName, password, firstName, lastName, peselNumber;
        List<DateTime> assignedDuties;
        public bool login;
        const int MaximumNumberOfDutiesPerMonth = 10;

        public Employee(string newUserName, string newPassword, string newFirstName, string newLastName, string newPeselNumber)
        {
            this.userName = newUserName;
            this.password = newPassword;
            this.firstName = newFirstName;
            this.lastName = newLastName;
            this.peselNumber = newPeselNumber;
            assignedDuties = new List<DateTime>();
        }

        
        public virtual string  Info ()
        {
            return (firstName + " " + lastName);
        }
    }
}
