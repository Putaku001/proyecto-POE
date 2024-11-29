using CommonLayer.Entities;

namespace BusinessLayer.Services.InterfacesServices
{
    public interface IProjectsEmnployeesServices
    {
        IEnumerable<TaskEmployees> GetsProjects(int idEmployee);
        IEnumerable<StatusTaskEmployees> GetStatusTaskEmployees();
        List<string> GetTasksByEmployees(int idEmployee);
    }
}