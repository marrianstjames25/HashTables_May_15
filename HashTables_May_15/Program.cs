using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace HashTables_May_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro to HashTables and how to use them
            Employee test = new Employee(1001, "John", "Doe");
            Employee test2 = new Employee(1002, "Mark", "Ford");
            Employee test3 = new Employee(1003, "James", "Filler");
            Employee test4 = new Employee(1004, "Monica", "Pollock");


            test.PrintInfo();

            Employee richard = new Employee(1002, "Richard", "Brown");

            //Create a hashtable 

            Hashtable empTable = new Hashtable();
            empTable.Add(test.EmployeeID, test);
            empTable.Add(test2.EmployeeID, test2);
            empTable.Add(test3.EmployeeID, test3);
            empTable.Add(test4.EmployeeID, test4);



            Employee empTest = (Employee)empTable[test.EmployeeID];

            foreach (DictionaryEntry de in empTable)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
                Console.ResetColor();
            }


            empTest.PrintInfo();

            //How do we print bulk data from a hashtable 

            foreach (DictionaryEntry e in empTable) //print the keys of the hashtable
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Employee tempEmp = (Employee)e.Value;
                Employee testEmp_2 = (Employee)empTable[tempEmp.EmployeeID]; //Here we are trying to use indexing to access a specific element , although unless we convert it from an object reference to a class, we cannot do it
                tempEmp.PrintInfo();
                testEmp_2.PrintInfo();
               
            }



            foreach (Employee e in empTable.Values) //you can access all the information about what is stored in the hashtable along with the keys and the values by just using the name of the class as a pointer 
            {
                Console.ForegroundColor=ConsoleColor.Cyan;
                e.PrintInfo();
                Console.ResetColor();

            }


            Console.WriteLine("Please enter an employee ID:");
            string inputEmpID = Console.ReadLine();


            int.TryParse(inputEmpID, out int validEmpID);

            //Console.WriteLine(validEmpID);

            while ((validEmpID == 0) || (!empTable.ContainsKey(validEmpID))) //check if the id exists nad if it actually is an integer
            {
                Console.WriteLine("Please enter a valid ID");
                inputEmpID = Console.ReadLine();
                int.TryParse(inputEmpID, out validEmpID);
            }

            Employee storedEmpID = (Employee)empTable[validEmpID];
            storedEmpID.PrintInfo();




        }
    }
}