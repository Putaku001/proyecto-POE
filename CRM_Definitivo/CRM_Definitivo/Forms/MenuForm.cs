using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using FontAwesome.Sharp;
using PresentationLayer.Forms.Cliente;
using PresentationLayer.Forms.Empleados;
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
using CRM_Definitivo;

namespace PresentationLayer.Forms
{
    public partial class MenuForm : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        private readonly IPermisoServices _permisosServices;
        private readonly IProyectsServices proyectoServices;
        private readonly IUsersServices usuarioServices;
        private readonly IRolServices _rolServices;
        private readonly IServiceProvider _provider;
        private readonly IUserReports _userReports;
        private System.Windows.Forms.Timer timer;

        public MenuForm(IPermisoServices services, IServiceProvider serviceProvider, IUsersServices _usuarioServices, IRolServices rolServices, IProyectsServices _proyectoServices, IUserReports userReports)
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
            loadPermission();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_tick;
            timer.Start();

            Dateandtime();

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath pathSelectedUser = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, idUserPictureBox.Width, idUserPictureBox.Height);
            pathSelectedUser.AddEllipse(0, 0, selectedUserPictureBox.Width, selectedUserPictureBox.Height);

            idUserPictureBox.Region = new Region(path);
            selectedUserPictureBox.Region = new Region(pathSelectedUser);

        }

        public void loadPermission()
        {
            menuGroupBox.Visible = false;

            if (CaptureData.IdRol == 1)
            {
                menuGroupBox.Visible = true;
            }
            else if (CaptureData.IdRol == 2)
            {
                menuGroupBox.Controls.Clear();
                var HomeUserEmployeeForm = _provider.GetRequiredService<HomeUserEmployeeForm>();
                AbrirFormulario(HomeUserEmployeeForm);
            }
            else if (CaptureData.IdRol == 4)
            {
                menuGroupBox.Controls.Clear();
                var HomeUserClientForm = _provider.GetRequiredService<HomeUserClientForm>();
                AbrirFormulario(HomeUserClientForm);
            }
        }



        private void LoadImageProfileUser(int idUser)
        {
            var servicesUser = usuarioServices.GetProfileImage(idUser);
            byte[] imagebyte = servicesUser;

            if (imagebyte != null)
            {
                using (var memoryStream = new MemoryStream(imagebyte))
                {
                    idUserPictureBox.Image = Image.FromStream(memoryStream);

                }
            }
            else
            {
                idUserPictureBox.Image = null;
            }
        }



        private void LoadData()
        {
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Dateandtime()
        {
            timeUserLabel.Text = DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss");
            userAccountLabel.Text = AuthUser.UserAccount;
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            Dateandtime();
        }

        private List<Control> controlesIniciales;

        private void MenuForm_Load(object sender, EventArgs e)
        {

            nameUserIdLabel.Text = AuthUser.UserAccount;

            controlesIniciales = new List<Control>();
            foreach (Control control in containerPanel.Controls)
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

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void AbrirFormulario(Form formulario)
        {

            if (this.containerPanel.Controls.Count > 0)
                this.containerPanel.Controls.RemoveAt(0);

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            this.containerPanel.Controls.Add(formulario);
            this.containerPanel.Tag = formulario;

            formulario.Show();
        }
        private void closedPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void closedPictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(closedPictureBox, "Cerrar Aplicacion");
        }

        private void minimizarPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizarPictureBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(minimizarPictureBox, "Minimizar aplicacion");
        }

        private void iconMenuUsersForm_Click(object sender, EventArgs e)
        {
            var IconMenuUsersForm = _provider.GetRequiredService<UsersForm>();
            AbrirFormulario(IconMenuUsersForm);
        }

        private void iconMenuProyectsForm_Click_1(object sender, EventArgs e)
        {
            var IconMenuProyectsForm = _provider.GetRequiredService<ProjectsForm>();
            AbrirFormulario(IconMenuProyectsForm);
        }
        private void iconMenuRecordForm_Click(object sender, EventArgs e)
        {
            var iconMenuRecordForm = _provider.GetRequiredService<RecordProjectsEmployeeForm>();
            AbrirFormulario(iconMenuRecordForm);
        }
        private void iconMenusSettingsForm_Click(object sender, EventArgs e)
        {

        }
        private void iconMenuAccountForm_Click(object sender, EventArgs e)
        {
            var IconMenuAccountForm = _provider.GetRequiredService<ProfileUserAccountForm>();
            AbrirFormulario(IconMenuAccountForm);
        }


        private void iconMenuItemMenus_Click(object sender, EventArgs e)
        {
            var iconMenuItemMenus = _provider.GetRequiredService<PermissionForm>();
            AbrirFormulario(iconMenuItemMenus);
        }

        private void RestoreInitialControls()
        {
            this.containerPanel.Controls.Clear();

            foreach (Control control in controlesIniciales)
            {
                this.containerPanel.Controls.Add(control);
            }
        }

        private void iconMenuItemHome_Click(object sender, EventArgs e)
        {
            RestoreInitialControls();
        }

        private void administratorUserButton_Click(object sender, EventArgs e)
        {
            userDataGridView.DataSource = usuarioServices.GetAdmins();
            userDataGridView.Columns["idUser"].Visible = false;
            assignedProjectPanel.Visible = false;
            requestProjectPanel.Visible = false;
        }
        private void employeeUserButton_Click(object sender, EventArgs e)
        {
            userDataGridView.DataSource = usuarioServices.GetEmployees();
            userDataGridView.Columns["idUser"].Visible = false;
            requestProjectPanel.Visible = false;
            assignedProjectPanel.Visible = true;
        }

        private void clientUserButton_Click(object sender, EventArgs e)
        {
            userDataGridView.DataSource = usuarioServices.GetClients();
            userDataGridView.Columns["idUser"].Visible = false;
            assignedProjectPanel.Visible = false;
            requestProjectPanel.Visible = true;
        }

        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idUser = int.Parse(userDataGridView.CurrentRow.Cells[2].Value.ToString());



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

                        idUserLabel.Text = user.UserAccount;
                        ageUserLabel.Text = Convert.ToString(edad);
                        cityLabel.Text = user.City;
                        nameUserLabel.Text = user.NameUser;
                        emailIdUserLabel.Text = user.Email;
                        numberPhoneLabel.Text = user.NumberPhone;
                        registrationLabel.Text = Convert.ToString(user.DateRegistration);
                        countryUserLabel.Text = user.Country;

                        if (assignedProjectPanel.Visible == true)
                        {
                            var GetidEmployee = usuarioServices.GetEmployees().Where(id => id.idUser == idUser).Select(e => e.idEmployee).FirstOrDefault();
                            assignedProjectListBox.DataSource = proyectoServices.GetTasksByEmployees(GetidEmployee).ToList();
                        }
                        else if (requestProjectPanel.Visible == true)
                        {
                            var GetIdClient = Convert.ToInt32(usuarioServices.GetClients().Where(id => id.idUser == idUser).Select(id => id.idCliente).FirstOrDefault());
                            requestProjectListBox.DataSource = proyectoServices.GetRequestProyectsByIdClient(GetIdClient).ToList();
                        }

                        if (imageBytes != null && imageBytes.Length > 0)
                        {
                            using (var memoryStream = new MemoryStream(imageBytes))
                            {
                                selectedUserPictureBox.Image = Image.FromStream(memoryStream);
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
        private void selectedUserPictureBox_Click(object sender, EventArgs e)
        {
            var ImageViewerForm = _provider.GetRequiredService<ImageViewerForm>();
            ImageViewerForm.pictureBoxView.Image = selectedUserPictureBox.Image;

            ImageViewerForm.StartPosition = FormStartPosition.CenterScreen;
            ImageViewerForm.ShowDialog();
        }


        private void iconMenuItemProjectsEmployee_Click(object sender, EventArgs e)
        {
            var iconMenuItemProjectsEmployee = _provider.GetRequiredService<ProjectEmployeeForm>();
            AbrirFormulario(iconMenuItemProjectsEmployee);
        }

        private void iconMenuItemRequestClientProjects_Click(object sender, EventArgs e)
        {
            var iconMenuItemRequest = _provider.GetRequiredService<RequestClientForm>();
            AbrirFormulario(iconMenuItemRequest);
        }
    }

}
