namespace PresentationLayer.Forms.Empleados
{
    partial class HomeUserEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserEmployeeForm));
            introductionGroupBox = new GroupBox();
            welcomeLabel = new Label();
            userAccountLabel = new Label();
            timeLabel = new Label();
            usersViewPanel = new Panel();
            logoPictureBox = new PictureBox();
            nameGroupLabel = new Label();
            informationUsersPanel = new Panel();
            iconUserClientsButton = new FontAwesome.Sharp.IconButton();
            iconUserEmployeeButton = new FontAwesome.Sharp.IconButton();
            projectsAssignamentPanel = new Panel();
            taskPictureBox = new PictureBox();
            motivationLabel = new Label();
            projectsPendingsLabel = new Label();
            completedTaskLabel = new Label();
            introductionGroupBox.SuspendLayout();
            usersViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            informationUsersPanel.SuspendLayout();
            projectsAssignamentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskPictureBox).BeginInit();
            SuspendLayout();
            // 
            // introductionGroupBox
            // 
            introductionGroupBox.Controls.Add(welcomeLabel);
            introductionGroupBox.Controls.Add(userAccountLabel);
            introductionGroupBox.Controls.Add(timeLabel);
            introductionGroupBox.Controls.Add(usersViewPanel);
            introductionGroupBox.Controls.Add(informationUsersPanel);
            introductionGroupBox.Controls.Add(projectsAssignamentPanel);
            introductionGroupBox.Dock = DockStyle.Fill;
            introductionGroupBox.Location = new Point(0, 0);
            introductionGroupBox.Name = "introductionGroupBox";
            introductionGroupBox.Size = new Size(1025, 776);
            introductionGroupBox.TabIndex = 8;
            introductionGroupBox.TabStop = false;
            introductionGroupBox.Text = "Inicio";
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            welcomeLabel.Location = new Point(19, 24);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(250, 27);
            welcomeLabel.TabIndex = 7;
            welcomeLabel.Text = "Bienvenido de vuelta";
            // 
            // userAccountLabel
            // 
            userAccountLabel.AutoSize = true;
            userAccountLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            userAccountLabel.Location = new Point(268, 24);
            userAccountLabel.Name = "userAccountLabel";
            userAccountLabel.Size = new Size(94, 27);
            userAccountLabel.TabIndex = 1;
            userAccountLabel.Text = "Usuario";
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timeLabel.AutoSize = true;
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("Century Gothic", 12F);
            timeLabel.ForeColor = Color.Black;
            timeLabel.Location = new Point(572, 27);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(198, 23);
            timeLabel.TabIndex = 5;
            timeLabel.Text = "06/12/2024 00:00:00";
            // 
            // usersViewPanel
            // 
            usersViewPanel.BackColor = Color.LightGray;
            usersViewPanel.Controls.Add(logoPictureBox);
            usersViewPanel.Controls.Add(nameGroupLabel);
            usersViewPanel.Dock = DockStyle.Right;
            usersViewPanel.Location = new Point(796, 23);
            usersViewPanel.Name = "usersViewPanel";
            usersViewPanel.Size = new Size(226, 750);
            usersViewPanel.TabIndex = 6;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoPictureBox.Image = Properties.Resources.CRM_logo__1_;
            logoPictureBox.Location = new Point(18, 20);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(187, 178);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 31;
            logoPictureBox.TabStop = false;
            // 
            // nameGroupLabel
            // 
            nameGroupLabel.AutoSize = true;
            nameGroupLabel.BackColor = Color.Transparent;
            nameGroupLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameGroupLabel.ForeColor = Color.DimGray;
            nameGroupLabel.Location = new Point(10, 218);
            nameGroupLabel.Name = "nameGroupLabel";
            nameGroupLabel.Size = new Size(227, 34);
            nameGroupLabel.TabIndex = 30;
            nameGroupLabel.Text = "Los Tilinizasos77";
            // 
            // informationUsersPanel
            // 
            informationUsersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            informationUsersPanel.BorderStyle = BorderStyle.Fixed3D;
            informationUsersPanel.Controls.Add(iconUserClientsButton);
            informationUsersPanel.Controls.Add(iconUserEmployeeButton);
            informationUsersPanel.Location = new Point(19, 228);
            informationUsersPanel.Name = "informationUsersPanel";
            informationUsersPanel.Size = new Size(751, 350);
            informationUsersPanel.TabIndex = 3;
            // 
            // iconUserClientsButton
            // 
            iconUserClientsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconUserClientsButton.BackColor = Color.DodgerBlue;
            iconUserClientsButton.Cursor = Cursors.Hand;
            iconUserClientsButton.FlatStyle = FlatStyle.Flat;
            iconUserClientsButton.ForeColor = Color.White;
            iconUserClientsButton.IconChar = FontAwesome.Sharp.IconChar.Uber;
            iconUserClientsButton.IconColor = Color.White;
            iconUserClientsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUserClientsButton.ImageAlign = ContentAlignment.MiddleLeft;
            iconUserClientsButton.Location = new Point(227, 207);
            iconUserClientsButton.Name = "iconUserClientsButton";
            iconUserClientsButton.Size = new Size(295, 48);
            iconUserClientsButton.TabIndex = 6;
            iconUserClientsButton.Text = "Mis proyectos finalizados";
            iconUserClientsButton.UseVisualStyleBackColor = false;
            // 
            // iconUserEmployeeButton
            // 
            iconUserEmployeeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconUserEmployeeButton.BackColor = Color.DodgerBlue;
            iconUserEmployeeButton.Cursor = Cursors.Hand;
            iconUserEmployeeButton.FlatStyle = FlatStyle.Flat;
            iconUserEmployeeButton.ForeColor = Color.White;
            iconUserEmployeeButton.IconChar = FontAwesome.Sharp.IconChar.Uber;
            iconUserEmployeeButton.IconColor = Color.White;
            iconUserEmployeeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUserEmployeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            iconUserEmployeeButton.Location = new Point(227, 96);
            iconUserEmployeeButton.Name = "iconUserEmployeeButton";
            iconUserEmployeeButton.Size = new Size(295, 48);
            iconUserEmployeeButton.TabIndex = 4;
            iconUserEmployeeButton.Text = "Mis proyectos pendientes";
            iconUserEmployeeButton.UseVisualStyleBackColor = false;
            iconUserEmployeeButton.Click += iconUserEmployeeButton_Click_1;
            // 
            // projectsAssignamentPanel
            // 
            projectsAssignamentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            projectsAssignamentPanel.BorderStyle = BorderStyle.Fixed3D;
            projectsAssignamentPanel.Controls.Add(taskPictureBox);
            projectsAssignamentPanel.Controls.Add(motivationLabel);
            projectsAssignamentPanel.Controls.Add(projectsPendingsLabel);
            projectsAssignamentPanel.Controls.Add(completedTaskLabel);
            projectsAssignamentPanel.Location = new Point(19, 76);
            projectsAssignamentPanel.Name = "projectsAssignamentPanel";
            projectsAssignamentPanel.Size = new Size(751, 125);
            projectsAssignamentPanel.TabIndex = 2;
            // 
            // taskPictureBox
            // 
            taskPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            taskPictureBox.Image = (Image)resources.GetObject("taskPictureBox.Image");
            taskPictureBox.Location = new Point(601, 15);
            taskPictureBox.Name = "taskPictureBox";
            taskPictureBox.Size = new Size(107, 86);
            taskPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            taskPictureBox.TabIndex = 4;
            taskPictureBox.TabStop = false;
            // 
            // motivationLabel
            // 
            motivationLabel.AutoSize = true;
            motivationLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            motivationLabel.Location = new Point(37, 80);
            motivationLabel.Name = "motivationLabel";
            motivationLabel.Size = new Size(359, 21);
            motivationLabel.TabIndex = 3;
            motivationLabel.Text = "¿A qué esperas? ¡Ponte manos a la obra!";
            // 
            // projectsPendingsLabel
            // 
            projectsPendingsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            projectsPendingsLabel.AutoSize = true;
            projectsPendingsLabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectsPendingsLabel.Location = new Point(546, 41);
            projectsPendingsLabel.Name = "projectsPendingsLabel";
            projectsPendingsLabel.Size = new Size(34, 37);
            projectsPendingsLabel.TabIndex = 2;
            projectsPendingsLabel.Text = "0";
            // 
            // completedTaskLabel
            // 
            completedTaskLabel.AutoSize = true;
            completedTaskLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completedTaskLabel.Location = new Point(34, 29);
            completedTaskLabel.Name = "completedTaskLabel";
            completedTaskLabel.Size = new Size(220, 23);
            completedTaskLabel.TabIndex = 1;
            completedTaskLabel.Text = "Tareas por Completar";
            // 
            // HomeUserEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1025, 776);
            Controls.Add(introductionGroupBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeUserEmployeeForm";
            Text = "HomeUserEmployeeForm";
            introductionGroupBox.ResumeLayout(false);
            introductionGroupBox.PerformLayout();
            usersViewPanel.ResumeLayout(false);
            usersViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            informationUsersPanel.ResumeLayout(false);
            projectsAssignamentPanel.ResumeLayout(false);
            projectsAssignamentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox introductionGroupBox;
        private Label timeLabel;
        private Panel usersViewPanel;
        private Label label7;
        private Label welcomeLabel;
        private Panel informationUsersPanel;
        private FontAwesome.Sharp.IconButton iconUserClientsButton;
        private FontAwesome.Sharp.IconButton iconUserEmployeeButton;
        private Label userAccountLabel;
        private Panel projectsAssignamentPanel;
        private Label completedTaskLabel;
        private PictureBox taskPictureBox;
        private Label motivationLabel;
        private Label projectsPendingsLabel;
        private PictureBox logoPictureBox;
        private Label nameGroupLabel;
    }
}