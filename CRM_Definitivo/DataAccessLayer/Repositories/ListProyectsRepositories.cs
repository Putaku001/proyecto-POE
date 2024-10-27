using CommonLayer.Entities;
using Dapper;
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
    public class ListProyectsRepositories : IListProyectsRepositories
    {
        private readonly ISqlDataAccess _dbConnection;

        public ListProyectsRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<ListProyects> GetLisProyect()
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT idProyect, titleName, description, idClient, idEmployee, idStatusProyect, dateInit, dateEnd FROM proyect";

                return connection.Query<ListProyects>(query);
            }
        }
    }
}
