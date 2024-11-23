using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.InterfacesRepositories
{
    public interface IProyectsRepositories
    {

        IEnumerable<ListProyects> GetLisProyect();
        List<StatusProjects> GetStatusProjects();
        void UpdateTaskEmployee(int idTask, byte[] file);

        //proyectos
        IEnumerable<RequestProjects> GetRequestProjects();
        IEnumerable<TaskEmployees> GetTaskEmployees();
        IEnumerable<Projects> GetRequestProjectsRefused();
        IEnumerable<Projects> GetProjectsWaitingReponse();

        IEnumerable<Projects> GetRequestProjectsFinish();
        IEnumerable<Projects> GetRequestProjectsProgress();
        void ProjectRedo(string codeProject, int idStatusProject);
        void StatusProject(string codeProject, int idStatusProject);
        void DateInit(string codeProject, DateTime dateInit);
        void DateEnd(string codeProject, DateTime dateEnd);
        void SendProjects(string codeProject, byte[] file);





        //metodos para tareas
        void AddTasksEmployees(TaskEmployees taskEmployees);
        IEnumerable<TaskEmployees> GetTasksByCode(string codeProject);
        byte[] DownloadTask(int idTask);



        //Metodos para Clientes
        IEnumerable<RequestProjects> GetProjectsByIdClient(int idUser);
        void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject);
        List<string> GetRequestProyectsByIdClient(int idClient);


        //Metodos para Empleados
        List<string> GetTasksByEmployees(int idEmployee);
    }
}
