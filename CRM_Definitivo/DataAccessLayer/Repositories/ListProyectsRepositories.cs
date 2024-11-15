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
                string query = @"SELECT 
                                P.idProyect,
                                P.titleName,
                                P.description,   
                                CU.UserAccount AS Client,
                                P.idEmployee,
                                EU.UserAccount AS Employee,
	                            E.workStation,
	                            P.dateInit,
                                P.dateEnd,
                                S.statusproyect

                            FROM 
                                Proyect P
                            LEFT JOIN StatusProyect S ON P.idStatusProyect = S.idStatusProyect
                            LEFT JOIN Clients CL ON P.idClient = CL.idCliente
                            LEFT JOIN Users CU ON CL.idUser = CU.idUser
                            LEFT JOIN Employee E ON P.idEmployee = E.idEmployee
                            LEFT JOIN Users EU ON E.idUser = EU.idUser
                            WHERE P.idProyect = @idProject";

                return connection.Query<ListProyects>(query, new { idProject });
            }
        }

        public IEnumerable<ListProyects> GetByIdProjectsEmployee (int idEmployee)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT t.idTask, t.idProyect, p.titleName, t.nameTask, t.descriptionTask, t.idEmployee from task t 
                                left join proyect p on t.idProyect = p.idProyect
                                LEFT JOIN employee e on e.idEmployee = e.idUser
                            WHERE t.idEmployee = @idEmployee";

                return connection.Query<ListProyects>(query, new { idEmployee });
            }
        }
        public void UpdateTaskEmployee(int idTask, byte[] file)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE task SET
                                 [file] = @file
                                 WHERE idTask = @idTask";

                connection.Query(query, new { idTask, file });
            }
        }

        //STATUS PROJECTS
        public List<StatusProjects> GetStatusProjects()
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT idStatusProyect, statusproyect FROM statusProyect";

                return connection.Query<StatusProjects>(query).ToList();
            }
        }


        //TASK
        public IEnumerable<TaskEmployee> GetByIdTaskEmployee(int idProyect)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT t.idTask, t.idProyect, p.titleName, t.nameTask, t.descriptionTask, t.idEmployee from task t 
                                left join proyect p on t.idProyect = p.idProyect
                                WHERE t.idProyect = @idProyect";

                return connection.Query<TaskEmployee>(query, new { idProyect });
            }
        }
    }
}
