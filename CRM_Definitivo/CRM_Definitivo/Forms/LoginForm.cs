using System.Data;
using BusinessLayer;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using DataAccessLayer.Repositories.InterfacesRepositories;
using PresentationLayer.Forms;

namespace CRM_Definitivo
{
    public partial class LoginForm : Form
    {
        private IListaProyectoServices proyectoServices;
        private IUsuarioRepositories usuarioRepositories;
        private IUsuarioServices usuarioServices;
        private IRolServices _rolServices;
        public LoginForm(IUsuarioRepositories _usuarioRepositories, IUsuarioServices _usuarioServices, IRolServices rolServices, IListaProyectoServices _proyectoServices)
        {
            InitializeComponent();
            usuarioRepositories = _usuarioRepositories;
            usuarioServices = _usuarioServices;
            _rolServices = rolServices;
            proyectoServices = _proyectoServices;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxClosed_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClosed, "Cerrar aplicacion");
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimizar aplicacion");
        }

        private void pictureBoxOcultar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxOcultar, "Ocultar contraseña");
        }

        private void pictureBoxOcultar_Click(object sender, EventArgs e)
        {
            pictureBoxOcultar.Hide();
            txtContraseña.UseSystemPasswordChar = true;
            pictureBoxMostrar.Show();
        }

        private void pictureBoxMostrar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMostrar, "Mostrar contraseña");
        }

        private void pictureBoxMostrar_Click(object sender, EventArgs e)
        {
            pictureBoxMostrar.Hide();
            txtContraseña.UseSystemPasswordChar = false;
            pictureBoxOcultar.Show();
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";

            this.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable usuariosTable = new UsuariosServices(usuarioRepositories).GetUsuarios();

            DataRow ousariosRow = usuariosTable
                .AsEnumerable()
                .FirstOrDefault(u => u.Field<string>("Usuario") == txtUsuario.Text 
                &&
                u.Field<string>("Clave") == txtContraseña.Text);

            if (ousariosRow != null)
            {
                Usuarios ousuario = new Usuarios()
                {
                    IdUsuario = ousariosRow.Field<int>("IdUsuario"),
                    Nombre = ousariosRow.Field<string>("Usuario"),
                    Clave = ousariosRow.Field<string>("Clave"),
                };

                MenuForm form = new MenuForm(ousuario, usuarioServices, _rolServices, proyectoServices);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontró el usuario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}
