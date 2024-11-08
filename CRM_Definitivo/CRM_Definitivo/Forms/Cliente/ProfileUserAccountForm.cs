using BusinessLayer.Services.Interfaces;
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

namespace PresentationLayer.Forms.Cliente
{
    public partial class ProfileUserAccountForm : Form
    {
        private readonly IUsersServices _usersServices;
        public ProfileUserAccountForm(IUsersServices usersServices)
        {
            InitializeComponent();
            _usersServices = usersServices;
            LoadData();
        }

        private void LoadData()
        {
            //informacion del usuario
            textboxNameUser.Text = CaptureData.NameUser;
            textboxLastNameUser.Text = CaptureData.LastName;
            textboxNumberphoneUser.Text = CaptureData.NumberPhone;
            textboxPasswordChangeUser.Text = CaptureData.Password;
            datetimeDateUser.Value = CaptureData.DateBirth;

            //residencia del usuario
            comboboxCountryUser.Text = CaptureData.Country;
            comboboxCityUser.Text = CaptureData.City;
        }

        private void iconButtonSaveProfile_Click(object sender, EventArgs e)
        {
            User SaveProfile = new User();
            SaveProfile.NameUser = textboxNameUser.Text;
            SaveProfile.LastName = textboxLastNameUser.Text;
            SaveProfile.NumberPhone = textboxNumberphoneUser.Text;
            SaveProfile.Birthdate = datetimeDateUser.Value;
            SaveProfile.Country = Convert.ToString(comboboxCountryUser.SelectedValue);
            SaveProfile.City = Convert.ToString(comboboxCityUser.SelectedValue);

            _usersServices.EditAccountUser(SaveProfile);
        }
    }
}
