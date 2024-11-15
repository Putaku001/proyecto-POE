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
        public void UpdateProjectsEmployee(int idProject, int idStatusProyect, byte[] file) => _listaProyectosRepositories.UpdateProjectsEmployee(idProject, idStatusProyect, file); 
        //public byte[] LoadLinkFile (int idProject) => _listaProyectosRepositories.LoadLinkFile(idProject);
        
        //status project
        public List<StatusProjects> GetStatusProjects() => _listaProyectosRepositories.GetStatusProjects();
    }
}
