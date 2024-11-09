using BusinessLayer.Services.Interfaces;
using CommonLayer.Entities;
using PresentationLayer.Forms;
using QuestPDF.Infrastructure;
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
using Twilio.TwiML.Voice;

namespace PresentationLayer
{
    public partial class NewAccountForm : Form
    {
        private IUsersServices _usersServices;

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

            cboListCountrys.DataSource = ListaPaises;
            cboListCountrys.SelectedIndex = -1;
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
            cboListCity.DataSource = ListaCiudad;
            cboListCity.SelectedIndex = -1;
        }

        private void CleanFields()
        {
            nameTexBox.Text = "";
            lastNameTexBox.Text = "";
            dtpBirthDate.Value = DateTime.Now;
            txtNumberPhone.Text = "";
            txtPassword.Text = "";
            cboListCountrys.SelectedIndex = -1;
            cboListCity.SelectedIndex = -1;
        }

        private void pictureBoxClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClosed_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClosed, "Cerrar ventana");
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimizar ventana");
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
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

                    string password = txtPassword.Text;
                    if (password.Length < 8)
                    {
                        MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    User newAccount = new User
                    {
                        UserAccount = txtUserName.Text,
                        idRol = 4,
                        NameUser = nameTexBox.Text,
                        LastName = lastNameTexBox.Text,
                        Email = emailTextBox.Text,
                        Birthdate = dtpBirthDate.Value,
                        NumberPhone = txtNumberPhone.Text,
                        passworduser = HashPassword(password),
                        Country = (string)cboListCountrys.SelectedValue,
                        City = (string)cboListCity.SelectedValue,
                        Statususer = "Activo",
                        DateRegistration = DateTime.Now,
                    };

                    _usersServices.AddUsers(newAccount);
                    CleanFields();

                    MessageBox.Show("La cuenta se ha creado con éxito.");
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
                   !string.IsNullOrWhiteSpace(txtNumberPhone.Text) &&
                   !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                   cboListCountrys.SelectedIndex != -1 &&
                   cboListCity.SelectedIndex != -1;
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

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}