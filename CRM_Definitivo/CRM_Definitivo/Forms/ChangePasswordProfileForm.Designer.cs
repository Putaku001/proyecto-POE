namespace PresentationLayer.Forms
{
    partial class ChangePasswordProfileForm
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
            textBoxCurrentPassword = new TextBox();
            textBoxNewPassword = new TextBox();
            textBoxNewPasswordConfirm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            iconButtonChangePassword = new FontAwesome.Sharp.IconButton();
            menuStrip1 = new MenuStrip();
            cambiarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCurrentPassword
            // 
            textBoxCurrentPassword.Location = new Point(62, 101);
            textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            textBoxCurrentPassword.Size = new Size(528, 27);
            textBoxCurrentPassword.TabIndex = 0;
            textBoxCurrentPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(62, 216);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(528, 27);
            textBoxNewPassword.TabIndex = 1;
            textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewPasswordConfirm
            // 
            textBoxNewPasswordConfirm.Location = new Point(62, 292);
            textBoxNewPasswordConfirm.Name = "textBoxNewPasswordConfirm";
            textBoxNewPasswordConfirm.Size = new Size(528, 27);
            textBoxNewPasswordConfirm.TabIndex = 2;
            textBoxNewPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(62, 77);
            label1.Name = "label1";
            label1.Size = new Size(252, 21);
            label1.TabIndex = 4;
            label1.Text = "Coloce su contraseña actual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(62, 194);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 5;
            label2.Text = "Contraseña nueva:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(62, 270);
            label3.Name = "label3";
            label3.Size = new Size(192, 21);
            label3.TabIndex = 6;
            label3.Text = "Confirmar contraseña:";
            // 
            // iconButtonChangePassword
            // 
            iconButtonChangePassword.BackColor = Color.LimeGreen;
            iconButtonChangePassword.FlatStyle = FlatStyle.Flat;
            iconButtonChangePassword.ForeColor = Color.White;
            iconButtonChangePassword.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButtonChangePassword.IconColor = Color.White;
            iconButtonChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonChangePassword.IconSize = 34;
            iconButtonChangePassword.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonChangePassword.Location = new Point(221, 362);
            iconButtonChangePassword.Name = "iconButtonChangePassword";
            iconButtonChangePassword.Size = new Size(250, 39);
            iconButtonChangePassword.TabIndex = 7;
            iconButtonChangePassword.Text = "Guardar contraseña";
            iconButtonChangePassword.UseVisualStyleBackColor = false;
            iconButtonChangePassword.Click += iconButtonChangePassword_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Turquoise;
            menuStrip1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cambiarContraseñaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(724, 31);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            cambiarContraseñaToolStripMenuItem.ForeColor = Color.White;
            cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            cambiarContraseñaToolStripMenuItem.Size = new Size(225, 27);
            cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            // 
            // ChangePasswordProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
            Controls.Add(iconButtonChangePassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNewPasswordConfirm);
            Controls.Add(textBoxNewPassword);
            Controls.Add(textBoxCurrentPassword);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ChangePasswordProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar Contraseña";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCurrentPassword;
        private TextBox textBoxNewPassword;
        private TextBox textBoxNewPasswordConfirm;
        private Label label1;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButtonChangePassword;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
    }
}