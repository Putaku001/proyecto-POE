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
                string query = @"SELECT idUser, idRol, UserAccount, nameuser, lastName, email, birthdate, 
                                        numberPhone, passworduser, country, city, statususer, DateRegistration
                                 FROM Users";

                return connection.Query<User>(query);
            }
        }

        public IEnumerable<User> GetByIdUsers(int idUser)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT idUser, idRol, UserAccount, CONCAT(nameuser, ' ' ,lastName) AS nameUser, email, birthdate, 
                                        numberPhone, passworduser, country, city, statususer, DateRegistration 
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
                             numberPhone, passworduser, country, city, statususer, DateRegistration, idRol) 
                         VALUES (@UserAccount, @nameuser, @lastName, @email, @birthdate, 
                                 @numberPhone, @passworduser, @country, 
                                 @city, @statususer, @DateRegistration, @idRol)";
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
                                     statususer = @statususer
                                 WHERE idUser = @idUser";

                connection.Query<User>(query, user);
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
                string query = "SELECT * FROM Admins";

                return connection.Query<Admins>(query);
            }
        }
        public IEnumerable<Employee> GetEmployee()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Employee";

                return connection.Query<Employee>(query);
            }
        }
        public IEnumerable<Clients> GetClients()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Clients";

                return connection.Query<Clients>(query);
            }
        }

    }
}
