using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables_May_15
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        public Employee(int EmployeeID, string FirstName, string LastName) 
        { 
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmployeeID = EmployeeID;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"EmployeeID: {this.EmployeeID}\n" +
                $"First Name:{this.FirstName}\n" +
                $"Last Name: {this.LastName}");

        }

        ~Employee() //deconstructor 
        {

            Console.WriteLine("Clean up");
        } 

    }
}
