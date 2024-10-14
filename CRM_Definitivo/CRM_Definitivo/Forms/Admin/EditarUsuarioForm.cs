using BusinessLayer.Services;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PresentationLayer.Forms
{
    public partial class EditarUsuarioForm : Form
    {
        bool IsEditing = false;
        private Usuarios _usuario;
        public EditarUsuarioForm(UsuariosServices usuariosServices, RolServices rolServices, Usuarios usuario = null)
        {
            InitializeComponent();

            _usuario = usuario;
            IsEditing = usuario != null; 

        }


        public event EventHandler EditarUsuariosHandler;
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
