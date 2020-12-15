using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTest1a.Hospital
{
    public class Hospital
    {
        public List<Employee> employeeList;    

        public Hospital()
        {
            employeeList = new List<Employee>();
        }

        public void AddEmployee (Employee employee)
        {
            employeeList.Add(employee);
        }

        public List<Employee> employees()
        {
            return employeeList;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Welcome to hospital: \n\nWorkers here:\n");

            foreach (var item in employeeList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
