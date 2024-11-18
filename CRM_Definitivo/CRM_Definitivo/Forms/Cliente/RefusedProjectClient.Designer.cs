namespace PresentationLayer.Forms.Cliente
{
    partial class RefusedProjectClient
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
            textBoxRefusedProject = new TextBox();
            labelRefused = new Label();
            iconButtonSendRefused = new FontAwesome.Sharp.IconButton();
            labelCodeProject = new Label();
            labelNameProject = new Label();
            textBoxRefusedaName = new TextBox();
            labelRefus = new Label();
            SuspendLayout();
            // 
            // textBoxRefusedProject
            // 
            textBoxRefusedProject.Location = new Point(102, 154);
            textBoxRefusedProject.Multiline = true;
            textBoxRefusedProject.Name = "textBoxRefusedProject";
            textBoxRefusedProject.Size = new Size(392, 130);
            textBoxRefusedProject.TabIndex = 28;
            // 
            // labelRefused
            // 
            labelRefused.AutoSize = true;
            labelRefused.Location = new Point(220, 131);
            labelRefused.Name = "labelRefused";
            labelRefused.Size = new Size(167, 20);
            labelRefused.TabIndex = 27;
            labelRefused.Text = "Motivo de el rechazo";
            // 
            // iconButtonSendRefused
            // 
            iconButtonSendRefused.BackColor = Color.Red;
            iconButtonSendRefused.FlatStyle = FlatStyle.Flat;
            iconButtonSendRefused.ForeColor = Color.White;
            iconButtonSendRefused.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSendRefused.IconColor = Color.Black;
            iconButtonSendRefused.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSendRefused.Location = new Point(210, 303);
            iconButtonSendRefused.Name = "iconButtonSendRefused";
            iconButtonSendRefused.Size = new Size(168, 29);
            iconButtonSendRefused.TabIndex = 29;
            iconButtonSendRefused.Text = "Enviar";
            iconButtonSendRefused.UseVisualStyleBackColor = false;
            iconButtonSendRefused.Click += iconButtonSendRefused_Click;
            // 
            // labelCodeProject
            // 
            labelCodeProject.AutoSize = true;
            labelCodeProject.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCodeProject.ForeColor = SystemColors.ButtonShadow;
            labelCodeProject.Location = new Point(525, 9);
            labelCodeProject.Name = "labelCodeProject";
            labelCodeProject.Size = new Size(57, 18);
            labelCodeProject.TabIndex = 30;
            labelCodeProject.Text = "u24123";
            // 
            // labelNameProject
            // 
            labelNameProject.AutoSize = true;
            labelNameProject.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNameProject.Location = new Point(3, 9);
            labelNameProject.Name = "labelNameProject";
            labelNameProject.Size = new Size(134, 23);
            labelNameProject.TabIndex = 31;
            labelNameProject.Text = "nameProject";
            // 
            // textBoxRefusedaName
            // 
            textBoxRefusedaName.Location = new Point(102, 78);
            textBoxRefusedaName.Name = "textBoxRefusedaName";
            textBoxRefusedaName.Size = new Size(392, 26);
            textBoxRefusedaName.TabIndex = 33;
            // 
            // labelRefus
            // 
            labelRefus.AutoSize = true;
            labelRefus.Location = new Point(261, 55);
            labelRefus.Name = "labelRefus";
            labelRefus.Size = new Size(73, 20);
            labelRefus.TabIndex = 32;
            labelRefus.Text = "Rechazo";
            // 
            // RefusedProjectClient
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 354);
            Controls.Add(textBoxRefusedaName);
            Controls.Add(labelRefus);
            Controls.Add(labelCodeProject);
            Controls.Add(labelNameProject);
            Controls.Add(iconButtonSendRefused);
            Controls.Add(textBoxRefusedProject);
            Controls.Add(labelRefused);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "RefusedProjectClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rechazar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRefusedProject;
        private Label labelRefused;
        private FontAwesome.Sharp.IconButton iconButtonSendRefused;
        private Label labelCodeProject;
        private Label labelNameProject;
        private TextBox textBoxRefusedaName;
        private Label labelRefus;
    }
}