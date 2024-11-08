using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.DbSqlDataAccess;
using DataAccessLayer.Repositories.InterfacesRepositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PermissionRepositories : IPermissionRepositories
    {
        private ISqlDataAccess _dbConnection;

        public PermissionRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Permission> GetAllPermiso(int idUser)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.idRol, m.nameForm , p.idPermission FROM rolPermission rp
                                JOIN roles r ON rp.idRoles = r.idRol
                                JOIN permission p ON rp.idPermission = p.idPermission
                                JOIN menu m ON p.idMenu = m.idMenu
                                JOIN users u on u.idRol = r.idRol
                               WHERE u.idUser = @idUser";

                return connection.Query<Permission>(query, new { idUser });
            }
        }
    }
}
