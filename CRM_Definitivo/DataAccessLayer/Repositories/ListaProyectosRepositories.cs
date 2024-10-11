using DataAccessLayer.DbConnection;
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
    public class ListaProyectosRepositories : IListaProyectosRepositories
    {
        private readonly ISqlDataAccess _dbConnection;

        public ListaProyectosRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public DataTable GetListaProyectos()
        {
            DataTable listaproyectosTable = new DataTable();

            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT * FROM ListaProyectos";

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        listaproyectosTable.Load(reader);
                    }
                }
            }

            return listaproyectosTable;
        }
    }
}
