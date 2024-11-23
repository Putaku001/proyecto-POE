namespace PresentationLayer.Forms.Empleados
{
    partial class ProjectEmployeeForm
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
            dataGridViewProjectsEmployee = new DataGridView();
            Select = new DataGridViewButtonColumn();
            panelInformationProject = new Panel();
            groupBoxProjectsInfo = new GroupBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanelLinkFile = new FlowLayoutPanel();
            labelLinkFile = new Label();
            iconButtonSubmit = new FontAwesome.Sharp.IconButton();
            textBoxDescriptionTask = new TextBox();
            labelProjectName = new Label();
            linkLabelFile = new LinkLabel();
            labelDescription = new Label();
            labelNameTask = new Label();
            panelProjects = new Panel();
            labelProjectsAssignament = new Label();
            comboBoxTaskStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectsEmployee).BeginInit();
            panelInformationProject.SuspendLayout();
            groupBoxProjectsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanelLinkFile.SuspendLayout();
            panelProjects.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProjectsEmployee
            // 
            dataGridViewProjectsEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProjectsEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectsEmployee.Columns.AddRange(new DataGridViewColumn[] { Select });
            dataGridViewProjectsEmployee.Location = new Point(6, 46);
            dataGridViewProjectsEmployee.Name = "dataGridViewProjectsEmployee";
            dataGridViewProjectsEmployee.RowHeadersWidth = 51;
            dataGridViewProjectsEmployee.Size = new Size(617, 613);
            dataGridViewProjectsEmployee.TabIndex = 2;
            dataGridViewProjectsEmployee.CellClick += dataGridViewProjectsEmployee_CellClick;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Select.HeaderText = "Select";
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.Width = 70;
            // 
            // panelInformationProject
            // 
            panelInformationProject.BackColor = SystemColors.ActiveCaption;
            panelInformationProject.Controls.Add(groupBoxProjectsInfo);
            panelInformationProject.Controls.Add(labelNameTask);
            panelInformationProject.Dock = DockStyle.Right;
            panelInformationProject.Location = new Point(623, 0);
            panelInformationProject.Name = "panelInformationProject";
            panelInformationProject.Size = new Size(566, 660);
            panelInformationProject.TabIndex = 3;
            // 
            // groupBoxProjectsInfo
            // 
            groupBoxProjectsInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxProjectsInfo.Controls.Add(comboBoxTaskStatus);
            groupBoxProjectsInfo.Controls.Add(pictureBox1);
            groupBoxProjectsInfo.Controls.Add(flowLayoutPanelLinkFile);
            groupBoxProjectsInfo.Controls.Add(iconButtonSubmit);
            groupBoxProjectsInfo.Controls.Add(textBoxDescriptionTask);
            groupBoxProjectsInfo.Controls.Add(labelProjectName);
            groupBoxProjectsInfo.Controls.Add(linkLabelFile);
            groupBoxProjectsInfo.Controls.Add(labelDescription);
            groupBoxProjectsInfo.ForeColor = Color.White;
            groupBoxProjectsInfo.Location = new Point(38, 34);
            groupBoxProjectsInfo.Name = "groupBoxProjectsInfo";
            groupBoxProjectsInfo.Size = new Size(493, 593);
            groupBoxProjectsInfo.TabIndex = 12;
            groupBoxProjectsInfo.TabStop = false;
            groupBoxProjectsInfo.Text = "Proyecto";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(203, 256);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 124);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelLinkFile
            // 
            flowLayoutPanelLinkFile.BackColor = Color.White;
            flowLayoutPanelLinkFile.Controls.Add(labelLinkFile);
            flowLayoutPanelLinkFile.Location = new Point(13, 470);
            flowLayoutPanelLinkFile.Name = "flowLayoutPanelLinkFile";
            flowLayoutPanelLinkFile.Size = new Size(474, 43);
            flowLayoutPanelLinkFile.TabIndex = 12;
            // 
            // labelLinkFile
            // 
            labelLinkFile.AutoSize = true;
            labelLinkFile.BackColor = Color.Transparent;
            labelLinkFile.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelLinkFile.ForeColor = SystemColors.ControlDarkDark;
            labelLinkFile.Location = new Point(3, 0);
            labelLinkFile.Name = "labelLinkFile";
            labelLinkFile.Size = new Size(54, 18);
            labelLinkFile.TabIndex = 11;
            labelLinkFile.Text = "label3";
            // 
            // iconButtonSubmit
            // 
            iconButtonSubmit.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSubmit.IconColor = Color.Black;
            iconButtonSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSubmit.Location = new Point(214, 545);
            iconButtonSubmit.Name = "iconButtonSubmit";
            iconButtonSubmit.Size = new Size(94, 29);
            iconButtonSubmit.TabIndex = 2;
            iconButtonSubmit.Text = "Enviar";
            iconButtonSubmit.UseVisualStyleBackColor = true;
            iconButtonSubmit.Click += iconButtonSubmit_Click;
            // 
            // textBoxDescriptionTask
            // 
            textBoxDescriptionTask.BorderStyle = BorderStyle.None;
            textBoxDescriptionTask.Location = new Point(101, 87);
            textBoxDescriptionTask.Multiline = true;
            textBoxDescriptionTask.Name = "textBoxDescriptionTask";
            textBoxDescriptionTask.ReadOnly = true;
            textBoxDescriptionTask.Size = new Size(331, 148);
            textBoxDescriptionTask.TabIndex = 6;
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelProjectName.Location = new Point(13, 29);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(137, 23);
            labelProjectName.TabIndex = 0;
            labelProjectName.Text = "NameProject";
            // 
            // linkLabelFile
            // 
            linkLabelFile.AutoSize = true;
            linkLabelFile.Location = new Point(142, 383);
            linkLabelFile.Name = "linkLabelFile";
            linkLabelFile.Size = new Size(245, 20);
            linkLabelFile.TabIndex = 3;
            linkLabelFile.TabStop = true;
            linkLabelFile.Text = "En este apartado subira su tarea";
            linkLabelFile.LinkClicked += linkLabelFile_LinkClicked;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Century Gothic", 10.2F);
            labelDescription.Location = new Point(214, 63);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(112, 21);
            labelDescription.TabIndex = 5;
            labelDescription.Text = "Descripcion:";
            // 
            // labelNameTask
            // 
            labelNameTask.AutoSize = true;
            labelNameTask.Font = new Font("Century Gothic", 10.2F);
            labelNameTask.Location = new Point(252, 9);
            labelNameTask.Name = "labelNameTask";
            labelNameTask.Size = new Size(58, 21);
            labelNameTask.TabIndex = 7;
            labelNameTask.Text = "Tarea";
            // 
            // panelProjects
            // 
            panelProjects.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelProjects.BackColor = Color.MediumTurquoise;
            panelProjects.Controls.Add(labelProjectsAssignament);
            panelProjects.Location = new Point(0, 0);
            panelProjects.Name = "panelProjects";
            panelProjects.Size = new Size(623, 40);
            panelProjects.TabIndex = 4;
            // 
            // labelProjectsAssignament
            // 
            labelProjectsAssignament.AutoSize = true;
            labelProjectsAssignament.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelProjectsAssignament.ForeColor = Color.White;
            labelProjectsAssignament.Location = new Point(6, 9);
            labelProjectsAssignament.Name = "labelProjectsAssignament";
            labelProjectsAssignament.Size = new Size(208, 29);
            labelProjectsAssignament.TabIndex = 13;
            labelProjectsAssignament.Text = "Tareas Asignadas";
            // 
            // comboBoxTaskStatus
            // 
            comboBoxTaskStatus.FormattingEnabled = true;
            comboBoxTaskStatus.Location = new Point(191, 422);
            comboBoxTaskStatus.Name = "comboBoxTaskStatus";
            comboBoxTaskStatus.Size = new Size(151, 28);
            comboBoxTaskStatus.TabIndex = 14;
            // 
            // ProjectEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 660);
            Controls.Add(panelProjects);
            Controls.Add(panelInformationProject);
            Controls.Add(dataGridViewProjectsEmployee);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjectEmployeeForm";
            Text = "ProjectEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectsEmployee).EndInit();
            panelInformationProject.ResumeLayout(false);
            panelInformationProject.PerformLayout();
            groupBoxProjectsInfo.ResumeLayout(false);
            groupBoxProjectsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanelLinkFile.ResumeLayout(false);
            flowLayoutPanelLinkFile.PerformLayout();
            panelProjects.ResumeLayout(false);
            panelProjects.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProjectsEmployee;
        private Panel panelInformationProject;
        private FontAwesome.Sharp.IconButton iconButtonSubmit;
        private Label labelProjectName;
        private TextBox textBox3;
        private Label labelNameTask;
        private TextBox textBoxDescriptionTask;
        private Label labelDescription;
        private LinkLabel linkLabelFile;
        private Label labelLinkFile;
        private GroupBox groupBoxProjectsInfo;
        private FlowLayoutPanel flowLayoutPanelLinkFile;
        private DataGridViewButtonColumn Select;
        private Panel panelProjects;
        private Label labelProjectsAssignament;
        private PictureBox pictureBox1;
        private ComboBox comboBoxTaskStatus;
    }
}