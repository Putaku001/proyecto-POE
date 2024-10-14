using CommonLayer.Entities;
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
    public class UsuarioRepositories : IUsuarioRepositories
    {
        private ISqlDataAccess _dbConnection;

        public UsuarioRepositories(ISqlDataAccess DbConnection)
        {
            _dbConnection = DbConnection;
        }

        public DataTable GetAllUsuarios()
        {
            DataTable usuariosTable = new DataTable();

            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT u.IdUsuario, r.IdRol, r.rol, u.Nombre, u.Usuario, u.Edad, u.Correo, u.Clave, u.Pais, u.Departamento, u.Ciudad, u.Estado,  u.FechaRegistro FROM Usuarios u
                                INNER JOIN ROL r ON r.IdRol = u.IdRol";

                using(var sqlcommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using(SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        usuariosTable.Load(reader);
                    }
                }
            }

            return usuariosTable;
        }

        public void AddUsuarios(Usuarios usuarios)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Usuarios (IdRol, Usuario, Clave, Nombre, Edad, Correo, Pais, Departamento, Ciudad, Estado )
                                VALUES(@IdRol, @Usuario, @Clave, @Nombre, @Edad, @Correo, @Pais, @Departamento, @Ciudad, @Estado)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@IdRol", usuarios.oRol.IdRol);
                command.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                command.Parameters.AddWithValue("@Clave", usuarios.Clave);
                command.Parameters.AddWithValue("@Nombre", usuarios.Nombre);
                command.Parameters.AddWithValue("@Edad", usuarios.Edad);
                command.Parameters.AddWithValue("@Correo", usuarios.Correo);
                command.Parameters.AddWithValue("@Pais", usuarios.Pais);
                command.Parameters.AddWithValue("@Departamento", usuarios.Departamento);
                command.Parameters.AddWithValue("@Ciudad", usuarios.Ciudad);
                command.Parameters.AddWithValue("@Estado", usuarios.Estado);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void EditarUsuarios(Usuarios usuarios)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Usuarios SET " +
                                "IdRol = @IdRol, " +
                                "Usuario = @Usuario, " +
                                "Clave = @Clave, " +
                                "Nombre = @Nombre, " +
                                "Edad = @Edad, " +
                                "Correo = @Correo, " +
                                "Pais = @Pais, " +
                                "Departamento = @Departamento, " +
                                "Ciudad = @Ciudad, " +
                                "Estado = @Estado, " +
                                "FechaRegistro = @FechaRegistro " +
                                "WHERE IdUsuario = @IdUsuario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdRol", usuarios.oRol.IdRol);
                command.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                command.Parameters.AddWithValue("@Clave", usuarios.Clave);
                command.Parameters.AddWithValue("@Nombre", usuarios.Nombre);
                command.Parameters.AddWithValue("@Edad", usuarios.Edad);
                command.Parameters.AddWithValue("@Correo", usuarios.Correo);
                command.Parameters.AddWithValue("@Pais", usuarios.Pais);
                command.Parameters.AddWithValue("@Departamento", usuarios.Departamento);
                command.Parameters.AddWithValue("@Ciudad", usuarios.Ciudad);
                command.Parameters.AddWithValue("@Estado", usuarios.Estado);
                command.Parameters.AddWithValue("@IdUsuario", usuarios.IdUsuario);
                command.Parameters.AddWithValue("@FechaRegistro", usuarios.FechaRegistro);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteUsuarios(int IdUsuarios)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", IdUsuarios);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        
    }
}
