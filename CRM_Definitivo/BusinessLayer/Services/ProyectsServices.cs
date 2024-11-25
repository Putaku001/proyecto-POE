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
    public class ProyectsServices : IProyectsServices
    {
        private IProyectsRepositories _listaProyectosRepositories;

        public ProyectsServices(IProyectsRepositories listaProyectosRepositories)
        {
            _listaProyectosRepositories = listaProyectosRepositories;
        }

        public IEnumerable<ListProyects> GetLisProyect()
        {
            return _listaProyectosRepositories.GetLisProyect();
        }
 
        public void UpdateTaskEmployee(int idTask, byte[] file, int idStatusTask) => _listaProyectosRepositories.UpdateTaskEmployee(idTask, file, idStatusTask);
        

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
        public IEnumerable<TaskEmployees> GetTasksByCode(string codeProject) => _listaProyectosRepositories.GetTasksByCode(codeProject);
        public byte[] DownloadTask(int idTask) => _listaProyectosRepositories.DownloadTask(idTask);
        public IEnumerable<TaskEmployees> GetByIdTaskEmployee(int idEmployee) => _listaProyectosRepositories.GetByIdTaskEmployee(idEmployee);

        //status project
        public List<StatusProjects> GetStatusProjects() => _listaProyectosRepositories.GetStatusProjects();

        //Metodos para Clientes
        public IEnumerable<RequestProjects> GetProjectsByIdClient(int idUser) => _listaProyectosRepositories.GetProjectsByIdClient(idUser);
        public void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject) => _listaProyectosRepositories.AddNewProject(codeProject, idClient, nameProject, descriptionProject);
        public List<string> GetRequestProyectsByIdClient(int idClient) => _listaProyectosRepositories.GetRequestProyectsByIdClient(idClient);
        public IEnumerable<RequestProjects> GetProjectsByIdStatus(IEnumerable<int> idStatus) => _listaProyectosRepositories.GetProjectsByIdStatus(idStatus);
        public byte[] getProjectInDB(string codeProject) => _listaProyectosRepositories.getProjectInDB(codeProject);

        //Metodos para Empleados
        public List<string> GetTasksByEmployees(int idEmployee) => _listaProyectosRepositories.GetTasksByEmployees(idEmployee);
        public IEnumerable<TaskEmployees> GetsProjects(int idEmployee) => _listaProyectosRepositories.GetsProjects(idEmployee);
        public IEnumerable<StatusTaskEmployees> GetStatusTaskEmployees() => _listaProyectosRepositories.GetStatusTaskEmployees();
    }
}
