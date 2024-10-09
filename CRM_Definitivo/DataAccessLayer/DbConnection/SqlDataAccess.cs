using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace DataAccessLayer.DbSqlDataAccess
{
    public class SqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {
            _connectionString = "Data Source=LAPTOP-PHCFNULN\\SQLEXPRESS;Initial Catalog=CRM_Proyectos;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
