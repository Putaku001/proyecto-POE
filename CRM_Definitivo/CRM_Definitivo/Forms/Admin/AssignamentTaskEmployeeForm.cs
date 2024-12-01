﻿using BusinessLayer.Services.InterfacesServices;
using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using CommonLayer.Entities.Projects;
using CommonLayer.Entities.ViewModel;
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
        private readonly IProjectsServices _proyectsServices;
        private readonly IEmployeeServices _usersServices;
        private readonly EntitieViewModel _employeeViewModel;
        public AssignamentTaskEmployeeForm(IProjectsServices proyectsServices, IEmployeeServices usersServices, EntitieViewModel entitieViewModel)
        {
            InitializeComponent();
            _proyectsServices = proyectsServices;
            _usersServices = usersServices;
            _employeeViewModel = entitieViewModel;
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
            ConfigureData();
            assignamentTasksDataGridView.Columns["idStatusTask"].Visible = false;
            assignamentTasksDataGridView.Columns["fileTask"].Visible = false;

            clientUserLabel.Text = _employeeViewModel.EntitieNow.Client;
            codeProjectLabel.Text = _employeeViewModel.EntitieNow.codeProyect;
            nameProjectLabel.Text = _employeeViewModel.EntitieNow.nameProject;
            descriptionTextBox.Text = _employeeViewModel.EntitieNow.DescriptionProject;
        }

        private void SetNamesColumns(DataGridView dataGridView, Dictionary<String, string> columNames)
        {
            foreach(DataGridViewColumn column in dataGridView.Columns)
            {
                if (columNames.ContainsKey(column.Name))
                {
                    column.HeaderText = columNames[column.Name];
                }
            }
        }

        private void ConfigureData()
        {
            var setNamesDGV = new Dictionary<string, string>()
            {
                { "idTask" , "ID" },
                { "idEmployee" , "IdEmpleado" },
                { "codeProject" , "Codigo" },
                { "nameTask" , "Tarea" },
                { "descriptionTask" , "Descripcion" },
                { "statusTask" , "Estado" },
                { "dateEnd" , "Fecha de entrega" },
            };

            SetNamesColumns(assignamentTasksDataGridView, setNamesDGV);
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
            _proyectsServices.UpdateDates(_employeeViewModel.EntitieNow.codeProyect, dateEnd);

            _proyectsServices.AddTasksEmployees(AssignamentTaskEmployees);
            MessageBox.Show("La tarea se ha agregado exitosamente!");
            LoadEmployee();
        }
    }
}
