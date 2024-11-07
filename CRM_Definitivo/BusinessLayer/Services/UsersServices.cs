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
    public class UsersServices : IUsersServices
    {
        private IUsersRepositories _usuariosrepositoriess;

        public UsersServices(IUsersRepositories usuarioRepositories)
        {
            _usuariosrepositoriess = usuarioRepositories;
        }

        public User? Login(string UserAccount, string passwordUser)
        {
            return _usuariosrepositoriess.GetUserByeUserAndPassword(UserAccount, passwordUser);
        }
        public IEnumerable<User> GetUsers() => _usuariosrepositoriess.GetAllUser();

        public void AddUsers(User user) => _usuariosrepositoriess.AddUser(user);
        public void EditUsers(User user) => _usuariosrepositoriess.EditUser(user);

        public void DeleteUsers(int idUser) => _usuariosrepositoriess.DeleteUser(idUser);

        public IEnumerable<User> UserSearch(string search) => _usuariosrepositoriess.UserSearch(search);
    }
}
