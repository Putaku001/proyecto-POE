using BusinessLayer.Services.Interfaces;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Cliente
{
    public partial class ProfileUserAccountForm : Form
    {
        private readonly ISqlDataAccess _dbConnection;
        private readonly IUsersServices _usersServices;
        private readonly IServiceProvider _serviceProvider;
        public ProfileUserAccountForm(ISqlDataAccess dbConnection ,IServiceProvider serviceProvider, IUsersServices usersServices)
        {
            InitializeComponent();
            _dbConnection = dbConnection;
            _serviceProvider = serviceProvider;
            LoadProvincias();
            _usersServices = usersServices;
            LoadData();
            CargarImagenEnPictureBox(AuthUser.idUser);
        }

        public void LoadProvincias()
        {

            List<string> ListaPaises = new List<string>()
            {
                "El Salvador"
            };

            comboboxCountryUser.DataSource = ListaPaises;
            comboboxCountryUser.SelectedIndex = -1;



            List<string> ListaCiudad = new List<string>()
            {
                "San Salvador",
                "La Libertad",
                "Santa Ana"
            };

            comboboxCityUser.DataSource = ListaCiudad;
            comboboxCityUser.SelectedIndex = -1;
        }


        private void LoadData()
        {
            //informacion del usuario
            textBoxUserAccount.Text = CaptureData.UserAccount;
            textboxNameUser.Text = CaptureData.NameUser;
            textboxLastNameUser.Text = CaptureData.LastName;
            textboxNumberphoneUser.Text = CaptureData.NumberPhone;
            datetimeDateUser.Value = CaptureData.DateBirth;

            //residencia del usuario
            comboboxCountryUser.Text = CaptureData.Country;
            comboboxCityUser.Text = CaptureData.City;
        }

        private void iconButtonSaveProfile_Click(object sender, EventArgs e)
        {
            var SaveProfile = new User()
            {
                UserAccount = textBoxUserAccount.Text,
                IdUser = AuthUser.idUser,
                NameUser = textboxNameUser.Text,
                LastName = textboxLastNameUser.Text,
                NumberPhone = textboxNumberphoneUser.Text,
                Email = CaptureData.Email,
                Birthdate = datetimeDateUser.Value,
                passworduser = CaptureData.Password,
                Statususer = "Activo",
                Country = comboboxCountryUser.SelectedValue?.ToString(),
                City = comboboxCityUser.SelectedValue?.ToString(),

            };

            _usersServices.EditAccountUser(SaveProfile);

            textBoxUserAccount.Text = SaveProfile.UserAccount;
            textboxNameUser.Text = SaveProfile.NameUser;
            textboxLastNameUser.Text = SaveProfile.LastName;
            textboxNumberphoneUser.Text = SaveProfile.NumberPhone;
            datetimeDateUser.Value = SaveProfile.Birthdate;

            comboboxCountryUser.Text = SaveProfile.Country;
            comboboxCityUser.Text = SaveProfile.City;

            MessageBox.Show("Perfil actualizado correctamente!");


        }

        private void labelChangePasswordProfile_Click(object sender, EventArgs e)
        {
            var ChangePasswordProfile = _serviceProvider.GetRequiredService<ChangePasswordProfileForm>();
            ChangePasswordProfile.ShowDialog();
        }

        private void CargarImagenEnPictureBox(int idUser)
        {
            var repo =_usersServices.GetProfileImage(idUser);
            byte[] imageBytes = repo;

            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (var memoryStream = new MemoryStream(imageBytes))
                {
                    pictureBoxProfileUser.Image = Image.FromStream(memoryStream);
                }
            }
            else
            {
                pictureBoxProfileUser.Image = null; 
            }
        }


        private void lblPhotoProfileChangeUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog PhotoProfileUser = new OpenFileDialog();
            PhotoProfileUser.Filter = "Archivos de imagen (*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg";

            if (PhotoProfileUser.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfileUser.Image = Image.FromFile(PhotoProfileUser.FileName);

                byte[] imageBytes;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pictureBoxProfileUser.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = memoryStream.ToArray();
                }

                var imageProfile = new User
                {
                    UserAccount = textBoxUserAccount.Text,
                    IdUser = AuthUser.idUser,
                    NameUser = textboxNameUser.Text,
                    LastName = textboxLastNameUser.Text,
                    NumberPhone = textboxNumberphoneUser.Text,
                    Email = CaptureData.Email,
                    Birthdate = datetimeDateUser.Value,
                    passworduser = CaptureData.Password,
                    Statususer = "Activo",
                    Country = comboboxCountryUser.SelectedValue?.ToString(),
                    City = comboboxCityUser.SelectedValue?.ToString(),
                    Image = imageBytes
                };

                 _usersServices.EditAccountUser(imageProfile);                
            }
        }
    }
}
