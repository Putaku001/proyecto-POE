namespace PresentationLayer.Forms
{
    partial class ChangePasswordForm
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
            newPasswordTexBox = new TextBox();
            confirmPasswordTexBox = new TextBox();
            MenuChangePassGroupBox = new GroupBox();
            iconButtonChangePassword = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            NewPassLabel = new Label();
            menuStrip1 = new MenuStrip();
            restablecerLaContraseñaToolStripMenuItem = new ToolStripMenuItem();
            MenuChangePassGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // newPasswordTexBox
            // 
            newPasswordTexBox.Font = new Font("Century Gothic", 7.8F);
            newPasswordTexBox.Location = new Point(73, 101);
            newPasswordTexBox.Margin = new Padding(3, 4, 3, 4);
            newPasswordTexBox.Name = "newPasswordTexBox";
            newPasswordTexBox.Size = new Size(382, 23);
            newPasswordTexBox.TabIndex = 0;
            newPasswordTexBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordTexBox
            // 
            confirmPasswordTexBox.Font = new Font("Century Gothic", 7.8F);
            confirmPasswordTexBox.Location = new Point(73, 178);
            confirmPasswordTexBox.Margin = new Padding(3, 4, 3, 4);
            confirmPasswordTexBox.Name = "confirmPasswordTexBox";
            confirmPasswordTexBox.Size = new Size(382, 23);
            confirmPasswordTexBox.TabIndex = 1;
            confirmPasswordTexBox.UseSystemPasswordChar = true;
            // 
            // MenuChangePassGroupBox
            // 
            MenuChangePassGroupBox.Controls.Add(iconButtonChangePassword);
            MenuChangePassGroupBox.Controls.Add(label1);
            MenuChangePassGroupBox.Controls.Add(NewPassLabel);
            MenuChangePassGroupBox.Controls.Add(confirmPasswordTexBox);
            MenuChangePassGroupBox.Controls.Add(newPasswordTexBox);
            MenuChangePassGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MenuChangePassGroupBox.Location = new Point(261, 140);
            MenuChangePassGroupBox.Margin = new Padding(3, 4, 3, 4);
            MenuChangePassGroupBox.Name = "MenuChangePassGroupBox";
            MenuChangePassGroupBox.Padding = new Padding(3, 4, 3, 4);
            MenuChangePassGroupBox.Size = new Size(537, 296);
            MenuChangePassGroupBox.TabIndex = 3;
            MenuChangePassGroupBox.TabStop = false;
            MenuChangePassGroupBox.Text = "Nueva Contraseña";
            // 
            // iconButtonChangePassword
            // 
            iconButtonChangePassword.BackColor = Color.LimeGreen;
            iconButtonChangePassword.FlatStyle = FlatStyle.Flat;
            iconButtonChangePassword.ForeColor = Color.White;
            iconButtonChangePassword.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonChangePassword.IconColor = Color.Black;
            iconButtonChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonChangePassword.Location = new Point(112, 234);
            iconButtonChangePassword.Name = "iconButtonChangePassword";
            iconButtonChangePassword.Size = new Size(322, 32);
            iconButtonChangePassword.TabIndex = 3;
            iconButtonChangePassword.Text = "Guardar";
            iconButtonChangePassword.UseVisualStyleBackColor = false;
            iconButtonChangePassword.Click += iconButtonChangePassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F);
            label1.Location = new Point(73, 143);
            label1.Name = "label1";
            label1.Size = new Size(247, 20);
            label1.TabIndex = 2;
            label1.Text = "Vuelva a escribir la  Contraseña:\r\n";
            // 
            // NewPassLabel
            // 
            NewPassLabel.AutoSize = true;
            NewPassLabel.Font = new Font("Century Gothic", 9F);
            NewPassLabel.Location = new Point(73, 62);
            NewPassLabel.Name = "NewPassLabel";
            NewPassLabel.Size = new Size(217, 20);
            NewPassLabel.TabIndex = 1;
            NewPassLabel.Text = "Ingresar Nueva Contraseña:\r\n";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Turquoise;
            menuStrip1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { restablecerLaContraseñaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1000, 35);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // restablecerLaContraseñaToolStripMenuItem
            // 
            restablecerLaContraseñaToolStripMenuItem.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restablecerLaContraseñaToolStripMenuItem.ForeColor = Color.White;
            restablecerLaContraseñaToolStripMenuItem.Name = "restablecerLaContraseñaToolStripMenuItem";
            restablecerLaContraseñaToolStripMenuItem.Size = new Size(319, 31);
            restablecerLaContraseñaToolStripMenuItem.Text = "Restablecer la contraseña";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 570);
            Controls.Add(MenuChangePassGroupBox);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restablecer Contraseña";
            MenuChangePassGroupBox.ResumeLayout(false);
            MenuChangePassGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox newPasswordTexBox;
        private TextBox confirmPasswordTexBox;
        private GroupBox MenuChangePassGroupBox;
        private Label label1;
        private Label NewPassLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem restablecerLaContraseñaToolStripMenuItem;
        private FontAwesome.Sharp.IconButton iconButtonChangePassword;
    }
}