using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.InterfacesServices
{
    public interface IListProyectsServices
    {
        IEnumerable<ListProyects> GetByIdProjects(int idProject);
        IEnumerable<ListProyects> GetByIdProjectsEmployee(int idEmployee);
        IEnumerable<ListProyects> GetLisProyect();
        List<StatusProjects> GetStatusProjects();
        void UpdateProjectsEmployee(int idProject, int idStatusProyect, byte[] file);
        //byte[] LoadLinkFile (int idProject);
    }
}
