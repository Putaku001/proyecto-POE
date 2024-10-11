using DataAccessLayer.DbConnection;
using DataAccessLayer.DbSqlDataAccess;
using DataAccessLayer.Repositories.InterfacesRepositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RolRepositories : IRolRepositories
    {
        private ISqlDataAccess _dbConnection;

        public RolRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
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
