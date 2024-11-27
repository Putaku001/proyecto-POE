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
    public partial class RecordProjectsEmployeeForm : Form
    {
        private readonly IProyectsServices _proyectsServices;
        private readonly IUsersServices _usersServices;
        int idUser;
        public RecordProjectsEmployeeForm(IProyectsServices proyectsServices, IUsersServices usersServices)
        {
            InitializeComponent();
            _proyectsServices = proyectsServices;
            _usersServices = usersServices;
            idUser = CaptureData.idUser;
        }

        private void RecordProjectsEmployeeForm_Load(object sender, EventArgs e)
        {
            //En proceso de trabajo
            recordsProjectdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int idEmployee = Convert.ToInt32(_usersServices.GetByIdEmployees(idUser).Select(id => id.idEmployee).FirstOrDefault());
            int idClient = Convert.ToInt32(_usersServices.GetClients().Where(id => id.idUser == idUser).Select(client => client.idCliente).FirstOrDefault());

            recordsProjectdataGridView.DataSource = recordsProjectdataGridView.DataSource = _proyectsServices.GetByIdTaskEmployee(idEmployee).ToList();
            switch (CaptureData.IdRol)
            {
                case 1:
                    recordsProjectdataGridView.DataSource = _proyectsServices.GetRequestProjects().ToList();
                    break;
                //case 2:
                //    recordsProjectdataGridView.DataSource = _proyectsServices.GetByIdTaskEmployee(idEmployee).ToList();
                //    break;
                case 4:
                    recordsProjectdataGridView.DataSource = _proyectsServices.GetProjectsByIdClient(idClient).ToList();
                    break;
            }
        }
    }
}
