using CommonLayer.Entities;
using DataAccessLayer.DbSqlDataAccess;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UsuariosServices
    {
        private UsuarioRepositories _usuariosrepositoriess;

        public UsuariosServices()
        {
            _usuariosrepositoriess = new UsuarioRepositories();
        }

        public DataTable GetUsuarios()
        {
            return _usuariosrepositoriess.GetAllUsuarios();
        }

        public void AddUsuarios(Usuarios usuarios)
        {
            _usuariosrepositoriess.AddUsuarios(usuarios);
        }

        public void DeleteUsuarios(int IdUsuarios)
        {
            _usuariosrepositoriess.DeleteUsuarios(IdUsuarios);
        }
    }
}
