﻿using CommonLayer.Entities;

namespace DataAccessLayer.Repositories.InterfacesRepositories
{
    public interface IProjectsEmployeesRepositories
    {
        IEnumerable<TaskEmployees> GetsProjects(int idEmployee);
        IEnumerable<StatusTaskEmployees> GetStatusTaskEmployees();
        IEnumerable<TaskEmployees> GetTasksByEmployees(int idEmployee);
    }
}