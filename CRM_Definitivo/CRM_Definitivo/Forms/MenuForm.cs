using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using FontAwesome.Sharp;
using PresentationLayer.Forms.Cliente;
using Microsoft.VisualBasic;
using PresentationLayer.Reports;
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
using CommonLayer.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace PresentationLayer.Forms
{
    public partial class MenuForm : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        private readonly IPermisoServices _permisosServices;
        private IListProyectsServices proyectoServices;
        private IUsersServices usuarioServices;
        private IRolServices _rolServices;
        private readonly IServiceProvider _provider;
        private readonly IUserReports _userReports;
        private System.Windows.Forms.Timer timer;
        public MenuForm(IPermisoServices services, IServiceProvider serviceProvider, IUsersServices _usuarioServices, IRolServices rolServices, IListProyectsServices _proyectoServices, IUserReports userReports)
        {

            InitializeComponent();
            _permisosServices = services;
            _provider = serviceProvider;
            usuarioServices = _usuarioServices;
            _rolServices = rolServices;
            proyectoServices = _proyectoServices;
            _userReports = userReports;
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
            lblNombreUsuario.Text = AuthUser.UserAccount;

            var permisions = _permisosServices.GetPermisos(AuthUser.idUser);

            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool econtrado = permisions.Any(m => m.NameForm == iconMenu.Name);

                if (econtrado == false)
                {

                    iconMenu.Visible = false;
                }
            }
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
            UsersForm formulario = new UsersForm(usuarioServices, _rolServices, _userReports);
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

        private void IconMenuUsersForm_Click(object sender, EventArgs e)
        {
            var IconMenuUsersForm = _provider.GetRequiredService<UsersForm>();
            AbrirFormulario(IconMenuUsersForm);
        }

        private void IconMenuProyectsForm_Click(object sender, EventArgs e)
        {
            var IconMenuProyectsForm = _provider.GetRequiredService<ProyectsForm>();
            AbrirFormulario(IconMenuProyectsForm);
        }

        private void IconMenuRecordForm_Click(object sender, EventArgs e)
        {

        }

        private void IconMenusSettingsForm_Click(object sender, EventArgs e)
        {

        }

        private void IconMenuAccountForm_Click(object sender, EventArgs e)
        {
            var IconMenuAccountForm = _provider.GetRequiredService<ProfileUserAccountForm>();
            AbrirFormulario(IconMenuAccountForm);
        }
    }

}
