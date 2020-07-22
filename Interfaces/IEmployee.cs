using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10_1InterfacesDatabaseSimulation.Interfaces
{
    interface IEmployee
    {

        void InsertEmployee();
        void UpdateEmployee(int ID);
        void DeleteEmployee(int ID);
        void SelectEmployeesAll();
        void SelectEmployeeByID(int ID);

    }
}
