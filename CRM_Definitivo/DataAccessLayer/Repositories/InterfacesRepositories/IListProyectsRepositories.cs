using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.InterfacesRepositories
{
    public interface IListProyectsRepositories
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





        //metodo crud para tareas
        void AddTasksEmployees(TaskEmployees taskEmployees);

        //Metodos para Clientes
        IEnumerable<RequestProjects> GetProjectsByIdClient(int idUser);
        void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject);
    }
}
