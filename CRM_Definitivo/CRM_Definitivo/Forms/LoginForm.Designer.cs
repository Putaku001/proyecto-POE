namespace CRM_Definitivo
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            gbLogin = new GroupBox();
            pictureBoxMostrar = new PictureBox();
            pictureBoxOcultar = new PictureBox();
            lblCrearCuenta = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            fotgotPassLabel = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            txtUser = new TextBox();
            label1 = new Label();
            pictureBoxMinimize = new PictureBox();
            pictureBoxClosed = new PictureBox();
            toolTip1 = new ToolTip(components);
            gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOcultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosed).BeginInit();
            SuspendLayout();
            // 
            // gbLogin
            // 
            gbLogin.Anchor = AnchorStyles.None;
            gbLogin.BackColor = Color.Transparent;
            gbLogin.Controls.Add(pictureBoxMostrar);
            gbLogin.Controls.Add(pictureBoxOcultar);
            gbLogin.Controls.Add(lblCrearCuenta);
            gbLogin.Controls.Add(label4);
            gbLogin.Controls.Add(pictureBox1);
            gbLogin.Controls.Add(fotgotPassLabel);
            gbLogin.Controls.Add(txtPassword);
            gbLogin.Controls.Add(label2);
            gbLogin.Controls.Add(btnLogin);
            gbLogin.Controls.Add(txtUser);
            gbLogin.Controls.Add(label1);
            gbLogin.FlatStyle = FlatStyle.Flat;
            gbLogin.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbLogin.ForeColor = Color.White;
            gbLogin.Location = new Point(378, 106);
            gbLogin.Margin = new Padding(3, 2, 3, 2);
            gbLogin.Name = "gbLogin";
            gbLogin.Padding = new Padding(3, 2, 3, 2);
            gbLogin.Size = new Size(466, 282);
            gbLogin.TabIndex = 1;
            gbLogin.TabStop = false;
            gbLogin.Text = "Inicio de sesion";
            // 
            // pictureBoxMostrar
            // 
            pictureBoxMostrar.Image = PresentationLayer.Properties.Resources._3844476_eye_see_show_view_watch_110339;
            pictureBoxMostrar.Location = new Point(372, 155);
            pictureBoxMostrar.Margin = new Padding(3, 2, 3, 2);
            pictureBoxMostrar.Name = "pictureBoxMostrar";
            pictureBoxMostrar.Size = new Size(23, 20);
            pictureBoxMostrar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMostrar.TabIndex = 11;
            pictureBoxMostrar.TabStop = false;
            pictureBoxMostrar.Click += pictureBoxMostrar_Click;
            pictureBoxMostrar.MouseHover += pictureBoxMostrar_MouseHover;
            // 
            // pictureBoxOcultar
            // 
            pictureBoxOcultar.Image = PresentationLayer.Properties.Resources._3844477_disable_eye_inactive_see_show_view_watch_110343;
            pictureBoxOcultar.Location = new Point(372, 155);
            pictureBoxOcultar.Margin = new Padding(3, 2, 3, 2);
            pictureBoxOcultar.Name = "pictureBoxOcultar";
            pictureBoxOcultar.Size = new Size(23, 20);
            pictureBoxOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOcultar.TabIndex = 10;
            pictureBoxOcultar.TabStop = false;
            pictureBoxOcultar.Click += pictureBoxOcultar_Click;
            pictureBoxOcultar.MouseHover += pictureBoxOcultar_MouseHover;
            // 
            // lblCrearCuenta
            // 
            lblCrearCuenta.AutoSize = true;
            lblCrearCuenta.Cursor = Cursors.Hand;
            lblCrearCuenta.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCrearCuenta.ForeColor = Color.DarkCyan;
            lblCrearCuenta.Location = new Point(276, 254);
            lblCrearCuenta.Name = "lblCrearCuenta";
            lblCrearCuenta.Size = new Size(92, 16);
            lblCrearCuenta.TabIndex = 9;
            lblCrearCuenta.Text = "create una ya!";
            lblCrearCuenta.Click += lblCrearCuenta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(102, 254);
            label4.Name = "label4";
            label4.Size = new Size(161, 16);
            label4.TabIndex = 7;
            label4.Text = "Aun no tienes una cuenta?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = PresentationLayer.Properties.Resources.projects_icon_142976;
            pictureBox1.Location = new Point(208, 19);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // fotgotPassLabel
            // 
            fotgotPassLabel.AutoSize = true;
            fotgotPassLabel.Cursor = Cursors.Hand;
            fotgotPassLabel.ForeColor = Color.LightGray;
            fotgotPassLabel.Location = new Point(244, 177);
            fotgotPassLabel.Name = "fotgotPassLabel";
            fotgotPassLabel.Size = new Size(121, 16);
            fotgotPassLabel.TabIndex = 5;
            fotgotPassLabel.Text = "Forgot a password?";
            fotgotPassLabel.Click += fotgotPassLabel_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(112, 155);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 22);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 132);
            label2.Name = "label2";
            label2.Size = new Size(77, 16);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Turquoise;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(112, 218);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(262, 22);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(112, 110);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(263, 22);
            txtUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 87);
            label1.Name = "label1";
            label1.Size = new Size(53, 16);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.BackColor = Color.Transparent;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(1137, 9);
            pictureBoxMinimize.Margin = new Padding(3, 2, 3, 2);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(31, 26);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 5;
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
            pictureBoxClosed.Location = new Point(1181, 9);
            pictureBoxClosed.Margin = new Padding(3, 2, 3, 2);
            pictureBoxClosed.Name = "pictureBoxClosed";
            pictureBoxClosed.Size = new Size(31, 26);
            pictureBoxClosed.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClosed.TabIndex = 4;
            pictureBoxClosed.TabStop = false;
            pictureBoxClosed.Click += pictureBoxClosed_Click;
            pictureBoxClosed.MouseHover += pictureBoxClosed_MouseHover;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = PresentationLayer.Properties.Resources._377721;
            ClientSize = new Size(1222, 495);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClosed);
            Controls.Add(gbLogin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOcultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbLogin;
        private Label lblCrearCuenta;
        private Label label4;
        private PictureBox pictureBox1;
        private Label fotgotPassLabel;
        private TextBox txtPassword;
        private Label label2;
        private Button btnLogin;
        private TextBox txtUser;
        private Label label1;
        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBoxClosed;
        private ToolTip toolTip1;
        private PictureBox pictureBoxMostrar;
        private PictureBox pictureBoxOcultar;
    }
}
