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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEmployeeForm));
            professionLabel = new Label();
            professionsTextBox = new TextBox();
            iconSaveInformationButton = new FontAwesome.Sharp.IconButton();
            workStationLabel = new Label();
            workStationTextBox = new TextBox();
            errorValidation = new ErrorProvider(components);
            errorProfessionLabel = new Label();
            errorWorkStationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)errorValidation).BeginInit();
            SuspendLayout();
            // 
            // professionLabel
            // 
            professionLabel.AutoSize = true;
            professionLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            professionLabel.ForeColor = Color.White;
            professionLabel.Location = new Point(279, 21);
            professionLabel.Name = "professionLabel";
            professionLabel.Size = new Size(128, 30);
            professionLabel.TabIndex = 3;
            professionLabel.Text = "Profesión:";
            // 
            // professionsTextBox
            // 
            professionsTextBox.Location = new Point(151, 63);
            professionsTextBox.Multiline = true;
            professionsTextBox.Name = "professionsTextBox";
            professionsTextBox.Size = new Size(409, 76);
            professionsTextBox.TabIndex = 4;
            // 
            // iconSaveInformationButton
            // 
            iconSaveInformationButton.BackColor = Color.DodgerBlue;
            iconSaveInformationButton.Cursor = Cursors.Hand;
            iconSaveInformationButton.FlatStyle = FlatStyle.Popup;
            iconSaveInformationButton.ForeColor = Color.White;
            iconSaveInformationButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSaveInformationButton.IconColor = Color.DarkTurquoise;
            iconSaveInformationButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSaveInformationButton.Location = new Point(253, 294);
            iconSaveInformationButton.Name = "iconSaveInformationButton";
            iconSaveInformationButton.Size = new Size(197, 46);
            iconSaveInformationButton.TabIndex = 0;
            iconSaveInformationButton.Text = "Guardar";
            iconSaveInformationButton.UseVisualStyleBackColor = false;
            iconSaveInformationButton.Click += iconSaveInformationButton_Click;
            // 
            // workStationLabel
            // 
            workStationLabel.AutoSize = true;
            workStationLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            workStationLabel.ForeColor = Color.White;
            workStationLabel.Location = new Point(235, 173);
            workStationLabel.Name = "workStationLabel";
            workStationLabel.Size = new Size(229, 30);
            workStationLabel.TabIndex = 6;
            workStationLabel.Text = "Puesto de trabajo:";
            // 
            // workStationTextBox
            // 
            workStationTextBox.Location = new Point(163, 216);
            workStationTextBox.Name = "workStationTextBox";
            workStationTextBox.Size = new Size(397, 30);
            workStationTextBox.TabIndex = 7;
            // 
            // errorValidation
            // 
            errorValidation.ContainerControl = this;
            // 
            // errorProfessionLabel
            // 
            errorProfessionLabel.AutoSize = true;
            errorProfessionLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorProfessionLabel.ForeColor = Color.Red;
            errorProfessionLabel.Location = new Point(154, 145);
            errorProfessionLabel.Name = "errorProfessionLabel";
            errorProfessionLabel.Size = new Size(64, 21);
            errorProfessionLabel.TabIndex = 8;
            errorProfessionLabel.Text = "label1";
            // 
            // errorWorkStationLabel
            // 
            errorWorkStationLabel.AutoSize = true;
            errorWorkStationLabel.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorWorkStationLabel.ForeColor = Color.Red;
            errorWorkStationLabel.Location = new Point(163, 249);
            errorWorkStationLabel.Name = "errorWorkStationLabel";
            errorWorkStationLabel.Size = new Size(64, 21);
            errorWorkStationLabel.TabIndex = 9;
            errorWorkStationLabel.Text = "label2";
            // 
            // InfoEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 54, 61);
            ClientSize = new Size(709, 372);
            Controls.Add(errorWorkStationLabel);
            Controls.Add(errorProfessionLabel);
            Controls.Add(iconSaveInformationButton);
            Controls.Add(workStationLabel);
            Controls.Add(workStationTextBox);
            Controls.Add(professionLabel);
            Controls.Add(professionsTextBox);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InfoEmployeeForm";
            Text = "Informacion";
            ((System.ComponentModel.ISupportInitialize)errorValidation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label professionLabel;
        private System.Windows.Forms.TextBox professionsTextBox;
        private System.Windows.Forms.TextBox workStationTextBox;
        private System.Windows.Forms.Label workStationLabel;
        private FontAwesome.Sharp.IconButton iconSaveInformationButton;
        private ErrorProvider errorValidation;
        private Label errorWorkStationLabel;
        private Label errorProfessionLabel;
    }
}
