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
            panelInformationProject.Visible = false;
        }

        public void LoadData()
        {
            //var idEmployee = _usersService.GetEmployees()
            //    .Where(u => u.idUser == AuthUser.idUser)
            //    .Select(e => e.idEmployee)
            //    .FirstOrDefault();

            //if (idEmployee > 0)
            //{
            //    var employeeProjects = _listProyectsServices.GetByIdProjectsEmployee(idEmployee);

            //    var GetProjectById = employeeProjects.Where(e => e.idEmployee == idEmployee).Select(e => e.idProyect).FirstOrDefault();

            //    var employeeTask = _listProyectsServices.GetByIdTaskEmployee(GetProjectById);
            //    dataGridViewProjectsEmployee.DataSource = employeeTask;
            //    dataGridViewProjectsEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //    dataGridViewProjectsEmployee.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            //    dataGridViewProjectsEmployee.DefaultCellStyle.ForeColor = Color.Black;
            //    dataGridViewProjectsEmployee.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            //    dataGridViewProjectsEmployee.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            //    dataGridViewProjectsEmployee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //    dataGridViewProjectsEmployee.EnableHeadersVisualStyles = false;
            //}
            //else
            //{
            //    MessageBox.Show("No se encontró el empleado para el usuario autmenticado.");
            //}

        }



        private void dataGridViewProjectsEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var idEmployee = _usersService.GetEmployees()
            //    .Where(u => u.idUser == AuthUser.idUser)
            //    .Select(e => e.idEmployee)
            //    .FirstOrDefault();

            //int idTask = Convert.ToInt32(dataGridViewProjectsEmployee.CurrentRow.Cells["idTask"].Value);
            //var idem = _listProyectsServices.GetByIdTaskEmployee(idEmployee);
            //var Noc = idem.Where(e => e.idTask == idTask).Select(t => t.idTask).FirstOrDefault();

            //panelInformationProject.Visible = true;

            //var projects = _listProyectsServices.GetByIdTaskEmployee(Noc);

            //var selectedTask = projects.FirstOrDefault(p => p.idTask == Noc);

            //if (selectedTask != null)
            //{
            //    labelProjectName.Text = selectedTask.titleName;
            //    labelNameTask.Text = selectedTask.nameTask;
            //    textBoxDescriptionTask.Text = selectedTask.descriptionTask;
            //}
            //else
            //{
            //    MessageBox.Show("No se encontró el proyecto seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void linkLabelFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //OpenFileDialog openFileEmployee = new OpenFileDialog();
            //openFileEmployee.Filter = "Todos los archivos (*.*) | *.*";

            //if (openFileEmployee.ShowDialog() == DialogResult.OK)
            //{
            //    string filePath = openFileEmployee.FileName;


            //    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            //    {
            //        using (MemoryStream ms = new MemoryStream())
            //        {
            //            fs.CopyTo(ms);
            //            fileByte = ms.ToArray();
            //            labelLinkFile.Text = filePath;
            //        }
            //    }
            //}
        }

        private void iconButtonSubmit_Click(object sender, EventArgs e)
        {
            //int idTask = int.Parse(dataGridViewProjectsEmployee.CurrentRow.Cells[1].Value.ToString());
            ////int updateStatus = Convert.ToInt32(comboBoxStatus.SelectedValue);
            //byte[] updateFile = fileByte;


            ////_listProyectsServices.UpdateProjectsEmployee(idProject, updateStatus, updateFile);
            //_listProyectsServices.UpdateTaskEmployee(idTask, updateFile);


            //MessageBox.Show("Se ha enviado correctamente", "Enviado correctamente", MessageBoxButtons.OK);
            //LoadData();
        }
    }
}
