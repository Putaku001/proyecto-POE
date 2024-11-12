using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Admin
{
    public partial class PermissionForm : Form
    {
        private readonly IRolServices _rolservices;
        private readonly IPermisoServices _permissionServices;
        bool isEditing = false;
        public PermissionForm(IRolServices rolServices, IPermisoServices permisionsServices)
        {
            InitializeComponent();
            _rolservices = rolServices;
            _permissionServices = permisionsServices;
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewMenu.DataSource = _permissionServices.GetByMenu();
            dataGridViewPermission.DataSource = _permissionServices.GetPermissions();
            dataGridViewrolPermission.DataSource = _permissionServices.GetByRolPermissions();

            dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPermission.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewrolPermission.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Diseño para dgv menu
            dataGridViewMenu.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridViewMenu.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewMenu.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dataGridViewMenu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewMenu.EnableHeadersVisualStyles = false;

            dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Diseño para dgvPermission
            dataGridViewPermission.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridViewPermission.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewPermission.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewPermission.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dataGridViewPermission.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewPermission.EnableHeadersVisualStyles = false;

            dataGridViewPermission.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPermission.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Diseño para dgvRolPermission
            dataGridViewrolPermission.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridViewrolPermission.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewrolPermission.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewrolPermission.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dataGridViewrolPermission.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewrolPermission.EnableHeadersVisualStyles = false;

            dataGridViewrolPermission.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewrolPermission.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //DATASOURCE DEL MENU 
            comboBoxMenu.DataSource = _permissionServices.GetByMenu();
            comboBoxMenu.DisplayMember = "nameForm";
            comboBoxMenu.ValueMember = "idMenu";

            //DATASOURCE DE PERMISSIONS
            comboBoxidPermission.DataSource = _permissionServices.GetPermissions();
            comboBoxidPermission.ValueMember = "idPermission";

            //DATASOURCE DE ROLPERMISSIONS
            comboBoxidRol.DataSource = _rolservices.GetRol();
            comboBoxidRol.DisplayMember = "Rol";
            comboBoxidRol.ValueMember = "idRol";
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            var menu = new Menu();

            if (isEditing)
            {
                menu.idMenu = int.Parse(dataGridViewMenu.CurrentRow.Cells[0].Value.ToString());
                menu.name = textBoxNameMenu.Text;
                menu.NameForm = textBoxNameMenuForm.Text;

                _permissionServices.EditMenu(menu);

                MessageBox.Show("El menu se ha actualizado de forma exitosa!");
                LoadData();

                isEditing = false;
            }
            else
            {
                menu.name = textBoxNameMenu.Text;
                menu.NameForm = textBoxNameMenuForm.Text;

                _permissionServices.AddMenu(menu);
                MessageBox.Show("El nuevo menu se ha agregado correctamente!");
                LoadData();
            }
        }

        private void iconButtonEditMenus_Click(object sender, EventArgs e)
        {
            if(dataGridViewMenu.SelectedRows.Count > 0)
            {
                textBoxNameMenu.Text = dataGridViewMenu.CurrentRow.Cells[1].Value.ToString();
                textBoxNameMenuForm.Text = dataGridViewMenu.CurrentRow.Cells[2].Value.ToString();
                isEditing = true;
            }
        }

        private void iconButtonSaveMenu_Click(object sender, EventArgs e)
        {
            var permission = new Permissions();

            if (isEditing)
            {
                permission.idPermission = int.Parse(dataGridViewMenu.CurrentRow.Cells[0].Value.ToString());
                _permissionServices.EditPermissions(permission);
                LoadData();
                isEditing = false;
            }
            else
            {
                permission.idMenu = Convert.ToInt32(comboBoxMenu.SelectedValue);

                _permissionServices.AddPermissions(permission);
                LoadData();
                MessageBox.Show("Se ha agregado correctamente!");
            }
        }

        private void iconButtonEditMenu_Click(object sender, EventArgs e)
        {
            if (dataGridViewPermission.SelectedRows.Count > 0)
            {
                comboBoxMenu.SelectedValue = Convert.ToInt32(dataGridViewPermission.CurrentRow.Cells[1].Value.ToString());
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void iconButtonSaveRolPermission_Click(object sender, EventArgs e)
        {
            var rolPermission = new RolPermission();

            if (isEditing)
            {
                rolPermission.idRolPermission = int.Parse(dataGridViewrolPermission.CurrentRow.Cells[0].Value.ToString());
                rolPermission.idRoles = Convert.ToInt32(comboBoxidRol.SelectedValue);
                rolPermission.idPermission = Convert.ToInt32(comboBoxidPermission.SelectedValue);

                _permissionServices.EditRolPermission(rolPermission);

                MessageBox.Show("Se ha editado el permiso correctamente");
                LoadData();

                isEditing = false;
            }
            else
            {
                rolPermission.idRoles = Convert.ToInt32(comboBoxidRol.SelectedValue);
                rolPermission.idPermission = Convert.ToInt32(comboBoxidPermission.SelectedValue);

                _permissionServices.AddRolPermission(rolPermission);

                MessageBox.Show($"Se ha asignado un nuevo permiso a los {comboBoxidRol.SelectedValue} correctamente!");
                LoadData();
            }

        }

        private void iconButtonEditRolPermission_Click(object sender, EventArgs e)
        {
            if (dataGridViewrolPermission.SelectedRows.Count > 0)
            {
                comboBoxidRol.Text = dataGridViewrolPermission.CurrentRow.Cells[2].Value.ToString();
                comboBoxidPermission.Text = dataGridViewrolPermission.CurrentRow.Cells[1].Value.ToString();
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }


    }
}
