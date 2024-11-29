using CommonLayer.Entities;

namespace BusinessLayer.Services.InterfacesServices
{
    public interface IProjectsClientServices
    {
        void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject);
        IEnumerable<RequestProjects> GetOnlyProjectsByIdClient(int idUser);
        byte[] getProjectInDB(string codeProject);
        IEnumerable<RequestProjects> GetProjectsByIdClient(int idUser);
        IEnumerable<RequestProjects> GetProjectsByIdStatus(int idClient, IEnumerable<int> idStatus);
        List<string> GetRequestProyectsByIdClient(int idClient);
        void InsertReasonForRejection(reasonForRejection reason);
    }
}