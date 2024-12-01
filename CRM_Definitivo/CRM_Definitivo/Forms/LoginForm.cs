using System.Data;
using BusinessLayer;
using BusinessLayer.Services;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using PresentationLayer.Forms;
using PresentationLayer;
using PresentationLayer.Reports;
using PresentationLayer.Forms.Cliente;
using Microsoft.Extensions.DependencyInjection;
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Net.Mail;
using CommonLayer.Entities.ViewModel;
using DataAccessLayer.Repositories.InterfacesRepositories.InterfacesUser;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;


namespace CRM_Definitivo
{
    public partial class LoginForm : Form
    {
        private readonly IProjectsServices proyectoServices;
        private readonly IEmployeeRepositories usuarioRepositories;
        private readonly IEmployeeServices usuarioServices;
        private readonly IAdminsServices _adminsServices;
        private readonly IUserReports _userReports;
        private readonly IRolServices _rolServices;
        private readonly IServiceProvider _serviceProvider;

        private readonly EmailSettings _emailSettings;

        public LoginForm(IServiceProvider serviceProvider, IEmployeeRepositories _usuarioRepositories, IAdminsServices adminsServices, IEmployeeServices _usuarioServices, IRolServices rolServices, IProjectsServices _proyectoServices, IUserReports userReports, EmailSettings emailSettings)
        {
            InitializeComponent();
            usuarioRepositories = _usuarioRepositories;
            usuarioServices = _usuarioServices;
            _adminsServices = adminsServices;
            _rolServices = rolServices;
            proyectoServices = _proyectoServices;
            _userReports = userReports;
            _serviceProvider = serviceProvider;
            _emailSettings = emailSettings;

        }

        private void closedPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void closedPictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(closedPictureBox, "Cerrar aplicaci�n");
        }

        private void minimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(minimizePictureBox, "Minimizar aplicaci�n");
        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void hidePictureBox_Click(object sender, EventArgs e)
        {
            hidePictureBox.Hide();
            passwordTextBox.UseSystemPasswordChar = true;
            showPictureBox.Show();
        }

        private void hidePictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(hidePictureBox, "Ocultar contrase�a");
        }
        private void showPictureBox_Click(object sender, EventArgs e)
        {
            showPictureBox.Hide();
            passwordTextBox.UseSystemPasswordChar = false;
            hidePictureBox.Show();
        }

        private void showPictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(showPictureBox, "Mostrar contrase�a");
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            userTextBox.Text = "";
            passwordTextBox.Text = "";

            this.Show();
        }
        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            NewAccountForm createAccount = new NewAccountForm(usuarioServices, _adminsServices);
            createAccount.FormClosing += createAccount_FormClosing;
            createAccount.ShowDialog();
        }

        private void createAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = _adminsServices.Login(userTextBox.Text, passwordTextBox.Text);

            if (user != null)
            {
                CaptureData.idUser = user.IdUser;
                CaptureData.IdRol = user.idRol;
                CaptureData.UserAccount = user.UserAccount;
                CaptureData.NameUser = user.NameUser;
                CaptureData.LastName = user.LastName;
                CaptureData.Email = user.Email;
                CaptureData.DateBirth = user.Birthdate;
                CaptureData.NumberPhone = user.NumberPhone;
                CaptureData.Country = user.Country;
                CaptureData.City = user.City;
                CaptureData.Password = user.passworduser;

                if(user.Statususer == "Desactivado")
                {
                    MessageBox.Show("Su cuenta ha sido bloqueado/baneado por infligir las normas de la empresa", "Mensaje de sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var menuForm = _serviceProvider.GetRequiredService<MenuForm>();
                    this.Hide();
                    menuForm.ShowDialog();
                }              
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrecta, vuelva a intentarlo");
            }
        }

        private void fortgotPasswordLabel_Click(object sender, EventArgs e)
        {
            // Obtener el usuario desde la base de datos
            var user = _adminsServices.UserSearch(userTextBox.Text).FirstOrDefault();

            string idUserVerification = userTextBox.Text;
            if (user != null)
            {
                // Generar un c�digo de verificaci�n de 6 d�gitos
                Random rnd = new Random();
                int verificationCode = rnd.Next(100000, 999999);

                // Enviar SMS al usuario
                SendVerificationCode(user.NumberPhone, verificationCode.ToString());

                // Guardar el c�digo en el usuario temporalmente
                user.VerificationCode = verificationCode;

                // Redirigir al formulario de verificaci�n
                VerificationForm verificationForm = new VerificationForm(user, _emailSettings, usuarioServices, _adminsServices,  idUserVerification);
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

                // n�mero de tel�fono en formato E.164
                if (!phoneNumber.StartsWith("+"))
                {
                    phoneNumber = "+503" + phoneNumber;
                }

                var message = MessageResource.Create(
                    body: $"Tu c�digo de verificaci�n es: {code}",
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