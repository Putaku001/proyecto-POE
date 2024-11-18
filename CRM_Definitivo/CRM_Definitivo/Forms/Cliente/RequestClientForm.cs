using BusinessLayer.Services;
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

namespace PresentationLayer.Forms.Cliente
{
    public partial class RequestClientForm : Form
    {
        private readonly IUsersServices _usersServices;
        private readonly IListProyectsServices _proyectsServices;
        private readonly IServiceProvider _serviceProvider;
        public RequestClientForm(IUsersServices usersServices, IListProyectsServices listProyectsServices, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _usersServices = usersServices;
            _proyectsServices = listProyectsServices;
            _serviceProvider = serviceProvider; 
        }

        private void RequestClientForm_Load(object sender, EventArgs e)
        {
            int idUser = CaptureData.idUser;
            dataGridViewRequestProject.DataSource = _proyectsServices.GetProjectsByIdClient(idUser);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == dataGridView1.Columns["SelectPf"].Index)
            {
                var OpenInfoProjects = _serviceProvider.GetRequiredService<InforProjectsClient>();
                OpenInfoProjects.ShowDialog();
            }
        }
    }
}
