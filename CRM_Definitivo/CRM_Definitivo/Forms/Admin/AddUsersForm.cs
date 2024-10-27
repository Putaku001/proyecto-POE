using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
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
                txtName.Text = _usuario.NameUser;
                txtLastName.Text = _usuario.LastName;
                dtpBirthDate.Value = _usuario.Birthdate;
                txtNumberPhone.Text = _usuario.NumberPhone;
                txtPassword.Text = _usuario.Passworduser;

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


        private void AñadirUsuariosForm_Load(object sender, EventArgs e)
        {

            cboRol.DataSource = rolServices.GetRolFiltro();
            cboRol.DisplayMember = "Rol";
            cboRol.ValueMember = "idRoles";
            cboRol.SelectedIndex = 0;
        }

        public event EventHandler AddUsuario;
        public event EventHandler EditUsuariosHandler;

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string Nombre = txtName.Text;
            string Apellido = txtLastName.Text;
            DateTime FechaNacimiento = dtpBirthDate.Value;
            string Telefono = txtNumberPhone.Text;
            string Clave = txtPassword.Text;
            string Pais = (string)cboListCountrys.SelectedValue;
            string Ciudad = (string)cboListCity.SelectedValue;
            string Estado = (string)cboStates.SelectedValue;
            int IdRol = (int)cboRol.SelectedValue;

            User usuario = new User()
            {
                NameUser = Nombre,
                LastName = Apellido,
                Birthdate = FechaNacimiento,
                NumberPhone = Telefono,
                Passworduser = Clave,
                Country = Pais,
                City = Ciudad,
                Statususer = Estado,
                DateRegistration = DateTime.Now,
            };

            _usuersservices.AddUsers(usuario);

            LoadProvincias();
            AddUsuario?.Invoke(this, EventArgs.Empty);
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _usuario.NameUser = txtName.Text;
            _usuario.Birthdate = dtpBirthDate.Value;
            _usuario.NumberPhone = txtNumberPhone.Text;
            _usuario.Passworduser = txtPassword.Text;
            _usuario.Country = (string)cboListCountrys.SelectedValue;
            _usuario.City = (string)cboListCity.SelectedValue;
            _usuario.Statususer = (string)cboStates.SelectedValue;
            _usuario.DateRegistration = DateTime.Now;

            _usuersservices.EditUsers(_usuario);
            MessageBox.Show("Usuario editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EditUsuariosHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}
