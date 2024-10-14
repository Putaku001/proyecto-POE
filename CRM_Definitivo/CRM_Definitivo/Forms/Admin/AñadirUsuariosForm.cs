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
    public partial class AñadirUsuariosForm : Form
    {
        private IUsuarioServices usuariosServices;
        private IRolServices rolServices;
        private UsuariosForm _formularioPrincipal;
        bool IsEditing = false;
        private Usuarios _usuario;

        public AñadirUsuariosForm(IUsuarioServices _usuarioServices, IRolServices _rolServices, Usuarios usuario = null)
        {
            InitializeComponent();

            _usuario = usuario;
            IsEditing = usuario != null; 
            usuariosServices = _usuarioServices;
            rolServices = _rolServices;
            LoadProvincias();

            ConfigurarFormulario();

        }

        private void ConfigurarFormulario()
        {
            if (IsEditing)
            {
                txtNombre.Text = _usuario.Nombre;
                txtEdad.Text = _usuario.Edad.ToString();
                txtCorreo.Text = _usuario.Correo;
                txtUsuario.Text = _usuario.Usuario;
                txtClave.Text = _usuario.Clave;
                dtmFechaRegistro.Value = _usuario.FechaRegistro;
                

                if (cboListaPaises.Items.Count > 0)
                {
                    cboListaPaises.SelectedItem = _usuario.Pais; 
                }

                if (cboListaDepartamento.Items.Count > 0)
                {
                    cboListaDepartamento.SelectedItem = _usuario.Departamento;
                }

                if (cboListaCiudad.Items.Count > 0)
                {
                    cboListaCiudad.SelectedItem = _usuario.Ciudad;
                }

                cboEstado.SelectedItem = _usuario.Estado; 

                btnGuardar.Visible = false; 
                btnEditar.Visible = true;

                lblAñadirUsuarios.Text = "Editar Usuarios";
            }
            else
            {
                btnGuardar.Visible = true;   
                btnEditar.Visible = false;    
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtClave.Clear();

            cboListaPaises.SelectedIndex = -1;
            cboListaDepartamento.SelectedIndex = -1;
            cboListaCiudad.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
            cboRol.SelectedIndex = -1;
        }


        private void LoadProvincias()
        {
            List<string> ListaEstado = new List<string>()
            {
                "Activo",
                "Inactivo"
            };

            cboEstado.DataSource = ListaEstado;

            List<string> ListaPaises = new List<string>()
            {
                "El Salvador",
                "Colombia",
                "Argentina"
            };

            cboListaPaises.DataSource = ListaPaises;
            cboListaPaises.SelectedIndex = -1;


            List<string> ListaDepartamentos = new List<string>()
            {
                "San Salvador",
                "La Libertad",
                "Santa Ana",
                "Antioquilla",
                "Cundinamarca",
                "Valle Del Cauca",
                "Buenos Aires",
                "Mendoza",
                "Cordoba",
            };

            cboListaDepartamento.DataSource = ListaDepartamentos;
            cboListaDepartamento.SelectedIndex = -1;

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

            cboListaCiudad.DataSource = ListaCiudad;
            cboListaCiudad.SelectedIndex = -1;
        }


        private void AñadirUsuariosForm_Load(object sender, EventArgs e)
        {

            cboRol.DataSource = rolServices.GetRolFiltro();
            cboRol.DisplayMember = "Rol";
            cboRol.ValueMember = "IdRol";
            cboRol.SelectedIndex = 0;
        }

        public event EventHandler UsuarioAgregado;
        public event EventHandler EditarUsuariosHandler;

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string Nombre = txtNombre.Text;
            int Edad = Convert.ToInt32(txtEdad.Text);
            string Correo = txtCorreo.Text;
            string Usuario = txtUsuario.Text;
            string Clave = txtClave.Text;

            string Pais = (string)cboListaPaises.SelectedValue;
            string Departamento = (string)cboListaDepartamento.SelectedValue;
            string Ciudad = (string)cboListaCiudad.SelectedValue;
            string Estado = (string)cboEstado.SelectedValue;
            int IdRol = (int)cboRol.SelectedValue;


            Usuarios usuarios = new Usuarios();
            usuarios.Nombre = Nombre;
            usuarios.Edad = Edad;
            usuarios.Correo = Correo;
            usuarios.Usuario = Usuario;
            usuarios.Clave = Clave;
            usuarios.Pais = Pais;
            usuarios.Departamento = Departamento;
            usuarios.Ciudad = Ciudad;
            usuarios.Estado = Estado;
            usuarios.oRol = new Rol { IdRol = IdRol };

            usuariosServices.AddUsuarios(usuarios);

            LoadProvincias();

            UsuarioAgregado?.Invoke(this, EventArgs.Empty);

            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _usuario.Nombre = txtNombre.Text;
            _usuario.Edad = Convert.ToInt32(txtEdad.Text);
            _usuario.Correo = txtCorreo.Text;
            _usuario.Usuario = txtUsuario.Text;
            _usuario.Clave = txtClave.Text;
            _usuario.Pais = (string)cboListaPaises.SelectedValue;
            _usuario.Departamento = (string)cboListaDepartamento.SelectedValue;
            _usuario.Ciudad = (string)cboListaCiudad.SelectedValue;
            _usuario.oRol = new Rol
            {
                IdRol = Convert.ToInt32(cboRol.SelectedValue) 
            };
            _usuario.FechaRegistro = DateTime.Now;
            

            usuariosServices.EditarUsuarios(_usuario);
            MessageBox.Show("Usuario editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EditarUsuariosHandler?.Invoke(this, EventArgs.Empty); 
        }
    }
}
