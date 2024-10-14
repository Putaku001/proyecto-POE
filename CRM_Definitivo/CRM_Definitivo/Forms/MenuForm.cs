using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using FontAwesome.Sharp;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class MenuForm : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        private Usuarios usuarioactual;
        private IListaProyectoServices proyectoServices;
        private IUsuarioServices usuarioServices;
        private IRolServices _rolServices;
        private System.Windows.Forms.Timer timer;
        public MenuForm(Usuarios ousuarios, IUsuarioServices _usuarioServices, IRolServices rolServices, IListaProyectoServices _proyectoServices)
        {

            InitializeComponent();
            this.usuarioactual = ousuarios;
            usuarioServices = _usuarioServices;
            _rolServices = rolServices;
            proyectoServices = _proyectoServices;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_tick;
            timer.Start();

            fechayhora();
        }

        private void fechayhora()
        {
            lblHoraUsuario.Text = DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss");
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            fechayhora();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = usuarioactual.Nombre;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormulario(Form formulario)
        {

            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            this.contenedor.Controls.Add(formulario);
            this.contenedor.Tag = formulario;

            formulario.Show();
        }

        private void btnUsuariosForm_Click(object sender, EventArgs e)
        {
            UsuariosForm formulario = new UsuariosForm(usuarioServices, _rolServices); 
            AbrirFormulario(formulario);
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbEliminar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbEliminar, "Cerrar Aplicacion");
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMinimizar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbMinimizar, "Minimizar aplicacion");
        }

        private void btnProyectosForm_Click(object sender, EventArgs e)
        {
            ProyectosForm proyectosForm = new ProyectosForm(proyectoServices);
            AbrirFormulario(proyectosForm);
        }
    }

}
