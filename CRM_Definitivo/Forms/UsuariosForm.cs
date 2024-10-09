using BusinessLayer.Services;
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
        private AñadirUsuariosForm _añadirusuariosform;
        private RolServices _rolservices;
        private UsuariosServices _usuariosservices;
        public UsuariosForm()
        {
            InitializeComponent();
            _usuariosservices = new UsuariosServices();
            _rolservices = new RolServices();
            //_añadirusuariosform = new AñadirUsuariosForm(formularioPrincipal);
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
            AñadirUsuariosForm formularioAñadir = new AñadirUsuariosForm(this);

            // Suscribirse al evento que notifica cuando se agrega un nuevo usuario
            formularioAñadir.UsuarioAgregado += (s, args) =>
            {
                // Lógica para actualizar el DataGridView
                LoadData(); // Método para cargar los usuarios en el DataGridView
            };

            // Abrir el formulario de "Añadir Usuarios"
            AbrirFormulario(formularioAñadir);

        }

        private void pbEditarUsuario_Click(object sender, EventArgs e)
        {


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
