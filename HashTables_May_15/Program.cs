using System;
using System.Collections;
using System.Globalization;

namespace HashTables_May_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro to HashTables and how to use them
            Employee test = new Employee(1001,"John","Doe");


            test.PrintInfo();

            Employee richard = new Employee(1002, "Richard", "Brown");

            //Create a hashtable 

            Hashtable empTable = new Hashtable();
            empTable.Add(test.EmployeeID, test);

            Employee empTest = (Employee)empTable[test.EmployeeID];

            empTest.PrintInfo();

            //How do we print bulk data from a hashtable 

            foreach (int e in empTable.Keys) //print the keys of the hashtable
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Console.ResetColor();

            }

            foreach (DictionaryEntry e in empTable)
            {

                Employee tempEmp = (Employee)e.Value;
                tempEmp.PrintInfo();


            }


            Console.WriteLine("Please enter an employee ID:");
            string inputEmpID = Console.ReadLine();


            int.TryParse(inputEmpID, out int validEmpID);

            //Console.WriteLine(validEmpID);

            while ((validEmpID == 0) || (!empTable.ContainsKey(validEmpID))) //check if the id exists nad if it actually is an integer
            {
                Console.WriteLine("Please enter a valid ID");
                inputEmpID = Console.ReadLine();
                int.TryParse(inputEmpID, out  validEmpID);
                         }

            Employee storedEmpID = (Employee)empTable[validEmpID];
            storedEmpID.PrintInfo();



        }
    }
}
