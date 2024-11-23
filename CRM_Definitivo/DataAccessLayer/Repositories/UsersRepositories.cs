using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.DbSqlDataAccess;
using DataAccessLayer.Repositories.InterfacesRepositories;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public class UsersRepositories : IUsersRepositories
    {
        private readonly ISqlDataAccess _dbConnection;

        public UsersRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public User? GetUserByeUserAndPassword(string UserAccount, string passworduser)
        {
            string query = @"SELECT idUser, idRol, UserAccount, nameuser, lastName, email, birthdate, 
                                        numberPhone, passworduser, country, city, statususer, DateRegistration
                                 FROM Users 
                                 WHERE UserAccount = @UserAccount AND passworduser = @PasswordUser";

            using (var connection = _dbConnection.GetConnection())
            {
                return connection.QueryFirstOrDefault<User>(query, new { UserAccount, passworduser });
            }
        }

        public IEnumerable<User> GetAllUser()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT u.idUser, u.idRol, r.Rol, u.UserAccount, u.nameuser, u.lastName, u.email, u.birthdate, 
                                 u.numberPhone, u.passworduser, u.country, u.city, u.statususer, u.DateRegistration
                                 FROM Users u
								 LEFT JOIN roles r on u.idRol = r.idRol";

                return connection.Query<User>(query);
            }
        }

        public IEnumerable<User> GetByIdUsers(int idUser)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT idUser, idRol, UserAccount,nameuser,lastName, email, birthdate, 
                                        numberPhone, passworduser, country, city, statususer, DateRegistration, Image 
                                        FROM Users 
                                 WHERE idUser = @idUser";

                return connection.Query<User>(query, new { idUser });
            }
        }



        public void AddUser(User user)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Users (UserAccount, nameuser, lastName, email, birthdate, 
                             numberPhone, passworduser, country, city, statususer, Image, DateRegistration, idRol) 
                         VALUES (@UserAccount, @nameuser, @lastName, @email, @birthdate, 
                                 @numberPhone, @passworduser, @country, 
                                 @city, @statususer, @Image, @DateRegistration, @idRol)";
                connection.Query<User>(query, new
                {
                    user.UserAccount,
                    user.NameUser,
                    user.LastName,
                    user.Email,
                    user.Birthdate,
                    user.NumberPhone,
                    user.passworduser,
                    user.Country,
                    user.City,
                    user.Statususer,
                    user.Image,
                    user.DateRegistration,
                    user.idRol
                });
            }
        }


        public void EditUser(User user)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Users 
                                 SET UserAccount = @UserAccount,
                                     idRol = @idRol,
                                     nameuser = @nameuser, 
                                     lastName = @lastName,
                                     email = @email,
                                     birthdate = @birthdate, 
                                     numberPhone = @numberPhone, 
                                     passworduser = @passworduser, 
                                     country = @country, 
                                     city = @city, 
                                     statususer = @statususer,
                                     DateRegistration = @DateRegistration 
                                 WHERE idUser = @idUser";

                connection.Query<User>(query, user);
            }
        }

        public void EditAccountUser(User user)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Users 
                                 SET UserAccount = @UserAccount,
                                     nameuser = @nameuser, 
                                     lastName = @lastName,
                                     email = @email,
                                     birthdate = @birthdate,
                                     numberPhone = @numberPhone, 
                                     passworduser = @passworduser, 
                                     country = @country, 
                                     city = @city, 
                                     statususer = @statususer,
                                     Image = @image
                                 WHERE idUser = @idUser";

                connection.Query<User>(query, user);
            }
        }

        public byte[] GetProfileImage(int idUser)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT Image FROM Users WHERE idUser = @idUser";
                return connection.QueryFirstOrDefault<byte[]>(query, new { idUser });
            }
        }


        public void ChangePassword(User user)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Users
                                 SET passworduser = @passworduser
                                 WHERE idUser = @idUser";

                connection.Query<User>(query, user);
            }
        }

        public void DeleteUser(int idUser)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Users WHERE idUser = @idUser";

                connection.Query<User>(query, new { idUser });
            }
        }

        IEnumerable<User> IUsersRepositories.UserSearch(string search)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT idUser, idRol, UserAccount, nameuser, lastName, email, birthdate, 
                                        numberPhone, passworduser, country, city, statususer, DateRegistration
                                 FROM Users WHERE UserAccount LIKE '%' + @search + '%'";

                return connection.Query<User>(query, new {search});
            }
        }

        //METODOS DEL INICIO PARA USERS

        public IEnumerable<Admins> GetAdmins()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "select a.idAdmin, a.idUser, u.userAccount from Admins a LEFT JOIN Users u on a.idUser = u.idUser";

                return connection.Query<Admins>(query);
            }
        }


        //EMPLEADOS
        public IEnumerable<Employees> GetEmployee()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "select e.idEmployee, e.idUser, u.UserAccount from employee e LEFT JOIN Users u on e.idUser = u.idUser";

                return connection.Query<Employees>(query);
            }
        }

        public IEnumerable<Employees> GetByIdEmployee(int idEmployee)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Employee WHERE idEmployee = @idEmployee";

                return connection.Query<Employees>(query, new { idEmployee });
            }
        }

        //CLIENTES
        public IEnumerable<Clients> GetClients()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "select c.idCliente, c.idUser, u.userAccount from Clients c LEFT JOIN Users u on c.idUser = u.idUser";

                return connection.Query<Clients>(query);
            }
        }

    }
}
