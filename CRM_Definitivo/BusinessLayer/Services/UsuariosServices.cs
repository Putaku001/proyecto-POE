using BusinessLayer.Services.Interfaces;
using CommonLayer.Entities;
using DataAccessLayer.DbSqlDataAccess;
using DataAccessLayer.Repositories.InterfacesRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UsuariosServices : IUsuarioServices
    {
        private IUsuarioRepositories _usuariosrepositoriess;

        public UsuariosServices(IUsuarioRepositories usuarioRepositories)
        {
            _usuariosrepositoriess = usuarioRepositories;
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
