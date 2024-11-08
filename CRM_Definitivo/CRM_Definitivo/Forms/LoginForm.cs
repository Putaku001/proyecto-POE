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
using Microsoft.Extensions.DependencyInjection;

namespace CRM_Definitivo
{
    public partial class LoginForm : Form
    {
        private readonly IListProyectsServices proyectoServices;
        private readonly IUsersRepositories usuarioRepositories;
        private readonly IUsersServices usuarioServices;
        private readonly IUserReports _userReports;
        private readonly IRolServices _rolServices;
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(IServiceProvider serviceProvider, IUsersRepositories _usuarioRepositories, IUsersServices _usuarioServices, IRolServices rolServices, IListProyectsServices _proyectoServices, IUserReports userReports)
        {
            InitializeComponent();
            usuarioRepositories = _usuarioRepositories;
            usuarioServices = _usuarioServices;
            _rolServices = rolServices;
            proyectoServices = _proyectoServices;
            _userReports = userReports;
            _serviceProvider = serviceProvider;
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
                var user = usuarioServices.Login(txtUser.Text, txtPassword.Text);

                if (user != null)
                {

                    AuthUser.idUser = user.IdUser;
                    AuthUser.UserAccount = user.UserAccount;
                    AuthUser.idRol = user.idRol;

                    CaptureData.UserAccount = user.UserAccount;
                    CaptureData.NameUser = user.NameUser;
                    CaptureData.LastName = user.LastName;
                    CaptureData.Email = user.Email;
                    CaptureData.DateBirth = user.Birthdate;
                    CaptureData.NumberPhone = user.NumberPhone;
                    CaptureData.Country = user.Country;
                    CaptureData.City = user.City;
                    CaptureData.Password = user.Passworduser;


                    var menuForm = _serviceProvider.GetRequiredService<MenuForm>();
                    menuForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta, vuelva a intentarlo");
                }

        }

    }
}