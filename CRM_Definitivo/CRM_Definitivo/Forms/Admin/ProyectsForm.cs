using BusinessLayer.Services.InterfacesServices;
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
    public partial class ProyectsForm : Form
    {
        private IListProyectsServices _proyectoServices;
        public ProyectsForm(IListProyectsServices proyectoServices)
        {
            InitializeComponent();
            _proyectoServices = proyectoServices;
            LoadListaProyecto();

        }

        private void LoadData()
        {

        }

        private void LoadListaProyecto()
        {
            dgvListaProyectos.DataSource = _proyectoServices.GetLisProyect();
            dgvListaProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvListaProyectos.Columns["titleName"].HeaderText = "Proyecto";
            //dgvListaProyectos.Columns["IdCategoriaProyecto"].HeaderText = "Categoria";
            //dgvListaProyectos.Columns["FechaRegistro"].HeaderText = "Registro";
        }

        private void tpListaProyectos_Click(object sender, EventArgs e)
        {

        }
    }
}
