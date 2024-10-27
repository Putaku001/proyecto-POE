using BusinessLayer.Services.Interfaces;
using CommonLayer.Entities;
using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            List<string> ListaPaises = new List<string>()
            {
                "El Salvador",
                "Colombia",
                "Argentina"
            };

            cboListCountrys.DataSource = ListaPaises;
            cboListCountrys.SelectedIndex = -1;



            List<string> ListaCiudad = new List<string>()
            {
                "San Salvador",
                "La Libertad",
                "Santa Ana",
                "Medellin",
                "Bogota",
                "Cali",
                "La Plata",
                "Mendoza",
                "Cordoba"

            };

            cboListCity.DataSource = ListaCiudad;
            cboListCity.SelectedIndex = -1;
        }

        private void CleanFields()
        {
            txtName.Text = "";
            txtLastName.Text = "";
            dtpBirthDate.Text = "";
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
            string Name = txtName.Text;
            string LastName = txtLastName.Text;
            DateTime BirthDate = dtpBirthDate.Value;
            string Phone = txtNumberPhone.Text;
            string Password = txtPassword.Text;

            string Country = (string)cboListCountrys.SelectedValue;
            string City = (string)cboListCity.SelectedValue;

            User newAccount = new User();
            newAccount.NameUser = Name;
            newAccount.LastName = LastName;
            newAccount.Birthdate = BirthDate;
            newAccount.NumberPhone = Phone;
            newAccount.Passworduser = Password;
            newAccount.Country = Country;
            newAccount.City = City;
            newAccount.Statususer = "Activo";
            newAccount.DateRegistration = DateTime.Now;

            _usersServices.AddUsers(newAccount);
            CleanFields();

            MessageBox.Show("La cuenta se ha creado con exito!!");
            this.Close();

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
