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
            gbProvincia = new GroupBox();
            label8 = new Label();
            cboListaCiudad = new ComboBox();
            cboListaPaises = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            cboListaDepartamento = new ComboBox();
            gbDetallesUsuarios = new GroupBox();
            label10 = new Label();
            cboEstado = new ComboBox();
            cboRol = new ComboBox();
            txtEdad = new TextBox();
            label1 = new Label();
            label9 = new Label();
            label5 = new Label();
            txtClave = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtUsuario = new TextBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            txtUserAccont = new TextBox();
            gbProvincia.SuspendLayout();
            gbDetallesUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // gbProvincia
            // 
            gbProvincia.Controls.Add(label8);
            gbProvincia.Controls.Add(cboListaCiudad);
            gbProvincia.Controls.Add(cboListaPaises);
            gbProvincia.Controls.Add(label7);
            gbProvincia.Controls.Add(label6);
            gbProvincia.Controls.Add(cboListaDepartamento);
            gbProvincia.Location = new Point(622, 67);
            gbProvincia.Name = "gbProvincia";
            gbProvincia.Size = new Size(578, 316);
            gbProvincia.TabIndex = 18;
            gbProvincia.TabStop = false;
            gbProvincia.Text = "Provinencia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(33, 174);
            label8.Name = "label8";
            label8.Size = new Size(74, 19);
            label8.TabIndex = 14;
            label8.Text = "Ciudad:";
            // 
            // cboListaCiudad
            // 
            cboListaCiudad.FormattingEnabled = true;
            cboListaCiudad.Location = new Point(198, 174);
            cboListaCiudad.Name = "cboListaCiudad";
            cboListaCiudad.Size = new Size(309, 27);
            cboListaCiudad.TabIndex = 13;
            // 
            // cboListaPaises
            // 
            cboListaPaises.FormattingEnabled = true;
            cboListaPaises.Location = new Point(198, 96);
            cboListaPaises.Name = "cboListaPaises";
            cboListaPaises.Size = new Size(309, 27);
            cboListaPaises.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(33, 135);
            label7.Name = "label7";
            label7.Size = new Size(131, 19);
            label7.TabIndex = 12;
            label7.Text = "Departamento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(33, 96);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 10;
            label6.Text = "Pais:";
            // 
            // cboListaDepartamento
            // 
            cboListaDepartamento.FormattingEnabled = true;
            cboListaDepartamento.Location = new Point(198, 136);
            cboListaDepartamento.Name = "cboListaDepartamento";
            cboListaDepartamento.Size = new Size(309, 27);
            cboListaDepartamento.TabIndex = 11;
            // 
            // gbDetallesUsuarios
            // 
            gbDetallesUsuarios.Controls.Add(label11);
            gbDetallesUsuarios.Controls.Add(txtUserAccont);
            gbDetallesUsuarios.Controls.Add(label10);
            gbDetallesUsuarios.Controls.Add(cboEstado);
            gbDetallesUsuarios.Controls.Add(cboRol);
            gbDetallesUsuarios.Controls.Add(txtEdad);
            gbDetallesUsuarios.Controls.Add(label1);
            gbDetallesUsuarios.Controls.Add(label9);
            gbDetallesUsuarios.Controls.Add(label5);
            gbDetallesUsuarios.Controls.Add(txtClave);
            gbDetallesUsuarios.Controls.Add(label2);
            gbDetallesUsuarios.Controls.Add(txtNombre);
            gbDetallesUsuarios.Controls.Add(label3);
            gbDetallesUsuarios.Controls.Add(txtCorreo);
            gbDetallesUsuarios.Controls.Add(label4);
            gbDetallesUsuarios.Controls.Add(txtUsuario);
            gbDetallesUsuarios.Location = new Point(11, 67);
            gbDetallesUsuarios.Name = "gbDetallesUsuarios";
            gbDetallesUsuarios.Size = new Size(578, 423);
            gbDetallesUsuarios.TabIndex = 17;
            gbDetallesUsuarios.TabStop = false;
            gbDetallesUsuarios.Text = "Datos Del Usuario";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(41, 181);
            label10.Name = "label10";
            label10.Size = new Size(56, 19);
            label10.TabIndex = 17;
            label10.Text = "Edad:";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(141, 359);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(309, 27);
            cboEstado.TabIndex = 15;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(141, 93);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(309, 27);
            cboRol.TabIndex = 7;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(141, 179);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(309, 28);
            txtEdad.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 363);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 16;
            label1.Text = "Estado:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(41, 317);
            label9.Name = "label9";
            label9.Size = new Size(63, 19);
            label9.TabIndex = 7;
            label9.Text = "Clave:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 97);
            label5.Name = "label5";
            label5.Size = new Size(39, 19);
            label5.TabIndex = 8;
            label5.Text = "Rol:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(141, 315);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(309, 28);
            txtClave.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 140);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(309, 28);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 227);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 3;
            label3.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(141, 224);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(309, 28);
            txtCorreo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(41, 270);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 5;
            label4.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(141, 268);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(309, 28);
            txtUsuario.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 28;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(497, 548);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(268, 43);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Actualizar datos";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(41, 49);
            label11.Name = "label11";
            label11.Size = new Size(73, 19);
            label11.TabIndex = 19;
            label11.Text = "Usuario:";
            // 
            // txtUserAccont
            // 
            txtUserAccont.Location = new Point(141, 46);
            txtUserAccont.Name = "txtUserAccont";
            txtUserAccont.Size = new Size(309, 28);
            txtUserAccont.TabIndex = 20;
            // 
            // EditUsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1216, 612);
            Controls.Add(btnGuardar);
            Controls.Add(gbProvincia);
            Controls.Add(gbDetallesUsuarios);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarUsuarioForm";
            gbProvincia.ResumeLayout(false);
            gbProvincia.PerformLayout();
            gbDetallesUsuarios.ResumeLayout(false);
            gbDetallesUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbProvincia;
        private Label label8;
        private ComboBox cboListaCiudad;
        private ComboBox cboListaPaises;
        private Label label7;
        private Label label6;
        private ComboBox cboListaDepartamento;
        private GroupBox gbDetallesUsuarios;
        private Label label10;
        private ComboBox cboEstado;
        private ComboBox cboRol;
        private TextBox txtEdad;
        private Label label1;
        private Label label9;
        private Label label5;
        private TextBox txtClave;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtUsuario;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblUserAccount;
        private TextBox txtUserAccount;
        private Label label11;
        private TextBox txtUserAccont;
    }
}