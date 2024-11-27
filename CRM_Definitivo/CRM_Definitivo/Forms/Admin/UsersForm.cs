using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PresentationLayer.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class UsersForm : Form
    {
        private IRolServices _rolservices;
        private IUsersServices _usuersservices;
        private readonly IUserReports _userReports;

        public UsersForm(IUsersServices usuarioServices, IRolServices rolServices, IUserReports userReports)
        {
            InitializeComponent();
            _usuersservices = usuarioServices;
            _rolservices = rolServices;
            _userReports = userReports;
            LoadData();

        }

        private void LoadData()
        {
            userDataGridView.DataSource = _usuersservices.GetUsers();
            userDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            userDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            userDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            userDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            userDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            userDataGridView.EnableHeadersVisualStyles = false;

            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            userDataGridView.Columns["idUser"].Visible = false;
            userDataGridView.Columns["Image"].Visible = false;
            userDataGridView.Columns["idRol"].Visible = false;


        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
        }

        private void addUserPictureBox_Click(object sender, EventArgs e)
        {
            AddUsersForm formularioAñadir = new AddUsersForm(_usuersservices, _rolservices);
            //var formularioAñadir = _serviceProvider.GetRequiredService<AddUsersForm>();

            formularioAñadir.AddUsuario += (s, args) =>
            {
                LoadData();
            };

            AbrirFormulario(formularioAñadir);
        }
        private void editUserPictureBox_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario para editar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow filaSeleccionada = userDataGridView.SelectedRows[0];
            User usuarioSeleccionado = new User
            {
                IdUser = Convert.ToInt32(filaSeleccionada.Cells["idUser"].Value),
                idRol = Convert.ToInt32(filaSeleccionada.Cells["idRol"].Value.ToString()),
                UserAccount = filaSeleccionada.Cells["UserAccount"].Value.ToString(),
                NameUser = filaSeleccionada.Cells["nameuser"].Value.ToString(),
                LastName = filaSeleccionada.Cells["lastName"].Value.ToString(),
                Birthdate = Convert.ToDateTime(filaSeleccionada.Cells["birthdate"].Value),
                NumberPhone = filaSeleccionada.Cells["numberPhone"].Value.ToString(),
                passworduser = filaSeleccionada.Cells["passworduser"].Value.ToString(),
                Country = filaSeleccionada.Cells["country"].Value.ToString(),
                City = filaSeleccionada.Cells["city"].Value.ToString(),
                Statususer = filaSeleccionada.Cells["statususer"].Value.ToString(),
                Email = filaSeleccionada.Cells["Email"].Value.ToString()
            };

            AddUsersForm editarUsuarioForm = new AddUsersForm(_usuersservices, _rolservices, usuarioSeleccionado);
            //var editarUsuarioForm = _serviceProvider.GetRequiredService<AddUsersForm>();

            editarUsuarioForm.EditUsuariosHandler += (s, args) => LoadData();

            AbrirFormulario(editarUsuarioForm);
        }

        private void deleteUserPictureBox_Click(object sender, EventArgs e)
        {
            if (userDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var eliminarConfirmar = MessageBox.Show(
                "¿Está seguro de que desea eliminar este usuario?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eliminarConfirmar == DialogResult.Yes)
            {
                int idUser = Convert.ToInt32(userDataGridView.CurrentRow.Cells["idUser"].Value);
                _usuersservices.DeleteUsers(idUser);
                LoadData();
            }
        }

        private void PdfUserPictureBox_Click(object sender, EventArgs e)
        {
            _userReports.GenerateReports();
        }

        private void searchUserIconButton_Click(object sender, EventArgs e)
        {
            if (searchUserTextBox.Text.IsNullOrEmpty())
            {
                LoadData();
            }
            else
            {
                string search = searchUserTextBox.Text;
                var users = _usuersservices.UserSearch(search);

                userDataGridView.DataSource = users;
            }
        }
    }
}
