using System;

namespace EmployeePayrollProblem_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo employee = new EmployeeRepo();
            employee.GetAllEmployee();
        }
    }
}
