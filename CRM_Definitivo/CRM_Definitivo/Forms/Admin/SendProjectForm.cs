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

namespace PresentationLayer.Forms.Admin
{
    public partial class SendProjectForm : Form
    {
        public string CodeProject { get; set; }
        public string NameProject { get; set; }
        public string DescriptionProject { get; set; }
        public string Client { get; set; }
        public DateTime DateEnd { get; set; }
        byte[] fileByte;

        private readonly IProyectsServices _proyectsServices;
        private readonly IUsersServices _usersServices;

        public SendProjectForm(IProyectsServices proyectsServices, IUsersServices usersServices)
        {
            _proyectsServices = proyectsServices;
            _usersServices = usersServices;
            InitializeComponent();
        }

        private void SendProjectForm_Load(object sender, EventArgs e)
        {
            codeProjectLabel.Text = CodeProject;
            descriptionTextBox.Text = DescriptionProject;
            nameUserLabel.Text = Client;
            nameProjectLabel.Text = NameProject;
            dateLabel.Text = DateEnd.ToString();

        }

        private void linkLabelFileProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Todos los archivos (*.*)|*.*";
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
                        selectedFileLabel.Text = filePath;
                    }
                }
            }
        }

        private void iconButtonSendProject_Click(object sender, EventArgs e)
        {
            if (fileByte == null || fileByte.Length == 0)
            {
                MessageBox.Show("Por favor, seleccione un archivo antes de enviar el proyecto.", "Archivo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Projects projects = new Projects();
            var file = projects.file = fileByte;
            _proyectsServices.SendProjects(CodeProject, file);

            StatusProjects statusProjects = new StatusProjects();
            int idStatusProject = statusProjects.idStatusProyect = 7;
            _proyectsServices.StatusProject(CodeProject, idStatusProject);

            MessageBox.Show("El proyecto ha sido enviado correctamente, estamos en espera de la respuesta del cliente!", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
