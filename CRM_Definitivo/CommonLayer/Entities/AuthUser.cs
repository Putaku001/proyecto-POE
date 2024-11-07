using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    //el static es para no tener que estar instanciando por ende nos va servir para agarrar cada una de las propiedades
    public static class AuthUser
    {
        public static string UserAccount { get; set; }
        public static int idRol { get; set; }
    }
}
