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
using PresentationLayer.Forms.Admin;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics.Metrics;

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
            
            LoadData();
            _permisosServices = services;
            _provider = serviceProvider;
            usuarioServices = _usuarioServices;
            _rolServices = rolServices;
            proyectoServices = _proyectoServices;
            _userReports = userReports;
            LoadImageProfileUser(AuthUser.idUser);
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_tick;
            timer.Start();

            fechayhora();
        }

        private void LoadImageProfileUser(int idUser)
        {
            var servicesUser = usuarioServices.GetProfileImage(idUser);
            byte[] imagebyte = servicesUser;

            if(imagebyte != null)
            {
                using (var memoryStream = new MemoryStream(imagebyte))
                {
                    pictureBoxImageByIdUser.Image = Image.FromStream(memoryStream);
                }
            }
            else
            {
                pictureBoxImageByIdUser.Image = null;
            }
        }

        private void LoadData()
        {
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

    

        }

        private void fechayhora()
        {
            lblHoraUsuario.Text = DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss");
            labelUserAccount.Text = AuthUser.UserAccount;
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            fechayhora();
        }

        private List<Control> controlesIniciales;

        private void MenuForm_Load(object sender, EventArgs e)
        {

            lblNombreUsuario.Text = AuthUser.UserAccount;

            controlesIniciales = new List<Control>();
            foreach (Control control in contenedor.Controls)
            {
                controlesIniciales.Add(control);
            }

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
            var IconMenuRecordForm = _provider.GetRequiredService<ProjectsHistoric>();
            AbrirFormulario(IconMenuRecordForm);
        }

        private void IconMenusSettingsForm_Click(object sender, EventArgs e)
        {
            var IconMenusSettingsForm = _provider.GetRequiredService<SettingsUserForm>();
            AbrirFormulario(IconMenusSettingsForm);
        }

        private void IconMenuAccountForm_Click(object sender, EventArgs e)
        {
            var IconMenuAccountForm = _provider.GetRequiredService<ProfileUserAccountForm>();
            AbrirFormulario(IconMenuAccountForm);
        }

        private void iconMenuItemMenus_Click(object sender, EventArgs e)
        {
            var iconMenuItemMenus = _provider.GetRequiredService<PermissionForm>();
            AbrirFormulario(iconMenuItemMenus);
        }

        private void RestaurarControlesIniciales()
        {
            this.contenedor.Controls.Clear();

            foreach (Control control in controlesIniciales)
            {
                this.contenedor.Controls.Add(control);
            }
        }

        private void iconMenuItemHome_Click(object sender, EventArgs e)
        {
            RestaurarControlesIniciales();
        }

        private void iconButtonUserAdministrator_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = usuarioServices.GetAdmins();
        }

        private void iconButtonUserEmployee_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = usuarioServices.GetEmployees();
        }

        private void iconButtonUserClients_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = usuarioServices.GetClients();
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int idUser = int.Parse(dataGridViewUsers.CurrentRow.Cells[2].Value.ToString()); 

                panelUsersView.Visible = true;
                var users = usuarioServices.GetByIdUser(idUser);
                var image = usuarioServices.GetProfileImage(idUser);

                byte[] imageBytes = image;

                var SelectedUser = users.Where(u => u.IdUser == idUser).ToList();


                if (SelectedUser.Any())   
                {
                    foreach (var user in SelectedUser)
                    {
                        DateTime fechaActual = DateTime.Now; 
                        int edad = fechaActual.Year - user.Birthdate.Year; 

                        if (fechaActual.Month < user.Birthdate.Month ||
                            (fechaActual.Month == user.Birthdate.Month && fechaActual.Day < user.Birthdate.Day))
                        {
                            edad--;
                        }

                        labelByUser.Text = user.UserAccount;
                        labelByAgeUser.Text = Convert.ToString(edad);
                        labelCity.Text = user.City;
                        labelnameUser.Text = user.NameUser;
                        labelEmail.Text = user.Email;
                        labelNumberPhone.Text = user.NumberPhone;
                        labelRegistration.Text = Convert.ToString(user.DateRegistration);
                        labelCountryByUser.Text = user.Country;

                        if(imageBytes != null && imageBytes.Length > 0)
                        {
                            using(var memoryStream = new MemoryStream(imageBytes))
                            {
                                pictureBoxSelectedUser.Image = Image.FromStream(memoryStream);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo moestrar la imagen");
                        }
                    }                   
                }
                else
                {
                    MessageBox.Show("usuario no econtrado");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado a un usuario ");
            }
        }
    }

}
