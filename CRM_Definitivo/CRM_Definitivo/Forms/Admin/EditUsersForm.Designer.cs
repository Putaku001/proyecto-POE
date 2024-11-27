namespace PresentationLayer.Forms
{
    partial class EditUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUsersForm));
            addressGroupBox = new GroupBox();
            cityLabel = new Label();
            listCityComboBox = new ComboBox();
            listCountryComboBox = new ComboBox();
            departamentLabel = new Label();
            countryLabel = new Label();
            listDepartamentComboBox = new ComboBox();
            detailsUserGroupBox = new GroupBox();
            userLabel = new Label();
            userTextBox = new TextBox();
            bithdayLabel = new Label();
            statusComboBox = new ComboBox();
            rolComboBox = new ComboBox();
            nameTextBox = new TextBox();
            statusLabel = new Label();
            passwordLabel = new Label();
            rolLabel = new Label();
            passwordTextBox = new TextBox();
            nameUserLabel = new Label();
            emailTexBox = new TextBox();
            emailLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            birthdayDateTimePicker = new DateTimePicker();
            phoneNumberLabel = new Label();
            phoneNumberTextBox = new TextBox();
            saveButton = new FontAwesome.Sharp.IconButton();
            addressGroupBox.SuspendLayout();
            detailsUserGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // addressGroupBox
            // 
            addressGroupBox.Controls.Add(saveButton);
            addressGroupBox.Controls.Add(cityLabel);
            addressGroupBox.Controls.Add(listCityComboBox);
            addressGroupBox.Controls.Add(listCountryComboBox);
            addressGroupBox.Controls.Add(departamentLabel);
            addressGroupBox.Controls.Add(countryLabel);
            addressGroupBox.Controls.Add(listDepartamentComboBox);
            addressGroupBox.Dock = DockStyle.Right;
            addressGroupBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressGroupBox.ForeColor = Color.Black;
            addressGroupBox.Location = new Point(659, 0);
            addressGroupBox.Name = "addressGroupBox";
            addressGroupBox.Size = new Size(557, 772);
            addressGroupBox.TabIndex = 18;
            addressGroupBox.TabStop = false;
            addressGroupBox.Text = "Dirección";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.ForeColor = Color.Black;
            cityLabel.Location = new Point(107, 212);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(88, 23);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "Ciudad:";
            // 
            // listCityComboBox
            // 
            listCityComboBox.FormattingEnabled = true;
            listCityComboBox.Location = new Point(217, 203);
            listCityComboBox.Name = "listCityComboBox";
            listCityComboBox.Size = new Size(322, 31);
            listCityComboBox.TabIndex = 13;
            // 
            // listCountryComboBox
            // 
            listCountryComboBox.FormattingEnabled = true;
            listCountryComboBox.Location = new Point(217, 61);
            listCountryComboBox.Name = "listCountryComboBox";
            listCountryComboBox.Size = new Size(322, 31);
            listCountryComboBox.TabIndex = 9;
            // 
            // departamentLabel
            // 
            departamentLabel.AutoSize = true;
            departamentLabel.ForeColor = Color.Black;
            departamentLabel.Location = new Point(33, 135);
            departamentLabel.Name = "departamentLabel";
            departamentLabel.Size = new Size(162, 23);
            departamentLabel.TabIndex = 12;
            departamentLabel.Text = "Departamento:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.ForeColor = Color.Black;
            countryLabel.Location = new Point(140, 64);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(52, 23);
            countryLabel.TabIndex = 10;
            countryLabel.Text = "Pais:";
            // 
            // listDepartamentComboBox
            // 
            listDepartamentComboBox.FormattingEnabled = true;
            listDepartamentComboBox.Location = new Point(217, 135);
            listDepartamentComboBox.Name = "listDepartamentComboBox";
            listDepartamentComboBox.Size = new Size(322, 31);
            listDepartamentComboBox.TabIndex = 11;
            // 
            // detailsUserGroupBox
            // 
            detailsUserGroupBox.Controls.Add(phoneNumberLabel);
            detailsUserGroupBox.Controls.Add(phoneNumberTextBox);
            detailsUserGroupBox.Controls.Add(birthdayDateTimePicker);
            detailsUserGroupBox.Controls.Add(userLabel);
            detailsUserGroupBox.Controls.Add(userTextBox);
            detailsUserGroupBox.Controls.Add(bithdayLabel);
            detailsUserGroupBox.Controls.Add(statusComboBox);
            detailsUserGroupBox.Controls.Add(rolComboBox);
            detailsUserGroupBox.Controls.Add(nameTextBox);
            detailsUserGroupBox.Controls.Add(statusLabel);
            detailsUserGroupBox.Controls.Add(passwordLabel);
            detailsUserGroupBox.Controls.Add(rolLabel);
            detailsUserGroupBox.Controls.Add(passwordTextBox);
            detailsUserGroupBox.Controls.Add(nameUserLabel);
            detailsUserGroupBox.Controls.Add(emailTexBox);
            detailsUserGroupBox.Controls.Add(emailLabel);
            detailsUserGroupBox.Controls.Add(lastNameTextBox);
            detailsUserGroupBox.Controls.Add(lastNameLabel);
            detailsUserGroupBox.Dock = DockStyle.Left;
            detailsUserGroupBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detailsUserGroupBox.ForeColor = Color.Black;
            detailsUserGroupBox.Location = new Point(0, 0);
            detailsUserGroupBox.Name = "detailsUserGroupBox";
            detailsUserGroupBox.Size = new Size(644, 772);
            detailsUserGroupBox.TabIndex = 17;
            detailsUserGroupBox.TabStop = false;
            detailsUserGroupBox.Text = "Datos Del Usuario";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.ForeColor = Color.Black;
            userLabel.Location = new Point(158, 37);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(84, 23);
            userLabel.TabIndex = 19;
            userLabel.Text = "Usuario:";
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(265, 37);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(342, 32);
            userTextBox.TabIndex = 20;
            // 
            // bithdayLabel
            // 
            bithdayLabel.AutoSize = true;
            bithdayLabel.ForeColor = Color.Black;
            bithdayLabel.Location = new Point(25, 354);
            bithdayLabel.Name = "bithdayLabel";
            bithdayLabel.Size = new Size(228, 23);
            bithdayLabel.TabIndex = 17;
            bithdayLabel.Text = "Fecha de Nacimiento:";
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(267, 535);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(342, 31);
            statusComboBox.TabIndex = 15;
            // 
            // rolComboBox
            // 
            rolComboBox.FormattingEnabled = true;
            rolComboBox.Location = new Point(265, 149);
            rolComboBox.Name = "rolComboBox";
            rolComboBox.Size = new Size(342, 31);
            rolComboBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(265, 209);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(342, 32);
            nameTextBox.TabIndex = 18;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = Color.Black;
            statusLabel.Location = new Point(158, 535);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(82, 23);
            statusLabel.TabIndex = 16;
            statusLabel.Text = "Estado:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(123, 475);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(130, 23);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Contraseña:";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.ForeColor = Color.Black;
            rolLabel.Location = new Point(195, 146);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new Size(45, 23);
            rolLabel.TabIndex = 8;
            rolLabel.Text = "Rol:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(267, 472);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(342, 32);
            passwordTextBox.TabIndex = 8;
            // 
            // nameUserLabel
            // 
            nameUserLabel.AutoSize = true;
            nameUserLabel.ForeColor = Color.Black;
            nameUserLabel.Location = new Point(158, 215);
            nameUserLabel.Name = "nameUserLabel";
            nameUserLabel.Size = new Size(95, 23);
            nameUserLabel.TabIndex = 1;
            nameUserLabel.Text = "Nombre:";
            // 
            // emailTexBox
            // 
            emailTexBox.Location = new Point(265, 93);
            emailTexBox.Name = "emailTexBox";
            emailTexBox.Size = new Size(342, 32);
            emailTexBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = Color.Black;
            emailLabel.Location = new Point(45, 90);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(197, 23);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Correo Electronico:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(265, 273);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(342, 32);
            lastNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.ForeColor = Color.Black;
            lastNameLabel.Location = new Point(156, 273);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(97, 23);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Apellido:";
            // 
            // birthdayDateTimePicker
            // 
            birthdayDateTimePicker.Location = new Point(267, 350);
            birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            birthdayDateTimePicker.Size = new Size(340, 32);
            birthdayDateTimePicker.TabIndex = 21;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.ForeColor = Color.Black;
            phoneNumberLabel.Location = new Point(155, 419);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(98, 23);
            phoneNumberLabel.TabIndex = 22;
            phoneNumberLabel.Text = "Telefono:";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(265, 416);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(342, 32);
            phoneNumberTextBox.TabIndex = 23;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Green;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveButton.IconColor = Color.White;
            saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveButton.IconSize = 28;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(159, 649);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(268, 58);
            saveButton.TabIndex = 19;
            saveButton.Text = "Actualizar datos";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // EditUsersForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1216, 772);
            Controls.Add(addressGroupBox);
            Controls.Add(detailsUserGroupBox);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuario";
            addressGroupBox.ResumeLayout(false);
            addressGroupBox.PerformLayout();
            detailsUserGroupBox.ResumeLayout(false);
            detailsUserGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox addressGroupBox;
        private Label cityLabel;
        private ComboBox listCityComboBox;
        private ComboBox listCountryComboBox;
        private Label departamentLabel;
        private Label countryLabel;
        private ComboBox listDepartamentComboBox;
        private GroupBox detailsUserGroupBox;
        private Label bithdayLabel;
        private ComboBox statusComboBox;
        private ComboBox rolComboBox;
        private TextBox nameTextBox;
        private Label statusLabel;
        private Label passwordLabel;
        private Label rolLabel;
        private TextBox passwordTextBox;
        private Label nameUserLabel;
        private TextBox emailTexBox;
        private Label emailLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private Label lblUserAccount;
        private TextBox txtUserAccount;
        private Label userLabel;
        private TextBox userTextBox;
        private DateTimePicker birthdayDateTimePicker;
        private Label phoneNumberLabel;
        private TextBox phoneNumberTextBox;
        private FontAwesome.Sharp.IconButton saveButton;
    }
}