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

        }
    }
}
