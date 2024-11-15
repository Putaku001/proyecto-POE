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
        public IEnumerable<ListProyects> GetByIdProjects(int idProject)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT idProyect, titleName, description, idClient, idEmployee, idStatusProyect, dateInit, dateEnd FROM proyect WHERE idProyect = @idProject";

                return connection.Query<ListProyects>(query, new { idProject });
            }
        }

        public IEnumerable<ListProyects> GetByIdProjectsEmployee (int idEmployee)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT idProyect, titleName, description, idClient, idEmployee, idStatusProyect, dateInit, dateEnd FROM proyect WHERE idEmployee = @idEmployee";

                return connection.Query<ListProyects>(query, new { idEmployee });
            }
        }
        public void UpdateProjectsEmployee(int idProject, int idStatusProject, byte[] file)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE proyect SET
                                 idStatusProyect = @idStatusProject,
                                 [file] = @file
                                 WHERE idProyect = @idProject";

                connection.Query(query, new { idProject,idStatusProject,file });
            }
        }

        //public byte[] LoadLinkFile(int idProject)
        //{
        //    using (var connection = _dbConnection.GetConnection())
        //    {
        //        string query = @"SELECT [file] FROM proyect 
        //                        WHERE idProyect = @idProject";

        //        return connection.QueryFirstOrDefault<byte[]>(query, new {idProject});
        //    }
        //}

        //STATUS PROJECTS
        public List<StatusProjects> GetStatusProjects()
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT idStatusProyect, statusproyect FROM statusProyect";

                return connection.Query<StatusProjects>(query).ToList();
            }
        }
    }
}
