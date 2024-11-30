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
    public partial class AnswerProjectClient : Form
    {
        public int idProject {  get; set; }
        public string codeProyect { get; set; }
        public string Description { get; set; }
        public string nameProject { get; set; }

        private readonly IServiceProvider _servicesProvider;
        private readonly IProjectsServices _proyectsServices;
        private readonly IProjectsClientServices _projectsClientServices;
        private byte[] fileByte;
        public AnswerProjectClient(IServiceProvider serviceProvider, IProjectsServices _proyectServices)
        {
            InitializeComponent();
            _servicesProvider = serviceProvider;
            _proyectsServices = _proyectServices;

        }
        private void AnswerProyectClient_Load(object sender, EventArgs e)
        {
            descriptionProjectTextBox.Text = Description;
            codeProjectLabel.Text = codeProyect;
            nameProjectLabel.Text = nameProject;
        }

        private void iconApprovedProjectButton_Click(object sender, EventArgs e)
        {
            _proyectsServices.StatusProject(codeProyect, 9);
            MessageBox.Show($"El Proyecto '{nameProject}' a sido Aceptado");
            this.Close();
        }

        private void iconRefusedProjectButton_Click(object sender, EventArgs e)
        {
            if (fileByte == null || fileByte.Length == 0)
            {
                MessageBox.Show("Por favor, seleccione un archivo antes de rechazar el proyecto.", "Archivo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            reasonForRejection refused = new reasonForRejection
            {
                idProject = idProject,
                fileRefused = fileByte
            };
            
            _projectsClientServices.InsertReasonForRejection(refused);

            StatusProjects statusProjects = new StatusProjects();
            int idStatusProject = statusProjects.idStatusProyect = 8;
            _proyectsServices.StatusProject(codeProyect, idStatusProject);

            MessageBox.Show($"El Proyecto '{nameProject}' ha sido rechazado correctamente.", "Rechazado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void refusedProjectLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Todos los archivos (*.txt)|*.txt";
            openFileDialog.Title = "Seleccione el archivo a enviar";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        fileByte = ms.ToArray();
                    }
                }
            }
        }
    }
}
