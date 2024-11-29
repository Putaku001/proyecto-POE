using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces
{
    public interface IUsersServices
    {
        User? Login(string username, string password);
        IEnumerable<User> GetUsers();
        void AddUsers(User user);
        void EditUsers(User user);
        void DeleteUsers(int idUser);
        IEnumerable<User> UserSearch(string search);
        void EditAccountUser(User user);
        void ChangePassword(User user);
        IEnumerable<User> GetByIdUser(int idUser);

        //INTERFAZ DE SERVICICIOS PARA LLAMAR A LAS TABLAS ADMINS, CLIENTES Y EMPLEADOS DE MENU
        IEnumerable<Admins> GetAdmins();
        IEnumerable<Employees> GetEmployees();
        IEnumerable<Clients> GetClients();
        byte[] GetProfileImage(int idUser);
        IEnumerable<Employees> GetByIdEmployees(int idEmployee);
        void UpdateStatusUser(int idUser, string statususer);
    }
}
