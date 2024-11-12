namespace PresentationLayer.Forms.Admin
{
    partial class PermissionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage2 = new TabPage();
            dataGridViewMenu = new DataGridView();
            groupBox3 = new GroupBox();
            textBoxNameMenuForm = new TextBox();
            label2 = new Label();
            textBoxNameMenu = new TextBox();
            label1 = new Label();
            iconButtonEditMenus = new FontAwesome.Sharp.IconButton();
            iconButtonSaveMenus = new FontAwesome.Sharp.IconButton();
            iconButtonDeleteMenus = new FontAwesome.Sharp.IconButton();
            tabControlPermission = new TabControl();
            tabPagePermission = new TabPage();
            groupBox1 = new GroupBox();
            comboBoxidRol = new ComboBox();
            iconButtonEditRolPermission = new FontAwesome.Sharp.IconButton();
            comboBoxidPermission = new ComboBox();
            iconButtonSaveRolPermission = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label6 = new Label();
            dataGridViewrolPermission = new DataGridView();
            groupBox2 = new GroupBox();
            comboBoxMenu = new ComboBox();
            iconButtonEditMenu = new FontAwesome.Sharp.IconButton();
            iconButtonSaveMenu = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            dataGridViewPermission = new DataGridView();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            groupBox3.SuspendLayout();
            tabControlPermission.SuspendLayout();
            tabPagePermission.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewrolPermission).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPermission).BeginInit();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewMenu);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1417, 720);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Menus";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMenu.BackgroundColor = Color.White;
            dataGridViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenu.Location = new Point(3, 212);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.RowHeadersWidth = 51;
            dataGridViewMenu.Size = new Size(1411, 505);
            dataGridViewMenu.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textBoxNameMenuForm);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBoxNameMenu);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(iconButtonEditMenus);
            groupBox3.Controls.Add(iconButtonSaveMenus);
            groupBox3.Controls.Add(iconButtonDeleteMenus);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1406, 200);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Agregar nuevos menus";
            // 
            // textBoxNameMenuForm
            // 
            textBoxNameMenuForm.Location = new Point(30, 97);
            textBoxNameMenuForm.Name = "textBoxNameMenuForm";
            textBoxNameMenuForm.Size = new Size(436, 26);
            textBoxNameMenuForm.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 22);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre del menu:";
            // 
            // textBoxNameMenu
            // 
            textBoxNameMenu.Location = new Point(30, 45);
            textBoxNameMenu.Name = "textBoxNameMenu";
            textBoxNameMenu.Size = new Size(436, 26);
            textBoxNameMenu.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 74);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre del el objeto a mostrar:";
            // 
            // iconButtonEditMenus
            // 
            iconButtonEditMenus.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonEditMenus.IconColor = Color.Black;
            iconButtonEditMenus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEditMenus.Location = new Point(181, 148);
            iconButtonEditMenus.Name = "iconButtonEditMenus";
            iconButtonEditMenus.Size = new Size(133, 29);
            iconButtonEditMenus.TabIndex = 3;
            iconButtonEditMenus.Text = "Editar";
            iconButtonEditMenus.UseVisualStyleBackColor = true;
            iconButtonEditMenus.Click += iconButtonEditMenus_Click;
            // 
            // iconButtonSaveMenus
            // 
            iconButtonSaveMenus.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSaveMenus.IconColor = Color.Black;
            iconButtonSaveMenus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSaveMenus.Location = new Point(29, 148);
            iconButtonSaveMenus.Name = "iconButtonSaveMenus";
            iconButtonSaveMenus.Size = new Size(133, 29);
            iconButtonSaveMenus.TabIndex = 5;
            iconButtonSaveMenus.Text = "Agregar";
            iconButtonSaveMenus.UseVisualStyleBackColor = true;
            iconButtonSaveMenus.Click += iconButtonSave_Click;
            // 
            // iconButtonDeleteMenus
            // 
            iconButtonDeleteMenus.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonDeleteMenus.IconColor = Color.Black;
            iconButtonDeleteMenus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDeleteMenus.Location = new Point(333, 148);
            iconButtonDeleteMenus.Name = "iconButtonDeleteMenus";
            iconButtonDeleteMenus.Size = new Size(133, 29);
            iconButtonDeleteMenus.TabIndex = 4;
            iconButtonDeleteMenus.Text = "Eliminar";
            iconButtonDeleteMenus.UseVisualStyleBackColor = true;
            iconButtonDeleteMenus.Click += iconButtonDeleteMenus_Click;
            // 
            // tabControlPermission
            // 
            tabControlPermission.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPermission.Controls.Add(tabPagePermission);
            tabControlPermission.Controls.Add(tabPage2);
            tabControlPermission.Location = new Point(0, 0);
            tabControlPermission.Name = "tabControlPermission";
            tabControlPermission.SelectedIndex = 0;
            tabControlPermission.Size = new Size(1425, 753);
            tabControlPermission.TabIndex = 0;
            // 
            // tabPagePermission
            // 
            tabPagePermission.Controls.Add(groupBox1);
            tabPagePermission.Controls.Add(dataGridViewrolPermission);
            tabPagePermission.Controls.Add(groupBox2);
            tabPagePermission.Controls.Add(dataGridViewPermission);
            tabPagePermission.Location = new Point(4, 29);
            tabPagePermission.Name = "tabPagePermission";
            tabPagePermission.Padding = new Padding(3);
            tabPagePermission.Size = new Size(1417, 720);
            tabPagePermission.TabIndex = 2;
            tabPagePermission.Text = "Permisos";
            tabPagePermission.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(comboBoxidRol);
            groupBox1.Controls.Add(iconButtonEditRolPermission);
            groupBox1.Controls.Add(comboBoxidPermission);
            groupBox1.Controls.Add(iconButtonSaveRolPermission);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(758, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 182);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dar acceso:";
            // 
            // comboBoxidRol
            // 
            comboBoxidRol.FormattingEnabled = true;
            comboBoxidRol.Location = new Point(23, 54);
            comboBoxidRol.Name = "comboBoxidRol";
            comboBoxidRol.Size = new Size(379, 28);
            comboBoxidRol.TabIndex = 9;
            // 
            // iconButtonEditRolPermission
            // 
            iconButtonEditRolPermission.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonEditRolPermission.IconColor = Color.Black;
            iconButtonEditRolPermission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEditRolPermission.Location = new Point(455, 90);
            iconButtonEditRolPermission.Name = "iconButtonEditRolPermission";
            iconButtonEditRolPermission.Size = new Size(160, 29);
            iconButtonEditRolPermission.TabIndex = 5;
            iconButtonEditRolPermission.Text = "Editar";
            iconButtonEditRolPermission.UseVisualStyleBackColor = true;
            iconButtonEditRolPermission.Click += iconButtonEditRolPermission_Click;
            // 
            // comboBoxidPermission
            // 
            comboBoxidPermission.FormattingEnabled = true;
            comboBoxidPermission.Location = new Point(23, 108);
            comboBoxidPermission.Name = "comboBoxidPermission";
            comboBoxidPermission.Size = new Size(379, 28);
            comboBoxidPermission.TabIndex = 8;
            // 
            // iconButtonSaveRolPermission
            // 
            iconButtonSaveRolPermission.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSaveRolPermission.IconColor = Color.Black;
            iconButtonSaveRolPermission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSaveRolPermission.Location = new Point(455, 55);
            iconButtonSaveRolPermission.Name = "iconButtonSaveRolPermission";
            iconButtonSaveRolPermission.Size = new Size(160, 29);
            iconButtonSaveRolPermission.TabIndex = 4;
            iconButtonSaveRolPermission.Text = "Agregar";
            iconButtonSaveRolPermission.UseVisualStyleBackColor = true;
            iconButtonSaveRolPermission.Click += iconButtonSaveRolPermission_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 85);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 2;
            label3.Text = "Coloce el id del permiso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 33);
            label6.Name = "label6";
            label6.Size = new Size(190, 20);
            label6.TabIndex = 0;
            label6.Text = "Coloce el rol del usuario:";
            // 
            // dataGridViewrolPermission
            // 
            dataGridViewrolPermission.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewrolPermission.BackgroundColor = Color.White;
            dataGridViewrolPermission.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewrolPermission.Location = new Point(762, 246);
            dataGridViewrolPermission.Name = "dataGridViewrolPermission";
            dataGridViewrolPermission.RowHeadersWidth = 51;
            dataGridViewrolPermission.Size = new Size(649, 468);
            dataGridViewrolPermission.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxMenu);
            groupBox2.Controls.Add(iconButtonEditMenu);
            groupBox2.Controls.Add(iconButtonSaveMenu);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(10, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(653, 182);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Permisos:";
            // 
            // comboBoxMenu
            // 
            comboBoxMenu.FormattingEnabled = true;
            comboBoxMenu.Location = new Point(23, 77);
            comboBoxMenu.Name = "comboBoxMenu";
            comboBoxMenu.Size = new Size(379, 28);
            comboBoxMenu.TabIndex = 7;
            // 
            // iconButtonEditMenu
            // 
            iconButtonEditMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonEditMenu.IconColor = Color.Black;
            iconButtonEditMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEditMenu.Location = new Point(455, 90);
            iconButtonEditMenu.Name = "iconButtonEditMenu";
            iconButtonEditMenu.Size = new Size(160, 29);
            iconButtonEditMenu.TabIndex = 5;
            iconButtonEditMenu.Text = "Editar";
            iconButtonEditMenu.UseVisualStyleBackColor = true;
            iconButtonEditMenu.Click += iconButtonEditMenu_Click;
            // 
            // iconButtonSaveMenu
            // 
            iconButtonSaveMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSaveMenu.IconColor = Color.Black;
            iconButtonSaveMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSaveMenu.Location = new Point(455, 55);
            iconButtonSaveMenu.Name = "iconButtonSaveMenu";
            iconButtonSaveMenu.Size = new Size(160, 29);
            iconButtonSaveMenu.TabIndex = 4;
            iconButtonSaveMenu.Text = "Agregar";
            iconButtonSaveMenu.UseVisualStyleBackColor = true;
            iconButtonSaveMenu.Click += iconButtonSaveMenu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 49);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 0;
            label4.Text = "Seleccionar el menu:";
            // 
            // dataGridViewPermission
            // 
            dataGridViewPermission.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewPermission.BackgroundColor = Color.White;
            dataGridViewPermission.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPermission.Location = new Point(8, 246);
            dataGridViewPermission.Name = "dataGridViewPermission";
            dataGridViewPermission.RowHeadersWidth = 51;
            dataGridViewPermission.Size = new Size(655, 468);
            dataGridViewPermission.TabIndex = 2;
            // 
            // PermissionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 753);
            Controls.Add(tabControlPermission);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PermissionForm";
            Text = "PermissionForm";
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabControlPermission.ResumeLayout(false);
            tabPagePermission.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewrolPermission).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPermission).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TextBox textBoxNameMenuForm;
        private TextBox textBoxNameMenu;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButtonSaveMenus;
        private FontAwesome.Sharp.IconButton iconButtonDeleteMenus;
        private FontAwesome.Sharp.IconButton iconButtonEditMenus;
        private Label label1;
        private DataGridView dataGridViewMenu;
        private TabControl tabControlPermission;
        private TabPage tabPagePermission;
        private GroupBox groupBox2;
        private TextBox textBoxidPermission;
        private Label label5;
        private TextBox textBoxidRol;
        private Label label4;
        private DataGridView dataGridViewPermission;
        private FontAwesome.Sharp.IconButton iconButtonEditMenu;
        private FontAwesome.Sharp.IconButton iconButtonSaveMenu;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButtonEditRolPermission;
        private FontAwesome.Sharp.IconButton iconButtonSaveRolPermission;
        private Label label3;
        private Label label6;
        private DataGridView dataGridViewrolPermission;
        private GroupBox groupBox3;
        private ComboBox comboBoxMenu;
        private ComboBox comboBoxidRol;
        private ComboBox comboBoxidPermission;
    }
}