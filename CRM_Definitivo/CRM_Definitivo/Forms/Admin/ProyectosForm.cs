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
    public partial class ProyectosForm : Form
    {
        private IListaProyectoServices _proyectoServices;
        public ProyectosForm(IListaProyectoServices proyectoServices)
        {
            InitializeComponent();
            _proyectoServices = proyectoServices;
            LoadListaProyecto();

        }

        private void LoadListaProyecto()
        {
            dgvListaProyectos.DataSource = _proyectoServices.GetListaProyecto();
            dgvListaProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaProyectos.Columns["NombreProyecto"].HeaderText = "Proyecto";
            dgvListaProyectos.Columns["DescripcionProyecto"].HeaderText = "Descripcion";
            dgvListaProyectos.Columns["IdCategoriaProyecto"].HeaderText = "Categoria";
            dgvListaProyectos.Columns["FechaRegistro"].HeaderText = "Registro";
        }

        private void tpListaProyectos_Click(object sender, EventArgs e)
        {

        }
    }
}
