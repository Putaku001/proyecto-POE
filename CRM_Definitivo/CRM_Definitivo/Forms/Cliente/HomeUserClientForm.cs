using BusinessLayer.Services.InterfacesServices;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using CommonLayer.Entities;
using CommonLayer.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Cliente
{
    public partial class HomeUserClientForm : Form
    {
        private readonly IProjectsClientServices _projectsClientServices;
        private readonly IEmployeeServices _usersServices;
        private readonly IClientsServices _clientsServices;
        int idUser;
        public HomeUserClientForm(IProjectsClientServices projectsClientServices, IEmployeeServices usersServices, IClientsServices clientsServices)
        {
            InitializeComponent();
            _projectsClientServices = projectsClientServices;
            _usersServices = usersServices;
            idUser = CaptureData.idUser;
            LoadData();
            _clientsServices = clientsServices;
        }

        private void LoadData()
        {
            userAccountLabel.Text = CaptureData.UserAccount;
            timeLabel.Text = DateTime.Now.ToString("g");
            ShowStatusProject();
        }

        private void ShowStatusProject()
        {
            int idClient = _clientsServices.GetClients().Where(id => id.idUser == idUser).Select(client => client.idCliente).FirstOrDefault();
            var allProjects = _projectsClientServices.GetsProjectsByIdClient(idClient).OrderByDescending(date => date.dateRegistration).ToList();

            if(allProjects.Any())
            {

                var mostRecentProject = allProjects.FirstOrDefault()?.statusProject;
                var nameMostRecentProject = allProjects.FirstOrDefault()?.nameProject;

                projectsAssignamentPanel.Visible = true;
                nameProjectLabel.Text = nameMostRecentProject;
                statusProjectLabel.Text = mostRecentProject;
            }
            else
            {
                projectsAssignamentPanel.Visible = false;
            }
        }


    }
}
