﻿using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;
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
        public UsersForm(IUsersServices usuarioServices, IRolServices rolServices)
        {
            InitializeComponent();
            _usuersservices = usuarioServices;
            _rolservices = rolServices;
            LoadData();

        }

        private void LoadData()
        {
            dgvUsuarios.DataSource = _usuersservices.GetUsers();

            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvUsuarios.Columns["idUser"].Visible = false;

        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
        }

        private void pbAñadirUsuario_Click(object sender, EventArgs e)
        {
            AddUsersForm formularioAñadir = new AddUsersForm(_usuersservices, _rolservices);

            formularioAñadir.AddUsuario += (s, args) =>
            {
                LoadData(); 
            };

            AbrirFormulario(formularioAñadir);

        }

        private void pbEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario para editar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];
            User usuarioSeleccionado = new User
            {
                IdUser = Convert.ToInt32(filaSeleccionada.Cells["idUser"].Value),
                NameUser = filaSeleccionada.Cells["nameuser"].Value.ToString(),
                LastName = filaSeleccionada.Cells["lastName"].Value.ToString(),
                Birthdate = Convert.ToDateTime(filaSeleccionada.Cells["birthdate"].Value),
                NumberPhone = filaSeleccionada.Cells["numberPhone"].Value.ToString(),
                Passworduser = filaSeleccionada.Cells["passworduser"].Value.ToString(),
                Country = filaSeleccionada.Cells["country"].Value.ToString(),
                City = filaSeleccionada.Cells["city"].Value.ToString(),
                Statususer = filaSeleccionada.Cells["statususer"].Value.ToString()
            };

            AddUsersForm editarUsuarioForm = new AddUsersForm(_usuersservices, _rolservices, usuarioSeleccionado);

            editarUsuarioForm.EditUsuariosHandler += (s, args) => LoadData();

            AbrirFormulario(editarUsuarioForm);
        }

        private void pbEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
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
                int idUser = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idUser"].Value);
                _usuersservices.DeleteUsers(idUser);
                LoadData();
            }
        }
    }
}