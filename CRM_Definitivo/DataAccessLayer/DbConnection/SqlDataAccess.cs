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

        public SqlDataAccess()
        {
            _connectionString = "Data Source=192.168.0.4\\SQLEXPRESS;Initial Catalog=SistemaProyectosDB;Persist Security Info=True;User ID=Admin;Password=Sijilo75;Encrypt=True;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
