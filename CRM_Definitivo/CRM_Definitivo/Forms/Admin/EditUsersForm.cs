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
    public partial class EditUsersForm : Form
    {
        bool IsEditing = false;
        private User _users;
        public EditUsersForm(UsersServices usuariosServices, RolServices rolServices, User user = null)
        {
            InitializeComponent();

            _users = user;
            IsEditing = user != null; 

        }


        public event EventHandler EditUserHandler;
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
