namespace PresentationLayer.Forms
{
    partial class AñadirUsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirUsuariosForm));
            lblAñadirUsuarios = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label4 = new Label();
            cboRol = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cboListaPaises = new ComboBox();
            label7 = new Label();
            cboListaDepartamento = new ComboBox();
            label8 = new Label();
            cboListaCiudad = new ComboBox();
            gbDetallesUsuarios = new GroupBox();
            label10 = new Label();
            cboEstado = new ComboBox();
            txtEdad = new TextBox();
            label1 = new Label();
            label9 = new Label();
            txtClave = new TextBox();
            gbProvincia = new GroupBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
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
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 28);
            txtNombre.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(109, 187);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(248, 28);
            txtCorreo.TabIndex = 4;
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
            // txtUsuario
            // 
            txtUsuario.Location = new Point(109, 232);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(248, 28);
            txtUsuario.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 235);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 5;
            label4.Text = "Usuario:";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 101);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 10;
            label6.Text = "Pais:";
            // 
            // cboListaPaises
            // 
            cboListaPaises.FormattingEnabled = true;
            cboListaPaises.Location = new Point(159, 101);
            cboListaPaises.Name = "cboListaPaises";
            cboListaPaises.Size = new Size(248, 27);
            cboListaPaises.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 142);
            label7.Name = "label7";
            label7.Size = new Size(131, 19);
            label7.TabIndex = 12;
            label7.Text = "Departamento:";
            // 
            // cboListaDepartamento
            // 
            cboListaDepartamento.FormattingEnabled = true;
            cboListaDepartamento.Location = new Point(159, 143);
            cboListaDepartamento.Name = "cboListaDepartamento";
            cboListaDepartamento.Size = new Size(248, 27);
            cboListaDepartamento.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 183);
            label8.Name = "label8";
            label8.Size = new Size(74, 19);
            label8.TabIndex = 14;
            label8.Text = "Ciudad:";
            // 
            // cboListaCiudad
            // 
            cboListaCiudad.FormattingEnabled = true;
            cboListaCiudad.Location = new Point(159, 183);
            cboListaCiudad.Name = "cboListaCiudad";
            cboListaCiudad.Size = new Size(248, 27);
            cboListaCiudad.TabIndex = 13;
            // 
            // gbDetallesUsuarios
            // 
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
            gbDetallesUsuarios.Location = new Point(13, 74);
            gbDetallesUsuarios.Name = "gbDetallesUsuarios";
            gbDetallesUsuarios.Size = new Size(462, 445);
            gbDetallesUsuarios.TabIndex = 15;
            gbDetallesUsuarios.TabStop = false;
            gbDetallesUsuarios.Text = "Datos Del Usuario";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 141);
            label10.Name = "label10";
            label10.Size = new Size(56, 19);
            label10.TabIndex = 17;
            label10.Text = "Edad:";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(109, 329);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(248, 27);
            cboEstado.TabIndex = 15;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(109, 139);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(248, 28);
            txtEdad.TabIndex = 18;
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
            // txtClave
            // 
            txtClave.Location = new Point(109, 282);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(248, 28);
            txtClave.TabIndex = 8;
            // 
            // gbProvincia
            // 
            gbProvincia.Controls.Add(label8);
            gbProvincia.Controls.Add(cboListaCiudad);
            gbProvincia.Controls.Add(cboListaPaises);
            gbProvincia.Controls.Add(label7);
            gbProvincia.Controls.Add(label6);
            gbProvincia.Controls.Add(cboListaDepartamento);
            gbProvincia.Location = new Point(527, 74);
            gbProvincia.Name = "gbProvincia";
            gbProvincia.Size = new Size(462, 332);
            gbProvincia.TabIndex = 16;
            gbProvincia.TabStop = false;
            gbProvincia.Text = "Provinencia";
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
            btnGuardar.Location = new Point(397, 562);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(215, 46);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Añadir";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // AñadirUsuariosForm
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1000, 620);
            Controls.Add(btnGuardar);
            Controls.Add(gbProvincia);
            Controls.Add(lblAñadirUsuarios);
            Controls.Add(gbDetallesUsuarios);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AñadirUsuariosForm";
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
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label label3;
        private TextBox txtUsuario;
        private Label label4;
        private ComboBox cboRol;
        private Label label5;
        private Label label6;
        private ComboBox cboListaPaises;
        private Label label7;
        private ComboBox cboListaDepartamento;
        private Label label8;
        private ComboBox cboListaCiudad;
        private GroupBox gbDetallesUsuarios;
        private Label label9;
        private TextBox txtClave;
        private GroupBox gbProvincia;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cboEstado;
        private Label label1;
        private Label label10;
        private TextBox txtEdad;
    }
}