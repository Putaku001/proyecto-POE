namespace PresentationLayer.Forms.Cliente
{
    partial class ProfileUserAccountForm
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
            pictureBoxProfileUser = new PictureBox();
            lblPhotoProfileChangeUser = new Label();
            informationUserGroupBox = new GroupBox();
            datetimeDateUser = new DateTimePicker();
            label5 = new Label();
            textboxLastNameUser = new TextBox();
            label4 = new Label();
            textboxNumberphoneUser = new TextBox();
            label3 = new Label();
            textboxNameUser = new TextBox();
            label2 = new Label();
            gbResidenceUser = new GroupBox();
            iconButtonSaveProfile = new FontAwesome.Sharp.IconButton();
            comboboxCityUser = new ComboBox();
            comboboxCountryUser = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            gbAccountUser = new GroupBox();
            textBoxUserAccount = new TextBox();
            label1 = new Label();
            labelChangePasswordProfile = new Label();
            textboxPasswordChangeUser = new TextBox();
            label8 = new Label();
            photoUserPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfileUser).BeginInit();
            informationUserGroupBox.SuspendLayout();
            gbResidenceUser.SuspendLayout();
            gbAccountUser.SuspendLayout();
            photoUserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxProfileUser
            // 
            pictureBoxProfileUser.BackColor = Color.White;
            pictureBoxProfileUser.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxProfileUser.Location = new Point(59, 53);
            pictureBoxProfileUser.Name = "pictureBoxProfileUser";
            pictureBoxProfileUser.Size = new Size(137, 128);
            pictureBoxProfileUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfileUser.TabIndex = 0;
            pictureBoxProfileUser.TabStop = false;
            // 
            // lblPhotoProfileChangeUser
            // 
            lblPhotoProfileChangeUser.AutoSize = true;
            lblPhotoProfileChangeUser.BackColor = Color.FromArgb(46, 54, 61);
            lblPhotoProfileChangeUser.Cursor = Cursors.Hand;
            lblPhotoProfileChangeUser.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblPhotoProfileChangeUser.ForeColor = Color.White;
            lblPhotoProfileChangeUser.Location = new Point(41, 208);
            lblPhotoProfileChangeUser.Name = "lblPhotoProfileChangeUser";
            lblPhotoProfileChangeUser.Size = new Size(170, 20);
            lblPhotoProfileChangeUser.TabIndex = 1;
            lblPhotoProfileChangeUser.Text = "Cambiar foto de perfil";
            lblPhotoProfileChangeUser.Click += lblPhotoProfileChangeUser_Click;
            // 
            // informationUserGroupBox
            // 
            informationUserGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            informationUserGroupBox.Controls.Add(datetimeDateUser);
            informationUserGroupBox.Controls.Add(label5);
            informationUserGroupBox.Controls.Add(textboxLastNameUser);
            informationUserGroupBox.Controls.Add(label4);
            informationUserGroupBox.Controls.Add(textboxNumberphoneUser);
            informationUserGroupBox.Controls.Add(label3);
            informationUserGroupBox.Controls.Add(textboxNameUser);
            informationUserGroupBox.Controls.Add(label2);
            informationUserGroupBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            informationUserGroupBox.Location = new Point(280, 30);
            informationUserGroupBox.Name = "informationUserGroupBox";
            informationUserGroupBox.Size = new Size(952, 323);
            informationUserGroupBox.TabIndex = 2;
            informationUserGroupBox.TabStop = false;
            informationUserGroupBox.Text = "Informacion";
            // 
            // datetimeDateUser
            // 
            datetimeDateUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            datetimeDateUser.Location = new Point(127, 265);
            datetimeDateUser.Name = "datetimeDateUser";
            datetimeDateUser.Size = new Size(389, 28);
            datetimeDateUser.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(34, 263);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 6;
            label5.Text = "Fecha:";
            // 
            // textboxLastNameUser
            // 
            textboxLastNameUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textboxLastNameUser.Location = new Point(127, 123);
            textboxLastNameUser.Name = "textboxLastNameUser";
            textboxLastNameUser.Size = new Size(389, 28);
            textboxLastNameUser.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(13, 123);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 4;
            label4.Text = "Apellido:";
            // 
            // textboxNumberphoneUser
            // 
            textboxNumberphoneUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textboxNumberphoneUser.Location = new Point(127, 197);
            textboxNumberphoneUser.Name = "textboxNumberphoneUser";
            textboxNumberphoneUser.Size = new Size(389, 28);
            textboxNumberphoneUser.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(13, 197);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // textboxNameUser
            // 
            textboxNameUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textboxNameUser.Location = new Point(127, 40);
            textboxNameUser.Name = "textboxNameUser";
            textboxNameUser.Size = new Size(389, 28);
            textboxNameUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(16, 40);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // gbResidenceUser
            // 
            gbResidenceUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbResidenceUser.Controls.Add(iconButtonSaveProfile);
            gbResidenceUser.Controls.Add(comboboxCityUser);
            gbResidenceUser.Controls.Add(comboboxCountryUser);
            gbResidenceUser.Controls.Add(label9);
            gbResidenceUser.Controls.Add(label7);
            gbResidenceUser.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbResidenceUser.Location = new Point(280, 372);
            gbResidenceUser.Name = "gbResidenceUser";
            gbResidenceUser.Size = new Size(952, 278);
            gbResidenceUser.TabIndex = 3;
            gbResidenceUser.TabStop = false;
            gbResidenceUser.Text = "Residenncia";
            // 
            // iconButtonSaveProfile
            // 
            iconButtonSaveProfile.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSaveProfile.IconColor = Color.Black;
            iconButtonSaveProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSaveProfile.Location = new Point(127, 204);
            iconButtonSaveProfile.Name = "iconButtonSaveProfile";
            iconButtonSaveProfile.Size = new Size(141, 40);
            iconButtonSaveProfile.TabIndex = 4;
            iconButtonSaveProfile.Text = "Guardar";
            iconButtonSaveProfile.UseVisualStyleBackColor = true;
            iconButtonSaveProfile.Click += iconButtonSaveProfile_Click;
            // 
            // comboboxCityUser
            // 
            comboboxCityUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboboxCityUser.FormattingEnabled = true;
            comboboxCityUser.Location = new Point(127, 131);
            comboboxCityUser.Name = "comboboxCityUser";
            comboboxCityUser.Size = new Size(351, 29);
            comboboxCityUser.TabIndex = 17;
            // 
            // comboboxCountryUser
            // 
            comboboxCountryUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboboxCountryUser.FormattingEnabled = true;
            comboboxCountryUser.Location = new Point(127, 48);
            comboboxCountryUser.Name = "comboboxCountryUser";
            comboboxCountryUser.Size = new Size(351, 29);
            comboboxCountryUser.TabIndex = 16;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(59, 48);
            label9.Name = "label9";
            label9.Size = new Size(47, 21);
            label9.TabIndex = 8;
            label9.Text = "Pais:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(23, 131);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 12;
            label7.Text = "Ciudad:";
            // 
            // gbAccountUser
            // 
            gbAccountUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAccountUser.Controls.Add(textBoxUserAccount);
            gbAccountUser.Controls.Add(label1);
            gbAccountUser.Controls.Add(labelChangePasswordProfile);
            gbAccountUser.Controls.Add(textboxPasswordChangeUser);
            gbAccountUser.Controls.Add(label8);
            gbAccountUser.Location = new Point(280, 680);
            gbAccountUser.Name = "gbAccountUser";
            gbAccountUser.Size = new Size(442, 201);
            gbAccountUser.TabIndex = 3;
            gbAccountUser.TabStop = false;
            gbAccountUser.Text = "Cuenta";
            // 
            // textBoxUserAccount
            // 
            textBoxUserAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxUserAccount.Location = new Point(141, 46);
            textBoxUserAccount.Name = "textBoxUserAccount";
            textBoxUserAccount.Size = new Size(281, 26);
            textBoxUserAccount.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(34, 55);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "Usuario:";
            // 
            // labelChangePasswordProfile
            // 
            labelChangePasswordProfile.AutoSize = true;
            labelChangePasswordProfile.Cursor = Cursors.Hand;
            labelChangePasswordProfile.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelChangePasswordProfile.ForeColor = SystemColors.Highlight;
            labelChangePasswordProfile.Location = new Point(195, 159);
            labelChangePasswordProfile.Name = "labelChangePasswordProfile";
            labelChangePasswordProfile.Size = new Size(160, 20);
            labelChangePasswordProfile.TabIndex = 2;
            labelChangePasswordProfile.Text = "Cambiar contraseña";
            labelChangePasswordProfile.Click += labelChangePasswordProfile_Click;
            // 
            // textboxPasswordChangeUser
            // 
            textboxPasswordChangeUser.Location = new Point(141, 130);
            textboxPasswordChangeUser.Name = "textboxPasswordChangeUser";
            textboxPasswordChangeUser.Size = new Size(281, 26);
            textboxPasswordChangeUser.TabIndex = 11;
            textboxPasswordChangeUser.Text = "pruebadestacochinada";
            textboxPasswordChangeUser.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 130);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 10;
            label8.Text = "Contraseña:";
            // 
            // photoUserPanel
            // 
            photoUserPanel.Controls.Add(lblPhotoProfileChangeUser);
            photoUserPanel.Controls.Add(pictureBoxProfileUser);
            photoUserPanel.Dock = DockStyle.Left;
            photoUserPanel.Location = new Point(0, 0);
            photoUserPanel.Name = "photoUserPanel";
            photoUserPanel.Size = new Size(250, 911);
            photoUserPanel.TabIndex = 4;
            // 
            // ProfileUserAccountForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1483, 911);
            Controls.Add(photoUserPanel);
            Controls.Add(gbAccountUser);
            Controls.Add(gbResidenceUser);
            Controls.Add(informationUserGroupBox);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1640, 960);
            Name = "ProfileUserAccountForm";
            Text = "Perfil de Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfileUser).EndInit();
            informationUserGroupBox.ResumeLayout(false);
            informationUserGroupBox.PerformLayout();
            gbResidenceUser.ResumeLayout(false);
            gbResidenceUser.PerformLayout();
            gbAccountUser.ResumeLayout(false);
            gbAccountUser.PerformLayout();
            photoUserPanel.ResumeLayout(false);
            photoUserPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxProfileUser;
        private Label lblPhotoProfileChangeUser;
        private GroupBox informationUserGroupBox;
        private Label label5;
        private TextBox textboxLastNameUser;
        private Label label4;
        private TextBox textboxNumberphoneUser;
        private Label label3;
        private TextBox textboxNameUser;
        private Label label2;
        private GroupBox gbResidenceUser;
        private GroupBox gbAccountUser;
        private DateTimePicker datetimeDateUser;
        private ComboBox comboboxCityUser;
        private ComboBox comboboxCountryUser;
        private Label label9;
        private Label label7;
        private Label label11;
        private Label label10;
        private TextBox textboxPasswordChangeUser;
        private Label label8;
        private TextBox txt;
        private Label label6;
        private Label labelChangePasswordProfile;
        private FontAwesome.Sharp.IconButton iconButtonSaveProfile;
        private TextBox textBoxUserAccount;
        private Label label1;
        private Panel photoUserPanel;
    }
}