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
            pbProfileUser = new PictureBox();
            gbPhotoUser = new GroupBox();
            lblPhotoProfileChangeUser = new Label();
            gbInformationUser = new GroupBox();
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
            labelChangePasswordProfile = new Label();
            textboxPasswordChangeUser = new TextBox();
            label8 = new Label();
            textBoxUserAccount = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProfileUser).BeginInit();
            gbPhotoUser.SuspendLayout();
            gbInformationUser.SuspendLayout();
            gbResidenceUser.SuspendLayout();
            gbAccountUser.SuspendLayout();
            SuspendLayout();
            // 
            // pbProfileUser
            // 
            pbProfileUser.BackColor = Color.White;
            pbProfileUser.Location = new Point(60, 57);
            pbProfileUser.Name = "pbProfileUser";
            pbProfileUser.Size = new Size(142, 109);
            pbProfileUser.TabIndex = 0;
            pbProfileUser.TabStop = false;
            // 
            // gbPhotoUser
            // 
            gbPhotoUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPhotoUser.Controls.Add(lblPhotoProfileChangeUser);
            gbPhotoUser.Controls.Add(pbProfileUser);
            gbPhotoUser.Location = new Point(14, 12);
            gbPhotoUser.Name = "gbPhotoUser";
            gbPhotoUser.Size = new Size(285, 610);
            gbPhotoUser.TabIndex = 1;
            gbPhotoUser.TabStop = false;
            gbPhotoUser.Text = "Foto de perfil";
            // 
            // lblPhotoProfileChangeUser
            // 
            lblPhotoProfileChangeUser.AutoSize = true;
            lblPhotoProfileChangeUser.Cursor = Cursors.Hand;
            lblPhotoProfileChangeUser.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblPhotoProfileChangeUser.ForeColor = SystemColors.Highlight;
            lblPhotoProfileChangeUser.Location = new Point(46, 182);
            lblPhotoProfileChangeUser.Name = "lblPhotoProfileChangeUser";
            lblPhotoProfileChangeUser.Size = new Size(170, 20);
            lblPhotoProfileChangeUser.TabIndex = 1;
            lblPhotoProfileChangeUser.Text = "Cambiar foto de perfil";
            // 
            // gbInformationUser
            // 
            gbInformationUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbInformationUser.Controls.Add(datetimeDateUser);
            gbInformationUser.Controls.Add(label5);
            gbInformationUser.Controls.Add(textboxLastNameUser);
            gbInformationUser.Controls.Add(label4);
            gbInformationUser.Controls.Add(textboxNumberphoneUser);
            gbInformationUser.Controls.Add(label3);
            gbInformationUser.Controls.Add(textboxNameUser);
            gbInformationUser.Controls.Add(label2);
            gbInformationUser.Location = new Point(316, 23);
            gbInformationUser.Name = "gbInformationUser";
            gbInformationUser.Size = new Size(996, 311);
            gbInformationUser.TabIndex = 2;
            gbInformationUser.TabStop = false;
            gbInformationUser.Text = "Informacion";
            // 
            // datetimeDateUser
            // 
            datetimeDateUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            datetimeDateUser.Location = new Point(587, 95);
            datetimeDateUser.Name = "datetimeDateUser";
            datetimeDateUser.Size = new Size(389, 26);
            datetimeDateUser.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(508, 97);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 6;
            label5.Text = "Fecha:";
            // 
            // textboxLastNameUser
            // 
            textboxLastNameUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textboxLastNameUser.Location = new Point(587, 46);
            textboxLastNameUser.Name = "textboxLastNameUser";
            textboxLastNameUser.Size = new Size(389, 26);
            textboxLastNameUser.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(508, 46);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Apellido:";
            // 
            // textboxNumberphoneUser
            // 
            textboxNumberphoneUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textboxNumberphoneUser.Location = new Point(94, 91);
            textboxNumberphoneUser.Name = "textboxNumberphoneUser";
            textboxNumberphoneUser.Size = new Size(389, 26);
            textboxNumberphoneUser.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(16, 91);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // textboxNameUser
            // 
            textboxNameUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textboxNameUser.Location = new Point(94, 40);
            textboxNameUser.Name = "textboxNameUser";
            textboxNameUser.Size = new Size(389, 26);
            textboxNameUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(16, 40);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
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
            gbResidenceUser.Location = new Point(316, 208);
            gbResidenceUser.Name = "gbResidenceUser";
            gbResidenceUser.Size = new Size(996, 292);
            gbResidenceUser.TabIndex = 3;
            gbResidenceUser.TabStop = false;
            gbResidenceUser.Text = "Residenncia";
            // 
            // iconButtonSaveProfile
            // 
            iconButtonSaveProfile.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSaveProfile.IconColor = Color.Black;
            iconButtonSaveProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSaveProfile.Location = new Point(94, 132);
            iconButtonSaveProfile.Name = "iconButtonSaveProfile";
            iconButtonSaveProfile.Size = new Size(94, 29);
            iconButtonSaveProfile.TabIndex = 4;
            iconButtonSaveProfile.Text = "Guardar";
            iconButtonSaveProfile.UseVisualStyleBackColor = true;
            iconButtonSaveProfile.Click += iconButtonSaveProfile_Click;
            // 
            // comboboxCityUser
            // 
            comboboxCityUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboboxCityUser.FormattingEnabled = true;
            comboboxCityUser.Location = new Point(587, 73);
            comboboxCityUser.Name = "comboboxCityUser";
            comboboxCityUser.Size = new Size(403, 28);
            comboboxCityUser.TabIndex = 17;
            // 
            // comboboxCountryUser
            // 
            comboboxCountryUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboboxCountryUser.FormattingEnabled = true;
            comboboxCountryUser.Location = new Point(88, 73);
            comboboxCountryUser.Name = "comboboxCountryUser";
            comboboxCountryUser.Size = new Size(395, 28);
            comboboxCountryUser.TabIndex = 16;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(39, 73);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 8;
            label9.Text = "Pais:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(514, 76);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
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
            gbAccountUser.Location = new Point(316, 372);
            gbAccountUser.Name = "gbAccountUser";
            gbAccountUser.Size = new Size(996, 250);
            gbAccountUser.TabIndex = 3;
            gbAccountUser.TabStop = false;
            gbAccountUser.Text = "Cuenta";
            // 
            // labelChangePasswordProfile
            // 
            labelChangePasswordProfile.AutoSize = true;
            labelChangePasswordProfile.Cursor = Cursors.Hand;
            labelChangePasswordProfile.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelChangePasswordProfile.ForeColor = SystemColors.Highlight;
            labelChangePasswordProfile.Location = new Point(404, 132);
            labelChangePasswordProfile.Name = "labelChangePasswordProfile";
            labelChangePasswordProfile.Size = new Size(160, 20);
            labelChangePasswordProfile.TabIndex = 2;
            labelChangePasswordProfile.Text = "Cambiar contraseña";
            labelChangePasswordProfile.Click += labelChangePasswordProfile_Click;
            // 
            // textboxPasswordChangeUser
            // 
            textboxPasswordChangeUser.Location = new Point(144, 129);
            textboxPasswordChangeUser.Name = "textboxPasswordChangeUser";
            textboxPasswordChangeUser.Size = new Size(254, 26);
            textboxPasswordChangeUser.TabIndex = 11;
            textboxPasswordChangeUser.Text = "pruebadestacochinada";
            textboxPasswordChangeUser.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 129);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 10;
            label8.Text = "Contraseña:";
            // 
            // textBoxUserAccount
            // 
            textBoxUserAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxUserAccount.Location = new Point(144, 85);
            textBoxUserAccount.Name = "textBoxUserAccount";
            textBoxUserAccount.Size = new Size(389, 26);
            textBoxUserAccount.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(38, 88);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "Usuario:";
            // 
            // ProfileUserAccountForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 697);
            Controls.Add(gbAccountUser);
            Controls.Add(gbResidenceUser);
            Controls.Add(gbInformationUser);
            Controls.Add(gbPhotoUser);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ProfileUserAccountForm";
            Text = "ProfileUserAccountForm";
            ((System.ComponentModel.ISupportInitialize)pbProfileUser).EndInit();
            gbPhotoUser.ResumeLayout(false);
            gbPhotoUser.PerformLayout();
            gbInformationUser.ResumeLayout(false);
            gbInformationUser.PerformLayout();
            gbResidenceUser.ResumeLayout(false);
            gbResidenceUser.PerformLayout();
            gbAccountUser.ResumeLayout(false);
            gbAccountUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbProfileUser;
        private GroupBox gbPhotoUser;
        private Label lblPhotoProfileChangeUser;
        private GroupBox gbInformationUser;
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
    }
}