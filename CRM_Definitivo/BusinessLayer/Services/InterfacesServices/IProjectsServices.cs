﻿using CommonLayer.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.InterfacesServices
{
    public interface IProjectsServices
    {
        IEnumerable<Projects> GetRequestProjectsByStatus(string statusproject);
        IEnumerable<TaskEmployees> GetTaskEmployees();
        void UpdateTaskEmployee(int idTask, byte[] file, int idStatusTask);
        void StatusProject(string codeProject, int idStatusProject);
        void UpdateDates(string codeProject, DateTime? dateInit = null, DateTime? dateEnd = null);
        void SendProjects(string codeProject, byte[] file);
        byte[] GetFileProjectsRefusedInDB(int idProject);

        //METODOS PARA TAREAS
        void AddTasksEmployees(TaskEmployees employees);
        IEnumerable<TaskEmployees> GetTasksByCode(string codeProject);
        byte[] DownloadTask(int idTask);
        IEnumerable<TaskEmployees> GetByIdTaskEmployee(int idEmployee, int? idStatusTask = null);
    }
}
