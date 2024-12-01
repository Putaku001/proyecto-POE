using BusinessLayer.Services;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities.Projects;
using CommonLayer.Entities.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using MimeKit;
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
        private readonly IProjectsServices _proyectoServices;
        private readonly IServiceProvider _serviceProvider;
        private readonly EntitieViewModel _entitieViewModel;
        public ProjectsForm(IProjectsServices proyectoServices, IServiceProvider serviceProvider, EntitieViewModel entitieViewModel)
        {
            InitializeComponent();
            _proyectoServices = proyectoServices;
            _serviceProvider = serviceProvider;
            _entitieViewModel = entitieViewModel;
            LoadProyecto();
        }

        private void LoadProyecto()
        {
            LoadDataProjectProgress();
            LoadDataRequestProject();
            LoadDataProjectWaiting();
            LoadDataProjectRefused();

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
            ConfigureDataGridView();
            ConfigureAutoSize(requestProjectsDataGridView);
            HideColumns(requestProjectsDataGridView, "file", "idClient", "dateInit", "dateEnd");

        }

        private void LoadDataProjectProgress()
        {
            projectProgressDataGridView.DataSource = _proyectoServices.GetRequestProjectsByStatus("En progreso");
            ConfigureDataGridView();
            ConfigureAutoSize(projectProgressDataGridView);
            HideColumns(projectProgressDataGridView, "file");
        }

        private void LoadDataProjectWaiting()
        {
            projectsWaitingResponseDataGridView.DataSource = _proyectoServices.GetRequestProjectsByStatus("esperando aprobacion del cliente");
            ConfigureAutoSize(projectsWaitingResponseDataGridView);
            ConfigureDataGridView();
            HideColumns(projectsWaitingResponseDataGridView, "file", "dateInit", "dateEnd");
        }

        private void LoadDataProjectRefused()
        {
            projectsRefusedDataGridView.DataSource = _proyectoServices.GetRequestProjectsByStatus("Rechazado");
            ConfigureDataGridView();
            ConfigureAutoSize(projectsRefusedDataGridView);
            HideColumns(projectsRefusedDataGridView, "file");
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

        private void SetCustomColumnNames(DataGridView dgv, Dictionary<string, string> columnNames)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (columnNames.ContainsKey(column.Name))
                {
                    column.HeaderText = columnNames[column.Name];
                }
            }
        }


        private void ConfigureDataGridView()
        {
            var columnNamesProjects = new Dictionary<string, string>
            {
                { "idProject", "ID" },
                { "codeProject", "Codigo" },
                { "UserAccount", "Cliente" },
                { "nameProject", "Proyecto" },
                { "descriptionProject", "Descripcion" },
                { "statusProject", "Estado" },
                { "dateRegistration", "Registro" }
            };

            var columnNamesProjecsAndDate = new Dictionary<string, string>
            {
                { "idProject", "ID" },
                { "codeProject", "Codigo" },
                { "UserAccount", "Cliente" },
                { "nameProject", "Proyecto" },
                { "descriptionProject", "Descripcion" },
                { "statusProject", "Estado" },
                { "dateRegistration", "Registro" },
                { "dateInit", "Fecha de Inicio" },
                { "dateEnd" , "Fecha De Entrega" }
            };

            SetCustomColumnNames(requestProjectsDataGridView, columnNamesProjects);
            SetCustomColumnNames(projectsRefusedDataGridView, columnNamesProjecsAndDate);
            SetCustomColumnNames(projectProgressDataGridView, columnNamesProjecsAndDate);
            SetCustomColumnNames(projectsWaitingResponseDataGridView, columnNamesProjects);
        }

        private void requestProjectsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == requestProjectsDataGridView.Columns["SelectPr"].Index)
            {
                try
                {
                    string CodeProject = requestProjectsDataGridView.Rows[e.RowIndex].Cells["codeProject"].Value?.ToString();
                    string NameProject = requestProjectsDataGridView.Rows[e.RowIndex].Cells["nameProject"].Value?.ToString();
                    string Client = requestProjectsDataGridView.Rows[e.RowIndex].Cells["userAccount"].Value?.ToString();
                    string DescriptionProject = requestProjectsDataGridView.Rows[e.RowIndex].Cells["descriptionProject"].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(CodeProject) || string.IsNullOrWhiteSpace(NameProject))
                    {
                        MessageBox.Show("Faltan datos necesarios del proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var assignamentTaskEmployeeForm = _serviceProvider.GetRequiredService<AssignamentTaskEmployeeForm>();


                    SharedData sharedData = new SharedData
                    {
                        Client = Client,
                        codeProyect = CodeProject,
                        nameProject = NameProject,
                        DescriptionProject = DescriptionProject
                    };
                    _entitieViewModel.UpdateEntities(sharedData);

                    var dialogResult = assignamentTaskEmployeeForm.ShowDialog();

                    if (dialogResult != DialogResult.OK)
                    {
                        MessageBox.Show("La operación fue cancelada. No se realizaron cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (!int.TryParse(CodeProject, out int codeProjectInt))
                    {
                        MessageBox.Show("El código del proyecto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Projects dateInit = new Projects
                    {
                        dateInit = DateTime.Now
                    };
                    _proyectoServices.UpdateDates(CodeProject, dateInit.dateInit);

                    StatusProjects statusProjects = new StatusProjects
                    {
                        idStatusProyect = 6
                    };
                    _proyectoServices.StatusProject(CodeProject, statusProjects.idStatusProyect);

                    LoadProyecto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al procesar la operación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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


                SharedData sharedData = new SharedData()
                {
                    codeProyect = CodeProject,
                    nameProject = NameProject,
                    Client = Client,
                    DescriptionProject = DescriptionProject,
                    dateEnd = dateEnd,
                };

                _entitieViewModel.UpdateEntities(sharedData);
                SendProjectForm.ShowDialog();

                LoadProyecto();

            }
        }

        private void projectsRefusedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == projectsRefusedDataGridView.Columns["selectRp"].Index)
            {
                var mensaje = MessageBox.Show("Desea reahacer el proyecto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.Yes)
                {

                    var ConfirmMessage = MessageBox.Show("Esta seguro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(ConfirmMessage == DialogResult.Yes)
                    {
                        string CodeProject = projectsRefusedDataGridView.Rows[e.RowIndex].Cells["codeProject"].Value.ToString();

                        _proyectoServices.StatusProject(CodeProject, 4);


                        var RestartTasksEmployees = _proyectoServices.GetTasksByCode(CodeProject).ToList();

                        foreach (var task in RestartTasksEmployees)
                        {
                            task.idStatusTask = 1;
                        }

                        _proyectoServices.UpdateTasks(RestartTasksEmployees);
                        LoadProyecto();
                    }                   
                }
                
            }
            else if (e.RowIndex >= 0 && projectsRefusedDataGridView.Columns[e.ColumnIndex].Name == "Rechazo")
            {
                try
                {
                    int idProject = Convert.ToInt32(projectsRefusedDataGridView.Rows[e.RowIndex].Cells["idProject"].Value);
                    byte[] content = _proyectoServices.GetFileProjectsRefusedInDB(idProject);

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = "Motivo del rechazo";
                    saveFileDialog.Filter = "Todos los archivos|*.*";

                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        File.WriteAllBytes(filePath, content);

                        MessageBox.Show("La descarga se logro de forma exitosa", "Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la descargar la tarea: " + ex.Message);
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
