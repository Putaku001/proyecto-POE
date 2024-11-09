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
    public partial class VerificationForm : Form
    {
        private readonly User _user;
        private readonly IUsersServices _usuarioServices;

        public VerificationForm(User user, IUsersServices usuarioServices)
        {
            InitializeComponent();
            _user = user;
            _usuarioServices = usuarioServices;
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            //if (verificationCodeTexBox.Text == _user.VerificationCode.ToString())
            //{
            //    ChangePasswordForm changePasswordForm = new ChangePasswordForm(_user, _usuarioServices);
            //    changePasswordForm.ShowDialog();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Código incorrecto. Inténtalo de nuevo.");
            //}
        }

        private void iconButtonVerify_Click(object sender, EventArgs e)
        {
            if (verificationCodeTexBox.Text == _user.VerificationCode.ToString())
            {
                ChangePasswordForm changePasswordForm = new ChangePasswordForm(_user, _usuarioServices);
                changePasswordForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Código incorrecto. Inténtalo de nuevo.");
            }
        }
    }
}
