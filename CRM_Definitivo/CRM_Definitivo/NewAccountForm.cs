using BusinessLayer.Services.Interfaces;
using CommonLayer.Entities;
using PresentationLayer.Forms;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Twilio.TwiML.Voice;
//using System.Windows.Controls;
using FluentValidation.Results;
using System.Drawing;
//using System.ComponentModel.DataAnnotations;
using PresentationLayer.Validations;
using Microsoft.Extensions.DependencyInjection;



namespace PresentationLayer
{
    public partial class NewAccountForm : Form
    {
        private readonly IUsersServices _usersServices;
        bool isEditing = false;
        byte[] imageBytes;


        public NewAccountForm(IUsersServices usersServices)
        {
            InitializeComponent();
            _usersServices = usersServices;
            LoadProvincias();
        }


        private void LoadProvincias()
        {
            List<string> ListaPaises = new List<string>
            {
                "El Salvador"

            };

            listCountrysComboBox.DataSource = ListaPaises;
            listCountrysComboBox.SelectedIndex = -1;
            List<string> ListaCiudad = new List<string>
            {
                "Ahuachapán",
                "Sonsonate",
                "Santa Ana",
                "La Libertad",
                "Chalatenango",
                "San Salvador",
                "Cuscatlán",
                "La Paz",
                "San Vicente",
                "Cabañas",
                "Usulután",
                "San Miguel",
                "Morazán",
                "La Unión"
            };
            listCityComboBox.DataSource = ListaCiudad;
            listCityComboBox.SelectedIndex = -1;
        }

        private void CleanFields()
        {
            nameTexBox.Text = "";
            lastNameTexBox.Text = "";
            BirthdayDataTimePicker.Value = DateTime.Now;
            numberPhoneTextBox.Text = "";
            passwordTextBox.Text = "";
            listCountrysComboBox.SelectedIndex = -1;
            listCityComboBox.SelectedIndex = -1;
        }
        private void closedPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closedPictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(closedPictureBox, "Cerrar ventana");
        }


        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void minimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(minimizePictureBox, "Minimizar ventana");
        }
        private void registerSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    if (!IsValidEmail(emailTextBox.Text))
                    {
                        MessageBox.Show("El formato del correo electrónico no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string password = passwordTextBox.Text;
                    if (password.Length < 8)
                    {
                        MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    User newAccount = new User
                    {
                        UserAccount = userNameTextBox.Text,
                        idRol = 4,
                        NameUser = nameTexBox.Text,
                        LastName = lastNameTexBox.Text,
                        Email = emailTextBox.Text,
                        Birthdate = BirthdayDataTimePicker.Value,
                        NumberPhone = numberPhoneTextBox.Text,
                        passworduser = HashPassword(password),
                        Country = (string)listCountrysComboBox.SelectedValue,
                        City = (string)listCityComboBox.SelectedValue,
                        Statususer = "Activo",
                        Image = imageBytes,
                        DateRegistration = DateTime.Now,
                    };

                    _usersServices.AddUsers(newAccount);
                    CleanFields();

                    MessageBox.Show("La cuenta se ha creado con éxito.");

                    notifyIcon1.BalloonTipTitle = $"Bienvenido {userNameTextBox.Text}, usted se ha registrado correctamente a los Tilinazos77";
                    notifyIcon1.BalloonTipText = "Ver detalles";
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.ShowBalloonTip(3000);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, completa todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            return !string.IsNullOrWhiteSpace(nameTexBox.Text) &&
                   !string.IsNullOrWhiteSpace(lastNameTexBox.Text) &&
                   !string.IsNullOrWhiteSpace(emailTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(numberPhoneTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(passwordTextBox.Text) &&
                   listCountrysComboBox.SelectedIndex != 1 &&
                   listCityComboBox.SelectedIndex != -1;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private string HashPassword(string password)
        {
            return password;
        }
        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            //Esto no se toca que se modificara despues(si es que no me da hueva de hacerlo):)
            //System.Diagnostics.Process.Start("https://www.google.com");

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://www.google.com",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la URL: " + ex.Message);
            }

        }

        private void selectImageUserLabel_Click(object sender, EventArgs e)
        {

            OpenFileDialog photoUser = new OpenFileDialog();
            photoUser.Filter = "Archivos de imagenes (*.png; *.jpg; *.jpeg; *.WEBP) | *.png; *.jpg; *.jpeg; *.WEBP";

            if (photoUser.ShowDialog() == DialogResult.OK)
            {
                photoNewUserPictureBox.Image = System.Drawing.Image.FromFile(photoUser.FileName);

                if (photoNewUserPictureBox.Image != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        photoNewUserPictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                        imageBytes = memoryStream.ToArray();
                    }
                }
            }
        }

        private void DisplayValidationErrors(ValidationResult result)
        {
            errorValidation.Clear();
            //Te daba error aca por el tema de la ambiguedad, tenias como 3 librerias que ocupaban la propiedad result.Errors causando un ambiguedad entre ellos
            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(User.UserAccount):
                        errorValidation.SetError(userNameTextBox, error.ErrorMessage);
                        errorUserLabel.Text = error.ErrorMessage;
                        break;
                    case nameof(User.NameUser):
                        errorValidation.SetError(nameTexBox, error.ErrorMessage);
                        errorUserNameLabel.Text = error.ErrorMessage;
                        break;
                    default:
                        Console.WriteLine($"Error en un campo no reconocido: {error.PropertyName}");
                        break;
                }
            }
        }

    }
}   