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
        public IEnumerable<User> GetByIdUser(int idUser) => _usuariosrepositoriess.GetByIdUsers(idUser);
        public void AddUsers(User user) => _usuariosrepositoriess.AddUser(user);
        public void EditUsers(User user) => _usuariosrepositoriess.EditUser(user);
        public void EditAccountUser(User user) => _usuariosrepositoriess.EditAccountUser(user);
        public void ChangePassword(User user) => _usuariosrepositoriess.ChangePassword(user);
        public void DeleteUsers(int idUser) => _usuariosrepositoriess.DeleteUser(idUser);
        public IEnumerable<User> UserSearch(string search) => _usuariosrepositoriess.UserSearch(search);

        //SERVICICIOS PARA LLAMAR A LAS TABLAS ADMINS, CLIENTES Y EMPLEADOS DE MENU
        public IEnumerable<Admins> GetAdmins() =>  _usuariosrepositoriess.GetAdmins();
        public IEnumerable<Employees> GetEmployees() => _usuariosrepositoriess.GetEmployee();
        public IEnumerable<Employees> GetByIdEmployees(int idEmployee) => _usuariosrepositoriess.GetByIdEmployee(idEmployee);
        public IEnumerable<Clients> GetClients() => _usuariosrepositoriess.GetClients();


        public Byte[] GetProfileImage(int idUser) => _usuariosrepositoriess.GetProfileImage(idUser);
        public void UpdateStatusUser(int idUser, string statususer) => _usuariosrepositoriess.UpdateStatusUser(idUser, statususer);

        public IEnumerable<Employees> GetInfoEmployee(int idUser) => _usuariosrepositoriess.GetInfoEmployee(idUser);
        public void UpdateWorkstation(Employee employee) => _usuariosrepositoriess.UpdateWorkstation(employee);

        public bool UserExists(string userAccount)
        {
            return _usuariosrepositoriess.UserExists(userAccount);  
        }

    }
}
