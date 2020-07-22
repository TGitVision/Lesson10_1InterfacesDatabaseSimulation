using System;
using System.Collections.Generic;
using System.Text;
using Lesson10_1InterfacesDatabaseSimulation.Interfaces;

namespace Lesson10_1InterfacesDatabaseSimulation.Repositories
{
    class EmployeeSQLRepo : IEmployee
    {
        public void DeleteEmployee(int ID)
        {
            Console.WriteLine($"SQL Employee {ID} was deleted.");
        }

        public void InsertEmployee()
        {
            Console.WriteLine($"SQL Employee was inserted.");
        }

        public void SelectEmployeeByID(int ID)
        {
            Console.WriteLine($"SQL Employee {ID} was Selected.");
        }

        public void SelectEmployeesAll()
        {
            Console.WriteLine($"SQL Employees were Selected.");
        }

        public void UpdateEmployee(int ID)
        {
            Console.WriteLine($"SQL Employee {ID} was updated.");
        }
    }
}
