using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Repositories.InterfacesRepositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ProyectsRepositories : IProyectsRepositories
    {
        private readonly ISqlDataAccess _dbConnection;

        public ProyectsRepositories(ISqlDataAccess dbConnection)
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

        public void UpdateTaskEmployee(int idTask, byte[] file, int idStatusTask)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE taskProjects SET
                                 fileTask = @file,
                                 idStatusTask = @idStatusTask
                                 WHERE idTask = @idTask";

                connection.Query(query, new { idTask, file, idStatusTask });
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
                string query = @"SELECT r.codeProject, u.UserAccount, r.nameProject, r.descriptionProject, r.[file], st.statusproyect, r.dateInit, r.dateEnd, r.dateRegistration FROM RequestProjectClient r
                                    LEFT JOIN RefusedProject rf on rf.idRefused = r.idRefused
                                    LEFT JOIN Clients c on c.idCliente = r.idClient
                                    LEFT JOIN Users u on u.idUser = c.idUser
                                    LEFT JOIN statusProyect st on st.idStatusProyect = r.idStatusProject
                                WHERE st.statusproyect = 'Rechazado'";

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

        //uno de estos 2 se eliminaran ya que hacen lo mismo (linea 143 - 167)
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

        //metodos para asignar tareas
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

        public IEnumerable<TaskEmployees> GetTasksByCode(string codeProject)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT t.codeProject, t.idEmployee, t.nameTask, t.descriptionTask, t.idStatusTask , te.statusTask, t.fileTask FROM taskProjects t
                                INNER JOIN taskEmployeesStatus te ON te.idStatusTask = t.idStatusTask
                                INNER JOIN employee e ON e.idEmployee = t.idEmployee
                                WHERE t.codeProject = @codeProject";

                return connection.Query<TaskEmployees>(query, new { codeProject });
            }
        }

        public IEnumerable<TaskEmployees> GetByIdTaskEmployee(int idEmployee)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT tk.idTask, tk.codeProject, tk.nameTask, tk.descriptionTask, tk.fileTask FROM taskProjects tk 
                                WHERE tk.idEmployee = @idEmployee";
                return connection.Query<TaskEmployees>(query, new { idEmployee });
            }
        }

        //Metodo para descargar un archivo
        public byte[] DownloadTask(int idTask)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT fileTask FROM taskProjects WHERE idTask = @idTask";

                return connection.QueryFirstOrDefault<byte[]>(query, new { idTask });
            }
        }

        public byte[] getProjectInDB(string codeProject)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT [file] FROM RequestProjectClient WHERE codeProject = @codeProject";

                return connection.QueryFirstOrDefault<byte[]>(query, new { codeProject });
            }
        }
        //Metodos para Admin



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

        public List<string> GetRequestProyectsByIdClient(int idClient)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT rp.nameProject FROM RequestProjectClient rp WHERE idClient = @idClient AND idStatusProject = 9";

                return connection.Query<string>(query, new { idClient }).ToList();
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

        public IEnumerable<RequestProjects> GetProjectsByIdStatus(IEnumerable<int> idStatus)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
            SELECT 
                r.codeProject,  
                r.nameProject, 
                r.descriptionProject, 
                r.[file], 
                st.statusproyect,  
                r.dateEnd, 
                r.dateRegistration
            FROM 
                RequestProjectClient r
            LEFT JOIN 
                statusProyect st ON st.idStatusProyect = r.idStatusProject
            WHERE 
               r.idStatusProject IN @idStatus";

                return connection.Query<RequestProjects>(query, new { idStatus });
            }
        }


        //Metodos para Empleados 
        public List<string> GetTasksByEmployees(int idEmployee)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT tp.codeProject FROM taskProjects tp WHERE idEmployee = @idEmployee AND idStatusTask = 3";

                return connection.Query<string>(query, new { idEmployee }).ToList();
            }
        }

        public IEnumerable<TaskEmployees> GetsProjects(int idEmployee)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT tp.idTask, tp.codeProject, tp.idEmployee , u.UserAccount, tp.nameTask, tp.descriptionTask, se.statusTask, tp.dateEnd FROM taskProjects tp
                                LEFT JOIN employee e on e.idEmployee = tp.idEmployee
                                LEFT JOIN Users u on u.idUser = e.idEmployee
                                INNER JOIN taskEmployeesStatus se on se.idStatusTask = tp.idStatusTask
                                WHERE tp.idEmployee = @idEmployee";
                return connection.Query<TaskEmployees>(query, new {idEmployee});
            }
        }

        public IEnumerable<StatusTaskEmployees> GetStatusTaskEmployees()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT idStatusTask, statusTask FROM taskEmployeesStatus";
                return connection.Query<StatusTaskEmployees>(query);
            }
        }
    }
}
