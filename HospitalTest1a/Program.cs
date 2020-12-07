using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTest1a
{
    class Program
    {
        static void Main(string[] args)
        {
            string hospitalName, firstName, lastName, speciality;

            Console.Write("Please enter the name of the hospital: ");
            hospitalName = Console.ReadLine();

            Hospital hospital = new Hospital(hospitalName);
            AddingWorkers(out firstName, out lastName, out speciality, hospital);
            AddingWorkers(out firstName, out lastName, out speciality, hospital);

            hospital.DisplayInfo();
        }

        private static void AddingWorkers(out string firstName, out string lastName, out string speciality, Hospital hospital)
        {
            Console.Write("Enter the first name of the worker");
            firstName = Console.ReadLine();
            Console.Write("Enter the last name of the Doctor");
            lastName = Console.ReadLine();
            Console.Write("Enter the speciality of the worker if any: ");
            speciality = Console.ReadLine();

            if (speciality == "Doctor" || speciality == "doctor")
            {
                Doctor doctor = new Doctor(speciality, firstName, lastName);
                hospital.workersList.Add(doctor.Info());
            }
            else
            {
                Employee worker = new Employee(firstName, lastName);
                hospital.workersList.Add(worker.Info());
            }
        }
    }
}
