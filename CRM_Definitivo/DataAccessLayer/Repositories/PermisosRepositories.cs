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
    public class PermisosRepositories : IPermisosRepositories
    {
        private ISqlDataAccess _dbConnection;

        public PermisosRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public DataTable GetAllPermiso(int IdUsuario)
        {
            DataTable permisosTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT p.IdRol, p.NombreMenu FROM PERMISO p
                                    inner join ROL r on r.IdRol = p.IdRol
                                    inner join Usuarios u on u.IdRol = r.IdRol
                                    where u.IdUsuario = @IdUsuario";

                using(var sqlcommand = new SqlCommand(query, connection))
                {
                    sqlcommand.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    connection.Open();

                    using (SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        permisosTable.Load(reader);
                    }
                }
            }

            return permisosTable;
        }
    }
}
