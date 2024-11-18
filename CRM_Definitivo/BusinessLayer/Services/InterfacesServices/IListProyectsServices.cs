using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.InterfacesServices
{
    public interface IListProyectsServices
    {
        IEnumerable<RequestProjects> GetRequestProjects();
        IEnumerable<TaskEmployees> GetTaskEmployees();
        IEnumerable<Projects> GetRequestProjectsProgress();
        IEnumerable<Projects> GetProjectsWaitingReponse();
        IEnumerable<Projects> GetRequestProjectsFinish();
        IEnumerable<Projects> GetRequestProjectsRefused();


        IEnumerable<ListProyects> GetLisProyect();
        List<StatusProjects> GetStatusProjects();
        void UpdateTaskEmployee(int idTask, byte[] file);
        void ProjectRedo(string codeProject, int idStatusProject);
        void StatusProject(string codeProject, int idStatusProject);
        void DateInit(string codeProject, DateTime DateInit);
        void DateEnd(string codeProject, DateTime DateEnd);
        void SendProjects(string codeProject, byte[] file);





        //METODOS CRUD PARA TAREAS
        void AddTasksEmployees(TaskEmployees employees);



        //Metodos para Clientes
        IEnumerable<Employees> GetProjectsByIdClient(int idUser);
    }
}
