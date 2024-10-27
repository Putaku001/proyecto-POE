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
            lblAñadirUsuarios = new Label();
            label2 = new Label();
            txtName = new TextBox();
            cboRol = new ComboBox();
            label5 = new Label();
            gbDetallesUsuarios = new GroupBox();
            dtpBirthDate = new DateTimePicker();
            label10 = new Label();
            txtNumberPhone = new TextBox();
            cboStates = new ComboBox();
            label1 = new Label();
            label9 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtLastName = new TextBox();
            gbProvincia = new GroupBox();
            dtmFechaRegistro = new DateTimePicker();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            cboListCountrys = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            cboListCity = new ComboBox();
            gbDetallesUsuarios.SuspendLayout();
            gbProvincia.SuspendLayout();
            SuspendLayout();
            // 
            // lblAñadirUsuarios
            // 
            lblAñadirUsuarios.BackColor = SystemColors.HotTrack;
            lblAñadirUsuarios.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAñadirUsuarios.Location = new Point(-2, 9);
            lblAñadirUsuarios.Name = "lblAñadirUsuarios";
            lblAñadirUsuarios.Size = new Size(477, 39);
            lblAñadirUsuarios.TabIndex = 0;
            lblAñadirUsuarios.Text = "Añadir";
            lblAñadirUsuarios.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 98);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(248, 28);
            txtName.TabIndex = 2;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(109, 49);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(248, 27);
            cboRol.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 52);
            label5.Name = "label5";
            label5.Size = new Size(39, 19);
            label5.TabIndex = 8;
            label5.Text = "Rol:";
            // 
            // gbDetallesUsuarios
            // 
            gbDetallesUsuarios.Controls.Add(dtpBirthDate);
            gbDetallesUsuarios.Controls.Add(label10);
            gbDetallesUsuarios.Controls.Add(txtNumberPhone);
            gbDetallesUsuarios.Controls.Add(cboStates);
            gbDetallesUsuarios.Controls.Add(cboRol);
            gbDetallesUsuarios.Controls.Add(label1);
            gbDetallesUsuarios.Controls.Add(label9);
            gbDetallesUsuarios.Controls.Add(label5);
            gbDetallesUsuarios.Controls.Add(txtPassword);
            gbDetallesUsuarios.Controls.Add(label2);
            gbDetallesUsuarios.Controls.Add(txtName);
            gbDetallesUsuarios.Controls.Add(label3);
            gbDetallesUsuarios.Controls.Add(label4);
            gbDetallesUsuarios.Controls.Add(txtLastName);
            gbDetallesUsuarios.Location = new Point(13, 74);
            gbDetallesUsuarios.Name = "gbDetallesUsuarios";
            gbDetallesUsuarios.Size = new Size(462, 419);
            gbDetallesUsuarios.TabIndex = 15;
            gbDetallesUsuarios.TabStop = false;
            gbDetallesUsuarios.Text = "Datos Del Usuario";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(109, 190);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 28);
            dtpBirthDate.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 235);
            label10.Name = "label10";
            label10.Size = new Size(84, 19);
            label10.TabIndex = 17;
            label10.Text = "Telefono:";
            // 
            // txtNumberPhone
            // 
            txtNumberPhone.Location = new Point(109, 232);
            txtNumberPhone.Name = "txtNumberPhone";
            txtNumberPhone.Size = new Size(248, 28);
            txtNumberPhone.TabIndex = 18;
            // 
            // cboStates
            // 
            cboStates.FormattingEnabled = true;
            cboStates.Location = new Point(109, 329);
            cboStates.Name = "cboStates";
            cboStates.Size = new Size(248, 27);
            cboStates.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 332);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 16;
            label1.Text = "Estado:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 284);
            label9.Name = "label9";
            label9.Size = new Size(63, 19);
            label9.TabIndex = 7;
            label9.Text = "Clave:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(109, 282);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(248, 28);
            txtPassword.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 190);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 3;
            label3.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 146);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 5;
            label4.Text = "Apellido:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(109, 143);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(248, 28);
            txtLastName.TabIndex = 6;
            // 
            // gbProvincia
            // 
            gbProvincia.Controls.Add(dtmFechaRegistro);
            gbProvincia.Controls.Add(label8);
            gbProvincia.Controls.Add(cboListCity);
            gbProvincia.Controls.Add(cboListCountrys);
            gbProvincia.Controls.Add(label6);
            gbProvincia.Location = new Point(527, 74);
            gbProvincia.Name = "gbProvincia";
            gbProvincia.Size = new Size(462, 332);
            gbProvincia.TabIndex = 16;
            gbProvincia.TabStop = false;
            gbProvincia.Text = "Provinencia";
            // 
            // dtmFechaRegistro
            // 
            dtmFechaRegistro.Enabled = false;
            dtmFechaRegistro.Location = new Point(43, 226);
            dtmFechaRegistro.Name = "dtmFechaRegistro";
            dtmFechaRegistro.Size = new Size(380, 28);
            dtmFechaRegistro.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 28;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(401, 515);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(215, 46);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Añadir";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.HotTrack;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.White;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 28;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(401, 567);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(215, 46);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // cboListCountrys
            // 
            cboListCountrys.FormattingEnabled = true;
            cboListCountrys.Location = new Point(159, 101);
            cboListCountrys.Name = "cboListCountrys";
            cboListCountrys.Size = new Size(248, 27);
            cboListCountrys.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 101);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 10;
            label6.Text = "Pais:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 146);
            label8.Name = "label8";
            label8.Size = new Size(74, 19);
            label8.TabIndex = 14;
            label8.Text = "Ciudad:";
            // 
            // cboListCity
            // 
            cboListCity.FormattingEnabled = true;
            cboListCity.Location = new Point(159, 146);
            cboListCity.Name = "cboListCity";
            cboListCity.Size = new Size(248, 27);
            cboListCity.TabIndex = 13;
            // 
            // AddUsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1000, 620);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(gbProvincia);
            Controls.Add(lblAñadirUsuarios);
            Controls.Add(gbDetallesUsuarios);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir Usuarios";
            Load += AñadirUsuariosForm_Load;
            gbDetallesUsuarios.ResumeLayout(false);
            gbDetallesUsuarios.PerformLayout();
            gbProvincia.ResumeLayout(false);
            gbProvincia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAñadirUsuarios;
        private Label label2;
        private TextBox txtName;
        private ComboBox cboRol;
        private Label label5;
        private Label label7;
        private ComboBox c;
        private GroupBox gbDetallesUsuarios;
        private Label label9;
        private TextBox txtPassword;
        private GroupBox gbProvincia;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cboStates;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnEditar;
        private DateTimePicker dtmFechaRegistro;
        private Label label10;
        private TextBox txtNumberPhone;
        private Label label3;
        private Label label4;
        private TextBox txtLastName;
        private DateTimePicker dtpBirthDate;
        private Label label8;
        private ComboBox cboListCity;
        private ComboBox cboListCountrys;
        private Label label6;
    }
}