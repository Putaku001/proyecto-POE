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
        int idClienById;
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
            var idClientByID = Convert.ToInt32(_usersServices.GetClients().Where(u => u.idUser == idUser).Select(e => e.idCliente).FirstOrDefault());
            dataGridViewRequestProject.DataSource = _proyectsServices.GetProjectsByIdClient(idClientByID);

            dataGridViewRequestProject.Columns["idClient"].Visible = false;
            dataGridViewRequestProject.Columns["UserAccount"].Visible = false;
            dataGridViewRequestProject.Columns["file"].Visible = false;
            dataGridViewRequestProject.Columns["statusproyect"].Visible = false;
            dataGridViewRequestProject.Columns["codeProject"].HeaderText = "Codigo";
            dataGridViewRequestProject.Columns["nameProject"].HeaderText = "Proyecto";
            dataGridViewRequestProject.Columns["descriptionProject"].HeaderText = "Descripcion";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView1.Columns["SelectPf"].Index)
            {
                var OpenInfoProjects = _serviceProvider.GetRequiredService<InforProjectsClient>();
                OpenInfoProjects.ShowDialog();
                //te falta hacer esta parte 
                //acordate que aqui va ir la logica de que dependiendo si el proyecto esta finalizado osea esperando la probacion del cliente mostrara el form de infor o el form para rechazar o aceptar el proyecto
            }
        }

        private void iconButtonGuardarNP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProyectoAñadir.Text) || string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int idUser = CaptureData.idUser;
            int idClient = _usersServices.GetClients().Where( U => U.idUser == idUser).Select(c => c.idCliente).FirstOrDefault();

            var newProject = new RequestProjects
            {
                codeProject = GenerateProjectCode(),
                idClient = idClient,
                nameProject = txtNombreProyectoAñadir.Text, 
                descriptionProject = textBoxDescription.Text 
            };

            var status = new StatusProjects
            {
                idStatusProyect = 4
            };

            _proyectsServices.AddNewProject(newProject.codeProject, newProject.idClient, newProject.nameProject, newProject.descriptionProject); // <-------- Error
            _proyectsServices.StatusProject(newProject.codeProject , status.idStatusProyect);

            dataGridViewRequestProject.DataSource = _proyectsServices.GetProjectsByIdClient(Convert.ToInt32(_usersServices.GetClients().Where(u => u.idUser == idUser).Select(e => e.idCliente).FirstOrDefault()));
            MessageBox.Show("Se ha añadido el proyecto!");
            txtNombreProyectoAñadir.Clear();
            textBoxDescription.Clear();
        }

        private string GenerateProjectCode()
        {
            string year = "24";

            Random random = new Random();
            int randomNumber = random.Next(100, 1000); 

            string projectCode = $"U{year}{randomNumber}";

            return projectCode;
        }
    }
}
