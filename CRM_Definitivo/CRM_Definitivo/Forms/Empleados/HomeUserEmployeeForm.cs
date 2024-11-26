using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
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

namespace PresentationLayer.Forms.Empleados
{
    public partial class HomeUserEmployeeForm : Form
    {
        private readonly IProyectsServices _proyectsServices;
        private readonly IUsersServices _usersServices;
        int idUser;
        public HomeUserEmployeeForm(IProyectsServices proyectsServices, IUsersServices usersServices)
        {
            InitializeComponent();
            _proyectsServices = proyectsServices;
            _usersServices = usersServices;
            idUser = CaptureData.idUser;
            LoadData();
        }

        private void LoadData()
        {
            userAccountLabel.Text = AuthUser.UserAccount;
            timeLabel.Text = DateTime.Now.ToString("g");

            var getidClient = _usersServices.GetClients().Where(id => id.idUser == idUser).Select(select => select.idCliente).FirstOrDefault();
            var projectsCount = _proyectsServices.GetProjectsByIdClient(getidClient).Count();
            projectsPendingsLabel.Text = projectsCount.ToString();
        }
    }
}
