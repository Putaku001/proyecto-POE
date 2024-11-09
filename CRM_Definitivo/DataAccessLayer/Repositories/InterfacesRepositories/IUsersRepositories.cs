using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.InterfacesRepositories
{
    public interface IUsersRepositories
    {
        User? GetUserByeUserAndPassword(string UserAccount, string passworduser);
        IEnumerable<User> GetAllUser();
        void AddUser(User user);
        void EditUser(User user);
        void DeleteUser(int idUser);
        IEnumerable<User> UserSearch(string search);
        void EditAccountUser(User user);
        void ChangePassword(User user);
        IEnumerable<User> GetByIdUsers(int idUser);
    }
}
