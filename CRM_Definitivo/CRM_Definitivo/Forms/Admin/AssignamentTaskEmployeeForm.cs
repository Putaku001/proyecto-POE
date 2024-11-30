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
    public partial class AssignamentTaskEmployeeForm : Form
    {

        public string CodeProject { get; set; }
        public string NameProject { get; set; }
        public string DescriptionProject { get; set; }
        public string Client { get; set; }
        private readonly IProjectsServices _proyectsServices;
        private readonly IUsersServices _usersServices;
        public AssignamentTaskEmployeeForm(IProjectsServices proyectsServices, IUsersServices usersServices)
        {
            InitializeComponent();
            _proyectsServices = proyectsServices;
            _usersServices = usersServices;
            LoadEmployee();
        }

        public void LoadEmployee()
        {
            employeeComboBox.DataSource = _usersServices.GetEmployees();
            employeeComboBox.DisplayMember = "UserAccount";
            employeeComboBox.ValueMember = "idEmployee";
        }

        private void AssignamentTaskEmployeeForm_Load(object sender, EventArgs e)
        {
            assignamentTasksDataGridView.DataSource = _proyectsServices.GetTaskEmployees();
            assignamentTasksDataGridView.Columns["idStatusTask"].Visible = false;

            clientUserLabel.Text = Client;
            codeProjectLabel.Text = CodeProject;
            nameProjectLabel.Text = NameProject;
            descriptionTextBox.Text = DescriptionProject;
        }

        private void iconAssignamentTaskButton_Click(object sender, EventArgs e)
        {
            TaskEmployees AssignamentTaskEmployees = new TaskEmployees();
            AssignamentTaskEmployees.codeProject = codeProjectLabel.Text;
            AssignamentTaskEmployees.nameTask = taskTextBox.Text;
            AssignamentTaskEmployees.descriptionTask = descriptionTextBox.Text;
            AssignamentTaskEmployees.idEmployee = Convert.ToInt32(employeeComboBox.SelectedValue);
            AssignamentTaskEmployees.idStatusTask = 1;
            AssignamentTaskEmployees.dateEnd = timeEndDateTimePicker.Value;

            var dateEnd = timeEndDateTimePicker.Value;
            _proyectsServices.UpdateDates(CodeProject, dateEnd);

            _proyectsServices.AddTasksEmployees(AssignamentTaskEmployees);
            MessageBox.Show("La tarea se ha agregado exitosamente!");
            LoadEmployee();
        }
    }
}
