using BusinessLayer.Services.InterfacesServices;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.InterfacesRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class PermissionServices : IPermisoServices
    {
        private IPermissionRepositories _permisosrepositories;

        public PermissionServices(IPermissionRepositories permisosRepositories)
        {
            _permisosrepositories = permisosRepositories;
        }

        public DataTable GetPermisos(int IdUsuario)
        {
            return _permisosrepositories.GetAllPermiso(IdUsuario);
        }
    }
}
