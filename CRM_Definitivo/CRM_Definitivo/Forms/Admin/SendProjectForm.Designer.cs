namespace PresentationLayer.Forms.Admin
{
    partial class SendProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendProjectForm));
            sendProjectIconButton = new FontAwesome.Sharp.IconButton();
            nameUserLabel = new Label();
            clientLabel = new Label();
            nameProjectLabel = new Label();
            projectGroupBox = new GroupBox();
            codeProjectLabel = new Label();
            fileProjectLinkLabel = new LinkLabel();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            dateLabel = new Label();
            employeeFlowLayoutPanel = new FlowLayoutPanel();
            getEmployeesCheckedListBox = new CheckedListBox();
            uploadFilePictureBox = new PictureBox();
            projectGroupBox.SuspendLayout();
            employeeFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uploadFilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // sendProjectIconButton
            // 
            sendProjectIconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            sendProjectIconButton.IconColor = Color.Black;
            sendProjectIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sendProjectIconButton.Location = new Point(271, 323);
            sendProjectIconButton.Margin = new Padding(4);
            sendProjectIconButton.Name = "sendProjectIconButton";
            sendProjectIconButton.Size = new Size(261, 36);
            sendProjectIconButton.TabIndex = 24;
            sendProjectIconButton.Text = "Enviar proyecto";
            sendProjectIconButton.UseVisualStyleBackColor = true;
            sendProjectIconButton.Click += iconButtonSendProject_Click;
            // 
            // nameUserLabel
            // 
            nameUserLabel.AutoSize = true;
            nameUserLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameUserLabel.Location = new Point(141, 103);
            nameUserLabel.Margin = new Padding(4, 0, 4, 0);
            nameUserLabel.Name = "nameUserLabel";
            nameUserLabel.Size = new Size(180, 25);
            nameUserLabel.TabIndex = 20;
            nameUserLabel.Text = "nombre Cliente";
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientLabel.Location = new Point(23, 103);
            clientLabel.Margin = new Padding(4, 0, 4, 0);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(95, 25);
            clientLabel.TabIndex = 19;
            clientLabel.Text = "Cliente:";
            // 
            // nameProjectLabel
            // 
            nameProjectLabel.BackColor = Color.DodgerBlue;
            nameProjectLabel.Dock = DockStyle.Top;
            nameProjectLabel.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameProjectLabel.ForeColor = Color.White;
            nameProjectLabel.Location = new Point(0, 0);
            nameProjectLabel.Margin = new Padding(4, 0, 4, 0);
            nameProjectLabel.Name = "nameProjectLabel";
            nameProjectLabel.Size = new Size(839, 58);
            nameProjectLabel.TabIndex = 18;
            nameProjectLabel.Text = "Nombre Proyecto";
            nameProjectLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // projectGroupBox
            // 
            projectGroupBox.Controls.Add(uploadFilePictureBox);
            projectGroupBox.Controls.Add(codeProjectLabel);
            projectGroupBox.Controls.Add(sendProjectIconButton);
            projectGroupBox.Controls.Add(fileProjectLinkLabel);
            projectGroupBox.Controls.Add(descriptionTextBox);
            projectGroupBox.Controls.Add(descriptionLabel);
            projectGroupBox.Location = new Point(4, 151);
            projectGroupBox.Margin = new Padding(4);
            projectGroupBox.Name = "projectGroupBox";
            projectGroupBox.Padding = new Padding(4);
            projectGroupBox.Size = new Size(822, 400);
            projectGroupBox.TabIndex = 23;
            projectGroupBox.TabStop = false;
            projectGroupBox.Text = "Proyecto";
            // 
            // codeProjectLabel
            // 
            codeProjectLabel.AutoSize = true;
            codeProjectLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            codeProjectLabel.ForeColor = SystemColors.AppWorkspace;
            codeProjectLabel.Location = new Point(8, 357);
            codeProjectLabel.Margin = new Padding(4, 0, 4, 0);
            codeProjectLabel.Name = "codeProjectLabel";
            codeProjectLabel.Size = new Size(85, 27);
            codeProjectLabel.TabIndex = 25;
            codeProjectLabel.Text = "u24123";
            // 
            // fileProjectLinkLabel
            // 
            fileProjectLinkLabel.AutoSize = true;
            fileProjectLinkLabel.Location = new Point(321, 261);
            fileProjectLinkLabel.Margin = new Padding(4, 0, 4, 0);
            fileProjectLinkLabel.Name = "fileProjectLinkLabel";
            fileProjectLinkLabel.Size = new Size(133, 25);
            fileProjectLinkLabel.TabIndex = 25;
            fileProjectLinkLabel.TabStop = true;
            fileProjectLinkLabel.Text = "Subir el archivo";
            fileProjectLinkLabel.LinkClicked += linkLabelFileProject_LinkClicked;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(19, 64);
            descriptionTextBox.Margin = new Padding(4);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(792, 111);
            descriptionTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(21, 35);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(108, 25);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Descripcion:";
            // 
            // dateLabel
            // 
            dateLabel.BackColor = Color.DodgerBlue;
            dateLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.ForeColor = Color.White;
            dateLabel.Image = (Image)resources.GetObject("dateLabel.Image");
            dateLabel.ImageAlign = ContentAlignment.MiddleLeft;
            dateLabel.Location = new Point(631, 9);
            dateLabel.Margin = new Padding(4, 0, 4, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(184, 35);
            dateLabel.TabIndex = 24;
            dateLabel.Text = "2024-11-12";
            dateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // employeeFlowLayoutPanel
            // 
            employeeFlowLayoutPanel.Controls.Add(getEmployeesCheckedListBox);
            employeeFlowLayoutPanel.Location = new Point(393, 79);
            employeeFlowLayoutPanel.Margin = new Padding(4);
            employeeFlowLayoutPanel.Name = "employeeFlowLayoutPanel";
            employeeFlowLayoutPanel.Size = new Size(446, 64);
            employeeFlowLayoutPanel.TabIndex = 25;
            // 
            // getEmployeesCheckedListBox
            // 
            getEmployeesCheckedListBox.FormattingEnabled = true;
            getEmployeesCheckedListBox.Location = new Point(4, 4);
            getEmployeesCheckedListBox.Margin = new Padding(4);
            getEmployeesCheckedListBox.Name = "getEmployeesCheckedListBox";
            getEmployeesCheckedListBox.Size = new Size(440, 32);
            getEmployeesCheckedListBox.TabIndex = 0;
            // 
            // uploadFilePictureBox
            // 
            uploadFilePictureBox.Image = (Image)resources.GetObject("uploadFilePictureBox.Image");
            uploadFilePictureBox.Location = new Point(340, 192);
            uploadFilePictureBox.Name = "uploadFilePictureBox";
            uploadFilePictureBox.Size = new Size(94, 54);
            uploadFilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            uploadFilePictureBox.TabIndex = 26;
            uploadFilePictureBox.TabStop = false;
            // 
            // SendProjectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 564);
            Controls.Add(employeeFlowLayoutPanel);
            Controls.Add(dateLabel);
            Controls.Add(nameUserLabel);
            Controls.Add(clientLabel);
            Controls.Add(nameProjectLabel);
            Controls.Add(projectGroupBox);
            Margin = new Padding(4);
            Name = "SendProjectForm";
            Text = "SendProjectForm";
            Load += SendProjectForm_Load;
            projectGroupBox.ResumeLayout(false);
            projectGroupBox.PerformLayout();
            employeeFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uploadFilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton sendProjectIconButton;
        private Label nameUserLabel;
        private Label clientLabel;
        private Label nameProjectLabel;
        private GroupBox projectGroupBox;
        private LinkLabel fileProjectLinkLabel;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label dateLabel;
        private Label codeProjectLabel;
        private FlowLayoutPanel employeeFlowLayoutPanel;
        private CheckedListBox getEmployeesCheckedListBox;
        private PictureBox uploadFilePictureBox;
    }
}