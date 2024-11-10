using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using PresentationLayer.Resources;
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

            ConfigurarFormulario();

        }

        private void ConfigurarFormulario()
        {
            if (IsEditing)
            {
                cboRol.DataSource = rolServices.GetRol();
                cboRol.DisplayMember = "Rol";
                cboRol.ValueMember = "idRol";

                cboRol.SelectedValue = _usuario.idRol;


                txtUserAccount.Text = _usuario.UserAccount;
                textBoxEmail.Text = _usuario.Email;
                txtName.Text = _usuario.NameUser;
                txtLastName.Text = _usuario.LastName;
                dtpBirthDate.Value = _usuario.Birthdate;
                txtNumberPhone.Text = _usuario.NumberPhone;
                txtPassword.Text = _usuario.passworduser;

                if (cboListCountrys.Items.Count > 0)
                {
                    cboListCountrys.SelectedItem = _usuario.Country;
                }

                if (cboListCity.Items.Count > 0)
                {
                    cboListCity.SelectedItem = _usuario.City;
                }

                cboStates.SelectedItem = _usuario.Statususer;

                btnGuardar.Visible = false;
                btnEditar.Visible = true;

                lblAñadirUsuarios.Text = "Editar Usuario";
            }
            else
            {
                btnGuardar.Visible = true;   
                btnEditar.Visible = false;    
            }
        }

        private void LimpiarCampos()
        {
            txtUserAccount.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtNumberPhone.Clear();
            txtPassword.Clear();

            cboListCountrys.SelectedIndex = -1;
            cboListCity.SelectedIndex = -1;
            cboStates.SelectedIndex = -1;
            cboRol.SelectedIndex = -1;
        }


        public void LoadProvincias()
        {

            List<string> Estado = new List<string>()
            {
                "Activo",
                "Inactivo"
            };

            cboStates.DataSource = Estado;
            cboStates.SelectedIndex = -1;

            List<string> ListaPaises = new List<string>()
            {
                "El Salvador"
            };

            cboListCountrys.DataSource = ListaPaises;
            cboListCountrys.SelectedIndex = -1;



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

            cboListCity.DataSource = ListaCiudad;
            cboListCity.SelectedIndex = -1;
        }


        private void AñadirUsuariosForm_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler AddUsuario;
        public event EventHandler EditUsuariosHandler;

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            User usuario = new User()
            {
                UserAccount = txtUserAccount.Text,
                Email = textBoxEmail.Text,
                idRol = Convert.ToInt32(cboRol.SelectedValue),
                NameUser = txtName.Text,
                LastName = txtLastName.Text,
                Birthdate = dtpBirthDate.Value,
                NumberPhone = txtNumberPhone.Text,
                passworduser = txtPassword.Text,
                Country = (string)cboListCountrys.SelectedValue,
                City = (string)cboListCity.SelectedValue,
                Statususer = (string)cboStates.SelectedValue,
                DateRegistration = DateTime.Now,
            };

            _usuersservices.AddUsers(usuario);

            LoadProvincias();
            AddUsuario?.Invoke(this, EventArgs.Empty);
            LimpiarCampos();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _usuario.UserAccount = txtUserAccount.Text;
            _usuario.Email = textBoxEmail.Text;
            _usuario.idRol = Convert.ToInt32(cboRol.SelectedValue);
            _usuario.NameUser = txtName.Text;
            _usuario.Birthdate = dtpBirthDate.Value;
            _usuario.NumberPhone = txtNumberPhone.Text;
            _usuario.passworduser = txtPassword.Text;
            _usuario.Country = (string)cboListCountrys.SelectedValue;
            _usuario.City = (string)cboListCity.SelectedValue;
            _usuario.Statususer = (string)cboStates.SelectedValue;
            _usuario.DateRegistration = DateTime.Now;

            _usuersservices.EditUsers(_usuario);
            MessageBox.Show("Usuario editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EditUsuariosHandler?.Invoke(this, EventArgs.Empty);
            LimpiarCampos();
            this.Close();
        }
    }
}
