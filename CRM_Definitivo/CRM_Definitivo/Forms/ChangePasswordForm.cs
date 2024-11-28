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
using BusinessLayer.Services;
using PresentationLayer.Validations;
using System.Security.Principal;

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

                ChangePasswordValidation changePasswordValidation = new ChangePasswordValidation();
                ValidationResult result = changePasswordValidation.Validate(_user);

                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);
                    return;
                }

                _usuarioServices.EditAccountUser(_user);

                MessageBox.Show("Contraseña cambiada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        errorValidation.SetError(newPasswordTexBox, error.ErrorMessage);
                        errorPasswordChangeLabel.Text = error.ErrorMessage;
                        break;
                    default:
                        Console.WriteLine($"Error en un campo no reconocido: {error.PropertyName}");
                        break;
                }
            }
        }

        private void ResetErrorLabels()
        {
            errorPasswordChangeLabel.Text = string.Empty;
            errorValidation.SetError(newPasswordTexBox, string.Empty);
        }
    }

}
