namespace PresentationLayer.Forms.Cliente
{
    partial class AnswerProjectClient
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
            iconApprovedProjectButton = new FontAwesome.Sharp.IconButton();
            descriptionLabel = new Label();
            descriptionProjectTextBox = new TextBox();
            iconRefusedProjectButton = new FontAwesome.Sharp.IconButton();
            informationGroupBox = new GroupBox();
            refusedProjectLinkLabel = new LinkLabel();
            nameProjectLabel = new Label();
            codeProjectLabel = new Label();
            informationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // iconApprovedProjectButton
            // 
            iconApprovedProjectButton.BackColor = Color.ForestGreen;
            iconApprovedProjectButton.Cursor = Cursors.Hand;
            iconApprovedProjectButton.FlatAppearance.BorderColor = Color.Black;
            iconApprovedProjectButton.FlatStyle = FlatStyle.Flat;
            iconApprovedProjectButton.ForeColor = Color.White;
            iconApprovedProjectButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconApprovedProjectButton.IconColor = Color.White;
            iconApprovedProjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconApprovedProjectButton.IconSize = 22;
            iconApprovedProjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            iconApprovedProjectButton.Location = new Point(44, 417);
            iconApprovedProjectButton.Name = "iconApprovedProjectButton";
            iconApprovedProjectButton.Size = new Size(296, 47);
            iconApprovedProjectButton.TabIndex = 24;
            iconApprovedProjectButton.Text = "Aprobar";
            iconApprovedProjectButton.UseVisualStyleBackColor = false;
            iconApprovedProjectButton.Click += iconApprovedProjectButton_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(135, 41);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(159, 17);
            descriptionLabel.TabIndex = 25;
            descriptionLabel.Text = "Descripcion del proyecto";
            // 
            // descriptionProjectTextBox
            // 
            descriptionProjectTextBox.Location = new Point(49, 78);
            descriptionProjectTextBox.Multiline = true;
            descriptionProjectTextBox.Name = "descriptionProjectTextBox";
            descriptionProjectTextBox.Size = new Size(335, 231);
            descriptionProjectTextBox.TabIndex = 26;
            // 
            // iconRefusedProjectButton
            // 
            iconRefusedProjectButton.BackColor = Color.Red;
            iconRefusedProjectButton.Cursor = Cursors.Hand;
            iconRefusedProjectButton.FlatAppearance.BorderColor = Color.Black;
            iconRefusedProjectButton.FlatStyle = FlatStyle.Flat;
            iconRefusedProjectButton.ForeColor = Color.White;
            iconRefusedProjectButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            iconRefusedProjectButton.IconColor = Color.White;
            iconRefusedProjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRefusedProjectButton.IconSize = 22;
            iconRefusedProjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            iconRefusedProjectButton.Location = new Point(446, 417);
            iconRefusedProjectButton.Name = "iconRefusedProjectButton";
            iconRefusedProjectButton.Size = new Size(296, 47);
            iconRefusedProjectButton.TabIndex = 27;
            iconRefusedProjectButton.Text = "Rechazar";
            iconRefusedProjectButton.UseVisualStyleBackColor = false;
            iconRefusedProjectButton.Click += iconRefusedProjectButton_Click;
            // 
            // informationGroupBox
            // 
            informationGroupBox.Controls.Add(refusedProjectLinkLabel);
            informationGroupBox.Controls.Add(descriptionProjectTextBox);
            informationGroupBox.Controls.Add(descriptionLabel);
            informationGroupBox.Location = new Point(27, 54);
            informationGroupBox.Name = "informationGroupBox";
            informationGroupBox.Size = new Size(715, 335);
            informationGroupBox.TabIndex = 28;
            informationGroupBox.TabStop = false;
            informationGroupBox.Text = "Informacion";
            // 
            // refusedProjectLinkLabel
            // 
            refusedProjectLinkLabel.AutoSize = true;
            refusedProjectLinkLabel.Location = new Point(509, 154);
            refusedProjectLinkLabel.Name = "refusedProjectLinkLabel";
            refusedProjectLinkLabel.Size = new Size(116, 17);
            refusedProjectLinkLabel.TabIndex = 28;
            refusedProjectLinkLabel.TabStop = true;
            refusedProjectLinkLabel.Text = "Razon de Rechazo";
            refusedProjectLinkLabel.LinkClicked += refusedProjectLinkLabel_LinkClicked;
            // 
            // nameProjectLabel
            // 
            nameProjectLabel.AutoSize = true;
            nameProjectLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameProjectLabel.Location = new Point(14, 9);
            nameProjectLabel.Name = "nameProjectLabel";
            nameProjectLabel.Size = new Size(144, 19);
            nameProjectLabel.TabIndex = 27;
            nameProjectLabel.Text = "Nombre Proyecto";
            // 
            // codeProjectLabel
            // 
            codeProjectLabel.AutoSize = true;
            codeProjectLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            codeProjectLabel.ForeColor = SystemColors.ButtonShadow;
            codeProjectLabel.Location = new Point(603, 15);
            codeProjectLabel.Name = "codeProjectLabel";
            codeProjectLabel.Size = new Size(49, 16);
            codeProjectLabel.TabIndex = 27;
            codeProjectLabel.Text = "u24123";
            // 
            // AnswerProjectClient
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 510);
            Controls.Add(codeProjectLabel);
            Controls.Add(nameProjectLabel);
            Controls.Add(iconRefusedProjectButton);
            Controls.Add(iconApprovedProjectButton);
            Controls.Add(informationGroupBox);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "AnswerProjectClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informacion";
            Load += AnswerProyectClient_Load;
            informationGroupBox.ResumeLayout(false);
            informationGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconApprovedProjectButton;
        private Label descriptionLabel;
        private TextBox descriptionProjectTextBox;
        private FontAwesome.Sharp.IconButton iconRefusedProjectButton;
        private GroupBox informationGroupBox;
        private Label nameProjectLabel;
        private Label codeProjectLabel;
        private LinkLabel refusedProjectLinkLabel;
    }
}