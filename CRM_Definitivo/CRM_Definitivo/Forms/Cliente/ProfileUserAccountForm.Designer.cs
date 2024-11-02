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
            dtmDateUser = new DateTimePicker();
            label5 = new Label();
            txtLastNameUser = new TextBox();
            label4 = new Label();
            txtNumberphoneUser = new TextBox();
            label3 = new Label();
            txtNameUser = new TextBox();
            label2 = new Label();
            gbResidenceUser = new GroupBox();
            cboCityUser = new ComboBox();
            cboCountryUser = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            gbAccountUser = new GroupBox();
            txtPasswordChangeUser = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProfileUser).BeginInit();
            gbPhotoUser.SuspendLayout();
            gbInformationUser.SuspendLayout();
            gbResidenceUser.SuspendLayout();
            gbAccountUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pbProfileUser
            // 
            pbProfileUser.Location = new Point(60, 57);
            pbProfileUser.Name = "pbProfileUser";
            pbProfileUser.Size = new Size(142, 109);
            pbProfileUser.TabIndex = 0;
            pbProfileUser.TabStop = false;
            // 
            // gbPhotoUser
            // 
            gbPhotoUser.Controls.Add(lblPhotoProfileChangeUser);
            gbPhotoUser.Controls.Add(pbProfileUser);
            gbPhotoUser.Location = new Point(14, 12);
            gbPhotoUser.Name = "gbPhotoUser";
            gbPhotoUser.Size = new Size(281, 462);
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
            gbInformationUser.Controls.Add(dtmDateUser);
            gbInformationUser.Controls.Add(label5);
            gbInformationUser.Controls.Add(txtLastNameUser);
            gbInformationUser.Controls.Add(label4);
            gbInformationUser.Controls.Add(txtNumberphoneUser);
            gbInformationUser.Controls.Add(label3);
            gbInformationUser.Controls.Add(txtNameUser);
            gbInformationUser.Controls.Add(label2);
            gbInformationUser.Location = new Point(316, 23);
            gbInformationUser.Name = "gbInformationUser";
            gbInformationUser.Size = new Size(643, 163);
            gbInformationUser.TabIndex = 2;
            gbInformationUser.TabStop = false;
            gbInformationUser.Text = "Informacion";
            // 
            // dtmDateUser
            // 
            dtmDateUser.Location = new Point(364, 86);
            dtmDateUser.Name = "dtmDateUser";
            dtmDateUser.Size = new Size(250, 26);
            dtmDateUser.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 91);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 6;
            label5.Text = "Fecha:";
            // 
            // txtLastNameUser
            // 
            txtLastNameUser.Location = new Point(364, 37);
            txtLastNameUser.Name = "txtLastNameUser";
            txtLastNameUser.Size = new Size(250, 26);
            txtLastNameUser.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 40);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Apellido:";
            // 
            // txtNumberphoneUser
            // 
            txtNumberphoneUser.Location = new Point(94, 91);
            txtNumberphoneUser.Name = "txtNumberphoneUser";
            txtNumberphoneUser.Size = new Size(172, 26);
            txtNumberphoneUser.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 91);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // txtNameUser
            // 
            txtNameUser.Location = new Point(94, 40);
            txtNameUser.Name = "txtNameUser";
            txtNameUser.Size = new Size(172, 26);
            txtNameUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 40);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // gbResidenceUser
            // 
            gbResidenceUser.Controls.Add(cboCityUser);
            gbResidenceUser.Controls.Add(cboCountryUser);
            gbResidenceUser.Controls.Add(label9);
            gbResidenceUser.Controls.Add(label7);
            gbResidenceUser.Location = new Point(316, 208);
            gbResidenceUser.Name = "gbResidenceUser";
            gbResidenceUser.Size = new Size(643, 144);
            gbResidenceUser.TabIndex = 3;
            gbResidenceUser.TabStop = false;
            gbResidenceUser.Text = "Residenncia";
            // 
            // cboCityUser
            // 
            cboCityUser.FormattingEnabled = true;
            cboCityUser.Location = new Point(394, 59);
            cboCityUser.Name = "cboCityUser";
            cboCityUser.Size = new Size(208, 28);
            cboCityUser.TabIndex = 17;
            // 
            // cboCountryUser
            // 
            cboCountryUser.FormattingEnabled = true;
            cboCountryUser.Location = new Point(88, 59);
            cboCountryUser.Name = "cboCountryUser";
            cboCountryUser.Size = new Size(208, 28);
            cboCountryUser.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 59);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 8;
            label9.Text = "Pais:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(321, 62);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 12;
            label7.Text = "Ciudad:";
            // 
            // gbAccountUser
            // 
            gbAccountUser.Controls.Add(label1);
            gbAccountUser.Controls.Add(txtPasswordChangeUser);
            gbAccountUser.Controls.Add(label8);
            gbAccountUser.Location = new Point(316, 372);
            gbAccountUser.Name = "gbAccountUser";
            gbAccountUser.Size = new Size(643, 102);
            gbAccountUser.TabIndex = 3;
            gbAccountUser.TabStop = false;
            gbAccountUser.Text = "Cuenta";
            // 
            // txtPasswordChangeUser
            // 
            txtPasswordChangeUser.Location = new Point(124, 51);
            txtPasswordChangeUser.Name = "txtPasswordChangeUser";
            txtPasswordChangeUser.Size = new Size(172, 26);
            txtPasswordChangeUser.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 51);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 10;
            label8.Text = "Contraseña:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(980, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(572, 188);
            dataGridView1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(302, 54);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 2;
            label1.Text = "Cambiar contraseña";
            // 
            // ProfileUserAccountForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 549);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbProfileUser;
        private GroupBox gbPhotoUser;
        private Label lblPhotoProfileChangeUser;
        private GroupBox gbInformationUser;
        private Label label5;
        private TextBox txtLastNameUser;
        private Label label4;
        private TextBox txtNumberphoneUser;
        private Label label3;
        private TextBox txtNameUser;
        private Label label2;
        private GroupBox gbResidenceUser;
        private GroupBox gbAccountUser;
        private DateTimePicker dtmDateUser;
        private ComboBox cboCityUser;
        private ComboBox cboCountryUser;
        private Label label9;
        private Label label7;
        private Label label11;
        private Label label10;
        private TextBox txtPasswordChangeUser;
        private Label label8;
        private TextBox txt;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label1;
    }
}