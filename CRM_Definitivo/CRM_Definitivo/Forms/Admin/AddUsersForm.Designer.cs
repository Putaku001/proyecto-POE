namespace PresentationLayer.Forms
{
    partial class AddUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsersForm));
            addUserLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            rolComboBox = new ComboBox();
            rolLabel = new Label();
            detailsUserGroupBox = new GroupBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            nameUserLabel = new Label();
            nameUserTextBox = new TextBox();
            birthdateDateTimePicker = new DateTimePicker();
            numberPhoneLabel = new Label();
            numberPhoneTextBox = new TextBox();
            statusComboBox = new ComboBox();
            statusLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            dateLabel = new Label();
            lastNameLabel = new Label();
            lasNameTextBox = new TextBox();
            countryGroupBox = new GroupBox();
            dateRegistreDateTimePicker = new DateTimePicker();
            editButton = new FontAwesome.Sharp.IconButton();
            cityLabel = new Label();
            cityListComboBox = new ComboBox();
            saveButton = new FontAwesome.Sharp.IconButton();
            countrysComboBox = new ComboBox();
            countryUserLabel = new Label();
            informationPanel = new Panel();
            detailsUserGroupBox.SuspendLayout();
            countryGroupBox.SuspendLayout();
            informationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addUserLabel
            // 
            addUserLabel.BackColor = Color.DodgerBlue;
            addUserLabel.Dock = DockStyle.Top;
            addUserLabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUserLabel.Location = new Point(0, 0);
            addUserLabel.Name = "addUserLabel";
            addUserLabel.Size = new Size(1293, 59);
            addUserLabel.TabIndex = 0;
            addUserLabel.Text = "Añadir";
            addUserLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.Black;
            nameLabel.Location = new Point(133, 241);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(95, 23);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Nombre:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(264, 238);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(346, 32);
            nameTextBox.TabIndex = 2;
            // 
            // rolComboBox
            // 
            rolComboBox.FormattingEnabled = true;
            rolComboBox.Location = new Point(266, 172);
            rolComboBox.Name = "rolComboBox";
            rolComboBox.Size = new Size(344, 31);
            rolComboBox.TabIndex = 7;
            rolComboBox.SelectedIndexChanged += rolComboBox_SelectedIndexChanged;
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.ForeColor = Color.Black;
            rolLabel.Location = new Point(183, 180);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new Size(45, 23);
            rolLabel.TabIndex = 8;
            rolLabel.Text = "Rol:";
            // 
            // detailsUserGroupBox
            // 
            detailsUserGroupBox.Controls.Add(emailLabel);
            detailsUserGroupBox.Controls.Add(emailTextBox);
            detailsUserGroupBox.Controls.Add(nameUserLabel);
            detailsUserGroupBox.Controls.Add(nameUserTextBox);
            detailsUserGroupBox.Controls.Add(birthdateDateTimePicker);
            detailsUserGroupBox.Controls.Add(numberPhoneLabel);
            detailsUserGroupBox.Controls.Add(numberPhoneTextBox);
            detailsUserGroupBox.Controls.Add(statusComboBox);
            detailsUserGroupBox.Controls.Add(rolComboBox);
            detailsUserGroupBox.Controls.Add(statusLabel);
            detailsUserGroupBox.Controls.Add(passwordLabel);
            detailsUserGroupBox.Controls.Add(rolLabel);
            detailsUserGroupBox.Controls.Add(passwordTextBox);
            detailsUserGroupBox.Controls.Add(nameLabel);
            detailsUserGroupBox.Controls.Add(nameTextBox);
            detailsUserGroupBox.Controls.Add(dateLabel);
            detailsUserGroupBox.Controls.Add(lastNameLabel);
            detailsUserGroupBox.Controls.Add(lasNameTextBox);
            detailsUserGroupBox.Dock = DockStyle.Left;
            detailsUserGroupBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detailsUserGroupBox.Location = new Point(0, 0);
            detailsUserGroupBox.Name = "detailsUserGroupBox";
            detailsUserGroupBox.Size = new Size(642, 735);
            detailsUserGroupBox.TabIndex = 15;
            detailsUserGroupBox.TabStop = false;
            detailsUserGroupBox.Text = "Datos Del Usuario";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = Color.Black;
            emailLabel.Location = new Point(31, 101);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(197, 23);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Correo Electronico:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(266, 98);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(344, 32);
            emailTextBox.TabIndex = 23;
            // 
            // nameUserLabel
            // 
            nameUserLabel.AutoSize = true;
            nameUserLabel.ForeColor = Color.Black;
            nameUserLabel.Location = new Point(144, 43);
            nameUserLabel.Name = "nameUserLabel";
            nameUserLabel.Size = new Size(84, 23);
            nameUserLabel.TabIndex = 20;
            nameUserLabel.Text = "Usuario:";
            // 
            // nameUserTextBox
            // 
            nameUserTextBox.Location = new Point(266, 43);
            nameUserTextBox.Name = "nameUserTextBox";
            nameUserTextBox.Size = new Size(346, 32);
            nameUserTextBox.TabIndex = 21;
            // 
            // birthdateDateTimePicker
            // 
            birthdateDateTimePicker.Location = new Point(262, 380);
            birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            birthdateDateTimePicker.Size = new Size(346, 32);
            birthdateDateTimePicker.TabIndex = 19;
            // 
            // numberPhoneLabel
            // 
            numberPhoneLabel.AutoSize = true;
            numberPhoneLabel.ForeColor = Color.Black;
            numberPhoneLabel.Location = new Point(130, 458);
            numberPhoneLabel.Name = "numberPhoneLabel";
            numberPhoneLabel.Size = new Size(98, 23);
            numberPhoneLabel.TabIndex = 17;
            numberPhoneLabel.Text = "Telefono:";
            // 
            // numberPhoneTextBox
            // 
            numberPhoneTextBox.Location = new Point(262, 449);
            numberPhoneTextBox.Name = "numberPhoneTextBox";
            numberPhoneTextBox.Size = new Size(346, 32);
            numberPhoneTextBox.TabIndex = 18;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(262, 592);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(346, 31);
            statusComboBox.TabIndex = 15;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = Color.Black;
            statusLabel.Location = new Point(133, 595);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(82, 23);
            statusLabel.TabIndex = 16;
            statusLabel.Text = "Estado:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(98, 522);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(130, 23);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Contraseña:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(262, 519);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(346, 32);
            passwordTextBox.TabIndex = 8;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.ForeColor = Color.Black;
            dateLabel.Location = new Point(156, 389);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(72, 23);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Fecha";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.ForeColor = Color.Black;
            lastNameLabel.Location = new Point(131, 321);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(97, 23);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Apellido:";
            // 
            // lasNameTextBox
            // 
            lasNameTextBox.Location = new Point(264, 318);
            lasNameTextBox.Name = "lasNameTextBox";
            lasNameTextBox.Size = new Size(344, 32);
            lasNameTextBox.TabIndex = 6;
            // 
            // countryGroupBox
            // 
            countryGroupBox.Controls.Add(dateRegistreDateTimePicker);
            countryGroupBox.Controls.Add(editButton);
            countryGroupBox.Controls.Add(cityLabel);
            countryGroupBox.Controls.Add(cityListComboBox);
            countryGroupBox.Controls.Add(saveButton);
            countryGroupBox.Controls.Add(countrysComboBox);
            countryGroupBox.Controls.Add(countryUserLabel);
            countryGroupBox.Dock = DockStyle.Right;
            countryGroupBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countryGroupBox.ForeColor = Color.Black;
            countryGroupBox.Location = new Point(665, 0);
            countryGroupBox.Name = "countryGroupBox";
            countryGroupBox.Size = new Size(628, 735);
            countryGroupBox.TabIndex = 16;
            countryGroupBox.TabStop = false;
            countryGroupBox.Text = "Provinencia";
            // 
            // dateRegistreDateTimePicker
            // 
            dateRegistreDateTimePicker.Enabled = false;
            dateRegistreDateTimePicker.Location = new Point(162, 210);
            dateRegistreDateTimePicker.Name = "dateRegistreDateTimePicker";
            dateRegistreDateTimePicker.Size = new Size(380, 32);
            dateRegistreDateTimePicker.TabIndex = 15;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.HotTrack;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.ForeColor = Color.White;
            editButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editButton.IconColor = Color.White;
            editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editButton.IconSize = 28;
            editButton.ImageAlign = ContentAlignment.MiddleLeft;
            editButton.Location = new Point(341, 380);
            editButton.Name = "editButton";
            editButton.Size = new Size(215, 46);
            editButton.TabIndex = 18;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(24, 129);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(88, 23);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "Ciudad:";
            // 
            // cityListComboBox
            // 
            cityListComboBox.FormattingEnabled = true;
            cityListComboBox.Location = new Point(159, 121);
            cityListComboBox.Name = "cityListComboBox";
            cityListComboBox.Size = new Size(383, 31);
            cityListComboBox.TabIndex = 13;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Green;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.ForeColor = Color.White;
            saveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveButton.IconColor = Color.White;
            saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveButton.IconSize = 28;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(38, 380);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(215, 46);
            saveButton.TabIndex = 17;
            saveButton.Text = "Añadir";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // countrysComboBox
            // 
            countrysComboBox.FormattingEnabled = true;
            countrysComboBox.Location = new Point(159, 44);
            countrysComboBox.Name = "countrysComboBox";
            countrysComboBox.Size = new Size(383, 31);
            countrysComboBox.TabIndex = 9;
            // 
            // countryUserLabel
            // 
            countryUserLabel.AutoSize = true;
            countryUserLabel.Location = new Point(60, 46);
            countryUserLabel.Name = "countryUserLabel";
            countryUserLabel.Size = new Size(52, 23);
            countryUserLabel.TabIndex = 10;
            countryUserLabel.Text = "Pais:";
            // 
            // informationPanel
            // 
            informationPanel.BackColor = Color.LightGray;
            informationPanel.Controls.Add(detailsUserGroupBox);
            informationPanel.Controls.Add(countryGroupBox);
            informationPanel.Dock = DockStyle.Fill;
            informationPanel.Location = new Point(0, 59);
            informationPanel.Name = "informationPanel";
            informationPanel.Size = new Size(1293, 735);
            informationPanel.TabIndex = 19;
            // 
            // AddUsersForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1293, 794);
            Controls.Add(informationPanel);
            Controls.Add(addUserLabel);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir Usuarios";
            Load += AddUsersForm_Load;
            detailsUserGroupBox.ResumeLayout(false);
            detailsUserGroupBox.PerformLayout();
            countryGroupBox.ResumeLayout(false);
            countryGroupBox.PerformLayout();
            informationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label addUserLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private ComboBox rolComboBox;
        private Label rolLabel;
        private Label label7;
        private ComboBox c;
        private GroupBox detailsUserGroupBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private GroupBox countryGroupBox;
        private FontAwesome.Sharp.IconButton saveButton;
        private ComboBox statusComboBox;
        private Label statusLabel;
        private FontAwesome.Sharp.IconButton editButton;
        private DateTimePicker dateRegistreDateTimePicker;
        private Label numberPhoneLabel;
        private TextBox numberPhoneTextBox;
        private Label dateLabel;
        private Label lastNameLabel;
        private TextBox lasNameTextBox;
        private DateTimePicker birthdateDateTimePicker;
        private Label cityLabel;
        private ComboBox cityListComboBox;
        private ComboBox countrysComboBox;
        private Label countryUserLabel;
        private Label nameUserLabel;
        private TextBox nameUserTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Panel informationPanel;
    }
}