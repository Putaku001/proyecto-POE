using CommonLayer.Entities;

namespace DataAccessLayer.Repositories.InterfacesRepositories
{
    public interface IProjectsClientsRepositories
    {
        void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject);
        IEnumerable<RequestProjects> GetProjectsByIdClient(int idUser);
        IEnumerable<RequestProjects> GetProjectsByIdStatus(int idClient, IEnumerable<int> idStatus);
        byte[] getProjectInDB(string codeProject);
        List<string> GetRequestProyectsByIdClient(int idClient);
        IEnumerable<RequestProjects> GetOnlyProjectsByIdClient(int idUser);
    }
}