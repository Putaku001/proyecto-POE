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
    public partial class ProjectsForm : Form
    {
        private readonly IProyectsServices _proyectoServices;
        private readonly IServiceProvider _serviceProvider;
        public ProjectsForm(IProyectsServices proyectoServices, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _proyectoServices = proyectoServices;
            _serviceProvider = serviceProvider;
            LoadProyecto();
        }

        private void LoadProyecto()
        {
            requestProjectsDataGridView.DataSource = _proyectoServices.GetRequestProjects();
            requestProjectsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            projectProgressDataGridView.DataSource = _proyectoServices.GetRequestProjectsProgress();
            projectProgressDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            projectsEndDataGridView.DataSource = _proyectoServices.GetRequestProjectsFinish();
            projectsEndDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            projectsRefusedDataGridView.DataSource = _proyectoServices.GetRequestProjectsRefused();
            projectsRefusedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            projectsWaitingResponseDataGridView.DataSource = _proyectoServices.GetProjectsWaitingReponse();
            projectsWaitingResponseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            projectsWaitingResponseDataGridView.Columns["file"].Visible = false;
            projectsRefusedDataGridView.Columns["file"].Visible = false;
            projectsEndDataGridView.Columns["file"].Visible = false;
            requestProjectsDataGridView.Columns["file"].Visible = false;
            requestProjectsDataGridView.Columns["idClient"].Visible = false;
            projectProgressDataGridView.Columns["file"].Visible = false;

        }


        private void requestProjectsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == requestProjectsDataGridView.Columns["SelectPr"].Index)
            {
                string CodeProject = requestProjectsDataGridView.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();
                string NameProject = requestProjectsDataGridView.Rows[e.RowIndex].Cells["nameProject"].Value.ToString();
                string Client = requestProjectsDataGridView.Rows[e.RowIndex].Cells["userAccount"].Value.ToString();
                string DescriptionProject = requestProjectsDataGridView.Rows[e.RowIndex].Cells["descriptionProject"].Value.ToString();

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
        private void projectProgressDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string CodeProject = projectProgressDataGridView.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();
                string NameProject = projectProgressDataGridView.Rows[e.RowIndex].Cells["nameProject"].Value.ToString();
                string Client = projectProgressDataGridView.Rows[e.RowIndex].Cells["userAccount"].Value.ToString();
                string DescriptionProject = projectProgressDataGridView.Rows[e.RowIndex].Cells["descriptionProject"].Value.ToString();
                DateTime dateEnd = Convert.ToDateTime(projectProgressDataGridView.Rows[e.RowIndex].Cells["dateEnd"].Value.ToString());

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


        private void projectsEndDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void projectsRefusedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == projectsRefusedDataGridView.Columns["selectRp"].Index)
            {
                var mensaje = MessageBox.Show("Desea reahacer el proyecto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                var ConfirmMessage = MessageBox.Show("Esta seguro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ConfirmMessage == DialogResult.Yes)
                {
                    string CodeProject = projectsRefusedDataGridView.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();

                    _proyectoServices.ProjectRedo(CodeProject, 4);
                    LoadProyecto();
                }
            }
        }

        private void projectsWaitingResponseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void projectProgressDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var CodeProject = projectProgressDataGridView.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();

                var OpenInfoProjects = _serviceProvider.GetRequiredService<infoProjects>();
                OpenInfoProjects.codeProject = CodeProject;
                OpenInfoProjects.ShowDialog();

            }
        }


    }
}
