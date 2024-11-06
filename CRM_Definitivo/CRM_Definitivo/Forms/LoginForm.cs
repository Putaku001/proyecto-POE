using System.Data;
using BusinessLayer;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using DataAccessLayer.Repositories.InterfacesRepositories;
using PresentationLayer.Forms;
using PresentationLayer;
using PresentationLayer.Reports;
using PresentationLayer.Forms.Cliente;

namespace CRM_Definitivo
{
    public partial class LoginForm : Form
    {
        private readonly IListProyectsServices proyectoServices;
        private readonly IUsersRepositories usuarioRepositories;
        private readonly IUsersServices usuarioServices;
        private readonly IUserReports _userReports;
        private readonly IRolServices _rolServices;

        public LoginForm(IUsersRepositories _usuarioRepositories, IUsersServices _usuarioServices, IRolServices rolServices, IListProyectsServices _proyectoServices, IUserReports userReports)
        {
            InitializeComponent();
            usuarioRepositories = _usuarioRepositories;
            usuarioServices = _usuarioServices;
            _rolServices = rolServices;
            proyectoServices = _proyectoServices;
            _userReports = userReports;
        }

        private void pictureBoxClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxClosed_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClosed, "Cerrar aplicación");
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimizar aplicación");
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
            try
            {
                var usuarios = usuarioServices.GetUsers();
                User ousuario = usuarios.FirstOrDefault(u =>
                    u.UserAccount == txtUser.Text &&
                    VerifyPassword(txtPassword.Text, u.Passworduser)
                );

                if (ousuario != null)
                {
                    if (ousuario.idRol == 2)
                    {
                        ClientForm clientForm = new ClientForm(usuarioServices);
                        clientForm.Show();
                        this.Hide();
                        clientForm.FormClosing += frm_closing;
                    }
                    else
                    {
                        MenuForm form = new MenuForm(ousuario, usuarioServices, _rolServices, proyectoServices, _userReports);
                        form.Show();
                        this.Hide();
                        form.FormClosing += frm_closing;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario o contraseña incorrecta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante el inicio de sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            return enteredPassword == storedHash;
        }
    }
}