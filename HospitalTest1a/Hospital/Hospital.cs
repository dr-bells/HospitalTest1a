using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTest1a
{
    class Hospital
    {
        private string name;
        public List<string> workersList;    

        public Hospital(string newName)
        {
            this.name = newName;
        }

        public void AddWorker (string name)
        {
            workersList.Add(name);
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Welcome to hospital: " + name + "\n\nWorkers here:\n");

            foreach (var item in workersList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
