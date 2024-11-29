using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.InterfacesRepositories;

namespace DataAccessLayer.Repositories
{
    public class ProjectsClientsRepositories : IProjectsClientsRepositories
    {
        private readonly ISqlDataAccess _dbConnection;

        public ProjectsClientsRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<RequestProjects> GetOnlyProjectsByIdClient(int idUser)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.codeProject, u.UserAccount, r.nameProject, r.descriptionProject, r.[file], st.statusproyect, r.dateInit, r.dateEnd, rf.reason, rf.reasonForRejection, r.dateRegistration FROM RequestProjectClient r
                                 LEFT JOIN RefusedProject rf on rf.idRefused = r.idRefused
                                 LEFT JOIN Clients c on c.idCliente = r.idClient
                                 LEFT JOIN Users u on u.idUser = c.idUser
                                 LEFT JOIN statusProyect st on st.idStatusProyect = r.idStatusProject
                                 WHERE idClient = @idUser";

                return connection.Query<RequestProjects>(query, new { idUser });
            }
        }
        //Este metodo podes borrarlo y reutilizar el otro metodo de GetProjectsByIdStatus cuando a ese le metas el id, y le estarias pasando los aprametros del id mas el estado y este metodo borrarlo
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

        public IEnumerable<RequestProjects> GetProjectsByIdStatus(int idClient, IEnumerable<int> idStatus)
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
                r.idClient = @idClient AND
                r.idStatusProject IN @idStatus";

                return connection.Query<RequestProjects>(query, new { idClient, idStatus });
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
    }
}
