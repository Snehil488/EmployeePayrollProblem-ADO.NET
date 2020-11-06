using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayrollProblem_ADO.NET
{
    class EmployeeRepo
    {
        public static string connectionString = @"Data Source=LAPTOP-T69UTPHB\SQLEXPRESS;Initial Catalog=payroll_service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
    }
}
