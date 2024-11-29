using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using DataAccessLayer.Repositories.InterfacesRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ProjectsClientServices : IProjectsClientServices
    {
        private readonly IProjectsClientsRepositories _projectsClientsRepositories;

        public ProjectsClientServices(IProjectsClientsRepositories projectsClientsRepositories)
        {
            _projectsClientsRepositories = projectsClientsRepositories;
        }
        public IEnumerable<RequestProjects> GetOnlyProjectsByIdClient(int idUser) => _projectsClientsRepositories.GetOnlyProjectsByIdClient(idUser);
        public IEnumerable<RequestProjects> GetProjectsByIdClient(int idUser) => _projectsClientsRepositories.GetProjectsByIdClient(idUser);
        public void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject) => _projectsClientsRepositories.AddNewProject(codeProject, idClient, nameProject, descriptionProject);
        public List<string> GetRequestProyectsByIdClient(int idClient) => _projectsClientsRepositories.GetRequestProyectsByIdClient(idClient);
        public IEnumerable<RequestProjects> GetProjectsByIdStatus(IEnumerable<int> idStatus) => _projectsClientsRepositories.GetProjectsByIdStatus(idStatus);
        public byte[] getProjectInDB(string codeProject) => _projectsClientsRepositories.getProjectInDB(codeProject);
    }
}
