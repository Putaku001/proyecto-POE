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
            this.professionLabel = new Label();
            this.professionsTextBox = new TextBox();
            this.iconSaveInformationButton = new FontAwesome.Sharp.IconButton();
            this.workStationLabel = new Label();
            workStationTextBox = new TextBox();
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
            this.professionLabel.Text = "Profesion:";
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
            workStationTextBox.Location = new Point(163, 216);
            workStationTextBox.Name = "workStationTextBox";
            workStationTextBox.Size = new Size(397, 30);
            workStationTextBox.TabIndex = 7;
            // 
            // InfoEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 54, 61);
            ClientSize = new Size(709, 372);
            Controls.Add(this.iconSaveInformationButton);
            Controls.Add(this.workStationLabel);
            Controls.Add(workStationTextBox);
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

        private Label labelInfo;
        private TextBox textBoxProfession;
        private Panel panelSaveInfo;
        private FontAwesome.Sharp.IconButton iconButtonSaveInfoAditional;
        private Label labelInfo2;
        private TextBox workStationTextBox;
    }
}