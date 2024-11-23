using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.InterfacesServices
{
    public interface IProyectsServices
    {
        IEnumerable<RequestProjects> GetRequestProjects();
        IEnumerable<TaskEmployees> GetTaskEmployees();
        IEnumerable<Projects> GetRequestProjectsProgress();
        IEnumerable<Projects> GetProjectsWaitingReponse();
        IEnumerable<Projects> GetRequestProjectsFinish();
        IEnumerable<Projects> GetRequestProjectsRefused();


        IEnumerable<ListProyects> GetLisProyect();
        List<StatusProjects> GetStatusProjects();
        void UpdateTaskEmployee(int idTask, byte[] file, int idStatusTask);
        void ProjectRedo(string codeProject, int idStatusProject);
        void StatusProject(string codeProject, int idStatusProject);
        void DateInit(string codeProject, DateTime DateInit);
        void DateEnd(string codeProject, DateTime DateEnd);
        void SendProjects(string codeProject, byte[] file);





        //METODOS PARA TAREAS
        void AddTasksEmployees(TaskEmployees employees);
        IEnumerable<TaskEmployees> GetTasksByCode(string codeProject);
        byte[] DownloadTask(int idTask);
        IEnumerable<TaskEmployees> GetByIdTaskEmployee(int idEmployee);





        //Metodos para Clientes
        IEnumerable<RequestProjects> GetProjectsByIdClient(int idUser);
        void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject);
        List<string> GetRequestProyectsByIdClient(int idClient);


        //Metodos para Empleados
        List<string> GetTasksByEmployees(int idEmployee);
        IEnumerable<TaskEmployees> GetsProjects(int idEmployee);
        IEnumerable<StatusTaskEmployees> GetStatusTaskEmployees();

    }
}
