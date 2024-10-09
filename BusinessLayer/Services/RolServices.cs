using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class RolServices
    {
        private RolRepositories _rolrepositories;

        public RolServices()
        {
            _rolrepositories = new RolRepositories();
        }

        public DataTable GetRolFiltro()
        {
            return _rolrepositories.GetRol();
        }

        public DataTable GetRol()
        {
            return _rolrepositories.GetAllRol();
        }
    }
}
