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
            userAccountLabel = new Label();
            timeLabel = new Label();
            usersViewPanel = new Panel();
            logoPictureBox = new PictureBox();
            nameGroupLabel = new Label();
            label7 = new Label();
            welcomeLabel = new Label();
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
            introductionGroupBox.Controls.Add(userAccountLabel);
            introductionGroupBox.Controls.Add(timeLabel);
            introductionGroupBox.Controls.Add(usersViewPanel);
            introductionGroupBox.Controls.Add(welcomeLabel);
            introductionGroupBox.Controls.Add(informationUsersPanel);
            introductionGroupBox.Controls.Add(projectsAssignamentPanel);
            introductionGroupBox.Dock = DockStyle.Fill;
            introductionGroupBox.Location = new Point(0, 0);
            introductionGroupBox.Margin = new Padding(4);
            introductionGroupBox.Name = "introductionGroupBox";
            introductionGroupBox.Padding = new Padding(4);
            introductionGroupBox.Size = new Size(1281, 970);
            introductionGroupBox.TabIndex = 8;
            introductionGroupBox.TabStop = false;
            introductionGroupBox.Text = "Inicio";
            // 
            // userAccountLabel
            // 
            userAccountLabel.AutoSize = true;
            userAccountLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            userAccountLabel.Location = new Point(361, 30);
            userAccountLabel.Margin = new Padding(4, 0, 4, 0);
            userAccountLabel.Name = "userAccountLabel";
            userAccountLabel.Size = new Size(114, 34);
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
            timeLabel.Location = new Point(753, 34);
            timeLabel.Margin = new Padding(4, 0, 4, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(68, 30);
            timeLabel.TabIndex = 5;
            timeLabel.Text = "Hora";
            // 
            // usersViewPanel
            // 
            usersViewPanel.BackColor = Color.LightGray;
            usersViewPanel.Controls.Add(logoPictureBox);
            usersViewPanel.Controls.Add(nameGroupLabel);
            usersViewPanel.Controls.Add(label7);
            usersViewPanel.Dock = DockStyle.Right;
            usersViewPanel.Location = new Point(994, 28);
            usersViewPanel.Margin = new Padding(4);
            usersViewPanel.Name = "usersViewPanel";
            usersViewPanel.Size = new Size(283, 938);
            usersViewPanel.TabIndex = 6;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoPictureBox.Image = Properties.Resources.CRM_logo__1_;
            logoPictureBox.Location = new Point(22, 25);
            logoPictureBox.Margin = new Padding(4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(234, 222);
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
            nameGroupLabel.Location = new Point(12, 273);
            nameGroupLabel.Margin = new Padding(4, 0, 4, 0);
            nameGroupLabel.Name = "nameGroupLabel";
            nameGroupLabel.Size = new Size(267, 40);
            nameGroupLabel.TabIndex = 30;
            nameGroupLabel.Text = "Los Tilinizasos77";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(160, 120);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(20, 30);
            label7.TabIndex = 19;
            label7.Text = ",";
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            welcomeLabel.Location = new Point(24, 30);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(311, 34);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Bienvenido de vuelta ";
            // 
            // informationUsersPanel
            // 
            informationUsersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            informationUsersPanel.BorderStyle = BorderStyle.Fixed3D;
            informationUsersPanel.Controls.Add(iconUserClientsButton);
            informationUsersPanel.Controls.Add(iconUserEmployeeButton);
            informationUsersPanel.Location = new Point(24, 285);
            informationUsersPanel.Margin = new Padding(4);
            informationUsersPanel.Name = "informationUsersPanel";
            informationUsersPanel.Size = new Size(938, 436);
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
            iconUserClientsButton.Location = new Point(51, 162);
            iconUserClientsButton.Margin = new Padding(4);
            iconUserClientsButton.Name = "iconUserClientsButton";
            iconUserClientsButton.Size = new Size(369, 78);
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
            iconUserEmployeeButton.Location = new Point(51, 48);
            iconUserEmployeeButton.Margin = new Padding(4);
            iconUserEmployeeButton.Name = "iconUserEmployeeButton";
            iconUserEmployeeButton.Size = new Size(369, 85);
            iconUserEmployeeButton.TabIndex = 4;
            iconUserEmployeeButton.Text = "Mis proyectos pendientes";
            iconUserEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // projectsAssignamentPanel
            // 
            projectsAssignamentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            projectsAssignamentPanel.BorderStyle = BorderStyle.Fixed3D;
            projectsAssignamentPanel.Controls.Add(taskPictureBox);
            projectsAssignamentPanel.Controls.Add(motivationLabel);
            projectsAssignamentPanel.Controls.Add(projectsPendingsLabel);
            projectsAssignamentPanel.Controls.Add(completedTaskLabel);
            projectsAssignamentPanel.Location = new Point(24, 95);
            projectsAssignamentPanel.Margin = new Padding(4);
            projectsAssignamentPanel.Name = "projectsAssignamentPanel";
            projectsAssignamentPanel.Size = new Size(938, 155);
            projectsAssignamentPanel.TabIndex = 2;
            // 
            // taskPictureBox
            // 
            taskPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            taskPictureBox.Image = (Image)resources.GetObject("taskPictureBox.Image");
            taskPictureBox.Location = new Point(776, 19);
            taskPictureBox.Margin = new Padding(4);
            taskPictureBox.Name = "taskPictureBox";
            taskPictureBox.Size = new Size(134, 128);
            taskPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            taskPictureBox.TabIndex = 4;
            taskPictureBox.TabStop = false;
            // 
            // motivationLabel
            // 
            motivationLabel.AutoSize = true;
            motivationLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            motivationLabel.Location = new Point(18, 74);
            motivationLabel.Margin = new Padding(4, 0, 4, 0);
            motivationLabel.Name = "motivationLabel";
            motivationLabel.Size = new Size(431, 24);
            motivationLabel.TabIndex = 3;
            motivationLabel.Text = "¿A qué esperas? ¡Ponte manos a la obra!";
            // 
            // projectsPendingsLabel
            // 
            projectsPendingsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            projectsPendingsLabel.AutoSize = true;
            projectsPendingsLabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectsPendingsLabel.Location = new Point(680, 19);
            projectsPendingsLabel.Margin = new Padding(4, 0, 4, 0);
            projectsPendingsLabel.Name = "projectsPendingsLabel";
            projectsPendingsLabel.Size = new Size(39, 43);
            projectsPendingsLabel.TabIndex = 2;
            projectsPendingsLabel.Text = "0";
            // 
            // completedTaskLabel
            // 
            completedTaskLabel.AutoSize = true;
            completedTaskLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completedTaskLabel.Location = new Point(35, 19);
            completedTaskLabel.Margin = new Padding(4, 0, 4, 0);
            completedTaskLabel.Name = "completedTaskLabel";
            completedTaskLabel.Size = new Size(266, 28);
            completedTaskLabel.TabIndex = 1;
            completedTaskLabel.Text = "Tareas por Completar";
            // 
            // HomeUserEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1281, 970);
            Controls.Add(introductionGroupBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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