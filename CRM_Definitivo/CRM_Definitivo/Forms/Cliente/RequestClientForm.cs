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
        private readonly IProyectsServices _proyectsServices;
        private readonly IServiceProvider _serviceProvider;
        int idClienById;
        public RequestClientForm(IUsersServices usersServices, IProyectsServices listProyectsServices, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _usersServices = usersServices;
            _proyectsServices = listProyectsServices;
            _serviceProvider = serviceProvider;
        }

        private void RequestClientForm_Load(object sender, EventArgs e)
        {
           loadData();
        }
        public void loadData()
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

            var pendingStatusId = new List<int> { 7, 6 };
            dataGridView1.DataSource = _proyectsServices.GetProjectsByIdStatus(pendingStatusId);

            dataGridView1.Columns["idClient"].Visible = false;
            dataGridView1.Columns["UserAccount"].Visible = false;
            dataGridView1.Columns["file"].Visible = false;
            dataGridView1.Columns["codeProject"].HeaderText = "Codigo";
            dataGridView1.Columns["nameProject"].HeaderText = "Proyecto";
            dataGridView1.Columns["descriptionProject"].HeaderText = "Descripcion";
            dataGridView1.Columns["statusproyect"].HeaderText = "Estado";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "SelectPf")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string codeProject = row.Cells["codeProject"].Value.ToString();
                string nameProject = row.Cells["nameProject"].Value.ToString();
                string Description = row.Cells["descriptionProject"].Value.ToString();
                string projectStatusId = row.Cells["statusproyect"].Value.ToString(); 
                string progressStatusId = "En progreso"; 

                
 
                if (projectStatusId == progressStatusId)
                {
                    MessageBox.Show($"El proyecto '{nameProject}' (Código: {codeProject}) está en progreso, aun no esta listo.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var openInfoProjects = _serviceProvider.GetRequiredService<AnswerProyectClient>();
                    openInfoProjects.codeProyect = codeProject;
                    openInfoProjects.nameProject = nameProject;
                    openInfoProjects.Description = Description;
                    
                    
                    openInfoProjects.ShowDialog();
                    loadData();

                }
            }
            else if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "downloadProject")
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["statusproyect"].Value.ToString() == "En progreso")
                {
                    MessageBox.Show($"El proyecto no esta listo y no puede descargarse",
                                   "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    try
                    {
                        string codeProject = dataGridView1.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();
                        byte[] content = _proyectsServices.getProjectInDB(codeProject);

                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            FileName = "proyecto",
                            Filter = "Todos los archivos|*.*"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            File.WriteAllBytes(filePath, content);

                            MessageBox.Show("Proyecto descargada correctamente");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en la descargar la tarea: " + ex.Message);
                    }
                }
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

            _proyectsServices.AddNewProject(newProject.codeProject, newProject.idClient, newProject.nameProject, newProject.descriptionProject);
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
