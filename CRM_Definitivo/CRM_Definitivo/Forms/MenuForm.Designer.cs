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
            iconMenuItemHome = new FontAwesome.Sharp.IconMenuItem();
            iconMenuUsersForm = new FontAwesome.Sharp.IconMenuItem();
            iconMenuProyectsForm = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemRequestClientProjects = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemProjectsEmployee = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            iconMenuRecordForm = new FontAwesome.Sharp.IconMenuItem();
            iconMenusSettingsForm = new FontAwesome.Sharp.IconMenuItem();
            iconMenuAccountForm = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemMenus = new FontAwesome.Sharp.IconMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            containerPanel = new Panel();
            menuGroupBox = new GroupBox();
            userAccountLabel = new Label();
            panelUsersView = new Panel();
            panel10 = new Panel();
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
            projectAssignamentPanel = new Panel();
            userPictureBox = new PictureBox();
            logoPictureBox = new PictureBox();
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
            projectAssignamentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
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
            timeUserLabel.Location = new Point(959, 26);
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
            menuPerfilPanel.Size = new Size(284, 1108);
            menuPerfilPanel.TabIndex = 4;
            // 
            // logoutLabel
            // 
            logoutLabel.AutoSize = true;
            logoutLabel.BackColor = Color.White;
            logoutLabel.Cursor = Cursors.Hand;
            logoutLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutLabel.ForeColor = Color.FromArgb(46, 54, 61);
            logoutLabel.Location = new Point(61, 749);
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
            menu.Items.AddRange(new ToolStripItem[] { iconMenuItemHome, iconMenuUsersForm, iconMenuProyectsForm, iconMenuItemRequestClientProjects, iconMenuItemProjectsEmployee, iconMenuRecordForm, iconMenusSettingsForm, iconMenuAccountForm, iconMenuItemMenus });
            menu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menu.Location = new Point(9, 176);
            menu.Name = "menu";
            menu.Size = new Size(268, 531);
            menu.TabIndex = 9;
            // 
            // iconMenuItemHome
            // 
            iconMenuItemHome.BackgroundImageLayout = ImageLayout.None;
            iconMenuItemHome.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItemHome.ForeColor = Color.White;
            iconMenuItemHome.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItemHome.IconColor = Color.White;
            iconMenuItemHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemHome.IconSize = 30;
            iconMenuItemHome.ImageAlign = ContentAlignment.MiddleLeft;
            iconMenuItemHome.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemHome.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemHome.Name = "iconMenuItemHome";
            iconMenuItemHome.RightToLeft = RightToLeft.No;
            iconMenuItemHome.Size = new Size(261, 34);
            iconMenuItemHome.Text = "Menú Principal";
            iconMenuItemHome.TextImageRelation = TextImageRelation.Overlay;
            iconMenuItemHome.Click += iconMenuItemHome_Click;
            // 
            // iconMenuUsersForm
            // 
            iconMenuUsersForm.BackgroundImageLayout = ImageLayout.None;
            iconMenuUsersForm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuUsersForm.ForeColor = Color.White;
            iconMenuUsersForm.IconChar = FontAwesome.Sharp.IconChar.User;
            iconMenuUsersForm.IconColor = Color.White;
            iconMenuUsersForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuUsersForm.IconSize = 30;
            iconMenuUsersForm.ImageAlign = ContentAlignment.MiddleLeft;
            iconMenuUsersForm.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuUsersForm.Margin = new Padding(0, 20, 0, 0);
            iconMenuUsersForm.Name = "iconMenuUsersForm";
            iconMenuUsersForm.Size = new Size(261, 34);
            iconMenuUsersForm.Text = "Menú Usuario";
            iconMenuUsersForm.TextImageRelation = TextImageRelation.Overlay;
            iconMenuUsersForm.Click += iconMenuUsersForm_Click;
            // 
            // iconMenuProyectsForm
            // 
            iconMenuProyectsForm.BackgroundImageLayout = ImageLayout.None;
            iconMenuProyectsForm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuProyectsForm.ForeColor = Color.White;
            iconMenuProyectsForm.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            iconMenuProyectsForm.IconColor = Color.White;
            iconMenuProyectsForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuProyectsForm.IconSize = 30;
            iconMenuProyectsForm.ImageAlign = ContentAlignment.MiddleLeft;
            iconMenuProyectsForm.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuProyectsForm.Margin = new Padding(0, 20, 0, 0);
            iconMenuProyectsForm.Name = "iconMenuProyectsForm";
            iconMenuProyectsForm.Size = new Size(261, 34);
            iconMenuProyectsForm.Text = "Menú Proyectos";
            iconMenuProyectsForm.TextImageRelation = TextImageRelation.Overlay;
            iconMenuProyectsForm.Click += iconMenuProyectsForm_Click_1;
            // 
            // iconMenuItemRequestClientProjects
            // 
            iconMenuItemRequestClientProjects.BackgroundImageLayout = ImageLayout.None;
            iconMenuItemRequestClientProjects.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItemRequestClientProjects.ForeColor = Color.White;
            iconMenuItemRequestClientProjects.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            iconMenuItemRequestClientProjects.IconColor = Color.White;
            iconMenuItemRequestClientProjects.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemRequestClientProjects.IconSize = 30;
            iconMenuItemRequestClientProjects.ImageAlign = ContentAlignment.MiddleLeft;
            iconMenuItemRequestClientProjects.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemRequestClientProjects.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemRequestClientProjects.Name = "iconMenuItemRequestClientProjects";
            iconMenuItemRequestClientProjects.Size = new Size(261, 34);
            iconMenuItemRequestClientProjects.Text = "Menú Cliente";
            iconMenuItemRequestClientProjects.TextImageRelation = TextImageRelation.Overlay;
            iconMenuItemRequestClientProjects.Click += iconMenuItemRequestClientProjects_Click;
            // 
            // iconMenuItemProjectsEmployee
            // 
            iconMenuItemProjectsEmployee.BackgroundImageLayout = ImageLayout.None;
            iconMenuItemProjectsEmployee.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1 });
            iconMenuItemProjectsEmployee.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItemProjectsEmployee.ForeColor = Color.White;
            iconMenuItemProjectsEmployee.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconMenuItemProjectsEmployee.IconColor = Color.White;
            iconMenuItemProjectsEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemProjectsEmployee.IconSize = 30;
            iconMenuItemProjectsEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            iconMenuItemProjectsEmployee.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemProjectsEmployee.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemProjectsEmployee.Name = "iconMenuItemProjectsEmployee";
            iconMenuItemProjectsEmployee.Size = new Size(261, 34);
            iconMenuItemProjectsEmployee.Text = "Menú Empleado";
            iconMenuItemProjectsEmployee.TextImageRelation = TextImageRelation.Overlay;
            iconMenuItemProjectsEmployee.Click += iconMenuItemProjectsEmployee_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(87, 6);
            // 
            // iconMenuRecordForm
            // 
            iconMenuRecordForm.BackgroundImageLayout = ImageLayout.None;
            iconMenuRecordForm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuRecordForm.ForeColor = Color.White;
            iconMenuRecordForm.IconChar = FontAwesome.Sharp.IconChar.Poll;
            iconMenuRecordForm.IconColor = Color.White;
            iconMenuRecordForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuRecordForm.IconSize = 30;
            iconMenuRecordForm.ImageAlign = ContentAlignment.MiddleLeft;
            iconMenuRecordForm.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuRecordForm.Margin = new Padding(0, 20, 0, 0);
            iconMenuRecordForm.Name = "iconMenuRecordForm";
            iconMenuRecordForm.Size = new Size(261, 34);
            iconMenuRecordForm.Text = "Registro";
            iconMenuRecordForm.TextImageRelation = TextImageRelation.Overlay;
            iconMenuRecordForm.Click += iconMenuRecordForm_Click;
            // 
            // iconMenusSettingsForm
            // 
            iconMenusSettingsForm.BackgroundImageLayout = ImageLayout.None;
            iconMenusSettingsForm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenusSettingsForm.ForeColor = Color.White;
            iconMenusSettingsForm.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            iconMenusSettingsForm.IconColor = Color.White;
            iconMenusSettingsForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenusSettingsForm.IconSize = 30;
            iconMenusSettingsForm.ImageAlign = ContentAlignment.MiddleLeft;
            iconMenusSettingsForm.ImageScaling = ToolStripItemImageScaling.None;
            iconMenusSettingsForm.Margin = new Padding(0, 20, 0, 0);
            iconMenusSettingsForm.Name = "iconMenusSettingsForm";
            iconMenusSettingsForm.Size = new Size(261, 34);
            iconMenusSettingsForm.Text = "Ajustes";
            iconMenusSettingsForm.TextImageRelation = TextImageRelation.Overlay;
            iconMenusSettingsForm.Click += iconMenusSettingsForm_Click;
            // 
            // iconMenuAccountForm
            // 
            iconMenuAccountForm.BackgroundImageLayout = ImageLayout.None;
            iconMenuAccountForm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuAccountForm.ForeColor = Color.White;
            iconMenuAccountForm.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            iconMenuAccountForm.IconColor = Color.White;
            iconMenuAccountForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuAccountForm.IconSize = 30;
            iconMenuAccountForm.ImageAlign = ContentAlignment.MiddleLeft;
            iconMenuAccountForm.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuAccountForm.Margin = new Padding(0, 20, 0, 0);
            iconMenuAccountForm.Name = "iconMenuAccountForm";
            iconMenuAccountForm.Size = new Size(261, 34);
            iconMenuAccountForm.Text = "Cuenta";
            iconMenuAccountForm.TextImageRelation = TextImageRelation.Overlay;
            iconMenuAccountForm.Click += iconMenuAccountForm_Click;
            // 
            // iconMenuItemMenus
            // 
            iconMenuItemMenus.BackgroundImageLayout = ImageLayout.None;
            iconMenuItemMenus.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItemMenus.ForeColor = Color.White;
            iconMenuItemMenus.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            iconMenuItemMenus.IconColor = Color.White;
            iconMenuItemMenus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemMenus.IconSize = 30;
            iconMenuItemMenus.ImageAlign = ContentAlignment.MiddleLeft;
            iconMenuItemMenus.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemMenus.Margin = new Padding(0, 20, 0, 0);
            iconMenuItemMenus.Name = "iconMenuItemMenus";
            iconMenuItemMenus.Size = new Size(261, 34);
            iconMenuItemMenus.Text = "Menú";
            iconMenuItemMenus.TextImageRelation = TextImageRelation.Overlay;
            iconMenuItemMenus.Click += iconMenuItemMenus_Click;
            // 
            // containerPanel
            // 
            containerPanel.BackColor = Color.WhiteSmoke;
            containerPanel.Controls.Add(menuGroupBox);
            containerPanel.Location = new Point(310, 113);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(1707, 995);
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
            menuGroupBox.Controls.Add(projectAssignamentPanel);
            menuGroupBox.Location = new Point(22, 15);
            menuGroupBox.Name = "menuGroupBox";
            menuGroupBox.Size = new Size(1666, 963);
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
            panelUsersView.Controls.Add(panel10);
            panelUsersView.Controls.Add(informationPanel);
            panelUsersView.Controls.Add(nameUserLabel);
            panelUsersView.Controls.Add(cityLabel);
            panelUsersView.Controls.Add(countryUserLabel);
            panelUsersView.Controls.Add(ageUserLabel);
            panelUsersView.Controls.Add(selectedUserPictureBox);
            panelUsersView.Controls.Add(idUserLabel);
            panelUsersView.Dock = DockStyle.Right;
            panelUsersView.Location = new Point(1198, 26);
            panelUsersView.Name = "panelUsersView";
            panelUsersView.Size = new Size(465, 934);
            panelUsersView.TabIndex = 6;
            panelUsersView.Visible = false;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BackColor = Color.SteelBlue;
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Location = new Point(17, 661);
            panel10.Name = "panel10";
            panel10.Size = new Size(437, 262);
            panel10.TabIndex = 24;
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
            registrationLabel.Location = new Point(264, 436);
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
            numberPhoneLabel.Location = new Point(141, 157);
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
            emailIdUserLabel.Location = new Point(141, 113);
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
            dateCreateLabel.Location = new Point(18, 435);
            dateCreateLabel.Name = "dateCreateLabel";
            dateCreateLabel.Size = new Size(240, 28);
            dateCreateLabel.TabIndex = 22;
            dateCreateLabel.Text = "Fecha de creacion:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            phoneNumberLabel.ForeColor = Color.White;
            phoneNumberLabel.Location = new Point(18, 151);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(117, 30);
            phoneNumberLabel.TabIndex = 21;
            phoneNumberLabel.Text = "Telefono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(28, 108);
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
            cityLabel.Location = new Point(342, 100);
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
            countryUserLabel.Location = new Point(207, 100);
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
            projectPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            projectPanel.BorderStyle = BorderStyle.Fixed3D;
            projectPanel.Controls.Add(requestProjectPanel);
            projectPanel.Controls.Add(assignedProjectPanel);
            projectPanel.Location = new Point(19, 621);
            projectPanel.Name = "projectPanel";
            projectPanel.Size = new Size(1168, 317);
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
            requestProjectPanel.Size = new Size(534, 278);
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
            requestProjectListBox.Size = new Size(406, 210);
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
            assignedProjectPanel.Size = new Size(541, 278);
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
            assignedProjectListBox.Size = new Size(407, 210);
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
            informationUserPanel.Location = new Point(19, 252);
            informationUserPanel.Name = "informationUserPanel";
            informationUserPanel.Size = new Size(1173, 352);
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
            userDataGridView.Size = new Size(873, 350);
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
            // projectAssignamentPanel
            // 
            projectAssignamentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            projectAssignamentPanel.BorderStyle = BorderStyle.Fixed3D;
            projectAssignamentPanel.Controls.Add(userPictureBox);
            projectAssignamentPanel.Controls.Add(logoPictureBox);
            projectAssignamentPanel.Location = new Point(19, 79);
            projectAssignamentPanel.Name = "projectAssignamentPanel";
            projectAssignamentPanel.Size = new Size(1168, 158);
            projectAssignamentPanel.TabIndex = 2;
            // 
            // userPictureBox
            // 
            userPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userPictureBox.BackColor = Color.LightGray;
            userPictureBox.Location = new Point(0, 0);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(871, 154);
            userPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userPictureBox.TabIndex = 1;
            userPictureBox.TabStop = false;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Right;
            logoPictureBox.Image = Properties.Resources.CRM_logo__1_;
            logoPictureBox.Location = new Point(914, 0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(250, 154);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
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
            closedPictureBox.Location = new Point(1736, 3);
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
            minimizarPictureBox.Image = Properties.Resources.minimizar;
            minimizarPictureBox.Location = new Point(1685, 3);
            minimizarPictureBox.Name = "minimizarPictureBox";
            minimizarPictureBox.Size = new Size(30, 44);
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
            nameUserPanel.Location = new Point(280, 0);
            nameUserPanel.Name = "nameUserPanel";
            nameUserPanel.Size = new Size(1778, 95);
            nameUserPanel.TabIndex = 2;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2057, 1108);
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
            WindowState = FormWindowState.Maximized;
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
            projectAssignamentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
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
        private FontAwesome.Sharp.IconMenuItem iconMenuUsersForm;
        private FontAwesome.Sharp.IconMenuItem iconMenuProyectsForm;
        private FontAwesome.Sharp.IconMenuItem iconMenuRecordForm;
        private FontAwesome.Sharp.IconMenuItem iconMenusSettingsForm;
        private FontAwesome.Sharp.IconMenuItem iconMenuAccountForm;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemProjectsEmployee;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemRequestClientProjects;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemMenus;
        private Label welcomeLabel;
        private Panel projectAssignamentPanel;
        private Label userAccountLabel;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemHome;
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
        private Panel panel10;
        public PictureBox idUserPictureBox;
        private PictureBox logoPictureBox;
        private PictureBox userPictureBox;
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