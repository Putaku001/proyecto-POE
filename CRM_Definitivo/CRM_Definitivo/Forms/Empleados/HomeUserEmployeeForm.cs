using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
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

namespace PresentationLayer.Forms.Empleados
{
    public partial class HomeUserEmployeeForm : Form
    {
        private readonly IProyectsServices _proyectsServices;
        private readonly IUsersServices _usersServices;
        private readonly IProjectsClientServices _projectsClientServices;
        private readonly IServiceProvider _serviceProvider;
        int idUser;
        public HomeUserEmployeeForm(IProyectsServices proyectsServices, IUsersServices usersServices, IProjectsClientServices projectsClientServices , IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _proyectsServices = proyectsServices;
            _usersServices = usersServices;
            _projectsClientServices = projectsClientServices;
            _serviceProvider = serviceProvider;
            idUser = CaptureData.idUser;
            LoadData();
        }

        private void LoadData()
        {
            userAccountLabel.Text = AuthUser.UserAccount;
            timeLabel.Text = DateTime.Now.ToString("g");

            var getidClient = _usersServices.GetClients().Where(id => id.idUser == idUser).Select(select => select.idCliente).FirstOrDefault();
            var projectsCount = _projectsClientServices.GetsProjectsByIdClient(getidClient).Count();
            projectsPendingsLabel.Text = projectsCount.ToString();
        }

        private void iconUserEmployeeButton_Click_1(object sender, EventArgs e)
        {
            var openForm = _serviceProvider.GetRequiredService<RecordProjectsForm>();
            openForm.ShowDialog();

        }
    }
}
