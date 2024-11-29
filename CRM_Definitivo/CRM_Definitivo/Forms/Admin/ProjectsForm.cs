using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Forms.Admin;
using PresentationLayer.Resources;
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
            LoadDataProjectProgress();
            LoadDataRequestProject();
            LoadDataProjectWaiting();
            LoadDataProjectRefused();
            //HideColumns(projectProgressDataGridView, "file");

            foreach (DataGridViewColumn column in projectProgressDataGridView.Columns)
            {
                if (column.Visible == true && column.Name != "SelectProjectInProgress")
                {
                    searchProcessComboBox.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }

            searchProcessComboBox.DisplayMember = "Texto";
            searchProcessComboBox.ValueMember = "Valor";
            searchProcessComboBox.SelectedIndex = 0;
        }

        private void LoadDataRequestProject()
        {
            requestProjectsDataGridView.DataSource = _proyectoServices.GetRequestProjectsByStatus("Pendiente");
            ConfigureAutoSize(requestProjectsDataGridView);
            HideColumns(requestProjectsDataGridView, "file", "idClient", "dateInit", "dateEnd");

        }

        private void LoadDataProjectProgress()
        {
            projectProgressDataGridView.DataSource = _proyectoServices.GetRequestProjectsByStatus("En progreso");
            ConfigureAutoSize(projectProgressDataGridView);
            HideColumns(projectProgressDataGridView, "file");
        }

        private void LoadDataProjectWaiting()
        {
            projectsWaitingResponseDataGridView.DataSource = _proyectoServices.GetRequestProjectsByStatus("esperando aprobacion del cliente");
            ConfigureAutoSize(projectsWaitingResponseDataGridView);
            HideColumns(projectsWaitingResponseDataGridView, "file", "dateInit", "dateEnd");
        }

        private void LoadDataProjectRefused()
        {
            projectsRefusedDataGridView.DataSource = _proyectoServices.GetRequestProjectsByStatus("Rechazado");
            ConfigureAutoSize(projectsRefusedDataGridView);
        }

        private void ConfigureAutoSize(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HideColumns(DataGridView dataGridView, params string[] columnNames)
        {
            foreach (var column in columnNames)
            {
                if (dataGridView.Columns[column] != null)
                {
                    dataGridView.Columns[column].Visible = false;
                }
            }
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

        private void projectsRefusedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == projectsRefusedDataGridView.Columns["selectRp"].Index)
            {
                var mensaje = MessageBox.Show("Desea reahacer el proyecto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                var ConfirmMessage = MessageBox.Show("Esta seguro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ConfirmMessage == DialogResult.Yes)
                {
                    string CodeProject = projectsRefusedDataGridView.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();

                    _proyectoServices.StatusProject(CodeProject, 4);
                    LoadProyecto();
                }
            }
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

        private void iconSearchProcessButton_Click(object sender, EventArgs e)
        {
            //
            string columnFilter = ((OpcionCombo)searchProcessComboBox.SelectedItem).Valor.ToString();
            bool encontrado = false;

            if (projectProgressDataGridView.Rows.Count > 0)
            {
                // Desactiva momentáneamente la selección actual
                projectProgressDataGridView.CurrentCell = null;

                foreach (DataGridViewRow row in projectProgressDataGridView.Rows)
                {
                    if (row.Cells[columnFilter].Value != null &&
                        row.Cells[columnFilter].Value.ToString().Trim().ToUpper().Contains(searProjectProgresstextBox.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                        encontrado = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show($"No existe un proyecto llamado {searProjectProgresstextBox.Text}", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void iconCleanProcessButton_Click(object sender, EventArgs e)
        {
            searProjectProgresstextBox.Clear();

            foreach (DataGridViewRow row in projectProgressDataGridView.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
