﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Usuario {  get; set; }
        public int Edad {  get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public Rol oRol { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
