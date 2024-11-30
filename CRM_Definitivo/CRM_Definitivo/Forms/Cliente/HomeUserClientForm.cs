using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
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
        private readonly IUsersServices _usersServices;
        int idUser;
        public HomeUserClientForm(IProjectsClientServices projectsClientServices, IUsersServices usersServices)
        {
            InitializeComponent();
            _projectsClientServices = projectsClientServices;
            _usersServices = usersServices;
            idUser = CaptureData.idUser;
            LoadData();
        }

        private void LoadData()
        {
            userAccountLabel.Text = AuthUser.UserAccount;
            timeLabel.Text = DateTime.Now.ToString("g");
            ShowStatusProject();
        }

        private void ShowStatusProject()
        {
            int idClient = _usersServices.GetClients().Where(id => id.idUser == idUser).Select(client => client.idCliente).FirstOrDefault();
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
