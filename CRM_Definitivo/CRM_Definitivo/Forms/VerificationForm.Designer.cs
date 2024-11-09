namespace PresentationLayer.Forms
{
    partial class VerificationForm
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
            menuStrip1 = new MenuStrip();
            recuperarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            verificationCodeTexBox = new TextBox();
            messageLabel = new Label();
            iconButtonVerify = new FontAwesome.Sharp.IconButton();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Turquoise;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { recuperarContraseñaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(653, 31);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // recuperarContraseñaToolStripMenuItem
            // 
            recuperarContraseñaToolStripMenuItem.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recuperarContraseñaToolStripMenuItem.ForeColor = Color.White;
            recuperarContraseñaToolStripMenuItem.Name = "recuperarContraseñaToolStripMenuItem";
            recuperarContraseñaToolStripMenuItem.Size = new Size(241, 27);
            recuperarContraseñaToolStripMenuItem.Text = "Recuperar contraseña";
            // 
            // verificationCodeTexBox
            // 
            verificationCodeTexBox.Location = new Point(207, 205);
            verificationCodeTexBox.Margin = new Padding(3, 4, 3, 4);
            verificationCodeTexBox.Name = "verificationCodeTexBox";
            verificationCodeTexBox.Size = new Size(258, 26);
            verificationCodeTexBox.TabIndex = 0;
            verificationCodeTexBox.TextAlign = HorizontalAlignment.Center;
            // 
            // messageLabel
            // 
            messageLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 161);
            messageLabel.ForeColor = Color.DimGray;
            messageLabel.Location = new Point(97, 93);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(483, 80);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Introduce el codigo de 6 digitos que se te ha enviado al numero de telefono asociado a su cuenta en Tilinizos77";
            // 
            // iconButtonVerify
            // 
            iconButtonVerify.BackColor = Color.LimeGreen;
            iconButtonVerify.FlatStyle = FlatStyle.Flat;
            iconButtonVerify.ForeColor = Color.White;
            iconButtonVerify.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconButtonVerify.IconColor = Color.White;
            iconButtonVerify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonVerify.IconSize = 34;
            iconButtonVerify.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonVerify.Location = new Point(246, 259);
            iconButtonVerify.Name = "iconButtonVerify";
            iconButtonVerify.Size = new Size(175, 33);
            iconButtonVerify.TabIndex = 5;
            iconButtonVerify.Text = "Verificar";
            iconButtonVerify.UseVisualStyleBackColor = false;
            iconButtonVerify.Click += iconButtonVerify_Click;
            // 
            // VerificationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 321);
            Controls.Add(iconButtonVerify);
            Controls.Add(messageLabel);
            Controls.Add(verificationCodeTexBox);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VerificationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Codigo de Verificacion";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem recuperarContraseñaToolStripMenuItem;
        private TextBox verificationCodeTexBox;
        private Label messageLabel;
        private FontAwesome.Sharp.IconButton iconButtonVerify;
    }
}