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
using FluentValidation.Results;
using PresentationLayer.Validations;

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

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (CaptureData.Password == currentPasswordTextBox.Text)
            {
                if (newPasswordTextBox.Text == confirmPasswordTextBox.Text)
                {
                    _user.IdUser = AuthUser.idUser;
                    _user.passworduser = newPasswordTextBox.Text;


                    ChangePasswordProfileValidation changePasswordValidation = new ChangePasswordProfileValidation();
                    ValidationResult result = changePasswordValidation.Validate(_user);
                    if (!result.IsValid)
                    {
                        DisplayValidationErrors(result);
                        return;
                    }

                    _services.ChangePassword(_user);

                    MessageBox.Show("La contraseña se ha cambiado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                }
            }
            else
            {
                MessageBox.Show("La contraseña actual es incorrecta.");
            }
        }


        private void DisplayValidationErrors(ValidationResult result)
        {
            errorValidation.Clear();
            ResetErrorLabels();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(User.passworduser):
                        errorValidation.SetError(newPasswordTextBox, error.ErrorMessage);
                        errorNewPasswordLabel.Text = error.ErrorMessage;
                        break;
                    default:
                        Console.WriteLine($"Error en un campo no reconocido: {error.PropertyName}");
                        break;
                }
            }
        }

        private void ResetErrorLabels()
        {
            errorNewPasswordLabel.Text = string.Empty;
            errorValidation.SetError(newPasswordTextBox, string.Empty);
        }
    }
}
