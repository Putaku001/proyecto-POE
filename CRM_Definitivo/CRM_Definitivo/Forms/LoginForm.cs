using System.Data;
using BusinessLayer;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using DataAccessLayer.Repositories.InterfacesRepositories;
using PresentationLayer.Forms;
using PresentationLayer;

namespace CRM_Definitivo
{
    public partial class LoginForm : Form
    {
        private IListProyectsServices proyectoServices;
        private IUsersRepositories usuarioRepositories;
        private IUsersServices usuarioServices;
        private IRolServices _rolServices;
        public LoginForm(IUsersRepositories _usuarioRepositories, IUsersServices _usuarioServices, IRolServices rolServices, IListProyectsServices _proyectoServices)
        {
            InitializeComponent();
            usuarioRepositories = _usuarioRepositories;
            usuarioServices = _usuarioServices;
            _rolServices = rolServices;
            proyectoServices = _proyectoServices;
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
            txtPassword.UseSystemPasswordChar = true;
            pictureBoxMostrar.Show();
        }

        private void pictureBoxMostrar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMostrar, "Mostrar contraseña");
        }

        private void pictureBoxMostrar_Click(object sender, EventArgs e)
        {
            pictureBoxMostrar.Hide();
            txtPassword.UseSystemPasswordChar = false;
            pictureBoxOcultar.Show();
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";

            this.Show();
        }

        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {
            NewAccountForm crearCuenta = new NewAccountForm(usuarioServices);

            crearCuenta.FormClosing += CrearCuenta_FormClosing;


            crearCuenta.ShowDialog();
        }

        private void CrearCuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuarios = new UsersServices(usuarioRepositories).GetUsers();

            User ousuario = usuarios.FirstOrDefault(u =>
                u.NameUser == txtUser.Text &&
                u.Passworduser == txtPassword.Text
            );

            if (ousuario != null)
            {
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
