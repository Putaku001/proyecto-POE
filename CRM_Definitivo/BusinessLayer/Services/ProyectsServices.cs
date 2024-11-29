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
        private readonly IProyectsRepositories _listaProyectosRepositories;

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

        public IEnumerable<Projects> GetRequestProjectsByStatus(string statusproject) => _listaProyectosRepositories.GetRequestProjectsByStatus(statusproject);


        public IEnumerable<TaskEmployees> GetTaskEmployees() => _listaProyectosRepositories.GetTaskEmployees();
        public void StatusProject(string codeProject, int idStatusProject) => _listaProyectosRepositories.StatusProject(codeProject, idStatusProject);
        public void DateInit(string codeProject, DateTime DateInit) => _listaProyectosRepositories.DateInit(codeProject, DateInit); 
        public void DateEnd(string codeProject, DateTime DateEnd) => _listaProyectosRepositories.DateEnd(codeProject, DateEnd);
        public void SendProjects(string codeProject, byte[] file) => _listaProyectosRepositories.SendProjects( codeProject ,file);
        
        
        //metodos crud para tareas
        public void AddTasksEmployees(TaskEmployees taskEmployees) => _listaProyectosRepositories.AddTasksEmployees(taskEmployees);
        public IEnumerable<TaskEmployees> GetTasksByCode(string codeProject) => _listaProyectosRepositories.GetTasksByCode(codeProject);
        public byte[] DownloadTask(int idTask) => _listaProyectosRepositories.DownloadTask(idTask);
        public IEnumerable<TaskEmployees> GetByIdTaskEmployee(int idEmployee) => _listaProyectosRepositories.GetByIdTaskEmployee(idEmployee);

    }
}
