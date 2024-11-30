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
    public partial class RecordProjectsForm : Form
    {
        private readonly IProyectsServices _proyectsServices;
        private readonly IProjectsClientServices _projectsClientServices;
        private readonly IProjectsEmnployeesServices _projectsEmnployeesServices;
        private readonly IUsersServices _usersServices;
        int idUser;
        public RecordProjectsForm(IProyectsServices proyectsServices, IUsersServices usersServices, IProjectsClientServices projectsClientServices, IProjectsEmnployeesServices projectsEmnployeesServices)
        {
            InitializeComponent();
            _proyectsServices = proyectsServices;
            _usersServices = usersServices;
            _projectsClientServices = projectsClientServices;
            _projectsEmnployeesServices = projectsEmnployeesServices;
            idUser = CaptureData.idUser;
        }

        private void RecordProjectsEmployeeForm_Load(object sender, EventArgs e)
        {
            //En proceso de trabajo
            ConfigureDataGridView(); 
            int idEmployee = Convert.ToInt32(_usersServices.GetByIdEmployees(idUser).Select(id => id.idEmployee).FirstOrDefault());
            int idClient = Convert.ToInt32(_usersServices.GetClients().Where(id => id.idUser == idUser).Select(client => client.idCliente).FirstOrDefault());

            recordsProjectdataGridView.DataSource = recordsProjectdataGridView.DataSource = _proyectsServices.GetByIdTaskEmployee(idEmployee).ToList();
            switch (CaptureData.IdRol)
            {
                case 1:
                    LoadProjectsForAdmin();
                    break;
                case 2:
                    LoadProjectsForEmployee(idEmployee);
                    break;
                case 4:
                    LoadProjectsForClient(idClient);
                    break;
                default:
                    MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ConfigureDataGridView()
        {
            recordsProjectdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadProjectsForAdmin()
        {
            recordsProjectdataGridView.DataSource = _proyectsServices.GetRequestProjectsByStatus("Terminado").ToList();
            HideColumns("file");
        }

        //--Falta completar
        private void LoadProjectsForEmployee(int idEmployee)
        {
            recordsProjectdataGridView.DataSource = _projectsEmnployeesServices.GetTasksByEmployees(idEmployee).ToList();
            HideColumns("idEmployee", "idStatusTask", "statusTask", "fileTask", "dateEnd");
        }

        //--
        //Completar
        private void LoadProjectsForClient(int idClient)
        {
            int idStatusProject = 9;
            recordsProjectdataGridView.DataSource = _projectsClientServices.GetsProjectsByIdClient(idClient, idStatusProject).ToList();
            HideColumns("idClient", "file");
        }
        //--

        private void HideColumns(params string[] columnNames)
        {
            foreach (string columnName in columnNames)
            {
                if (recordsProjectdataGridView.Columns[columnName] != null)
                {
                    recordsProjectdataGridView.Columns[columnName].Visible = false;
                }
            }
        }
    }
}
