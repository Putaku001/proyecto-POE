using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class PermisoServices
    {
        private PermisosRepositories _permisosrepositories;

        public PermisoServices()
        {
            _permisosrepositories = new PermisosRepositories();
        }

        public DataTable GetPermisos(int IdUsuario)
        {
            return _permisosrepositories.GetAllPermiso(IdUsuario);
        }
    }
}
