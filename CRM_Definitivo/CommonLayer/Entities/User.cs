using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserAccount { get; set; }
        public int idRol { get; set; }
        public string Rol { get; set; }
        public string NameUser { get; set; }
        public string LastName {  get; set; }
        public string Email { get; set; }
        public DateTime Birthdate {  get; set; }
        public string NumberPhone { get; set; }
        public string passworduser { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Statususer { get; set; }
        public Byte[] Image { get; set; }
        public DateTime DateRegistration { get; set; }
        public int VerificationCode { get; set; }
    }

    public class Admins
    {
        public int idAdmin { get; set; }
        public int idUser { get; set; }
        public string UserAccount { get; set; }
    }
    public class Employees
    {
        public int idEmployee { get; set; }
        public int idUser { get; set; }
        public string comment {  get; set; }
        public string workStation { get; set; }
        public string UserAccount { get; set; }

    }
    public class Clients
    {
        public int idCliente { get; set; }
        public int idUser { get; set; }
        public string UserAccount { get; set; }

    }
}
