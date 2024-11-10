namespace PresentationLayer.Forms
{
    partial class MenuForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            pbMinimizar = new PictureBox();
            pbEliminar = new PictureBox();
            pictureBox1 = new PictureBox();
            lblHoraUsuario = new Label();
            lblNombreUsuario = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            lblNombreProyecto = new Label();
            pictureBox2 = new PictureBox();
            menu = new MenuStrip();
            IconMenuUsersForm = new FontAwesome.Sharp.IconMenuItem();
            IconMenuProyectsForm = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemRequestClientProjects = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemProjectsEmployee = new FontAwesome.Sharp.IconMenuItem();
            IconMenuRecordForm = new FontAwesome.Sharp.IconMenuItem();
            IconMenusSettingsForm = new FontAwesome.Sharp.IconMenuItem();
            IconMenuAccountForm = new FontAwesome.Sharp.IconMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            contenedor = new Panel();
            toolTip1 = new ToolTip(components);
            iconMenuItemMenus = new FontAwesome.Sharp.IconMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pbMinimizar);
            panel1.Controls.Add(pbEliminar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblHoraUsuario);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(242, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 96);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(69, 64);
            label2.Name = "label2";
            label2.Size = new Size(126, 22);
            label2.TabIndex = 6;
            label2.Text = "Cerrar sesion";
            label2.Click += label2_Click;
            // 
            // pbMinimizar
            // 
            pbMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbMinimizar.Cursor = Cursors.Hand;
            pbMinimizar.Image = Properties.Resources.negative_sign_icon_icons_com_70439;
            pbMinimizar.Location = new Point(1100, 3);
            pbMinimizar.Name = "pbMinimizar";
            pbMinimizar.Size = new Size(34, 36);
            pbMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pbMinimizar.TabIndex = 8;
            pbMinimizar.TabStop = false;
            pbMinimizar.Click += pbMinimizar_Click;
            pbMinimizar.MouseHover += pbMinimizar_MouseHover;
            // 
            // pbEliminar
            // 
            pbEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbEliminar.Cursor = Cursors.Hand;
            pbEliminar.Image = Properties.Resources.close_remove_delete_icon_148989;
            pbEliminar.Location = new Point(1140, 3);
            pbEliminar.Name = "pbEliminar";
            pbEliminar.Size = new Size(34, 36);
            pbEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pbEliminar.TabIndex = 7;
            pbEliminar.TabStop = false;
            pbEliminar.Click += pbEliminar_Click;
            pbEliminar.MouseHover += pbEliminar_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user_icon_icons_com_57997;
            pictureBox1.Location = new Point(5, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblHoraUsuario
            // 
            lblHoraUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHoraUsuario.AutoSize = true;
            lblHoraUsuario.Font = new Font("Century Gothic", 12F);
            lblHoraUsuario.ForeColor = Color.White;
            lblHoraUsuario.Location = new Point(1033, 58);
            lblHoraUsuario.Name = "lblHoraUsuario";
            lblHoraUsuario.Size = new Size(150, 23);
            lblHoraUsuario.TabIndex = 5;
            lblHoraUsuario.Text = "lblHoraUsuario";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Century Gothic", 12F);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(69, 35);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(183, 23);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "lblNombreUsuario";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Turquoise;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblNombreProyecto);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(menu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 772);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom;
            panel4.BackColor = Color.Azure;
            panel4.Location = new Point(3, 671);
            panel4.Name = "panel4";
            panel4.Size = new Size(247, 10);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Location = new Point(0, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 10);
            panel3.TabIndex = 0;
            // 
            // lblNombreProyecto
            // 
            lblNombreProyecto.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreProyecto.ForeColor = Color.White;
            lblNombreProyecto.Location = new Point(12, 99);
            lblNombreProyecto.Name = "lblNombreProyecto";
            lblNombreProyecto.Size = new Size(215, 46);
            lblNombreProyecto.TabIndex = 7;
            lblNombreProyecto.Text = "Proyectos Los Tilines";
            lblNombreProyecto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.projects_icon_142976;
            pictureBox2.Location = new Point(60, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // menu
            // 
            menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menu.AutoSize = false;
            menu.Dock = DockStyle.None;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { IconMenuUsersForm, IconMenuProyectsForm, iconMenuItemRequestClientProjects, iconMenuItemProjectsEmployee, IconMenuRecordForm, IconMenusSettingsForm, IconMenuAccountForm, iconMenuItemMenus });
            menu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menu.Location = new Point(3, 184);
            menu.Name = "menu";
            menu.Size = new Size(239, 484);
            menu.TabIndex = 9;
            // 
            // IconMenuUsersForm
            // 
            IconMenuUsersForm.AutoSize = false;
            IconMenuUsersForm.Font = new Font("Segoe UI", 10.2F);
            IconMenuUsersForm.IconChar = FontAwesome.Sharp.IconChar.User;
            IconMenuUsersForm.IconColor = Color.Black;
            IconMenuUsersForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuUsersForm.ImageAlign = ContentAlignment.BottomLeft;
            IconMenuUsersForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuUsersForm.Name = "IconMenuUsersForm";
            IconMenuUsersForm.Size = new Size(232, 27);
            IconMenuUsersForm.Text = "Usuarios";
            IconMenuUsersForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuUsersForm.Click += IconMenuUsersForm_Click;
            // 
            // IconMenuProyectsForm
            // 
            IconMenuProyectsForm.AutoSize = false;
            IconMenuProyectsForm.Font = new Font("Segoe UI", 10.2F);
            IconMenuProyectsForm.IconChar = FontAwesome.Sharp.IconChar.Compass;
            IconMenuProyectsForm.IconColor = Color.Black;
            IconMenuProyectsForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuProyectsForm.ImageAlign = ContentAlignment.BottomLeft;
            IconMenuProyectsForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuProyectsForm.Name = "IconMenuProyectsForm";
            IconMenuProyectsForm.Size = new Size(232, 27);
            IconMenuProyectsForm.Text = "Proyectos";
            IconMenuProyectsForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuProyectsForm.Click += IconMenuProyectsForm_Click;
            // 
            // iconMenuItemRequestClientProjects
            // 
            iconMenuItemRequestClientProjects.Font = new Font("Segoe UI", 10.2F);
            iconMenuItemRequestClientProjects.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            iconMenuItemRequestClientProjects.IconColor = Color.Black;
            iconMenuItemRequestClientProjects.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemRequestClientProjects.ImageAlign = ContentAlignment.BottomLeft;
            iconMenuItemRequestClientProjects.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemRequestClientProjects.Name = "iconMenuItemRequestClientProjects";
            iconMenuItemRequestClientProjects.Size = new Size(232, 27);
            iconMenuItemRequestClientProjects.Text = "Solicitar Proyecto";
            iconMenuItemRequestClientProjects.TextImageRelation = TextImageRelation.Overlay;
            // 
            // iconMenuItemProjectsEmployee
            // 
            iconMenuItemProjectsEmployee.Font = new Font("Segoe UI", 10.2F);
            iconMenuItemProjectsEmployee.IconChar = FontAwesome.Sharp.IconChar.Compass;
            iconMenuItemProjectsEmployee.IconColor = Color.Black;
            iconMenuItemProjectsEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemProjectsEmployee.ImageAlign = ContentAlignment.BottomLeft;
            iconMenuItemProjectsEmployee.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemProjectsEmployee.Name = "iconMenuItemProjectsEmployee";
            iconMenuItemProjectsEmployee.Size = new Size(232, 27);
            iconMenuItemProjectsEmployee.Text = "Mis proyectos";
            iconMenuItemProjectsEmployee.TextImageRelation = TextImageRelation.Overlay;
            // 
            // IconMenuRecordForm
            // 
            IconMenuRecordForm.AutoSize = false;
            IconMenuRecordForm.Font = new Font("Segoe UI", 10.2F);
            IconMenuRecordForm.IconChar = FontAwesome.Sharp.IconChar.Poll;
            IconMenuRecordForm.IconColor = Color.Black;
            IconMenuRecordForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuRecordForm.ImageAlign = ContentAlignment.BottomLeft;
            IconMenuRecordForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuRecordForm.Name = "IconMenuRecordForm";
            IconMenuRecordForm.Size = new Size(232, 27);
            IconMenuRecordForm.Text = "Historial";
            IconMenuRecordForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuRecordForm.Click += IconMenuRecordForm_Click;
            // 
            // IconMenusSettingsForm
            // 
            IconMenusSettingsForm.AutoSize = false;
            IconMenusSettingsForm.Font = new Font("Segoe UI", 10.2F);
            IconMenusSettingsForm.IconChar = FontAwesome.Sharp.IconChar.Stream;
            IconMenusSettingsForm.IconColor = Color.Black;
            IconMenusSettingsForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenusSettingsForm.ImageAlign = ContentAlignment.BottomLeft;
            IconMenusSettingsForm.Margin = new Padding(0, 20, 0, 0);
            IconMenusSettingsForm.Name = "IconMenusSettingsForm";
            IconMenusSettingsForm.Size = new Size(232, 27);
            IconMenusSettingsForm.Text = "Ajustes";
            IconMenusSettingsForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenusSettingsForm.Click += IconMenusSettingsForm_Click;
            // 
            // IconMenuAccountForm
            // 
            IconMenuAccountForm.AutoSize = false;
            IconMenuAccountForm.Font = new Font("Segoe UI", 10.2F);
            IconMenuAccountForm.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            IconMenuAccountForm.IconColor = Color.Black;
            IconMenuAccountForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuAccountForm.ImageAlign = ContentAlignment.BottomLeft;
            IconMenuAccountForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuAccountForm.Name = "IconMenuAccountForm";
            IconMenuAccountForm.Size = new Size(232, 27);
            IconMenuAccountForm.Text = "Perfil";
            IconMenuAccountForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuAccountForm.Click += IconMenuAccountForm_Click;
            // 
            // contenedor
            // 
            contenedor.BackColor = Color.White;
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(242, 96);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1186, 676);
            contenedor.TabIndex = 0;
            // 
            // iconMenuItemMenus
            // 
            iconMenuItemMenus.AutoSize = false;
            iconMenuItemMenus.Font = new Font("Segoe UI", 10.2F);
            iconMenuItemMenus.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            iconMenuItemMenus.IconColor = Color.Black;
            iconMenuItemMenus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemMenus.ImageAlign = ContentAlignment.BottomLeft;
            iconMenuItemMenus.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemMenus.Name = "iconMenuItemMenus";
            iconMenuItemMenus.Size = new Size(232, 27);
            iconMenuItemMenus.Text = "Menus";
            iconMenuItemMenus.TextImageRelation = TextImageRelation.Overlay;
            iconMenuItemMenus.Click += iconMenuItemMenus_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1428, 772);
            Controls.Add(contenedor);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menu;
            Name = "MenuForm";
            Text = "E";
            WindowState = FormWindowState.Maximized;
            Load += MenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lblHoraUsuario;
        private Label lblNombreUsuario;
        private Panel panel2;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel contenedor;
        private Label lblNombreProyecto;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pbMinimizar;
        private PictureBox pbEliminar;
        private ToolTip toolTip1;
        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem IconMenuUsersForm;
        private FontAwesome.Sharp.IconMenuItem IconMenuProyectsForm;
        private FontAwesome.Sharp.IconMenuItem IconMenuRecordForm;
        private FontAwesome.Sharp.IconMenuItem IconMenusSettingsForm;
        private FontAwesome.Sharp.IconMenuItem IconMenuAccountForm;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemProjectsEmployee;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemRequestClientProjects;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemMenus;
    }
}