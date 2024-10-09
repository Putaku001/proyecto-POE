using DataAccessLayer.DbSqlDataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RolRepositories
    {
        private SqlDataAccess _dbConnection;

        public RolRepositories()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetRol()
        {
            DataTable rolTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT TOP 2 * FROM ROL";


                using (var sqlcommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        rolTable.Load(reader);
                    }
                }
            }

            return rolTable;
        }

        public DataTable GetAllRol()
        {
            DataTable rolTable = new DataTable();

            using(var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT IdRol, Rol FROM ROL";


                using (var sqlcommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using(SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        rolTable.Load(reader);
                    }
                }
            }

            return rolTable;
        }


    }
}
