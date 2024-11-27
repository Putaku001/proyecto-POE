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
            idUserPictureBox = new PictureBox();
            timeUserLabel = new Label();
            menuPerfilPanel = new Panel();
            logoutLabel = new Label();
            menu = new MenuStrip();
            IconMenuItemHome = new FontAwesome.Sharp.IconMenuItem();
            IconMenuUsersForm = new FontAwesome.Sharp.IconMenuItem();
            IconMenuProyectsForm = new FontAwesome.Sharp.IconMenuItem();
            IconMenuItemRequestClientProjects = new FontAwesome.Sharp.IconMenuItem();
            IconMenuItemProjectsEmployee = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            IconMenuRecordForm = new FontAwesome.Sharp.IconMenuItem();
            IconMenusSettingsForm = new FontAwesome.Sharp.IconMenuItem();
            IconMenuAccountForm = new FontAwesome.Sharp.IconMenuItem();
            IconMenuItemMenus = new FontAwesome.Sharp.IconMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            containerPanel = new Panel();
            menuGroupBox = new GroupBox();
            userAccountLabel = new Label();
            panelUsersView = new Panel();
            informationPanel = new Panel();
            registrationLabel = new Label();
            numberPhoneLabel = new Label();
            emailIdUserLabel = new Label();
            dateCreateLabel = new Label();
            phoneNumberLabel = new Label();
            emailLabel = new Label();
            userInformationIdLabel = new Label();
            nameUserLabel = new Label();
            cityLabel = new Label();
            countryUserLabel = new Label();
            ageUserLabel = new Label();
            selectedUserPictureBox = new PictureBox();
            idUserLabel = new Label();
            welcomeLabel = new Label();
            projectPanel = new Panel();
            requestProjectPanel = new Panel();
            projectRequestedPictureBox = new PictureBox();
            requestProjectListBox = new ListBox();
            projectRequestedLabel = new Label();
            assignedProjectPanel = new Panel();
            assignedProjectPictureBox = new PictureBox();
            assignedProjectListBox = new ListBox();
            assignedProjectLabel = new Label();
            informationUserPanel = new Panel();
            userDataGridView = new DataGridView();
            viewUser = new DataGridViewButtonColumn();
            clientUserButton = new FontAwesome.Sharp.IconButton();
            administratorUserButton = new FontAwesome.Sharp.IconButton();
            employeeUserButton = new FontAwesome.Sharp.IconButton();
            toolTip1 = new ToolTip(components);
            nameUserIdLabel = new Label();
            closedPictureBox = new PictureBox();
            minimizarPictureBox = new PictureBox();
            nameUserPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)idUserPictureBox).BeginInit();
            menuPerfilPanel.SuspendLayout();
            menu.SuspendLayout();
            containerPanel.SuspendLayout();
            menuGroupBox.SuspendLayout();
            panelUsersView.SuspendLayout();
            informationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedUserPictureBox).BeginInit();
            projectPanel.SuspendLayout();
            requestProjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectRequestedPictureBox).BeginInit();
            assignedProjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)assignedProjectPictureBox).BeginInit();
            informationUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closedPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizarPictureBox).BeginInit();
            nameUserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // idUserPictureBox
            // 
            idUserPictureBox.BackColor = Color.FromArgb(46, 54, 61);
            idUserPictureBox.Image = Properties.Resources.usuario__5_;
            idUserPictureBox.Location = new Point(72, 36);
            idUserPictureBox.Name = "idUserPictureBox";
            idUserPictureBox.Size = new Size(126, 121);
            idUserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            idUserPictureBox.TabIndex = 6;
            idUserPictureBox.TabStop = false;
            // 
            // timeUserLabel
            // 
            timeUserLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timeUserLabel.AutoSize = true;
            timeUserLabel.BackColor = Color.White;
            timeUserLabel.Font = new Font("Century Gothic", 12F);
            timeUserLabel.ForeColor = Color.Black;
            timeUserLabel.Location = new Point(892, 26);
            timeUserLabel.Name = "timeUserLabel";
            timeUserLabel.Size = new Size(68, 30);
            timeUserLabel.TabIndex = 5;
            timeUserLabel.Text = "Hora";
            // 
            // menuPerfilPanel
            // 
            menuPerfilPanel.BackColor = Color.FromArgb(46, 54, 61);
            menuPerfilPanel.Controls.Add(logoutLabel);
            menuPerfilPanel.Controls.Add(idUserPictureBox);
            menuPerfilPanel.Controls.Add(menu);
            menuPerfilPanel.Dock = DockStyle.Left;
            menuPerfilPanel.Location = new Point(0, 0);
            menuPerfilPanel.Name = "menuPerfilPanel";
            menuPerfilPanel.Size = new Size(284, 995);
            menuPerfilPanel.TabIndex = 4;
            // 
            // logoutLabel
            // 
            logoutLabel.AutoSize = true;
            logoutLabel.BackColor = Color.White;
            logoutLabel.Cursor = Cursors.Hand;
            logoutLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutLabel.ForeColor = Color.FromArgb(46, 54, 61);
            logoutLabel.Location = new Point(56, 770);
            logoutLabel.Name = "logoutLabel";
            logoutLabel.Size = new Size(151, 26);
            logoutLabel.TabIndex = 6;
            logoutLabel.Text = "Cerrar sesion";
            logoutLabel.Click += logoutLabel_Click;
            // 
            // menu
            // 
            menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menu.AutoSize = false;
            menu.BackColor = Color.FromArgb(46, 54, 61);
            menu.Dock = DockStyle.None;
            menu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu.ImageScalingSize = new Size(60, 60);
            menu.Items.AddRange(new ToolStripItem[] { IconMenuItemHome, IconMenuUsersForm, IconMenuProyectsForm, IconMenuItemRequestClientProjects, IconMenuItemProjectsEmployee, IconMenuRecordForm, IconMenusSettingsForm, IconMenuAccountForm, IconMenuItemMenus });
            menu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menu.Location = new Point(9, 176);
            menu.Name = "menu";
            menu.Size = new Size(272, 572);
            menu.TabIndex = 9;
            // 
            // IconMenuItemHome
            // 
            IconMenuItemHome.BackgroundImageLayout = ImageLayout.None;
            IconMenuItemHome.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconMenuItemHome.ForeColor = Color.White;
            IconMenuItemHome.IconChar = FontAwesome.Sharp.IconChar.House;
            IconMenuItemHome.IconColor = Color.White;
            IconMenuItemHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuItemHome.IconSize = 30;
            IconMenuItemHome.ImageAlign = ContentAlignment.MiddleLeft;
            IconMenuItemHome.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuItemHome.Margin = new Padding(0, 20, 0, 0);
            IconMenuItemHome.Name = "IconMenuItemHome";
            IconMenuItemHome.RightToLeft = RightToLeft.No;
            IconMenuItemHome.Size = new Size(265, 34);
            IconMenuItemHome.Text = "Menú Principal";
            IconMenuItemHome.TextImageRelation = TextImageRelation.Overlay;
            IconMenuItemHome.Click += iconMenuItemHome_Click;
            // 
            // IconMenuUsersForm
            // 
            IconMenuUsersForm.BackgroundImageLayout = ImageLayout.None;
            IconMenuUsersForm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconMenuUsersForm.ForeColor = Color.White;
            IconMenuUsersForm.IconChar = FontAwesome.Sharp.IconChar.User;
            IconMenuUsersForm.IconColor = Color.White;
            IconMenuUsersForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuUsersForm.IconSize = 30;
            IconMenuUsersForm.ImageAlign = ContentAlignment.MiddleLeft;
            IconMenuUsersForm.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuUsersForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuUsersForm.Name = "IconMenuUsersForm";
            IconMenuUsersForm.Size = new Size(265, 34);
            IconMenuUsersForm.Text = "Menú Usuario";
            IconMenuUsersForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuUsersForm.Click += iconMenuUsersForm_Click;
            // 
            // IconMenuProyectsForm
            // 
            IconMenuProyectsForm.BackgroundImageLayout = ImageLayout.None;
            IconMenuProyectsForm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconMenuProyectsForm.ForeColor = Color.White;
            IconMenuProyectsForm.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            IconMenuProyectsForm.IconColor = Color.White;
            IconMenuProyectsForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuProyectsForm.IconSize = 30;
            IconMenuProyectsForm.ImageAlign = ContentAlignment.MiddleLeft;
            IconMenuProyectsForm.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuProyectsForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuProyectsForm.Name = "IconMenuProyectsForm";
            IconMenuProyectsForm.Size = new Size(265, 34);
            IconMenuProyectsForm.Text = "Menú Proyectos";
            IconMenuProyectsForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuProyectsForm.Click += iconMenuProyectsForm_Click_1;
            // 
            // IconMenuItemRequestClientProjects
            // 
            IconMenuItemRequestClientProjects.BackgroundImageLayout = ImageLayout.None;
            IconMenuItemRequestClientProjects.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconMenuItemRequestClientProjects.ForeColor = Color.White;
            IconMenuItemRequestClientProjects.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            IconMenuItemRequestClientProjects.IconColor = Color.White;
            IconMenuItemRequestClientProjects.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuItemRequestClientProjects.IconSize = 30;
            IconMenuItemRequestClientProjects.ImageAlign = ContentAlignment.MiddleLeft;
            IconMenuItemRequestClientProjects.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuItemRequestClientProjects.Margin = new Padding(0, 20, 0, 0);
            IconMenuItemRequestClientProjects.Name = "IconMenuItemRequestClientProjects";
            IconMenuItemRequestClientProjects.Size = new Size(265, 34);
            IconMenuItemRequestClientProjects.Text = "Menú Cliente";
            IconMenuItemRequestClientProjects.TextImageRelation = TextImageRelation.Overlay;
            IconMenuItemRequestClientProjects.Click += iconMenuItemRequestClientProjects_Click;
            // 
            // IconMenuItemProjectsEmployee
            // 
            IconMenuItemProjectsEmployee.BackgroundImageLayout = ImageLayout.None;
            IconMenuItemProjectsEmployee.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1 });
            IconMenuItemProjectsEmployee.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconMenuItemProjectsEmployee.ForeColor = Color.White;
            IconMenuItemProjectsEmployee.IconChar = FontAwesome.Sharp.IconChar.Book;
            IconMenuItemProjectsEmployee.IconColor = Color.White;
            IconMenuItemProjectsEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuItemProjectsEmployee.IconSize = 30;
            IconMenuItemProjectsEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            IconMenuItemProjectsEmployee.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuItemProjectsEmployee.Margin = new Padding(0, 20, 0, 0);
            IconMenuItemProjectsEmployee.Name = "IconMenuItemProjectsEmployee";
            IconMenuItemProjectsEmployee.Size = new Size(265, 34);
            IconMenuItemProjectsEmployee.Text = "Menú Empleado";
            IconMenuItemProjectsEmployee.TextImageRelation = TextImageRelation.Overlay;
            IconMenuItemProjectsEmployee.Click += iconMenuItemProjectsEmployee_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(87, 6);
            // 
            // IconMenuRecordForm
            // 
            IconMenuRecordForm.BackgroundImageLayout = ImageLayout.None;
            IconMenuRecordForm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconMenuRecordForm.ForeColor = Color.White;
            IconMenuRecordForm.IconChar = FontAwesome.Sharp.IconChar.Poll;
            IconMenuRecordForm.IconColor = Color.White;
            IconMenuRecordForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuRecordForm.IconSize = 30;
            IconMenuRecordForm.ImageAlign = ContentAlignment.MiddleLeft;
            IconMenuRecordForm.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuRecordForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuRecordForm.Name = "IconMenuRecordForm";
            IconMenuRecordForm.Size = new Size(265, 34);
            IconMenuRecordForm.Text = "Registro";
            IconMenuRecordForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuRecordForm.Click += iconMenuRecordForm_Click;
            // 
            // IconMenusSettingsForm
            // 
            IconMenusSettingsForm.BackgroundImageLayout = ImageLayout.None;
            IconMenusSettingsForm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconMenusSettingsForm.ForeColor = Color.White;
            IconMenusSettingsForm.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            IconMenusSettingsForm.IconColor = Color.White;
            IconMenusSettingsForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenusSettingsForm.IconSize = 30;
            IconMenusSettingsForm.ImageAlign = ContentAlignment.MiddleLeft;
            IconMenusSettingsForm.ImageScaling = ToolStripItemImageScaling.None;
            IconMenusSettingsForm.Margin = new Padding(0, 20, 0, 0);
            IconMenusSettingsForm.Name = "IconMenusSettingsForm";
            IconMenusSettingsForm.Size = new Size(265, 34);
            IconMenusSettingsForm.Text = "Ajustes";
            IconMenusSettingsForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenusSettingsForm.Click += iconMenusSettingsForm_Click;
            // 
            // IconMenuAccountForm
            // 
            IconMenuAccountForm.BackgroundImageLayout = ImageLayout.None;
            IconMenuAccountForm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconMenuAccountForm.ForeColor = Color.White;
            IconMenuAccountForm.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            IconMenuAccountForm.IconColor = Color.White;
            IconMenuAccountForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuAccountForm.IconSize = 30;
            IconMenuAccountForm.ImageAlign = ContentAlignment.MiddleLeft;
            IconMenuAccountForm.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuAccountForm.Margin = new Padding(0, 20, 0, 0);
            IconMenuAccountForm.Name = "IconMenuAccountForm";
            IconMenuAccountForm.Size = new Size(265, 34);
            IconMenuAccountForm.Text = "Cuenta";
            IconMenuAccountForm.TextImageRelation = TextImageRelation.Overlay;
            IconMenuAccountForm.Click += iconMenuAccountForm_Click;
            // 
            // IconMenuItemMenus
            // 
            IconMenuItemMenus.BackgroundImageLayout = ImageLayout.None;
            IconMenuItemMenus.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconMenuItemMenus.ForeColor = Color.White;
            IconMenuItemMenus.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            IconMenuItemMenus.IconColor = Color.White;
            IconMenuItemMenus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconMenuItemMenus.IconSize = 30;
            IconMenuItemMenus.ImageAlign = ContentAlignment.MiddleLeft;
            IconMenuItemMenus.ImageScaling = ToolStripItemImageScaling.None;
            IconMenuItemMenus.Margin = new Padding(0, 20, 0, 0);
            IconMenuItemMenus.Name = "IconMenuItemMenus";
            IconMenuItemMenus.Size = new Size(265, 34);
            IconMenuItemMenus.Text = "Menú";
            IconMenuItemMenus.TextImageRelation = TextImageRelation.Overlay;
            IconMenuItemMenus.Click += iconMenuItemMenus_Click;
            // 
            // containerPanel
            // 
            containerPanel.BackColor = Color.WhiteSmoke;
            containerPanel.Controls.Add(menuGroupBox);
            containerPanel.Location = new Point(284, 95);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(1640, 935);
            containerPanel.TabIndex = 0;
            // 
            // menuGroupBox
            // 
            menuGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuGroupBox.Controls.Add(userAccountLabel);
            menuGroupBox.Controls.Add(timeUserLabel);
            menuGroupBox.Controls.Add(panelUsersView);
            menuGroupBox.Controls.Add(welcomeLabel);
            menuGroupBox.Controls.Add(projectPanel);
            menuGroupBox.Controls.Add(informationUserPanel);
            menuGroupBox.Location = new Point(22, 15);
            menuGroupBox.Name = "menuGroupBox";
            menuGroupBox.Size = new Size(1599, 869);
            menuGroupBox.TabIndex = 7;
            menuGroupBox.TabStop = false;
            menuGroupBox.Text = "Inicio";
            // 
            // userAccountLabel
            // 
            userAccountLabel.AutoSize = true;
            userAccountLabel.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userAccountLabel.Location = new Point(343, 21);
            userAccountLabel.Name = "userAccountLabel";
            userAccountLabel.Size = new Size(121, 34);
            userAccountLabel.TabIndex = 1;
            userAccountLabel.Text = "nombre";
            // 
            // panelUsersView
            // 
            panelUsersView.BackColor = Color.DodgerBlue;
            panelUsersView.Controls.Add(informationPanel);
            panelUsersView.Controls.Add(nameUserLabel);
            panelUsersView.Controls.Add(cityLabel);
            panelUsersView.Controls.Add(countryUserLabel);
            panelUsersView.Controls.Add(ageUserLabel);
            panelUsersView.Controls.Add(selectedUserPictureBox);
            panelUsersView.Controls.Add(idUserLabel);
            panelUsersView.Dock = DockStyle.Right;
            panelUsersView.Location = new Point(1131, 26);
            panelUsersView.Name = "panelUsersView";
            panelUsersView.Size = new Size(465, 840);
            panelUsersView.TabIndex = 6;
            panelUsersView.Visible = false;
            // 
            // informationPanel
            // 
            informationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            informationPanel.BackColor = Color.SteelBlue;
            informationPanel.BorderStyle = BorderStyle.Fixed3D;
            informationPanel.Controls.Add(registrationLabel);
            informationPanel.Controls.Add(numberPhoneLabel);
            informationPanel.Controls.Add(emailIdUserLabel);
            informationPanel.Controls.Add(dateCreateLabel);
            informationPanel.Controls.Add(phoneNumberLabel);
            informationPanel.Controls.Add(emailLabel);
            informationPanel.Controls.Add(userInformationIdLabel);
            informationPanel.Location = new Point(17, 158);
            informationPanel.Name = "informationPanel";
            informationPanel.Size = new Size(437, 497);
            informationPanel.TabIndex = 5;
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrationLabel.ForeColor = Color.White;
            registrationLabel.Location = new Point(18, 256);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(81, 23);
            registrationLabel.TabIndex = 25;
            registrationLabel.Text = "registro";
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberPhoneLabel.ForeColor = Color.White;
            numberPhoneLabel.Location = new Point(22, 196);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new Size(77, 23);
            numberPhoneLabel.TabIndex = 24;
            numberPhoneLabel.Text = "celular";
            // 
            // emailIdUserLabel
            // 
            emailIdUserLabel.AutoSize = true;
            emailIdUserLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailIdUserLabel.ForeColor = Color.White;
            emailIdUserLabel.Location = new Point(22, 123);
            emailIdUserLabel.Name = "emailIdUserLabel";
            emailIdUserLabel.Size = new Size(77, 23);
            emailIdUserLabel.TabIndex = 23;
            emailIdUserLabel.Text = "Correo";
            // 
            // dateCreateLabel
            // 
            dateCreateLabel.AutoSize = true;
            dateCreateLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateCreateLabel.ForeColor = Color.White;
            dateCreateLabel.Location = new Point(18, 228);
            dateCreateLabel.Name = "dateCreateLabel";
            dateCreateLabel.Size = new Size(240, 28);
            dateCreateLabel.TabIndex = 22;
            dateCreateLabel.Text = "Fecha de creacion:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneNumberLabel.ForeColor = Color.White;
            phoneNumberLabel.Location = new Point(18, 151);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(116, 28);
            phoneNumberLabel.TabIndex = 21;
            phoneNumberLabel.Text = "Telefono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(22, 83);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(99, 28);
            emailLabel.TabIndex = 20;
            emailLabel.Text = "Correo:";
            // 
            // userInformationIdLabel
            // 
            userInformationIdLabel.AutoSize = true;
            userInformationIdLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInformationIdLabel.ForeColor = Color.White;
            userInformationIdLabel.Location = new Point(60, 19);
            userInformationIdLabel.Name = "userInformationIdLabel";
            userInformationIdLabel.Size = new Size(287, 28);
            userInformationIdLabel.TabIndex = 20;
            userInformationIdLabel.Text = "Informacion del usuario";
            // 
            // nameUserLabel
            // 
            nameUserLabel.AutoSize = true;
            nameUserLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameUserLabel.ForeColor = Color.White;
            nameUserLabel.Location = new Point(99, 68);
            nameUserLabel.Name = "nameUserLabel";
            nameUserLabel.Size = new Size(107, 28);
            nameUserLabel.TabIndex = 18;
            nameUserLabel.Text = "Nombre";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = Color.Transparent;
            cityLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            cityLabel.ForeColor = Color.White;
            cityLabel.Location = new Point(283, 100);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(99, 28);
            cityLabel.TabIndex = 16;
            cityLabel.Text = "Ciudad";
            // 
            // countryUserLabel
            // 
            countryUserLabel.AutoSize = true;
            countryUserLabel.BackColor = Color.Transparent;
            countryUserLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            countryUserLabel.ForeColor = Color.White;
            countryUserLabel.Location = new Point(179, 100);
            countryUserLabel.Name = "countryUserLabel";
            countryUserLabel.Size = new Size(58, 28);
            countryUserLabel.TabIndex = 12;
            countryUserLabel.Text = "Pais";
            // 
            // ageUserLabel
            // 
            ageUserLabel.AutoSize = true;
            ageUserLabel.BackColor = Color.Transparent;
            ageUserLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ageUserLabel.ForeColor = Color.White;
            ageUserLabel.Location = new Point(95, 100);
            ageUserLabel.Name = "ageUserLabel";
            ageUserLabel.Size = new Size(59, 28);
            ageUserLabel.TabIndex = 11;
            ageUserLabel.Text = "age";
            // 
            // selectedUserPictureBox
            // 
            selectedUserPictureBox.BackColor = Color.Transparent;
            selectedUserPictureBox.Cursor = Cursors.Hand;
            selectedUserPictureBox.Image = Properties.Resources.cheque;
            selectedUserPictureBox.Location = new Point(17, 68);
            selectedUserPictureBox.Name = "selectedUserPictureBox";
            selectedUserPictureBox.Size = new Size(58, 51);
            selectedUserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            selectedUserPictureBox.TabIndex = 10;
            selectedUserPictureBox.TabStop = false;
            selectedUserPictureBox.Click += selectedUserPictureBox_Click;
            // 
            // idUserLabel
            // 
            idUserLabel.AutoSize = true;
            idUserLabel.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idUserLabel.ForeColor = Color.White;
            idUserLabel.Location = new Point(17, 22);
            idUserLabel.Name = "idUserLabel";
            idUserLabel.Size = new Size(129, 38);
            idUserLabel.TabIndex = 9;
            idUserLabel.Text = "Usuario";
            // 
            // welcomeLabel
            // 
            welcomeLabel.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(19, 21);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(318, 34);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Bienvenido de nuevo ";
            // 
            // projectPanel
            // 
            projectPanel.BorderStyle = BorderStyle.Fixed3D;
            projectPanel.Controls.Add(requestProjectPanel);
            projectPanel.Controls.Add(assignedProjectPanel);
            projectPanel.Location = new Point(8, 462);
            projectPanel.Name = "projectPanel";
            projectPanel.Size = new Size(1112, 388);
            projectPanel.TabIndex = 3;
            // 
            // requestProjectPanel
            // 
            requestProjectPanel.BackColor = Color.DodgerBlue;
            requestProjectPanel.BorderStyle = BorderStyle.Fixed3D;
            requestProjectPanel.Controls.Add(projectRequestedPictureBox);
            requestProjectPanel.Controls.Add(requestProjectListBox);
            requestProjectPanel.Controls.Add(projectRequestedLabel);
            requestProjectPanel.Location = new Point(22, 22);
            requestProjectPanel.Name = "requestProjectPanel";
            requestProjectPanel.Size = new Size(534, 342);
            requestProjectPanel.TabIndex = 4;
            requestProjectPanel.Visible = false;
            // 
            // projectRequestedPictureBox
            // 
            projectRequestedPictureBox.BackColor = Color.Transparent;
            projectRequestedPictureBox.Image = (Image)resources.GetObject("projectRequestedPictureBox.Image");
            projectRequestedPictureBox.Location = new Point(7, 66);
            projectRequestedPictureBox.Name = "projectRequestedPictureBox";
            projectRequestedPictureBox.Size = new Size(96, 132);
            projectRequestedPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            projectRequestedPictureBox.TabIndex = 23;
            projectRequestedPictureBox.TabStop = false;
            // 
            // requestProjectListBox
            // 
            requestProjectListBox.BorderStyle = BorderStyle.None;
            requestProjectListBox.Font = new Font("Century Gothic", 9F, FontStyle.Italic);
            requestProjectListBox.FormattingEnabled = true;
            requestProjectListBox.ItemHeight = 21;
            requestProjectListBox.Location = new Point(109, 45);
            requestProjectListBox.Name = "requestProjectListBox";
            requestProjectListBox.Size = new Size(406, 252);
            requestProjectListBox.TabIndex = 21;
            // 
            // projectRequestedLabel
            // 
            projectRequestedLabel.AutoSize = true;
            projectRequestedLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectRequestedLabel.ForeColor = Color.White;
            projectRequestedLabel.Location = new Point(109, 12);
            projectRequestedLabel.Name = "projectRequestedLabel";
            projectRequestedLabel.Size = new Size(256, 28);
            projectRequestedLabel.TabIndex = 20;
            projectRequestedLabel.Text = "Proyectos solicitados";
            // 
            // assignedProjectPanel
            // 
            assignedProjectPanel.BackColor = Color.DodgerBlue;
            assignedProjectPanel.BorderStyle = BorderStyle.Fixed3D;
            assignedProjectPanel.Controls.Add(assignedProjectPictureBox);
            assignedProjectPanel.Controls.Add(assignedProjectListBox);
            assignedProjectPanel.Controls.Add(assignedProjectLabel);
            assignedProjectPanel.Location = new Point(575, 22);
            assignedProjectPanel.Name = "assignedProjectPanel";
            assignedProjectPanel.Size = new Size(541, 342);
            assignedProjectPanel.TabIndex = 3;
            assignedProjectPanel.Visible = false;
            // 
            // assignedProjectPictureBox
            // 
            assignedProjectPictureBox.BackColor = Color.Transparent;
            assignedProjectPictureBox.Image = Properties.Resources.gestion_de_proyectos;
            assignedProjectPictureBox.Location = new Point(14, 84);
            assignedProjectPictureBox.Name = "assignedProjectPictureBox";
            assignedProjectPictureBox.Size = new Size(74, 98);
            assignedProjectPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            assignedProjectPictureBox.TabIndex = 24;
            assignedProjectPictureBox.TabStop = false;
            // 
            // assignedProjectListBox
            // 
            assignedProjectListBox.BorderStyle = BorderStyle.None;
            assignedProjectListBox.Font = new Font("Century Gothic", 9F, FontStyle.Italic);
            assignedProjectListBox.FormattingEnabled = true;
            assignedProjectListBox.ItemHeight = 21;
            assignedProjectListBox.Location = new Point(109, 45);
            assignedProjectListBox.Name = "assignedProjectListBox";
            assignedProjectListBox.Size = new Size(407, 252);
            assignedProjectListBox.TabIndex = 20;
            // 
            // assignedProjectLabel
            // 
            assignedProjectLabel.AutoSize = true;
            assignedProjectLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assignedProjectLabel.ForeColor = Color.White;
            assignedProjectLabel.Location = new Point(109, 6);
            assignedProjectLabel.Name = "assignedProjectLabel";
            assignedProjectLabel.Size = new Size(253, 28);
            assignedProjectLabel.TabIndex = 19;
            assignedProjectLabel.Text = "Proyectos asignados";
            // 
            // informationUserPanel
            // 
            informationUserPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            informationUserPanel.BorderStyle = BorderStyle.Fixed3D;
            informationUserPanel.Controls.Add(userDataGridView);
            informationUserPanel.Controls.Add(clientUserButton);
            informationUserPanel.Controls.Add(administratorUserButton);
            informationUserPanel.Controls.Add(employeeUserButton);
            informationUserPanel.Location = new Point(14, 80);
            informationUserPanel.Name = "informationUserPanel";
            informationUserPanel.Size = new Size(1106, 352);
            informationUserPanel.TabIndex = 3;
            // 
            // userDataGridView
            // 
            userDataGridView.AllowUserToDeleteRows = false;
            userDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userDataGridView.BackgroundColor = Color.White;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Columns.AddRange(new DataGridViewColumn[] { viewUser });
            userDataGridView.Location = new Point(293, 0);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.Size = new Size(806, 350);
            userDataGridView.TabIndex = 7;
            userDataGridView.CellClick += userDataGridView_CellClick;
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
            // clientUserButton
            // 
            clientUserButton.BackColor = Color.DodgerBlue;
            clientUserButton.Cursor = Cursors.Hand;
            clientUserButton.FlatStyle = FlatStyle.Flat;
            clientUserButton.ForeColor = Color.White;
            clientUserButton.IconChar = FontAwesome.Sharp.IconChar.Uber;
            clientUserButton.IconColor = Color.White;
            clientUserButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clientUserButton.ImageAlign = ContentAlignment.MiddleLeft;
            clientUserButton.Location = new Point(22, 215);
            clientUserButton.Name = "clientUserButton";
            clientUserButton.Size = new Size(250, 58);
            clientUserButton.TabIndex = 6;
            clientUserButton.Text = "Clientes";
            clientUserButton.UseVisualStyleBackColor = false;
            clientUserButton.Click += clientUserButton_Click;
            // 
            // administratorUserButton
            // 
            administratorUserButton.BackColor = Color.DodgerBlue;
            administratorUserButton.Cursor = Cursors.Hand;
            administratorUserButton.FlatStyle = FlatStyle.Flat;
            administratorUserButton.ForeColor = Color.White;
            administratorUserButton.IconChar = FontAwesome.Sharp.IconChar.Uber;
            administratorUserButton.IconColor = Color.White;
            administratorUserButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            administratorUserButton.ImageAlign = ContentAlignment.MiddleLeft;
            administratorUserButton.Location = new Point(22, 28);
            administratorUserButton.Name = "administratorUserButton";
            administratorUserButton.Size = new Size(250, 58);
            administratorUserButton.TabIndex = 5;
            administratorUserButton.Text = "Administradores";
            administratorUserButton.UseVisualStyleBackColor = false;
            administratorUserButton.Click += administratorUserButton_Click;
            // 
            // employeeUserButton
            // 
            employeeUserButton.BackColor = Color.DodgerBlue;
            employeeUserButton.Cursor = Cursors.Hand;
            employeeUserButton.FlatStyle = FlatStyle.Flat;
            employeeUserButton.ForeColor = Color.White;
            employeeUserButton.IconChar = FontAwesome.Sharp.IconChar.Uber;
            employeeUserButton.IconColor = Color.White;
            employeeUserButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            employeeUserButton.ImageAlign = ContentAlignment.MiddleLeft;
            employeeUserButton.Location = new Point(22, 121);
            employeeUserButton.Name = "employeeUserButton";
            employeeUserButton.Size = new Size(250, 58);
            employeeUserButton.TabIndex = 4;
            employeeUserButton.Text = "Empleados";
            employeeUserButton.UseVisualStyleBackColor = false;
            employeeUserButton.Click += employeeUserButton_Click;
            // 
            // nameUserIdLabel
            // 
            nameUserIdLabel.AutoSize = true;
            nameUserIdLabel.Font = new Font("Century Gothic", 12F);
            nameUserIdLabel.ForeColor = Color.White;
            nameUserIdLabel.Location = new Point(30, 26);
            nameUserIdLabel.Name = "nameUserIdLabel";
            nameUserIdLabel.Size = new Size(203, 30);
            nameUserIdLabel.TabIndex = 4;
            nameUserIdLabel.Text = "Nombre Usuario";
            // 
            // closedPictureBox
            // 
            closedPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closedPictureBox.Cursor = Cursors.Hand;
            closedPictureBox.Image = Properties.Resources.cerrar__2_;
            closedPictureBox.Location = new Point(1598, 3);
            closedPictureBox.Name = "closedPictureBox";
            closedPictureBox.Size = new Size(30, 44);
            closedPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            closedPictureBox.TabIndex = 7;
            closedPictureBox.TabStop = false;
            closedPictureBox.Click += closedPictureBox_Click;
            closedPictureBox.MouseHover += closedPictureBox_MouseHover;
            // 
            // minimizarPictureBox
            // 
            minimizarPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizarPictureBox.Cursor = Cursors.Hand;
            minimizarPictureBox.Image = (Image)resources.GetObject("minimizarPictureBox.Image");
            minimizarPictureBox.Location = new Point(1544, 3);
            minimizarPictureBox.Name = "minimizarPictureBox";
            minimizarPictureBox.Size = new Size(34, 44);
            minimizarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            minimizarPictureBox.TabIndex = 8;
            minimizarPictureBox.TabStop = false;
            minimizarPictureBox.Click += minimizarPictureBox_Click;
            minimizarPictureBox.MouseHover += minimizarPictureBox_MouseHover;
            // 
            // nameUserPanel
            // 
            nameUserPanel.BackColor = Color.FromArgb(46, 54, 61);
            nameUserPanel.Controls.Add(minimizarPictureBox);
            nameUserPanel.Controls.Add(closedPictureBox);
            nameUserPanel.Controls.Add(nameUserIdLabel);
            nameUserPanel.Dock = DockStyle.Top;
            nameUserPanel.Location = new Point(284, 0);
            nameUserPanel.Name = "nameUserPanel";
            nameUserPanel.Size = new Size(1640, 95);
            nameUserPanel.TabIndex = 2;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 995);
            Controls.Add(containerPanel);
            Controls.Add(nameUserPanel);
            Controls.Add(menuPerfilPanel);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProyectosSV";
            Load += MenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)idUserPictureBox).EndInit();
            menuPerfilPanel.ResumeLayout(false);
            menuPerfilPanel.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            containerPanel.ResumeLayout(false);
            menuGroupBox.ResumeLayout(false);
            menuGroupBox.PerformLayout();
            panelUsersView.ResumeLayout(false);
            panelUsersView.PerformLayout();
            informationPanel.ResumeLayout(false);
            informationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectedUserPictureBox).EndInit();
            projectPanel.ResumeLayout(false);
            requestProjectPanel.ResumeLayout(false);
            requestProjectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectRequestedPictureBox).EndInit();
            assignedProjectPanel.ResumeLayout(false);
            assignedProjectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)assignedProjectPictureBox).EndInit();
            informationUserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)closedPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizarPictureBox).EndInit();
            nameUserPanel.ResumeLayout(false);
            nameUserPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label timeUserLabel;
        private Panel menuPerfilPanel;
        private System.Windows.Forms.Timer timer1;
        private Panel containerPanel;
        private ToolTip toolTip1;
        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem IconMenuUsersForm;
        private FontAwesome.Sharp.IconMenuItem IconMenuProyectsForm;
        private FontAwesome.Sharp.IconMenuItem IconMenuRecordForm;
        private FontAwesome.Sharp.IconMenuItem IconMenusSettingsForm;
        private FontAwesome.Sharp.IconMenuItem IconMenuAccountForm;
        private FontAwesome.Sharp.IconMenuItem IconMenuItemProjectsEmployee;
        private FontAwesome.Sharp.IconMenuItem IconMenuItemRequestClientProjects;
        private FontAwesome.Sharp.IconMenuItem IconMenuItemMenus;
        private Label welcomeLabel;
        private Label userAccountLabel;
        private FontAwesome.Sharp.IconMenuItem IconMenuItemHome;
        private Panel projectPanel;
        private Panel informationUserPanel;
        private Panel panelUsersView;
        private FontAwesome.Sharp.IconButton administratorUserButton;
        private DataGridView userDataGridView;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton employeeUserButton;
        private GroupBox menuGroupBox;
        private FontAwesome.Sharp.IconButton clientUserButton;
        private DataGridViewButtonColumn viewUser;
        private Label countryUserLabel;
        private Label ageUserLabel;
        private PictureBox selectedUserPictureBox;
        private Label idUserLabel;
        private Label cityLabel;
        private Label nameUserLabel;
        private Panel informationPanel;
        private Label userInformationIdLabel;
        private Label registrationLabel;
        private Label numberPhoneLabel;
        private Label emailIdUserLabel;
        private Label dateCreateLabel;
        private Label phoneNumberLabel;
        private Label emailLabel;
        public PictureBox idUserPictureBox;
        private Panel requestProjectPanel;
        private PictureBox projectRequestedPictureBox;
        private ListBox requestProjectListBox;
        private Label projectRequestedLabel;
        private Panel assignedProjectPanel;
        private PictureBox assignedProjectPictureBox;
        private ListBox assignedProjectListBox;
        private Label assignedProjectLabel;
        private Label nameUserIdLabel;
        private PictureBox closedPictureBox;
        private PictureBox minimizarPictureBox;
        private Label logoutLabel;
        private Panel nameUserPanel;
        private ToolStripSeparator toolStripSeparator1;
    }
}