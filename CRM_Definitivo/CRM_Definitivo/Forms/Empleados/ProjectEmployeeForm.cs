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
        private readonly IListProyectsServices _listProyectsServices;
        //
        byte[] fileByte;

        public ProjectEmployeeForm(IUsersServices usersServices, IListProyectsServices listProyectsServices)
        {
            InitializeComponent();
            _usersService = usersServices;
            _listProyectsServices = listProyectsServices;
            LoadData();
            LoadCboStatus();
            panelInformationProject.Visible = false;
        }

        private void LoadCboStatus()
        {
            comboBoxStatus.DataSource = _listProyectsServices.GetStatusProjects();
            comboBoxStatus.DisplayMember = "statusproyect";
            comboBoxStatus.ValueMember = "idStatusProyect";
        }

        public void LoadData()
        {
            var idEmployee = _usersService.GetEmployees()
                .Where(u => u.idUser == AuthUser.idUser)
                .Select(e => e.idEmployee)
                .FirstOrDefault();

            if (idEmployee > 0)
            {
                var employeeProjects = _listProyectsServices.GetByIdProjectsEmployee(idEmployee);
                dataGridViewProjectsEmployee.DataSource = employeeProjects;
                dataGridViewProjectsEmployee.Columns["file"].Visible = false;
                dataGridViewProjectsEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewProjectsEmployee.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewProjectsEmployee.DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewProjectsEmployee.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dataGridViewProjectsEmployee.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
                dataGridViewProjectsEmployee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewProjectsEmployee.EnableHeadersVisualStyles = false;
            }
            else
            {
                MessageBox.Show("No se encontró el empleado para el usuario autmenticado.");
            }

        }



        private void dataGridViewProjectsEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProject = int.Parse(dataGridViewProjectsEmployee.CurrentRow.Cells[1].Value.ToString());

            panelInformationProject.Visible = true;

            var projects = _listProyectsServices.GetByIdProjects(idProject);

            var selectedProject = projects.FirstOrDefault(p => p.idProyect == idProject);

            if (selectedProject != null)
            {
                labelProjectName.Text = selectedProject.titleName;
                labelNameClient.Text = Convert.ToString(selectedProject.idClient);
                textBoxDescription.Text = selectedProject.description;
                comboBoxStatus.SelectedValue = selectedProject.idStatusProyect;
            }
            else
            {
                MessageBox.Show("No se encontró el proyecto seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabelFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void iconButtonSubmit_Click(object sender, EventArgs e)
        {
            int idProject = int.Parse(dataGridViewProjectsEmployee.CurrentRow.Cells[1].Value.ToString());
            int updateStatus = Convert.ToInt32(comboBoxStatus.SelectedValue);
            byte[] updateFile = fileByte;


            _listProyectsServices.UpdateProjectsEmployee(idProject, updateStatus, updateFile);
        }
    }
}
