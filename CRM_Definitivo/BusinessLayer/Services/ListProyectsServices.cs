using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using DataAccessLayer.Repositories.InterfacesRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ListProyectsServices : IListProyectsServices
    {
        private IListProyectsRepositories _listaProyectosRepositories;

        public ListProyectsServices(IListProyectsRepositories listaProyectosRepositories)
        {
            _listaProyectosRepositories = listaProyectosRepositories;
        }

        public IEnumerable<ListProyects> GetLisProyect()
        {
            return _listaProyectosRepositories.GetLisProyect();
        }
        public IEnumerable<ListProyects> GetByIdProjects(int idProject) => _listaProyectosRepositories.GetByIdProjects(idProject);
        public IEnumerable<ListProyects> GetByIdProjectsEmployee(int idEmployee) => _listaProyectosRepositories.GetByIdProjectsEmployee(idEmployee);
        public void UpdateProjectsEmployee(int idProject, int idStatusProyect, byte[] file) => _listaProyectosRepositories.UpdateTaskEmployee(idProject, file); 
        

        public IEnumerable<TaskEmployee> GetByIdTaskEmployee(int idTask) => _listaProyectosRepositories.GetByIdTaskEmployee(idTask);
        public void UpdateTaskEmployee(int idTask, byte[] file) => _listaProyectosRepositories.UpdateTaskEmployee(idTask, file);
        //status project
        public List<StatusProjects> GetStatusProjects() => _listaProyectosRepositories.GetStatusProjects();
    }
}
