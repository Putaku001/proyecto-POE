namespace PresentationLayer.Forms.Admin
{
    partial class InfoEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEmployeeForm));
            this.professionLabel = new System.Windows.Forms.Label(); // Corrección
            this.professionsTextBox = new System.Windows.Forms.TextBox(); // Corrección
            this.iconSaveInformationButton = new FontAwesome.Sharp.IconButton();
            this.workStationLabel = new System.Windows.Forms.Label(); // Corrección
            this.workStationTextBox = new System.Windows.Forms.TextBox(); // Corrección

            SuspendLayout();
            // 
            // professionLabel
            // 
            this.professionLabel.AutoSize = true;
            this.professionLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.professionLabel.ForeColor = Color.White;
            this.professionLabel.Location = new Point(279, 21);
            this.professionLabel.Name = "professionLabel";
            this.professionLabel.Size = new Size(128, 30);
            this.professionLabel.TabIndex = 3;
            this.professionLabel.Text = "Profesión:";
            // 
            // professionsTextBox
            // 
            this.professionsTextBox.Location = new Point(151, 63);
            this.professionsTextBox.Multiline = true;
            this.professionsTextBox.Name = "professionsTextBox";
            this.professionsTextBox.Size = new Size(409, 76);
            this.professionsTextBox.TabIndex = 4;
            // 
            // iconSaveInformationButton
            // 
            this.iconSaveInformationButton.BackColor = Color.DodgerBlue;
            this.iconSaveInformationButton.Cursor = Cursors.Hand;
            this.iconSaveInformationButton.FlatStyle = FlatStyle.Popup;
            this.iconSaveInformationButton.ForeColor = Color.White;
            this.iconSaveInformationButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSaveInformationButton.IconColor = Color.DarkTurquoise;
            this.iconSaveInformationButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSaveInformationButton.Location = new Point(253, 294);
            this.iconSaveInformationButton.Name = "iconSaveInformationButton";
            this.iconSaveInformationButton.Size = new Size(197, 46);
            this.iconSaveInformationButton.TabIndex = 0;
            this.iconSaveInformationButton.Text = "Guardar";
            this.iconSaveInformationButton.UseVisualStyleBackColor = false;
            // 
            // workStationLabel
            // 
            this.workStationLabel.AutoSize = true;
            this.workStationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.workStationLabel.ForeColor = Color.White;
            this.workStationLabel.Location = new Point(235, 173);
            this.workStationLabel.Name = "workStationLabel";
            this.workStationLabel.Size = new Size(229, 30);
            this.workStationLabel.TabIndex = 6;
            this.workStationLabel.Text = "Puesto de trabajo:";
            // 
            // workStationTextBox
            // 
            this.workStationTextBox.Location = new Point(163, 216);
            this.workStationTextBox.Name = "workStationTextBox";
            this.workStationTextBox.Size = new Size(397, 30);
            this.workStationTextBox.TabIndex = 7;
            // 
            // InfoEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 54, 61);
            ClientSize = new Size(709, 372);
            Controls.Add(this.iconSaveInformationButton);
            Controls.Add(this.workStationLabel);
            Controls.Add(this.workStationTextBox); // Corrección
            Controls.Add(this.professionLabel);
            Controls.Add(this.professionsTextBox);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InfoEmployeeForm";
            Text = "Informacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label professionLabel;
        private System.Windows.Forms.TextBox professionsTextBox;
        private System.Windows.Forms.TextBox workStationTextBox;
        private System.Windows.Forms.Label workStationLabel;
        private FontAwesome.Sharp.IconButton iconSaveInformationButton;
    }
}
