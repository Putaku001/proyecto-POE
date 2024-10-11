using BusinessLayer.Services.InterfacesServices;
using DataAccessLayer.Repositories.InterfacesRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ListaProyectosServices : IListaProyectoServices
    {
        private IListaProyectosRepositories _listaProyectosRepositories;

        public ListaProyectosServices(IListaProyectosRepositories listaProyectosRepositories)
        {
            _listaProyectosRepositories = listaProyectosRepositories;
        }

        public DataTable GetListaProyecto()
        {
            return _listaProyectosRepositories.GetListaProyectos();
        }
    }
}
