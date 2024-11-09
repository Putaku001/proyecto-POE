using BusinessLayer.Services.Interfaces;
using CommonLayer.Entities;
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
        private readonly IUsersServices _usersServices;
        private readonly IServiceProvider _serviceProvider;
        public ProfileUserAccountForm(IServiceProvider serviceProvider, IUsersServices usersServices)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            LoadProvincias();
            _usersServices = usersServices;
            LoadData();
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
    }
}
