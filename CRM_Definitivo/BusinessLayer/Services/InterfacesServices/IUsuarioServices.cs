using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces
{
    public interface IUsuarioServices
    {
        DataTable GetUsuarios();
        void AddUsuarios(Usuarios usuarios);
        void DeleteUsuarios(int IdUsuarios);
    }
}
