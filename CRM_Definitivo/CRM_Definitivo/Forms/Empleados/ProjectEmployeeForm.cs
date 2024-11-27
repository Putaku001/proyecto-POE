using BusinessLayer.Services;
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

namespace PresentationLayer.Forms.Empleados
{
    public partial class ProjectEmployeeForm : Form
    {
        private readonly IUsersServices _usersService;
        private readonly IProyectsServices _listProyectsServices;
        byte[] fileByte;

        public ProjectEmployeeForm(IUsersServices usersServices, IProyectsServices listProyectsServices)
        {
            InitializeComponent();
            _usersService = usersServices;
            _listProyectsServices = listProyectsServices;
            LoadData();
            informationProjectPanel.Visible = false;
        }

        public void LoadData()
        {
            taskStatusComboBox.DataSource = _listProyectsServices.GetStatusTaskEmployees();
            taskStatusComboBox.DisplayMember = "statusTask";
            taskStatusComboBox.ValueMember = "idStatusTask";
            taskStatusComboBox.SelectedIndex = 1;
            var idEmployee = _usersService.GetEmployees()
                .Where(u => u.idUser == CaptureData.idUser)
                .Select(e => e.idEmployee)
                .FirstOrDefault();

            if (idEmployee > 0)
            {
                projectsEmployeeDataGridView.DataSource = _listProyectsServices.GetsProjects(idEmployee);
                projectsEmployeeDataGridView.Columns["fileTask"].Visible = false;
                projectsEmployeeDataGridView.Columns["idStatusTask"].Visible = false;
                projectsEmployeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                projectsEmployeeDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                projectsEmployeeDataGridView.DefaultCellStyle.ForeColor = Color.Black;
                projectsEmployeeDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                projectsEmployeeDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
                projectsEmployeeDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                projectsEmployeeDataGridView.EnableHeadersVisualStyles = false;
            }
            else
            {
                MessageBox.Show("No se encontró el empleado para el usuario autmenticado.");
            }

        }

        private void projectsEmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                informationProjectPanel.Visible = true;
                var idEmployee = _usersService.GetEmployees()
                .Where(u => u.idUser == CaptureData.idUser)
                .Select(e => e.idEmployee)
                .FirstOrDefault();

                int idTask = Convert.ToInt32(projectsEmployeeDataGridView.CurrentRow.Cells["idTask"].Value);
                var idem = _listProyectsServices.GetByIdTaskEmployee(idEmployee);
                var selectedTask = idem.FirstOrDefault(id => id.idTask == idTask);
                if (selectedTask != null)
                {
                    descriptionTaskTextBox.Text = selectedTask.descriptionTask;
                    nameTaskLabel.Text = selectedTask.nameTask;
                    projectNameLabel.Text = selectedTask.codeProject;
                }
                else
                {
                    MessageBox.Show("No se encontró el proyecto seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void linkFileLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileEmployee = new OpenFileDialog();
            openFileEmployee.Filter = "Todos los archivos (*.*) | *.*";

            if (openFileEmployee.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileEmployee.FileName;


                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        fileByte = ms.ToArray();
                        labelLinkFile.Text = filePath;
                    }
                }
            }
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            int idTask = int.Parse(projectsEmployeeDataGridView.CurrentRow.Cells[1].Value.ToString());
            int updateStatus = Convert.ToInt32(taskStatusComboBox.SelectedValue);
            byte[] updateFile = fileByte;

            _listProyectsServices.UpdateTaskEmployee(idTask, updateFile, updateStatus);


            MessageBox.Show("Se ha enviado correctamente", "Enviado correctamente", MessageBoxButtons.OK);
            LoadData();
        }
    }
}
