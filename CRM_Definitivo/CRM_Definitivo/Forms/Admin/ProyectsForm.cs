using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class ProyectsForm : Form
    {
        private readonly IProyectsServices _proyectoServices;
        private readonly IServiceProvider _serviceProvider;
        public ProyectsForm(IProyectsServices proyectoServices, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _proyectoServices = proyectoServices;
            _serviceProvider = serviceProvider;
            LoadProyecto();
        }

        private void LoadProyecto()
        {
            dataGridViewRequestProjects.DataSource = _proyectoServices.GetRequestProjects();
            dataGridViewRequestProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjectsInProgress.DataSource = _proyectoServices.GetRequestProjectsProgress();
            dataGridViewProjectsInProgress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjectsEnd.DataSource = _proyectoServices.GetRequestProjectsFinish();
            dataGridViewProjectsEnd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjectsRefused.DataSource = _proyectoServices.GetRequestProjectsRefused();
            dataGridViewProjectsRefused.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjectsWaitingResponse.DataSource = _proyectoServices.GetProjectsWaitingReponse();
            dataGridViewProjectsWaitingResponse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewProjectsWaitingResponse.Columns["file"].Visible = false;
            dataGridViewProjectsRefused.Columns["file"].Visible = false;
            dataGridViewProjectsEnd.Columns["file"].Visible = false;
            dataGridViewRequestProjects.Columns["file"].Visible = false;
            dataGridViewRequestProjects.Columns["idClient"].Visible = false;
            dataGridViewProjectsInProgress.Columns["file"].Visible = false;

        }

        private void tpListaProyectos_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRequestProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewRequestProjects.Columns["SelectPr"].Index)
            {
                string CodeProject = dataGridViewRequestProjects.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();
                string NameProject = dataGridViewRequestProjects.Rows[e.RowIndex].Cells["nameProject"].Value.ToString();
                string Client = dataGridViewRequestProjects.Rows[e.RowIndex].Cells["userAccount"].Value.ToString();
                string DescriptionProject = dataGridViewRequestProjects.Rows[e.RowIndex].Cells["descriptionProject"].Value.ToString();

                var assignamentTaskEmployeeForm = _serviceProvider.GetRequiredService<AssignamentTaskEmployeeForm>();
                assignamentTaskEmployeeForm.Client = Client;
                assignamentTaskEmployeeForm.CodeProject = CodeProject;
                assignamentTaskEmployeeForm.NameProject = NameProject;
                assignamentTaskEmployeeForm.DescriptionProject = DescriptionProject;
                assignamentTaskEmployeeForm.ShowDialog();

                Projects dateInit = new Projects();
                var dateInitial = dateInit.dateInit = DateTime.Now;

                _proyectoServices.DateInit(CodeProject, dateInitial);

                StatusProjects statusProjects = new StatusProjects();
                int status = statusProjects.idStatusProyect = 6;

                _proyectoServices.StatusProject(CodeProject, status);
                LoadProyecto();
            }
        }

        private void dataGridViewProjectsInProgress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridViewProjectsInProgress.Columns["SelectProjectInProgress"].Index)
            {
                string CodeProject = dataGridViewProjectsInProgress.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();
                string NameProject = dataGridViewProjectsInProgress.Rows[e.RowIndex].Cells["nameProject"].Value.ToString();
                string Client = dataGridViewProjectsInProgress.Rows[e.RowIndex].Cells["userAccount"].Value.ToString();
                string DescriptionProject = dataGridViewProjectsInProgress.Rows[e.RowIndex].Cells["descriptionProject"].Value.ToString();
                DateTime dateEnd = Convert.ToDateTime(dataGridViewProjectsInProgress.Rows[e.RowIndex].Cells["dateEnd"].Value.ToString());

                var SendProjectForm = _serviceProvider.GetRequiredService<SendProjectForm>();
                SendProjectForm.CodeProject = CodeProject;
                SendProjectForm.NameProject = NameProject;
                SendProjectForm.Client = Client;
                SendProjectForm.DescriptionProject = DescriptionProject;
                SendProjectForm.DateEnd = dateEnd;
                SendProjectForm.ShowDialog();

                LoadProyecto();

            }
        }

        private void dataGridViewProjectsEnd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProjectsRefused_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridViewProjectsRefused.Columns["selectRp"].Index)
            {
                var mensaje = MessageBox.Show("Desea reahacer el proyecto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                var ConfirmMessage = MessageBox.Show("Esta seguro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ConfirmMessage == DialogResult.Yes)
                {
                    string CodeProject = dataGridViewProjectsRefused.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();

                    _proyectoServices.ProjectRedo(CodeProject, 4);
                    LoadProyecto();
                }
            }
        }

        private void dataGridViewProjectsWaitingResponse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProjectsInProgress_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == 0)
            {
                var CodeProject = dataGridViewProjectsInProgress.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();

                var OpenInfoProjects = _serviceProvider.GetRequiredService<infoProjects>();
                OpenInfoProjects.codeProject = CodeProject;
                OpenInfoProjects.ShowDialog();
                
            }
        }
    }
}
