using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace DataAccessLayer.DbSqlDataAccess
{
    public class SqlDataAccess :ISqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess(IConfiguration configuration)
        {
            _connectionString = "Data Source=DESKTOP-JDM7JV2\\MSSQLSERVER01;Initial Catalog=SistemaProyectosDB;Integrated Security=True;Encrypt=False";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
