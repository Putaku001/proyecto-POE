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
            lblCrearCuenta = new Label();
            gbRegistrar = new GroupBox();
            btnNewAccount = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            cboListCity = new ComboBox();
            cboListCountrys = new ComboBox();
            label6 = new Label();
            dtpBirthDate = new DateTimePicker();
            label10 = new Label();
            txtNumberPhone = new TextBox();
            label9 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtLastName = new TextBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            lblLogin = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosed).BeginInit();
            gbRegistrar.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.BackColor = Color.Transparent;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(567, 11);
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
            pictureBoxClosed.Image = (Image)resources.GetObject("pictureBoxClosed.Image");
            pictureBoxClosed.Location = new Point(612, 11);
            pictureBoxClosed.Name = "pictureBoxClosed";
            pictureBoxClosed.Size = new Size(39, 32);
            pictureBoxClosed.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClosed.TabIndex = 6;
            pictureBoxClosed.TabStop = false;
            pictureBoxClosed.Click += pictureBoxClosed_Click;
            pictureBoxClosed.MouseHover += pictureBoxClosed_MouseHover;
            // 
            // lblCrearCuenta
            // 
            lblCrearCuenta.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearCuenta.Location = new Point(0, 50);
            lblCrearCuenta.Name = "lblCrearCuenta";
            lblCrearCuenta.Size = new Size(481, 30);
            lblCrearCuenta.TabIndex = 8;
            lblCrearCuenta.Text = "Registrarse";
            lblCrearCuenta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbRegistrar
            // 
            gbRegistrar.BackColor = Color.White;
            gbRegistrar.Controls.Add(label7);
            gbRegistrar.Controls.Add(lblLogin);
            gbRegistrar.Controls.Add(label1);
            gbRegistrar.Controls.Add(lblCrearCuenta);
            gbRegistrar.Controls.Add(btnNewAccount);
            gbRegistrar.Controls.Add(label8);
            gbRegistrar.Controls.Add(cboListCity);
            gbRegistrar.Controls.Add(cboListCountrys);
            gbRegistrar.Controls.Add(label6);
            gbRegistrar.Controls.Add(dtpBirthDate);
            gbRegistrar.Controls.Add(label10);
            gbRegistrar.Controls.Add(txtNumberPhone);
            gbRegistrar.Controls.Add(label9);
            gbRegistrar.Controls.Add(txtPassword);
            gbRegistrar.Controls.Add(label2);
            gbRegistrar.Controls.Add(txtName);
            gbRegistrar.Controls.Add(label3);
            gbRegistrar.Controls.Add(label4);
            gbRegistrar.Controls.Add(txtLastName);
            gbRegistrar.Location = new Point(91, 76);
            gbRegistrar.Name = "gbRegistrar";
            gbRegistrar.Size = new Size(481, 745);
            gbRegistrar.TabIndex = 9;
            gbRegistrar.TabStop = false;
            // 
            // btnNewAccount
            // 
            btnNewAccount.BackColor = Color.Turquoise;
            btnNewAccount.FlatStyle = FlatStyle.Flat;
            btnNewAccount.ForeColor = Color.White;
            btnNewAccount.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNewAccount.IconColor = Color.Black;
            btnNewAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNewAccount.Location = new Point(122, 569);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(248, 35);
            btnNewAccount.TabIndex = 34;
            btnNewAccount.Text = "Registrarse";
            btnNewAccount.UseVisualStyleBackColor = false;
            btnNewAccount.Click += btnNewAccount_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 492);
            label8.Name = "label8";
            label8.Size = new Size(67, 18);
            label8.TabIndex = 33;
            label8.Text = "Ciudad:";
            // 
            // cboListCity
            // 
            cboListCity.FormattingEnabled = true;
            cboListCity.Location = new Point(133, 489);
            cboListCity.Name = "cboListCity";
            cboListCity.Size = new Size(299, 26);
            cboListCity.TabIndex = 32;
            // 
            // cboListCountrys
            // 
            cboListCountrys.FormattingEnabled = true;
            cboListCountrys.Location = new Point(133, 444);
            cboListCountrys.Name = "cboListCountrys";
            cboListCountrys.Size = new Size(299, 26);
            cboListCountrys.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 447);
            label6.Name = "label6";
            label6.Size = new Size(40, 18);
            label6.TabIndex = 31;
            label6.Text = "Pais:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(133, 263);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(301, 26);
            dtpBirthDate.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 308);
            label10.Name = "label10";
            label10.Size = new Size(75, 18);
            label10.TabIndex = 27;
            label10.Text = "Telefono:";
            // 
            // txtNumberPhone
            // 
            txtNumberPhone.Location = new Point(133, 305);
            txtNumberPhone.Name = "txtNumberPhone";
            txtNumberPhone.Size = new Size(299, 26);
            txtNumberPhone.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 357);
            label9.Name = "label9";
            label9.Size = new Size(56, 18);
            label9.TabIndex = 25;
            label9.Text = "Clave:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(133, 355);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(299, 26);
            txtPassword.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 171);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 20;
            label2.Text = "Nombre:";
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 168);
            txtName.Name = "txtName";
            txtName.Size = new Size(299, 26);
            txtName.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 269);
            label3.Name = "label3";
            label3.Size = new Size(106, 18);
            label3.TabIndex = 22;
            label3.Text = "Cumpleaños:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 219);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 23;
            label4.Text = "Apellido:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(133, 216);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(299, 26);
            txtLastName.TabIndex = 24;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(122, 102);
            label1.Name = "label1";
            label1.Size = new Size(174, 30);
            label1.TabIndex = 35;
            label1.Text = "ya tienes una cuenta? ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            lblLogin.Cursor = Cursors.Hand;
            lblLogin.Font = new Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Turquoise;
            lblLogin.Location = new Point(289, 102);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(81, 30);
            lblLogin.TabIndex = 36;
            lblLogin.Text = "Ingresar";
            lblLogin.TextAlign = ContentAlignment.MiddleLeft;
            lblLogin.Click += lblLogin_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(6, 626);
            label7.Name = "label7";
            label7.Size = new Size(469, 80);
            label7.TabIndex = 37;
            label7.Text = "*Al registrarse, aceptas nuestros Terminos De Servicios, Politica de Privacidad y recibir  actualizaciones por parte de los InsanosSV";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NewAccountForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 858);
            Controls.Add(gbRegistrar);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClosed);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearCuentaForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosed).EndInit();
            gbRegistrar.ResumeLayout(false);
            gbRegistrar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBoxClosed;
        private Label lblCrearCuenta;
        private GroupBox gbRegistrar;
        private DateTimePicker dtpBirthDate;
        private Label label10;
        private TextBox txtNumberPhone;
        private Label label9;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private TextBox txtLastName;
        private FontAwesome.Sharp.IconButton btnNewAccount;
        private Label label8;
        private ComboBox cboListCity;
        private ComboBox cboListCountrys;
        private Label label6;
        private ToolTip toolTip1;
        private Label label7;
        private Label lblLogin;
        private Label label1;
    }
}