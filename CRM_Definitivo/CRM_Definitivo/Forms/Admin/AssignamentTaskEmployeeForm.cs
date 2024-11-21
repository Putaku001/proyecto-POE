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
        private readonly IListProyectsServices _proyectsServices;
        private readonly IUsersServices _usersServices;
        public AssignamentTaskEmployeeForm(IListProyectsServices proyectsServices, IUsersServices usersServices)
        {
            InitializeComponent();
            _proyectsServices = proyectsServices;
            _usersServices = usersServices;
            LoadEmployee();
        }

        public void LoadEmployee()
        {
            comboBoxEmployee.DataSource = _usersServices.GetEmployees();
            comboBoxEmployee.DisplayMember = "UserAccount";
            comboBoxEmployee.ValueMember = "idEmployee";
        }

        private void AssignamentTaskEmployeeForm_Load(object sender, EventArgs e)
        {
            dataGridViewAssignamentTasks.DataSource = _proyectsServices.GetTaskEmployees();
            dataGridViewAssignamentTasks.Columns["idStatusTask"].Visible = false;

            labelUserAccount.Text = Client;
            labelCodeProject.Text = CodeProject;
            labelNameProject.Text = NameProject;
            textBoxDescription.Text = DescriptionProject;
        }

        private void iconButtonAssignamentTask_Click(object sender, EventArgs e)
        {
            TaskEmployees AssignamentTaskEmployees = new TaskEmployees();
            AssignamentTaskEmployees.codeProject = labelCodeProject.Text;
            AssignamentTaskEmployees.nameTask = textBoxTask.Text;
            AssignamentTaskEmployees.descriptionTask = textBoxDescription.Text;
            AssignamentTaskEmployees.idEmployee = Convert.ToInt32(comboBoxEmployee.SelectedValue);
            AssignamentTaskEmployees.idStatusTask = 1;
            AssignamentTaskEmployees.dateEnd = dateTimePickerEnd.Value;

            var dateEnd = dateTimePickerEnd.Value;
            _proyectsServices.DateEnd(CodeProject, dateEnd);

            _proyectsServices.AddTasksEmployees(AssignamentTaskEmployees);
            MessageBox.Show("La tarea se ha agregado exitosamente!");
            LoadEmployee();



        }
    }
}
