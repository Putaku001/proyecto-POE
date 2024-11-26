using BusinessLayer.Services.Interfaces;
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

namespace PresentationLayer.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private readonly User _user;
        private readonly IUsersServices _usuarioServices;

        public ChangePasswordForm(User user, IUsersServices usuarioServices)
        {
            InitializeComponent();
            _user = user;
            _usuarioServices = usuarioServices;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (newPasswordTexBox.Text == confirmPasswordTexBox.Text)
            {

                _user.passworduser = newPasswordTexBox.Text;
                _usuarioServices.EditAccountUser(_user);

                MessageBox.Show("Contraseña cambiada con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.");
            }
        }

    }
}
