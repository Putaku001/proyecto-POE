using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Forms.Admin;
using PresentationLayer.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class AddUsersForm : Form
    {
        private IUsersServices _usuersservices;
        private IRolServices rolServices;
        private UsersForm _formularioPrincipal;
        bool IsEditing = false;
        private User _usuario;

        public AddUsersForm(IUsersServices _usuersServices, IRolServices _rolServices, User usuario = null)
        {
            InitializeComponent();


            _usuario = usuario;
            IsEditing = usuario != null;
            _usuersservices = _usuersServices;
            rolServices = _rolServices;
            LoadProvincias();

            ConfigureForm();

            // En el constructor o inicializador del formulario
            //cboRol.SelectedIndexChanged += cboRol_SelectedIndexChanged;


        }

        private void ConfigureForm()
        {
            rolComboBox.DataSource = rolServices.GetRol();
            rolComboBox.DisplayMember = "Rol";
            rolComboBox.ValueMember = "idRol";

            if (IsEditing)
            {


                rolComboBox.SelectedValue = _usuario.idRol;


                nameUserTextBox.Text = _usuario.UserAccount;
                emailTextBox.Text = _usuario.Email;
                nameTextBox.Text = _usuario.NameUser;
                lasNameTextBox.Text = _usuario.LastName;
                birthdateDateTimePicker.Value = _usuario.Birthdate;
                numberPhoneTextBox.Text = _usuario.NumberPhone;
                passwordTextBox.Text = _usuario.passworduser;

                if (countrysComboBox.Items.Count > 0)
                {
                    countrysComboBox.SelectedItem = _usuario.Country;
                }

                if (cityListComboBox.Items.Count > 0)
                {
                    cityListComboBox.SelectedItem = _usuario.City;
                }

                statusComboBox.SelectedItem = _usuario.Statususer;

                saveButton.Visible = false;
                editButton.Visible = true;

                lblAñadirUsuarios.Text = "Editar Usuario";
            }
            else
            {
                saveButton.Visible = true;
                editButton.Visible = false;
            }
        }

        private void ClearFields()
        {
            nameUserTextBox.Clear();
            nameTextBox.Clear();
            lasNameTextBox.Clear();
            numberPhoneTextBox.Clear();
            passwordTextBox.Clear();

            countrysComboBox.SelectedIndex = -1;
            cityListComboBox.SelectedIndex = -1;
            statusComboBox.SelectedIndex = -1;
            rolComboBox.SelectedIndex = -1;
        }


        public void LoadProvincias()
        {

            List<string> Estado = new List<string>()
            {
                "Activo",
                "Inactivo"
            };

            statusComboBox.DataSource = Estado;
            statusComboBox.SelectedIndex = -1;

            List<string> ListaPaises = new List<string>()
            {
                "El Salvador"
            };

            countrysComboBox.DataSource = ListaPaises;
            countrysComboBox.SelectedIndex = -1;



            List<string> ListaCiudad = new List<string>()
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

            cityListComboBox.DataSource = ListaCiudad;
            cityListComboBox.SelectedIndex = -1;
        }

        private void AddUsersForm_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler AddUsuario;
        public event EventHandler EditUsuariosHandler;

        private void saveButton_Click(object sender, EventArgs e)
        {
            User usuario = new User()
            {
                UserAccount = nameUserTextBox.Text,
                Email = emailTextBox.Text,
                idRol = Convert.ToInt32(rolComboBox.SelectedValue),
                NameUser = nameTextBox.Text,
                LastName = lasNameTextBox.Text,
                Birthdate = birthdateDateTimePicker.Value,
                NumberPhone = numberPhoneTextBox.Text,
                passworduser = passwordTextBox.Text,
                Country = (string)countrysComboBox.SelectedValue,
                City = (string)cityListComboBox.SelectedValue,
                Statususer = (string)statusComboBox.SelectedValue,
                DateRegistration = DateTime.Now,
            };

            _usuersservices.AddUsers(usuario);

            LoadProvincias();
            AddUsuario?.Invoke(this, EventArgs.Empty);
            ClearFields();
            this.Close();
        }



        private void editButton_Click(object sender, EventArgs e)
        {
            _usuario.UserAccount = nameUserTextBox.Text;
            _usuario.Email = emailTextBox.Text;
            _usuario.idRol = Convert.ToInt32(rolComboBox.SelectedValue);
            _usuario.NameUser = nameTextBox.Text;
            _usuario.Birthdate = birthdateDateTimePicker.Value;
            _usuario.NumberPhone = numberPhoneTextBox.Text;
            _usuario.passworduser = passwordTextBox.Text;
            _usuario.Country = (string)countrysComboBox.SelectedValue;
            _usuario.City = (string)cityListComboBox.SelectedValue;
            _usuario.Statususer = (string)statusComboBox.SelectedValue;
            _usuario.DateRegistration = DateTime.Now;

            _usuersservices.EditUsers(_usuario);
            MessageBox.Show("Usuario editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EditUsuariosHandler?.Invoke(this, EventArgs.Empty);
            ClearFields();
            this.Close();
        }

        private void rolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteRol = rolComboBox.Text;

            switch (selecteRol)
            {
                case "Empleado":
                    var inforemployeeform = new InfoEmployeeForm();
                    inforemployeeform.ShowDialog();
                    break;
                    //default:
                    //    MessageBox.Show("Seleccion no valida");
                    //    break;
            }
        }


    }
}
