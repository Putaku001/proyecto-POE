using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.InterfacesServices
{
    public interface IPermisoServices
    {
        IEnumerable<Permission> GetPermisos(int idUser);
    }
}
