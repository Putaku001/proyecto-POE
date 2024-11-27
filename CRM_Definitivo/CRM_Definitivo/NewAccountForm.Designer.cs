namespace PresentationLayer
{
    partial class NewAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccountForm));
            pictureBoxMinimize = new PictureBox();
            pictureBoxClosed = new PictureBox();
            titleLabel = new Label();
            registerGroupBox = new GroupBox();
            selectImageUserLabel = new Label();
            photoNewUserPictureBox = new PictureBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            userLabel = new Label();
            userNameTextBox = new TextBox();
            privacyLabel = new Label();
            loginLabel = new Label();
            existingAccountLabel = new Label();
            registerSaveButton = new FontAwesome.Sharp.IconButton();
            cityLabel = new Label();
            listCityComboBox = new ComboBox();
            listCountrysComboBox = new ComboBox();
            countryLabel = new Label();
            BirthdayDataTimePicker = new DateTimePicker();
            phoneNumberLabel = new Label();
            numberPhoneTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            nameLabel = new Label();
            nameTexBox = new TextBox();
            birthdayLabel = new Label();
            lastNameLabel = new Label();
            lastNameTexBox = new TextBox();
            toolTip1 = new ToolTip(components);
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosed).BeginInit();
            registerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)photoNewUserPictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.BackColor = Color.Transparent;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(602, 11);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(39, 32);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 7;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover;
            // 
            // pictureBoxClosed
            // 
            pictureBoxClosed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClosed.BackColor = Color.Transparent;
            pictureBoxClosed.Cursor = Cursors.Hand;
            pictureBoxClosed.Image = Properties.Resources.cerrar__2_;
            pictureBoxClosed.Location = new Point(647, 11);
            pictureBoxClosed.Name = "pictureBoxClosed";
            pictureBoxClosed.Size = new Size(39, 32);
            pictureBoxClosed.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClosed.TabIndex = 6;
            pictureBoxClosed.TabStop = false;
            pictureBoxClosed.Click += pictureBoxClosed_Click;
            pictureBoxClosed.MouseHover += pictureBoxClosed_MouseHover;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.DodgerBlue;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(3, 26);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(645, 44);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "Registrarse";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerGroupBox
            // 
            registerGroupBox.BackColor = Color.LightGray;
            registerGroupBox.Controls.Add(selectImageUserLabel);
            registerGroupBox.Controls.Add(photoNewUserPictureBox);
            registerGroupBox.Controls.Add(emailLabel);
            registerGroupBox.Controls.Add(emailTextBox);
            registerGroupBox.Controls.Add(userLabel);
            registerGroupBox.Controls.Add(userNameTextBox);
            registerGroupBox.Controls.Add(privacyLabel);
            registerGroupBox.Controls.Add(loginLabel);
            registerGroupBox.Controls.Add(existingAccountLabel);
            registerGroupBox.Controls.Add(titleLabel);
            registerGroupBox.Controls.Add(registerSaveButton);
            registerGroupBox.Controls.Add(cityLabel);
            registerGroupBox.Controls.Add(listCityComboBox);
            registerGroupBox.Controls.Add(listCountrysComboBox);
            registerGroupBox.Controls.Add(countryLabel);
            registerGroupBox.Controls.Add(BirthdayDataTimePicker);
            registerGroupBox.Controls.Add(phoneNumberLabel);
            registerGroupBox.Controls.Add(numberPhoneTextBox);
            registerGroupBox.Controls.Add(passwordLabel);
            registerGroupBox.Controls.Add(passwordTextBox);
            registerGroupBox.Controls.Add(nameLabel);
            registerGroupBox.Controls.Add(nameTexBox);
            registerGroupBox.Controls.Add(birthdayLabel);
            registerGroupBox.Controls.Add(lastNameLabel);
            registerGroupBox.Controls.Add(lastNameTexBox);
            registerGroupBox.Location = new Point(21, 49);
            registerGroupBox.Name = "registerGroupBox";
            registerGroupBox.Size = new Size(651, 963);
            registerGroupBox.TabIndex = 9;
            registerGroupBox.TabStop = false;
            // 
            // selectImageUserLabel
            // 
            selectImageUserLabel.AutoSize = true;
            selectImageUserLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            selectImageUserLabel.ForeColor = Color.SteelBlue;
            selectImageUserLabel.Location = new Point(183, 222);
            selectImageUserLabel.Name = "selectImageUserLabel";
            selectImageUserLabel.Size = new Size(265, 22);
            selectImageUserLabel.TabIndex = 45;
            selectImageUserLabel.Text = "Seleccione una foto de perfil";
            selectImageUserLabel.Click += labelSelectedImageUser_Click;
            // 
            // photoNewUserPictureBox
            // 
            photoNewUserPictureBox.BorderStyle = BorderStyle.Fixed3D;
            photoNewUserPictureBox.Location = new Point(253, 87);
            photoNewUserPictureBox.Name = "photoNewUserPictureBox";
            photoNewUserPictureBox.Size = new Size(154, 122);
            photoNewUserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            photoNewUserPictureBox.TabIndex = 44;
            photoNewUserPictureBox.TabStop = false;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(66, 443);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(181, 22);
            emailLabel.TabIndex = 42;
            emailLabel.Text = "Correo Electronico:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(253, 440);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(332, 30);
            emailTextBox.TabIndex = 43;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(161, 256);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(80, 22);
            userLabel.TabIndex = 38;
            userLabel.Text = "Usuario:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(253, 256);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(332, 30);
            userNameTextBox.TabIndex = 39;
            // 
            // privacyLabel
            // 
            privacyLabel.BackColor = Color.Transparent;
            privacyLabel.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            privacyLabel.ForeColor = Color.DimGray;
            privacyLabel.Location = new Point(40, 838);
            privacyLabel.Name = "privacyLabel";
            privacyLabel.Size = new Size(548, 80);
            privacyLabel.TabIndex = 37;
            privacyLabel.Text = "*Al registrarse, aceptas nuestros Terminos De Servicios, Politica de Privacidad y recibir  actualizaciones por parte de los InsanosSV";
            privacyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginLabel
            // 
            loginLabel.Cursor = Cursors.Hand;
            loginLabel.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.DodgerBlue;
            loginLabel.Location = new Point(365, 918);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(81, 30);
            loginLabel.TabIndex = 36;
            loginLabel.Text = "Ingresar";
            loginLabel.TextAlign = ContentAlignment.MiddleLeft;
            loginLabel.Click += lblLogin_Click;
            // 
            // existingAccountLabel
            // 
            existingAccountLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            existingAccountLabel.ForeColor = Color.Black;
            existingAccountLabel.Location = new Point(93, 918);
            existingAccountLabel.Name = "existingAccountLabel";
            existingAccountLabel.Size = new Size(236, 30);
            existingAccountLabel.TabIndex = 35;
            existingAccountLabel.Text = "¿Ya tienes una cuenta? ";
            existingAccountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // registerSaveButton
            // 
            registerSaveButton.BackColor = Color.DodgerBlue;
            registerSaveButton.FlatStyle = FlatStyle.Popup;
            registerSaveButton.ForeColor = Color.White;
            registerSaveButton.IconChar = FontAwesome.Sharp.IconChar.None;
            registerSaveButton.IconColor = Color.Black;
            registerSaveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            registerSaveButton.Location = new Point(198, 791);
            registerSaveButton.Name = "registerSaveButton";
            registerSaveButton.Size = new Size(248, 35);
            registerSaveButton.TabIndex = 34;
            registerSaveButton.Text = "Registrarse";
            registerSaveButton.UseVisualStyleBackColor = false;
            registerSaveButton.Click += btnNewAccount_Click;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(167, 737);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(80, 22);
            cityLabel.TabIndex = 33;
            cityLabel.Text = "Ciudad:";
            // 
            // listCityComboBox
            // 
            listCityComboBox.FormattingEnabled = true;
            listCityComboBox.Location = new Point(253, 729);
            listCityComboBox.Name = "listCityComboBox";
            listCityComboBox.Size = new Size(332, 30);
            listCityComboBox.TabIndex = 32;
            // 
            // listCountrysComboBox
            // 
            listCountrysComboBox.FormattingEnabled = true;
            listCountrysComboBox.Location = new Point(253, 666);
            listCountrysComboBox.Name = "listCountrysComboBox";
            listCountrysComboBox.Size = new Size(332, 30);
            listCountrysComboBox.TabIndex = 30;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(195, 669);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(49, 22);
            countryLabel.TabIndex = 31;
            countryLabel.Text = "Pais:";
            // 
            // BirthdayDataTimePicker
            // 
            BirthdayDataTimePicker.Location = new Point(253, 505);
            BirthdayDataTimePicker.Name = "BirthdayDataTimePicker";
            BirthdayDataTimePicker.Size = new Size(332, 30);
            BirthdayDataTimePicker.TabIndex = 29;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(150, 559);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(91, 22);
            phoneNumberLabel.TabIndex = 27;
            phoneNumberLabel.Text = "Telefono:";
            // 
            // numberPhoneTextBox
            // 
            numberPhoneTextBox.Location = new Point(253, 556);
            numberPhoneTextBox.Name = "numberPhoneTextBox";
            numberPhoneTextBox.Size = new Size(332, 30);
            numberPhoneTextBox.TabIndex = 28;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(123, 614);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(118, 22);
            passwordLabel.TabIndex = 25;
            passwordLabel.Text = "Contraseña:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(253, 614);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(332, 30);
            passwordTextBox.TabIndex = 26;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(154, 316);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(87, 22);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "Nombre:";
            // 
            // nameTexBox
            // 
            nameTexBox.Location = new Point(253, 316);
            nameTexBox.Name = "nameTexBox";
            nameTexBox.Size = new Size(332, 30);
            nameTexBox.TabIndex = 21;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new Point(34, 511);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(207, 22);
            birthdayLabel.TabIndex = 22;
            birthdayLabel.Text = "Fecha de Nacimiento:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(156, 384);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(88, 22);
            lastNameLabel.TabIndex = 23;
            lastNameLabel.Text = "Apellido:";
            // 
            // lastNameTexBox
            // 
            lastNameTexBox.Location = new Point(253, 376);
            lastNameTexBox.Name = "lastNameTexBox";
            lastNameTexBox.Size = new Size(332, 30);
            lastNameTexBox.TabIndex = 24;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipClicked += notifyIcon1_BalloonTipClicked;
            // 
            // NewAccountForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 54, 61);
            ClientSize = new Size(700, 1032);
            Controls.Add(registerGroupBox);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClosed);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearCuentaForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosed).EndInit();
            registerGroupBox.ResumeLayout(false);
            registerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)photoNewUserPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBoxClosed;
        private Label titleLabel;
        private GroupBox registerGroupBox;
        private DateTimePicker BirthdayDataTimePicker;
        private Label phoneNumberLabel;
        private TextBox numberPhoneTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label nameLabel;
        private TextBox nameTexBox;
        private Label birthdayLabel;
        private Label lastNameLabel;
        private TextBox lastNameTexBox;
        private FontAwesome.Sharp.IconButton registerSaveButton;
        private Label cityLabel;
        private ComboBox listCityComboBox;
        private ComboBox listCountrysComboBox;
        private Label countryLabel;
        private ToolTip toolTip1;
        private Label privacyLabel;
        private Label loginLabel;
        private Label existingAccountLabel;
        private Label userLabel;
        private TextBox userNameTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private NotifyIcon notifyIcon1;
        private Label selectImageUserLabel;
        private PictureBox photoNewUserPictureBox;
    }
}