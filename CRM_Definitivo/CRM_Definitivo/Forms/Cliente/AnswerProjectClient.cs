using BusinessLayer.Services;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Validations;
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
        public AnswerProjectClient(IServiceProvider serviceProvider, IProjectsServices projectServices, IProjectsClientServices projectsClientServices)
        {
            InitializeComponent();
            _servicesProvider = serviceProvider;
            _proyectsServices = projectServices;
            _projectsClientServices = projectsClientServices ?? throw new ArgumentNullException(nameof(projectsClientServices));
        }
        private void AnswerProyectClient_Load(object sender, EventArgs e)
        {
            descriptionProjectTextBox.Text = Description;
            codeProjectLabel.Text = codeProyect;
            nameProjectLabel.Text = nameProject;
        }


        private void iconApprovedProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(codeProyect))
                {
                    MessageBox.Show("El código del proyecto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (codeProyect.Length < 5 || codeProyect.Length > 20)
                {
                    MessageBox.Show("El código del proyecto debe tener entre 5 y 20 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (string.IsNullOrEmpty(nameProject))
                {
                    MessageBox.Show("El nombre del proyecto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (nameProject.Length > 100)
                {
                    MessageBox.Show("El nombre del proyecto no debe exceder los 100 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }


                _proyectsServices.StatusProject(codeProyect, 9);

                MessageBox.Show($"El Proyecto '{nameProject}' ha sido Aceptado.", "Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void iconRefusedProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileByte == null || fileByte.Length == 0)
                {
                    MessageBox.Show("Por favor, seleccione un archivo antes de rechazar el proyecto.", "Archivo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_projectsClientServices == null)
                {
                    MessageBox.Show("El servicio de proyectos de cliente no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (idProject <= 0)
                {
                    MessageBox.Show("El ID del proyecto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(descriptionProjectTextBox.Text))
                {
                    MessageBox.Show("Por favor, ingrese una descripción antes de rechazar el proyecto.", "Descripción requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                reasonForRejection refused = new reasonForRejection
                {
                    idProject = idProject,
                    fileRefused = fileByte
                };

                _projectsClientServices.InsertReasonForRejection(refused);

                int idStatusProject = 8;
                _proyectsServices.StatusProject(codeProyect, idStatusProject);

                MessageBox.Show($"El Proyecto '{nameProject}' ha sido rechazado correctamente.", "Rechazado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
