using BusinessLayer.Services;
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
        private UsuariosServices usuariosServices;
        private RolServices rolServices;
        private UsuariosForm _formularioPrincipal;
        bool isEditing = false;
        public AñadirUsuariosForm(UsuariosForm formularioPrincipal)
        {
            InitializeComponent();
            usuariosServices = new UsuariosServices();
            rolServices = new RolServices();
            LoadProvincias();
            _formularioPrincipal = formularioPrincipal;
            //usuariosForm = usuariosform;
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

        public event EventHandler UsuarioAgregado; // Evento para notificar que se agregó un usuario

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //DataGridView dgvUsuarios = usuariosForm.ObtenerDgvUsuarios();

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

            this.Close(); // Cerrar el formulario después de guardar
        }
    }
}
