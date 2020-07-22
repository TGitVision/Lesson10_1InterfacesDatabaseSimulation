using System;
using System.Collections.Generic;
using System.Text;
using Lesson10_1InterfacesDatabaseSimulation.Interfaces;

namespace Lesson10_1InterfacesDatabaseSimulation.Repositories
{
    class EmployeeOracleRepo : IEmployee
    {
        public void DeleteEmployee(int ID)
        {
            Console.WriteLine($"Oracle Employee {ID} was deleted.");
        }

        public void InsertEmployee()
        {
            Console.WriteLine($"Oracle Employee was inserted.");
        }

        public void SelectEmployeeByID(int ID)
        {
            Console.WriteLine($"Oracle Employee {ID} was Selected.");
        }

        public void SelectEmployeesAll()
        {
            Console.WriteLine($"Oracle Employees were Selected.");
        }

        public void UpdateEmployee(int ID)
        {
            Console.WriteLine($"Oracle Employee {ID} was updated.");
        }
    }
}
