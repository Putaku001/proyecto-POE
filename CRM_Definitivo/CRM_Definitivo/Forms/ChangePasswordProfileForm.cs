﻿using BusinessLayer.Services.Interfaces;
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
    public partial class ChangePasswordProfileForm : Form
    {
        private readonly IUsersServices _services;
        private readonly User _user;
        public ChangePasswordProfileForm(User user, IUsersServices services)
        {
            InitializeComponent();
            _services = services;
            _user = user;
        }

        private void iconButtonChangePassword_Click(object sender, EventArgs e)
        {
            if(CaptureData.Password == textBoxCurrentPassword.Text)
            {
                if(textBoxNewPassword.Text == textBoxNewPasswordConfirm.Text)
                {
                    _user.IdUser = AuthUser.idUser;
                    _user.passworduser = textBoxNewPassword.Text;
                    _services.ChangePassword(_user);

                    CaptureData.Password = textBoxNewPasswordConfirm.Text;

                    MessageBox.Show("Se he cambiado la contraseña correctamente!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("La contraseña actual es incorrecta");
            }
        }
    }
}