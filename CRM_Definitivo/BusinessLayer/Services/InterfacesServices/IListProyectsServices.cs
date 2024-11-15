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
        IEnumerable<TaskEmployee> GetByIdTaskEmployee(int idProyect);
        IEnumerable<ListProyects> GetLisProyect();
        List<StatusProjects> GetStatusProjects();
        void UpdateTaskEmployee(int idTask, byte[] file);
        //byte[] LoadLinkFile (int idProject);
    }
}
