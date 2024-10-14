using BusinessLayer.Services;
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
    public partial class UsuariosForm : Form
    {
        private IRolServices _rolservices;
        private IUsuarioServices _usuariosservices;
        public UsuariosForm(IUsuarioServices usuarioServices, IRolServices rolServices)
        {
            InitializeComponent();
            _usuariosservices = usuarioServices;
            _rolservices = rolServices;
            LoadData();

        }

        private void LoadData()
        {
            dgvUsuarios.DataSource = _usuariosservices.GetUsuarios();

            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvUsuarios.Columns["IdUsuario"].Visible = false;

            dgvUsuarios.Columns["IdRol"].Visible = false;

            dgvUsuarios.Columns["rol"].HeaderText = "Rol";

            dgvUsuarios.Columns["rol"].Visible = true;
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.Show();
        }

        private void pbAñadirUsuario_Click(object sender, EventArgs e)
        {
            AñadirUsuariosForm formularioAñadir = new AñadirUsuariosForm(_usuariosservices, _rolservices);

            formularioAñadir.UsuarioAgregado += (s, args) =>
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
            Usuarios usuarioSeleccionado = new Usuarios
            {
                IdUsuario = Convert.ToInt32(filaSeleccionada.Cells["IdUsuario"].Value),
                Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString(),
                Edad = Convert.ToInt32(filaSeleccionada.Cells["Edad"].Value.ToString()),
                Correo = filaSeleccionada.Cells["Correo"].Value.ToString(),
                Usuario = filaSeleccionada.Cells["Usuario"].Value.ToString(),
                Clave = filaSeleccionada.Cells["Clave"].Value.ToString(),

                Pais = filaSeleccionada.Cells["Pais"].Value.ToString(),
                Departamento = filaSeleccionada.Cells["Departamento"].Value.ToString(),
                Ciudad = filaSeleccionada.Cells["Ciudad"].Value.ToString(),
                Estado = filaSeleccionada.Cells["Estado"].Value.ToString(),
                FechaRegistro = Convert.ToDateTime(filaSeleccionada.Cells["FechaRegistro"].Value),
                oRol = new Rol
                {
                    IdRol = Convert.ToInt32(filaSeleccionada.Cells["IdRol"].Value)
                }
            };

            AñadirUsuariosForm editarUsuarioForm = new AñadirUsuariosForm(_usuariosservices, _rolservices, usuarioSeleccionado);

            editarUsuarioForm.EditarUsuariosHandler += (s, args) =>
            {
                LoadData(); 
            };

            AbrirFormulario(editarUsuarioForm);
        }

        private void pbEliminarUsuario_Click(object sender, EventArgs e)
        {
            if(dgvUsuarios.Rows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una fila para para eliminar","Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var EliminarConfirmar = new DialogResult();

                EliminarConfirmar = MessageBox.Show("Esta seguro que desea eliminar este usuario ? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (EliminarConfirmar == DialogResult.Yes)
                {
                    int IdUsuarios = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                    _usuariosservices.DeleteUsuarios(IdUsuarios);

                    LoadData();
                }
            }
        }
    }
}
