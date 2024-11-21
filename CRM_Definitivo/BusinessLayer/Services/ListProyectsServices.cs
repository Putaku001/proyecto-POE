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
 
        public void UpdateTaskEmployee(int idTask, byte[] file) => _listaProyectosRepositories.UpdateTaskEmployee(idTask, file);
        

        //METODOS PARA PROYECTOS
        public IEnumerable<RequestProjects> GetRequestProjects() => _listaProyectosRepositories.GetRequestProjects();
        public IEnumerable<TaskEmployees> GetTaskEmployees() => _listaProyectosRepositories.GetTaskEmployees();
        public IEnumerable<Projects> GetRequestProjectsProgress() => _listaProyectosRepositories.GetRequestProjectsProgress();
        public IEnumerable<Projects> GetProjectsWaitingReponse() => _listaProyectosRepositories.GetProjectsWaitingReponse();
        public IEnumerable<Projects> GetRequestProjectsFinish() => _listaProyectosRepositories.GetRequestProjectsFinish();
        public IEnumerable<Projects> GetRequestProjectsRefused() => _listaProyectosRepositories.GetRequestProjectsRefused();
        public void StatusProject(string codeProject, int idStatusProject) => _listaProyectosRepositories.StatusProject(codeProject, idStatusProject);
        public void ProjectRedo(string codeProject, int idStatusProject) => _listaProyectosRepositories.ProjectRedo(codeProject, idStatusProject);
        public void DateInit(string codeProject, DateTime DateInit) => _listaProyectosRepositories.DateInit(codeProject, DateInit); 
        public void DateEnd(string codeProject, DateTime DateEnd) => _listaProyectosRepositories.DateEnd(codeProject, DateEnd);
        public void SendProjects(string codeProject, byte[] file) => _listaProyectosRepositories.SendProjects( codeProject ,file);
        
        
        //metodos crud para tareas
        public void AddTasksEmployees(TaskEmployees taskEmployees) => _listaProyectosRepositories.AddTasksEmployees(taskEmployees);

        
        //status project
        public List<StatusProjects> GetStatusProjects() => _listaProyectosRepositories.GetStatusProjects();

        //Metodos para Clientes
        public IEnumerable<RequestProjects> GetProjectsByIdClient(int idUser) => _listaProyectosRepositories.GetProjectsByIdClient(idUser);
        public void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject) => _listaProyectosRepositories.AddNewProject(codeProject, idClient, nameProject, descriptionProject);
    }
}
