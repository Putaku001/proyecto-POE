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
        IEnumerable<User> GetUsers();
        void AddUsers(User user);
        void EditUsers(User user);
        void DeleteUsers(int idUser);
    }
}
