using System;
using Lesson10_1InterfacesDatabaseSimulation.Interfaces;
using Lesson10_1InterfacesDatabaseSimulation.Repositories;

namespace Lesson10_1InterfacesDatabaseSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson10_1_InterfacesDatabaseSimulation!");

            // Database Change Over Example
            IEmployee employeeSQL = new EmployeeSQLRepo();
            ExecuteDatabase(employeeSQL, 1);

            IEmployee employeeOracle = new EmployeeOracleRepo();
            ExecuteDatabase(employeeOracle, 1);

        }

        private static void ExecuteDatabase(IEmployee employee, int ID = 0)
        {
            employee.InsertEmployee();
            employee.UpdateEmployee(ID);
            employee.SelectEmployeesAll();
            employee.SelectEmployeeByID(ID);
            employee.DeleteEmployee(ID);
        }
    }
}
