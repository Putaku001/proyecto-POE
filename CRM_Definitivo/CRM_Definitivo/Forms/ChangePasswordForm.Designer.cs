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
            menuChangePassGroupBox = new GroupBox();
            changePasswordButton = new FontAwesome.Sharp.IconButton();
            confirmPasswordLabel = new Label();
            newPasswordLabel = new Label();
            menuStrip = new MenuStrip();
            restablecerLaContraseñaToolStripMenuItem = new ToolStripMenuItem();
            menuChangePassGroupBox.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // newPasswordTexBox
            // 
            newPasswordTexBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordTexBox.Location = new Point(73, 107);
            newPasswordTexBox.Margin = new Padding(3, 4, 3, 4);
            newPasswordTexBox.Name = "newPasswordTexBox";
            newPasswordTexBox.Size = new Size(400, 32);
            newPasswordTexBox.TabIndex = 0;
            newPasswordTexBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordTexBox
            // 
            confirmPasswordTexBox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTexBox.Location = new Point(73, 231);
            confirmPasswordTexBox.Margin = new Padding(3, 4, 3, 4);
            confirmPasswordTexBox.Name = "confirmPasswordTexBox";
            confirmPasswordTexBox.Size = new Size(400, 32);
            confirmPasswordTexBox.TabIndex = 1;
            confirmPasswordTexBox.UseSystemPasswordChar = true;
            // 
            // menuChangePassGroupBox
            // 
            menuChangePassGroupBox.Controls.Add(changePasswordButton);
            menuChangePassGroupBox.Controls.Add(confirmPasswordLabel);
            menuChangePassGroupBox.Controls.Add(newPasswordLabel);
            menuChangePassGroupBox.Controls.Add(confirmPasswordTexBox);
            menuChangePassGroupBox.Controls.Add(newPasswordTexBox);
            menuChangePassGroupBox.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuChangePassGroupBox.Location = new Point(129, 80);
            menuChangePassGroupBox.Margin = new Padding(3, 4, 3, 4);
            menuChangePassGroupBox.Name = "menuChangePassGroupBox";
            menuChangePassGroupBox.Padding = new Padding(3, 4, 3, 4);
            menuChangePassGroupBox.Size = new Size(537, 447);
            menuChangePassGroupBox.TabIndex = 3;
            menuChangePassGroupBox.TabStop = false;
            menuChangePassGroupBox.Text = "Nueva Contraseña";
            // 
            // changePasswordButton
            // 
            changePasswordButton.BackColor = Color.Green;
            changePasswordButton.FlatStyle = FlatStyle.Flat;
            changePasswordButton.ForeColor = Color.White;
            changePasswordButton.IconChar = FontAwesome.Sharp.IconChar.None;
            changePasswordButton.IconColor = Color.Black;
            changePasswordButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            changePasswordButton.Location = new Point(106, 329);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(322, 55);
            changePasswordButton.TabIndex = 3;
            changePasswordButton.Text = "Guardar";
            changePasswordButton.UseVisualStyleBackColor = false;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordLabel.Location = new Point(73, 189);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(331, 23);
            confirmPasswordLabel.TabIndex = 2;
            confirmPasswordLabel.Text = "Vuelva a escribir la  Contraseña:\r\n";
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordLabel.Location = new Point(73, 63);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(281, 23);
            newPasswordLabel.TabIndex = 1;
            newPasswordLabel.Text = "Ingresar Nueva Contraseña";
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.DodgerBlue;
            menuStrip.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { restablecerLaContraseñaToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(819, 42);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip1";
            // 
            // restablecerLaContraseñaToolStripMenuItem
            // 
            restablecerLaContraseñaToolStripMenuItem.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restablecerLaContraseñaToolStripMenuItem.ForeColor = Color.White;
            restablecerLaContraseñaToolStripMenuItem.Name = "restablecerLaContraseñaToolStripMenuItem";
            restablecerLaContraseñaToolStripMenuItem.Size = new Size(385, 38);
            restablecerLaContraseñaToolStripMenuItem.Text = "Restablecer la contraseña";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(819, 637);
            Controls.Add(menuChangePassGroupBox);
            Controls.Add(menuStrip);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restablecer Contraseña";
            menuChangePassGroupBox.ResumeLayout(false);
            menuChangePassGroupBox.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox newPasswordTexBox;
        private TextBox confirmPasswordTexBox;
        private GroupBox menuChangePassGroupBox;
        private Label confirmPasswordLabel;
        private Label newPasswordLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem restablecerLaContraseñaToolStripMenuItem;
        private FontAwesome.Sharp.IconButton changePasswordButton;
    }
}