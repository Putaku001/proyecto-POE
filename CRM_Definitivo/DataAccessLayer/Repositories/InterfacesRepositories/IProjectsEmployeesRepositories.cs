using CommonLayer.Entities;

namespace DataAccessLayer.Repositories.InterfacesRepositories
{
    public interface IProjectsEmployeesRepositories
    {
        IEnumerable<TaskEmployees> GetsProjects(int idEmployee);
        IEnumerable<StatusTaskEmployees> GetStatusTaskEmployees();
        List<string> GetTasksByEmployees(int idEmployee);
    }
}