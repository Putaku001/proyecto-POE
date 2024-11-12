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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            panel1 = new Panel();
            label2 = new Label();
            pbMinimizar = new PictureBox();
            pbEliminar = new PictureBox();
            lblNombreUsuario = new Label();
            pictureBoxImageByIdUser = new PictureBox();
            lblHoraUsuario = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            menu = new MenuStrip();
            iconMenuItemHome = new FontAwesome.Sharp.IconMenuItem();
            IconMenuUsersForm = new FontAwesome.Sharp.IconMenuItem();
            IconMenuProyectsForm = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemRequestClientProjects = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemProjectsEmployee = new FontAwesome.Sharp.IconMenuItem();
            IconMenuRecordForm = new FontAwesome.Sharp.IconMenuItem();
            IconMenusSettingsForm = new FontAwesome.Sharp.IconMenuItem();
            IconMenuAccountForm = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemMenus = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemConfigurationEmployee = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemConfigurationUserClient = new FontAwesome.Sharp.IconMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            contenedor = new Panel();
            groupBox1 = new GroupBox();
            panelUsersView = new Panel();
            panel10 = new Panel();
            label7 = new Label();
            panel9 = new Panel();
            labelRegistration = new Label();
            labelNumberPhone = new Label();
            labelEmail = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            panel7 = new Panel();
            pictureBox6 = new PictureBox();
            listBoxRequestProjects = new ListBox();
            label4 = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            listBoxProjectsAsignamment = new ListBox();
            label5 = new Label();
            labelnameUser = new Label();
            label3 = new Label();
            labelCity = new Label();
            labelCountryByUser = new Label();
            labelByAgeUser = new Label();
            pictureBoxSelectedUser = new PictureBox();
            labelByUser = new Label();
            label1 = new Label();
            panel8 = new Panel();
            label11 = new Label();
            panelInfoUsers = new Panel();
            dataGridViewUsers = new DataGridView();
            viewUser = new DataGridViewButtonColumn();
            iconButtonUserClients = new FontAwesome.Sharp.IconButton();
            iconButtonUserAdministrator = new FontAwesome.Sharp.IconButton();
            iconButtonUserEmployee = new FontAwesome.Sharp.IconButton();
            labelUserAccount = new Label();
            panelPrijectsAssignament = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageByIdUser).BeginInit();
            panel2.SuspendLayout();
            menu.SuspendLayout();
            contenedor.SuspendLayout();
            groupBox1.SuspendLayout();
            panelUsersView.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedUser).BeginInit();
            panel8.SuspendLayout();
            panelInfoUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panelPrijectsAssignament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pbMinimizar);
            panel1.Controls.Add(pbEliminar);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(73, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1355, 62);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(6, 32);
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
            pbMinimizar.Location = new Point(1269, 3);
            pbMinimizar.Name = "pbMinimizar";
            pbMinimizar.Size = new Size(34, 44);
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
            pbEliminar.Location = new Point(1309, 3);
            pbEliminar.Name = "pbEliminar";
            pbEliminar.Size = new Size(34, 44);
            pbEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pbEliminar.TabIndex = 7;
            pbEliminar.TabStop = false;
            pbEliminar.Click += pbEliminar_Click;
            pbEliminar.MouseHover += pbEliminar_MouseHover;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Century Gothic", 12F);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(6, 9);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(183, 23);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "lblNombreUsuario";
            // 
            // pictureBoxImageByIdUser
            // 
            pictureBoxImageByIdUser.BackColor = Color.DarkSlateGray;
            pictureBoxImageByIdUser.Image = Properties.Resources.user_icon_icons_com_57997;
            pictureBoxImageByIdUser.Location = new Point(12, 9);
            pictureBoxImageByIdUser.Name = "pictureBoxImageByIdUser";
            pictureBoxImageByIdUser.Size = new Size(46, 47);
            pictureBoxImageByIdUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImageByIdUser.TabIndex = 6;
            pictureBoxImageByIdUser.TabStop = false;
            // 
            // lblHoraUsuario
            // 
            lblHoraUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHoraUsuario.AutoSize = true;
            lblHoraUsuario.BackColor = Color.White;
            lblHoraUsuario.Font = new Font("Century Gothic", 12F);
            lblHoraUsuario.ForeColor = Color.Black;
            lblHoraUsuario.Location = new Point(633, 25);
            lblHoraUsuario.Name = "lblHoraUsuario";
            lblHoraUsuario.Size = new Size(150, 23);
            lblHoraUsuario.TabIndex = 5;
            lblHoraUsuario.Text = "lblHoraUsuario";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBoxImageByIdUser);
            panel2.Controls.Add(menu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(73, 872);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Azure;
            panel4.Location = new Point(0, 771);
            panel4.Name = "panel4";
            panel4.Size = new Size(73, 10);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Azure;
            panel3.Location = new Point(0, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(73, 10);
            panel3.TabIndex = 0;
            // 
            // menu
            // 
            menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menu.AutoSize = false;
            menu.Dock = DockStyle.None;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { iconMenuItemHome, IconMenuUsersForm, IconMenuProyectsForm, iconMenuItemRequestClientProjects, iconMenuItemProjectsEmployee, IconMenuRecordForm, IconMenusSettingsForm, IconMenuAccountForm, iconMenuItemMenus, iconMenuItemConfigurationEmployee, iconMenuItemConfigurationUserClient });
            menu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menu.Location = new Point(0, 114);
            menu.Name = "menu";
            menu.Size = new Size(70, 654);
            menu.TabIndex = 9;
            // 
            // iconMenuItemHome
            // 
            iconMenuItemHome.AutoSize = false;
            iconMenuItemHome.BackgroundImageLayout = ImageLayout.None;
            iconMenuItemHome.Font = new Font("Segoe UI", 10.2F);
            iconMenuItemHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconMenuItemHome.IconColor = Color.Black;
            iconMenuItemHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemHome.IconSize = 28;
            iconMenuItemHome.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemHome.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemHome.Name = "iconMenuItemHome";
            iconMenuItemHome.Size = new Size(232, 27);
            iconMenuItemHome.TextImageRelation = TextImageRelation.Overlay;
            iconMenuItemHome.Click += iconMenuItemHome_Click;
            // 
            // IconMenuUsersForm
            // 
            IconMenuUsersForm.AutoSize = false;
            IconMenuUsersForm.BackgroundImageLayout = ImageLayout.None;
            IconMenuUsersForm.Font = new Font("Segoe UI", 10.2F);
            IconMenuUsersForm.IconChar = FontAwesome.Sharp.IconChar.User;
            IconMenuUsersForm.IconColor = Color.Black;
            IconMenuUsersForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuUsersForm.IconSize = 28;
            IconMenuUsersForm.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuUsersForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuUsersForm.Name = "IconMenuUsersForm";
            IconMenuUsersForm.Size = new Size(232, 27);
            IconMenuUsersForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuUsersForm.Click += IconMenuUsersForm_Click;
            // 
            // IconMenuProyectsForm
            // 
            IconMenuProyectsForm.AutoSize = false;
            IconMenuProyectsForm.BackgroundImageLayout = ImageLayout.None;
            IconMenuProyectsForm.Font = new Font("Segoe UI", 10.2F);
            IconMenuProyectsForm.IconChar = FontAwesome.Sharp.IconChar.Compass;
            IconMenuProyectsForm.IconColor = Color.Black;
            IconMenuProyectsForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuProyectsForm.IconSize = 28;
            IconMenuProyectsForm.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuProyectsForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuProyectsForm.Name = "IconMenuProyectsForm";
            IconMenuProyectsForm.Size = new Size(232, 27);
            IconMenuProyectsForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuProyectsForm.Click += IconMenuProyectsForm_Click;
            // 
            // iconMenuItemRequestClientProjects
            // 
            iconMenuItemRequestClientProjects.BackgroundImageLayout = ImageLayout.None;
            iconMenuItemRequestClientProjects.Font = new Font("Segoe UI", 10.2F);
            iconMenuItemRequestClientProjects.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            iconMenuItemRequestClientProjects.IconColor = Color.Black;
            iconMenuItemRequestClientProjects.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemRequestClientProjects.IconSize = 28;
            iconMenuItemRequestClientProjects.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemRequestClientProjects.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemRequestClientProjects.Name = "iconMenuItemRequestClientProjects";
            iconMenuItemRequestClientProjects.Size = new Size(63, 32);
            iconMenuItemRequestClientProjects.TextImageRelation = TextImageRelation.Overlay;
            // 
            // iconMenuItemProjectsEmployee
            // 
            iconMenuItemProjectsEmployee.BackgroundImageLayout = ImageLayout.None;
            iconMenuItemProjectsEmployee.Font = new Font("Segoe UI", 10.2F);
            iconMenuItemProjectsEmployee.IconChar = FontAwesome.Sharp.IconChar.Compass;
            iconMenuItemProjectsEmployee.IconColor = Color.Black;
            iconMenuItemProjectsEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemProjectsEmployee.IconSize = 28;
            iconMenuItemProjectsEmployee.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemProjectsEmployee.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemProjectsEmployee.Name = "iconMenuItemProjectsEmployee";
            iconMenuItemProjectsEmployee.Size = new Size(63, 32);
            iconMenuItemProjectsEmployee.TextImageRelation = TextImageRelation.Overlay;
            // 
            // IconMenuRecordForm
            // 
            IconMenuRecordForm.AutoSize = false;
            IconMenuRecordForm.BackgroundImageLayout = ImageLayout.None;
            IconMenuRecordForm.Font = new Font("Segoe UI", 10.2F);
            IconMenuRecordForm.IconChar = FontAwesome.Sharp.IconChar.Poll;
            IconMenuRecordForm.IconColor = Color.Black;
            IconMenuRecordForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuRecordForm.IconSize = 28;
            IconMenuRecordForm.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuRecordForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuRecordForm.Name = "IconMenuRecordForm";
            IconMenuRecordForm.Size = new Size(232, 27);
            IconMenuRecordForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuRecordForm.Click += IconMenuRecordForm_Click;
            // 
            // IconMenusSettingsForm
            // 
            IconMenusSettingsForm.AutoSize = false;
            IconMenusSettingsForm.BackgroundImageLayout = ImageLayout.None;
            IconMenusSettingsForm.Font = new Font("Segoe UI", 10.2F);
            IconMenusSettingsForm.IconChar = FontAwesome.Sharp.IconChar.Stream;
            IconMenusSettingsForm.IconColor = Color.Black;
            IconMenusSettingsForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenusSettingsForm.IconSize = 28;
            IconMenusSettingsForm.ImageScaling = ToolStripItemImageScaling.None;
            IconMenusSettingsForm.Margin = new Padding(0, 20, 0, 0);
            IconMenusSettingsForm.Name = "IconMenusSettingsForm";
            IconMenusSettingsForm.Size = new Size(232, 27);
            IconMenusSettingsForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenusSettingsForm.Click += IconMenusSettingsForm_Click;
            // 
            // IconMenuAccountForm
            // 
            IconMenuAccountForm.AutoSize = false;
            IconMenuAccountForm.BackgroundImageLayout = ImageLayout.None;
            IconMenuAccountForm.Font = new Font("Segoe UI", 10.2F);
            IconMenuAccountForm.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            IconMenuAccountForm.IconColor = Color.Black;
            IconMenuAccountForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuAccountForm.IconSize = 28;
            IconMenuAccountForm.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuAccountForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuAccountForm.Name = "IconMenuAccountForm";
            IconMenuAccountForm.Size = new Size(232, 27);
            IconMenuAccountForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuAccountForm.Click += IconMenuAccountForm_Click;
            // 
            // iconMenuItemMenus
            // 
            iconMenuItemMenus.AutoSize = false;
            iconMenuItemMenus.BackgroundImageLayout = ImageLayout.None;
            iconMenuItemMenus.Font = new Font("Segoe UI", 10.2F);
            iconMenuItemMenus.IconChar = FontAwesome.Sharp.IconChar.Node;
            iconMenuItemMenus.IconColor = Color.Black;
            iconMenuItemMenus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemMenus.IconSize = 28;
            iconMenuItemMenus.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemMenus.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemMenus.Name = "iconMenuItemMenus";
            iconMenuItemMenus.Size = new Size(232, 27);
            iconMenuItemMenus.TextImageRelation = TextImageRelation.Overlay;
            iconMenuItemMenus.Click += iconMenuItemMenus_Click;
            // 
            // iconMenuItemConfigurationEmployee
            // 
            iconMenuItemConfigurationEmployee.AutoSize = false;
            iconMenuItemConfigurationEmployee.BackgroundImageLayout = ImageLayout.None;
            iconMenuItemConfigurationEmployee.Font = new Font("Segoe UI", 10.2F);
            iconMenuItemConfigurationEmployee.IconChar = FontAwesome.Sharp.IconChar.Stop;
            iconMenuItemConfigurationEmployee.IconColor = Color.Black;
            iconMenuItemConfigurationEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemConfigurationEmployee.IconSize = 28;
            iconMenuItemConfigurationEmployee.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemConfigurationEmployee.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemConfigurationEmployee.Name = "iconMenuItemConfigurationEmployee";
            iconMenuItemConfigurationEmployee.Size = new Size(232, 27);
            iconMenuItemConfigurationEmployee.TextImageRelation = TextImageRelation.Overlay;
            iconMenuItemConfigurationEmployee.Click += iconMenuItemConfigurationEmployee_Click;
            // 
            // iconMenuItemConfigurationUserClient
            // 
            iconMenuItemConfigurationUserClient.AutoSize = false;
            iconMenuItemConfigurationUserClient.BackgroundImageLayout = ImageLayout.None;
            iconMenuItemConfigurationUserClient.Font = new Font("Segoe UI", 10.2F);
            iconMenuItemConfigurationUserClient.IconChar = FontAwesome.Sharp.IconChar.StripeS;
            iconMenuItemConfigurationUserClient.IconColor = Color.Black;
            iconMenuItemConfigurationUserClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemConfigurationUserClient.IconSize = 28;
            iconMenuItemConfigurationUserClient.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemConfigurationUserClient.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemConfigurationUserClient.Name = "iconMenuItemConfigurationUserClient";
            iconMenuItemConfigurationUserClient.Size = new Size(232, 27);
            iconMenuItemConfigurationUserClient.TextImageRelation = TextImageRelation.Overlay;
            iconMenuItemConfigurationUserClient.Click += iconMenuItemConfigurationUserClient_Click;
            // 
            // contenedor
            // 
            contenedor.BackColor = Color.WhiteSmoke;
            contenedor.Controls.Add(groupBox1);
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(73, 62);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1355, 810);
            contenedor.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblHoraUsuario);
            groupBox1.Controls.Add(panelUsersView);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(panel8);
            groupBox1.Controls.Add(panelInfoUsers);
            groupBox1.Controls.Add(labelUserAccount);
            groupBox1.Controls.Add(panelPrijectsAssignament);
            groupBox1.Location = new Point(6, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1346, 801);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inicio";
            // 
            // panelUsersView
            // 
            panelUsersView.BackColor = Color.MediumTurquoise;
            panelUsersView.Controls.Add(panel10);
            panelUsersView.Controls.Add(label7);
            panelUsersView.Controls.Add(panel9);
            panelUsersView.Controls.Add(panel7);
            panelUsersView.Controls.Add(panel6);
            panelUsersView.Controls.Add(labelnameUser);
            panelUsersView.Controls.Add(label3);
            panelUsersView.Controls.Add(labelCity);
            panelUsersView.Controls.Add(labelCountryByUser);
            panelUsersView.Controls.Add(labelByAgeUser);
            panelUsersView.Controls.Add(pictureBoxSelectedUser);
            panelUsersView.Controls.Add(labelByUser);
            panelUsersView.Dock = DockStyle.Right;
            panelUsersView.Location = new Point(918, 22);
            panelUsersView.Name = "panelUsersView";
            panelUsersView.Size = new Size(425, 776);
            panelUsersView.TabIndex = 6;
            panelUsersView.Visible = false;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BackColor = Color.DarkCyan;
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Location = new Point(17, 669);
            panel10.Name = "panel10";
            panel10.Size = new Size(397, 104);
            panel10.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(128, 96);
            label7.Name = "label7";
            label7.Size = new Size(15, 23);
            label7.TabIndex = 19;
            label7.Text = ",";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.DarkCyan;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(labelRegistration);
            panel9.Controls.Add(labelNumberPhone);
            panel9.Controls.Add(labelEmail);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(label9);
            panel9.Controls.Add(label8);
            panel9.Controls.Add(label6);
            panel9.Location = new Point(17, 488);
            panel9.Name = "panel9";
            panel9.Size = new Size(397, 159);
            panel9.TabIndex = 5;
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            labelRegistration.ForeColor = Color.White;
            labelRegistration.Location = new Point(220, 123);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(69, 21);
            labelRegistration.TabIndex = 25;
            labelRegistration.Text = "registro";
            // 
            // labelNumberPhone
            // 
            labelNumberPhone.AutoSize = true;
            labelNumberPhone.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            labelNumberPhone.ForeColor = Color.White;
            labelNumberPhone.Location = new Point(115, 88);
            labelNumberPhone.Name = "labelNumberPhone";
            labelNumberPhone.Size = new Size(66, 21);
            labelNumberPhone.TabIndex = 24;
            labelNumberPhone.Text = "celular";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(94, 51);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(71, 21);
            labelEmail.TabIndex = 23;
            labelEmail.Text = "Correo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(15, 121);
            label10.Name = "label10";
            label10.Size = new Size(203, 23);
            label10.TabIndex = 22;
            label10.Text = "Fecha de creacion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(15, 88);
            label9.Name = "label9";
            label9.Size = new Size(99, 23);
            label9.TabIndex = 21;
            label9.Text = "Telefono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 51);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 20;
            label8.Text = "Correo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(241, 23);
            label6.TabIndex = 20;
            label6.Text = "Informacion del usuario";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.DarkCyan;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(pictureBox6);
            panel7.Controls.Add(listBoxRequestProjects);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(17, 323);
            panel7.Name = "panel7";
            panel7.Size = new Size(397, 122);
            panel7.TabIndex = 4;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.Proyecto;
            pictureBox6.Location = new Point(12, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(74, 98);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // listBoxRequestProjects
            // 
            listBoxRequestProjects.BorderStyle = BorderStyle.None;
            listBoxRequestProjects.Font = new Font("Century Gothic", 9F, FontStyle.Italic);
            listBoxRequestProjects.FormattingEnabled = true;
            listBoxRequestProjects.ItemHeight = 18;
            listBoxRequestProjects.Items.AddRange(new object[] { "prueba1", "prueba2", "prueba3", "prueba4", "prueba5" });
            listBoxRequestProjects.Location = new Point(109, 47);
            listBoxRequestProjects.Name = "listBoxRequestProjects";
            listBoxRequestProjects.Size = new Size(251, 54);
            listBoxRequestProjects.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(109, 12);
            label4.Name = "label4";
            label4.Size = new Size(216, 23);
            label4.TabIndex = 20;
            label4.Text = "Proyectos solicitados";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.DarkCyan;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(listBoxProjectsAsignamment);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(17, 157);
            panel6.Name = "panel6";
            panel6.Size = new Size(397, 116);
            panel6.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.projects_icon_142976;
            pictureBox4.Location = new Point(12, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(74, 98);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // listBoxProjectsAsignamment
            // 
            listBoxProjectsAsignamment.BorderStyle = BorderStyle.None;
            listBoxProjectsAsignamment.Font = new Font("Century Gothic", 9F, FontStyle.Italic);
            listBoxProjectsAsignamment.FormattingEnabled = true;
            listBoxProjectsAsignamment.ItemHeight = 18;
            listBoxProjectsAsignamment.Items.AddRange(new object[] { "prueba1", "prueba2", "prueba3", "prueba4", "prueba5" });
            listBoxProjectsAsignamment.Location = new Point(109, 47);
            listBoxProjectsAsignamment.Name = "listBoxProjectsAsignamment";
            listBoxProjectsAsignamment.Size = new Size(251, 54);
            listBoxProjectsAsignamment.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(109, 6);
            label5.Name = "label5";
            label5.Size = new Size(212, 23);
            label5.TabIndex = 19;
            label5.Text = "Proyectos asignados";
            // 
            // labelnameUser
            // 
            labelnameUser.AutoSize = true;
            labelnameUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelnameUser.ForeColor = Color.White;
            labelnameUser.Location = new Point(99, 68);
            labelnameUser.Name = "labelnameUser";
            labelnameUser.Size = new Size(70, 23);
            labelnameUser.TabIndex = 18;
            labelnameUser.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(262, 97);
            label3.Name = "label3";
            label3.Size = new Size(15, 23);
            label3.TabIndex = 17;
            label3.Text = ",";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.BackColor = Color.Transparent;
            labelCity.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelCity.ForeColor = Color.RoyalBlue;
            labelCity.Location = new Point(274, 96);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(49, 23);
            labelCity.TabIndex = 16;
            labelCity.Text = "City";
            // 
            // labelCountryByUser
            // 
            labelCountryByUser.AutoSize = true;
            labelCountryByUser.BackColor = Color.Transparent;
            labelCountryByUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelCountryByUser.ForeColor = Color.RoyalBlue;
            labelCountryByUser.Location = new Point(149, 96);
            labelCountryByUser.Name = "labelCountryByUser";
            labelCountryByUser.Size = new Size(114, 23);
            labelCountryByUser.TabIndex = 12;
            labelCountryByUser.Text = "El salvador";
            // 
            // labelByAgeUser
            // 
            labelByAgeUser.AutoSize = true;
            labelByAgeUser.BackColor = Color.Transparent;
            labelByAgeUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelByAgeUser.ForeColor = Color.RoyalBlue;
            labelByAgeUser.Location = new Point(99, 96);
            labelByAgeUser.Name = "labelByAgeUser";
            labelByAgeUser.Size = new Size(49, 23);
            labelByAgeUser.TabIndex = 11;
            labelByAgeUser.Text = "age";
            // 
            // pictureBoxSelectedUser
            // 
            pictureBoxSelectedUser.BackColor = Color.Transparent;
            pictureBoxSelectedUser.Cursor = Cursors.Hand;
            pictureBoxSelectedUser.Image = Properties.Resources.user_icon_icons_com_57997;
            pictureBoxSelectedUser.Location = new Point(17, 68);
            pictureBoxSelectedUser.Name = "pictureBoxSelectedUser";
            pictureBoxSelectedUser.Size = new Size(58, 51);
            pictureBoxSelectedUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSelectedUser.TabIndex = 10;
            pictureBoxSelectedUser.TabStop = false;
            pictureBoxSelectedUser.Click += pictureBoxSelectedUser_Click;
            // 
            // labelByUser
            // 
            labelByUser.AutoSize = true;
            labelByUser.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelByUser.ForeColor = Color.White;
            labelByUser.Location = new Point(17, 22);
            labelByUser.Name = "labelByUser";
            labelByUser.Size = new Size(72, 34);
            labelByUser.TabIndex = 9;
            labelByUser.Text = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(257, 27);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido de nuevo ";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(label11);
            panel8.Location = new Point(19, 580);
            panel8.Name = "panel8";
            panel8.Size = new Size(877, 217);
            panel8.TabIndex = 3;
            // 
            // label11
            // 
            label11.Location = new Point(129, 47);
            label11.Name = "label11";
            label11.Size = new Size(372, 81);
            label11.TabIndex = 0;
            label11.Text = "Aca lo mas probable que vaya graficas y estadisticas sobre los proyectos que mas piden los clientes y eso si es que no me da huevaxd";
            // 
            // panelInfoUsers
            // 
            panelInfoUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelInfoUsers.BorderStyle = BorderStyle.Fixed3D;
            panelInfoUsers.Controls.Add(dataGridViewUsers);
            panelInfoUsers.Controls.Add(iconButtonUserClients);
            panelInfoUsers.Controls.Add(iconButtonUserAdministrator);
            panelInfoUsers.Controls.Add(iconButtonUserEmployee);
            panelInfoUsers.Location = new Point(19, 252);
            panelInfoUsers.Name = "panelInfoUsers";
            panelInfoUsers.Size = new Size(877, 289);
            panelInfoUsers.TabIndex = 3;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { viewUser });
            dataGridViewUsers.Location = new Point(293, 0);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(577, 306);
            dataGridViewUsers.TabIndex = 7;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // viewUser
            // 
            viewUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            viewUser.HeaderText = "Ver";
            viewUser.MinimumWidth = 6;
            viewUser.Name = "viewUser";
            viewUser.Resizable = DataGridViewTriState.False;
            viewUser.Width = 50;
            // 
            // iconButtonUserClients
            // 
            iconButtonUserClients.BackColor = Color.LightSeaGreen;
            iconButtonUserClients.Cursor = Cursors.Hand;
            iconButtonUserClients.FlatStyle = FlatStyle.Flat;
            iconButtonUserClients.ForeColor = Color.White;
            iconButtonUserClients.IconChar = FontAwesome.Sharp.IconChar.Uber;
            iconButtonUserClients.IconColor = Color.White;
            iconButtonUserClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonUserClients.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonUserClients.Location = new Point(22, 215);
            iconButtonUserClients.Name = "iconButtonUserClients";
            iconButtonUserClients.Size = new Size(250, 58);
            iconButtonUserClients.TabIndex = 6;
            iconButtonUserClients.Text = "Clientes";
            iconButtonUserClients.UseVisualStyleBackColor = false;
            iconButtonUserClients.Click += iconButtonUserClients_Click;
            // 
            // iconButtonUserAdministrator
            // 
            iconButtonUserAdministrator.BackColor = Color.LightSeaGreen;
            iconButtonUserAdministrator.Cursor = Cursors.Hand;
            iconButtonUserAdministrator.FlatStyle = FlatStyle.Flat;
            iconButtonUserAdministrator.ForeColor = Color.White;
            iconButtonUserAdministrator.IconChar = FontAwesome.Sharp.IconChar.Uber;
            iconButtonUserAdministrator.IconColor = Color.White;
            iconButtonUserAdministrator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonUserAdministrator.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonUserAdministrator.Location = new Point(22, 28);
            iconButtonUserAdministrator.Name = "iconButtonUserAdministrator";
            iconButtonUserAdministrator.Size = new Size(250, 58);
            iconButtonUserAdministrator.TabIndex = 5;
            iconButtonUserAdministrator.Text = "Administradores";
            iconButtonUserAdministrator.UseVisualStyleBackColor = false;
            iconButtonUserAdministrator.Click += iconButtonUserAdministrator_Click;
            // 
            // iconButtonUserEmployee
            // 
            iconButtonUserEmployee.BackColor = Color.LightSeaGreen;
            iconButtonUserEmployee.Cursor = Cursors.Hand;
            iconButtonUserEmployee.FlatStyle = FlatStyle.Flat;
            iconButtonUserEmployee.ForeColor = Color.White;
            iconButtonUserEmployee.IconChar = FontAwesome.Sharp.IconChar.Uber;
            iconButtonUserEmployee.IconColor = Color.White;
            iconButtonUserEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonUserEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonUserEmployee.Location = new Point(22, 121);
            iconButtonUserEmployee.Name = "iconButtonUserEmployee";
            iconButtonUserEmployee.Size = new Size(250, 58);
            iconButtonUserEmployee.TabIndex = 4;
            iconButtonUserEmployee.Text = "Empleados";
            iconButtonUserEmployee.UseVisualStyleBackColor = false;
            iconButtonUserEmployee.Click += iconButtonUserEmployee_Click;
            // 
            // labelUserAccount
            // 
            labelUserAccount.AutoSize = true;
            labelUserAccount.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            labelUserAccount.Location = new Point(268, 21);
            labelUserAccount.Name = "labelUserAccount";
            labelUserAccount.Size = new Size(125, 27);
            labelUserAccount.TabIndex = 1;
            labelUserAccount.Text = "nameUser";
            // 
            // panelPrijectsAssignament
            // 
            panelPrijectsAssignament.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPrijectsAssignament.BorderStyle = BorderStyle.Fixed3D;
            panelPrijectsAssignament.Controls.Add(pictureBox2);
            panelPrijectsAssignament.Controls.Add(pictureBox1);
            panelPrijectsAssignament.Location = new Point(19, 79);
            panelPrijectsAssignament.Name = "panelPrijectsAssignament";
            panelPrijectsAssignament.Size = new Size(872, 158);
            panelPrijectsAssignament.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.LightGray;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(575, 154);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.rimuru2;
            pictureBox1.Location = new Point(598, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1428, 872);
            Controls.Add(contenedor);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Name = "MenuForm";
            Text = "ProyectosSV";
            WindowState = FormWindowState.Maximized;
            Load += MenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageByIdUser).EndInit();
            panel2.ResumeLayout(false);
            menu.ResumeLayout(false);
            menu.PerformLayout();
            contenedor.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelUsersView.ResumeLayout(false);
            panelUsersView.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedUser).EndInit();
            panel8.ResumeLayout(false);
            panelInfoUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panelPrijectsAssignament.ResumeLayout(false);
            panelPrijectsAssignament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel3;
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
        private Label label1;
        private Panel panelPrijectsAssignament;
        private Label labelUserAccount;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemHome;
        private Panel panel8;
        private Panel panelInfoUsers;
        private Panel panelUsersView;
        private FontAwesome.Sharp.IconButton iconButtonUserAdministrator;
        private DataGridView dataGridViewUsers;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButtonUserEmployee;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButtonUserClients;
        private DataGridViewButtonColumn viewUser;
        private Label labelCountryByUser;
        private Label labelByAgeUser;
        private PictureBox pictureBoxSelectedUser;
        private Label labelByUser;
        private Label label3;
        private Label labelCity;
        private Label label5;
        private Label labelnameUser;
        private Panel panel9;
        private Label label6;
        private Panel panel7;
        private Label label4;
        private Panel panel6;
        private ListBox listBoxProjectsAsignamment;
        private Label label7;
        private PictureBox pictureBox6;
        private ListBox listBoxRequestProjects;
        private Label labelRegistration;
        private Label labelNumberPhone;
        private Label labelEmail;
        private Label label10;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox4;
        private Label label11;
        private Panel panel10;
        public PictureBox pictureBoxImageByIdUser;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemConfigurationEmployee;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemConfigurationUserClient;
    }
}