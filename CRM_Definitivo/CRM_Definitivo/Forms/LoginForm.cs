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
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Net.Mail;


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

        private readonly EmailSettings _emailSettings;

        public LoginForm(IServiceProvider serviceProvider, IUsersRepositories _usuarioRepositories, IUsersServices _usuarioServices, IRolServices rolServices, IListProyectsServices _proyectoServices, IUserReports userReports, EmailSettings emailSettings)
        {
            InitializeComponent();           
            usuarioRepositories = _usuarioRepositories;
            usuarioServices = _usuarioServices;
            _rolServices = rolServices;
            proyectoServices = _proyectoServices;
            _userReports = userReports;
            _serviceProvider = serviceProvider;
            _emailSettings = emailSettings;

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
                CaptureData.Password = user.passworduser;


                var menuForm = _serviceProvider.GetRequiredService<MenuForm>();
                this.Hide();
                menuForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta, vuelva a intentarlo");
            }

        }

        private void fotgotPassLabel_Click(object sender, EventArgs e)
        {
            // Obtener el usuario desde la base de datos
            var user = usuarioServices.UserSearch(txtUser.Text).FirstOrDefault();

            string idUserVerification = txtUser.Text;
            if (user != null)
            {
                // Generar un código de verificación de 6 dígitos
                Random rnd = new Random();
                int verificationCode = rnd.Next(100000, 999999);

                // Enviar SMS al usuario
                SendVerificationCode(user.NumberPhone, verificationCode.ToString());

                // Guardar el código en el usuario temporalmente
                user.VerificationCode = verificationCode;

                // Redirigir al formulario de verificación
                VerificationForm verificationForm = new VerificationForm(user, _emailSettings , usuarioServices, idUserVerification);
                verificationForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }
        private void SendVerificationCode(string phoneNumber, string code)
        {
            try
            {
                string accountSid = "ACda51772af5ba53292479ff29856eddbe";
                string authToken = "b02d4032c456f1e1c978e8a2b1a6442b";
                TwilioClient.Init(accountSid, authToken);

                // número de teléfono en formato E.164
                if (!phoneNumber.StartsWith("+"))
                {
                    phoneNumber = "+503" + phoneNumber;
                }

                var message = MessageResource.Create(
                    body: $"Tu código de verificación es: {code}",
                    from: new PhoneNumber("+13023608137"),
                    to: new PhoneNumber(phoneNumber)
                );

                Console.WriteLine("Mensaje enviado con SID: " + message.Sid);
            }
            catch (Twilio.Exceptions.ApiException ex)
            {
                Console.WriteLine("Error al enviar mensaje: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: " + ex.Message);
            }
        }
    }
}