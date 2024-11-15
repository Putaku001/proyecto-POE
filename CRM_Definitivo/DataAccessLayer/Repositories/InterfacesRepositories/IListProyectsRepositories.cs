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
        IEnumerable<ListProyects> GetByIdProjects(int idProject);
        IEnumerable<ListProyects> GetByIdProjectsEmployee(int idEmployee);
        IEnumerable<ListProyects> GetLisProyect();
        List<StatusProjects> GetStatusProjects();
        //byte[] LoadLinkFile(int idProject);
        void UpdateProjectsEmployee(int idProject, int idStatusProject, byte[] file);
    }
}
