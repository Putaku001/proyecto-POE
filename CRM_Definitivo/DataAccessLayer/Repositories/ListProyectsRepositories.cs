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








        //METODOS PARA PROYECTOS
        public IEnumerable<RequestProjects> GetRequestProjects()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.codeProject ,u.UserAccount, r.nameProject, r.descriptionProject, st.statusproyect, r.dateRegistration FROM RequestProjectClient r
                                LEFT JOIN Clients c on c.idCliente = r.idClient
                                LEFT JOIN Users u on u.idUser = c.idUser
                                LEFT JOIN statusProyect st on st.idStatusProyect = r.idStatusProject
                                WHERE st.statusproyect = 'Pendiente'";

                return connection.Query<RequestProjects>(query);
            }
        }

        public IEnumerable<Projects> GetRequestProjectsProgress()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.codeProject ,u.UserAccount, r.nameProject, r.descriptionProject, r.[file], st.statusproyect, r.dateInit, r.dateEnd, r.dateRegistration FROM RequestProjectClient r
                                LEFT JOIN Clients c on c.idCliente = r.idClient
                                LEFT JOIN Users u on u.idUser = c.idUser
                                LEFT JOIN statusProyect st on st.idStatusProyect = r.idStatusProject
                                WHERE st.statusproyect IN ('Abierto', 'En progreso')";

                return connection.Query<Projects>(query);
            }
        }

        public IEnumerable<Projects> GetProjectsWaitingReponse()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.codeProject ,u.UserAccount, r.nameProject, r.descriptionProject, r.[file], st.statusproyect, r.dateInit, r.dateEnd, r.dateRegistration FROM RequestProjectClient r
                                LEFT JOIN Clients c on c.idCliente = r.idClient
                                LEFT JOIN Users u on u.idUser = c.idUser
                                LEFT JOIN statusProyect st on st.idStatusProyect = r.idStatusProject
                                WHERE st.statusproyect = 'esperando aprobacion del cliente'";

                return connection.Query<Projects>(query);
            }
        }

        public IEnumerable<Projects> GetRequestProjectsFinish()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.codeProject ,u.UserAccount, r.nameProject, r.descriptionProject, r.[file], st.statusproyect, r.dateInit, r.dateEnd, r.dateRegistration FROM RequestProjectClient r
                                LEFT JOIN Clients c on c.idCliente = r.idClient
                                LEFT JOIN Users u on u.idUser = c.idUser
                                LEFT JOIN statusProyect st on st.idStatusProyect = r.idStatusProject
                                WHERE st.statusproyect = 'Terminado'";

                return connection.Query<Projects>(query);
            }
        }
        public IEnumerable<Projects> GetRequestProjectsRefused()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT p.codeProject, rp.reason, rp.reasonForRejection, sp.statusproyect FROM RefusedProject rp
                                LEFT JOIN RequestProjectClient p on p.idProject = rp.idProject
                                LEFT JOIN statusProyect sp on sp.idStatusProyect = p.idStatusProject
                                WHERE sp.statusproyect = 'Rechazado'";

                return connection.Query<Projects>(query);
            }
        }

        public IEnumerable<TaskEmployees> GetTaskEmployees()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT tp.idTask, tp.codeProject, u.UserAccount, tp.nameTask, tp.descriptionTask, se.statusTask, tp.dateEnd FROM taskProjects tp
                                LEFT JOIN employee e on e.idEmployee = tp.idEmployee
                                LEFT JOIN Users u on u.idUser = e.idEmployee
                                INNER JOIN taskEmployeesStatus se on se.idStatusTask = tp.idStatusTask
                                ";

                return connection.Query<TaskEmployees>(query);
            }
        }


        public void ProjectRedo(string codeProject,int idStatusProject)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE RequestProjectClient SET 
                                idStatusProject = @idStatusProject
                                WHERE codeProject = @codeProject";

                connection.Query<Projects>(query, new { codeProject, idStatusProject });
            }
            
        }

        public void StatusProject(string codeProject, int idStatusProject)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE RequestProjectClient SET 
                                idStatusProject = @idStatusProject
                                WHERE codeProject = @codeProject";

                connection.Query<Projects>(query, new { codeProject , idStatusProject });
            }
        }

        public void DateInit(string codeProject,DateTime dateInit)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE RequestProjectClient SET 
                                dateInit = @dateInit
                                WHERE codeProject = @codeProject";

                connection.Query<Projects>(query, new { codeProject, dateInit });
            }
        }

        public void DateEnd(string codeProject, DateTime dateEnd)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE RequestProjectClient SET 
                                dateEnd = @dateEnd
                                WHERE codeProject = @codeProject";

                connection.Query<Projects>(query, new { codeProject, dateEnd });
            }
        }

        public void SendProjects(string codeProject, byte[] file)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE RequestProjectClient SET  
                                 [file] = @file
                                 WHERE codeProject = @codeProject";

                connection.Query<Projects>(query, new { codeProject ,file });
            }
        }

        //metodo crud para asignar tareas
        public void AddTasksEmployees(TaskEmployees taskEmployees)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO taskProjects (codeProject, nameTask, descriptionTask, idEmployee, idStatusTask, dateEnd) 
                                 VALUES(@codeProject, @nameTask, @descriptionTask, @idEmployee, @idStatusTask, @dateEnd)";

                connection.Query<TaskEmployees>(query, new
                {
                    taskEmployees.codeProject,
                    taskEmployees.nameTask,
                    taskEmployees.descriptionTask,
                    taskEmployees.idEmployee,
                    taskEmployees.idStatusTask,
                    taskEmployees.dateEnd
                });
            }
        }


        //--------------------------------------------------------------------------------------//



        //Metodos para Clientes
        public IEnumerable<RequestProjects> GetProjectsByIdClient(int idUser)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.codeProject, u.UserAccount, r.nameProject, r.descriptionProject, r.[file], st.statusproyect, r.dateInit, r.dateEnd, rf.reason, rf.reasonForRejection, r.dateRegistration FROM RequestProjectClient r
                                 LEFT JOIN RefusedProject rf on rf.idRefused = r.idRefused
                                 LEFT JOIN Clients c on c.idCliente = r.idClient
                                 LEFT JOIN Users u on u.idUser = c.idUser
                                 LEFT JOIN statusProyect st on st.idStatusProyect = r.idStatusProject
                                 WHERE idClient = @idUser AND st.statusproyect = 'Pendiente'";

                return connection.Query<RequestProjects>(query, new { idUser });
            }
        }

        public void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO RequestProjectClient (codeProject, idClient, nameProject, descriptionProject) 
                         VALUES (@codeProject, @idClient, @nameProject, @descriptionProject)";

                connection.Execute(query, new
                {
                    codeProject,
                    idClient,
                    nameProject,
                    descriptionProject
                });
            }
        }

        //Metodos para Empleados 

    }
}
