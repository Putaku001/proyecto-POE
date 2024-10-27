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

        public IEnumerable<User> GetAllUser()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT u.idUser, u.nameuser, u.lastName, u.birthdate, 
                                        u.numberPhone, u.passworduser, u.country, u.city, u.statususer, u.DateRegistration
                                 FROM Users u";

                return connection.Query<User>(query);
            }
        }

        public void AddUser(User user)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Users (nameuser, lastName, birthdate, 
                                     numberPhone, passworduser, country, city, statususer, DateRegistration) 
                                 VALUES (@nameuser, @lastName, @birthdate, 
                                         @numberPhone, @passworduser, @country, 
                                         @city, @statususer, @DateRegistration)";
                connection.Query<User>(query, new 
                { 
                    user.NameUser,
                    user.LastName,
                    user.Birthdate,
                    user.NumberPhone,
                    user.Passworduser,
                    user.Country,
                    user.City,
                    user.Statususer,
                    user.DateRegistration,
                });
            }
        }

        public void EditUser(User user)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Users 
                                 SET nameuser = @nameuser, 
                                     lastName = @lastName, 
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

        public void DeleteUser(int idUser)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Users WHERE idUser = @idUser";

                connection.Query<User>(query, new { idUser });
            }
        }
    }
}
