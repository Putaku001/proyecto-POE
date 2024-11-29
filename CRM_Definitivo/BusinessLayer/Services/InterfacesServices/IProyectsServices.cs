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
        IEnumerable<Projects> GetRequestProjectsByStatus(string statusproject);
        IEnumerable<TaskEmployees> GetTaskEmployees();

        IEnumerable<ListProyects> GetLisProyect();

        void UpdateTaskEmployee(int idTask, byte[] file, int idStatusTask);
        void StatusProject(string codeProject, int idStatusProject);
        void DateInit(string codeProject, DateTime DateInit);
        void DateEnd(string codeProject, DateTime DateEnd);
        void SendProjects(string codeProject, byte[] file);





        //METODOS PARA TAREAS
        void AddTasksEmployees(TaskEmployees employees);
        IEnumerable<TaskEmployees> GetTasksByCode(string codeProject);
        byte[] DownloadTask(int idTask);
        IEnumerable<TaskEmployees> GetByIdTaskEmployee(int idEmployee);


    }
}
