namespace PresentationLayer.Forms.Cliente
{
    partial class RequestClientForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            newProjectGroupBox = new GroupBox();
            descriptionProjectLabel = new Label();
            descriptionProjectTextBox = new TextBox();
            saveProjectButton = new FontAwesome.Sharp.IconButton();
            nameProjectLabel = new Label();
            nameNewProyectTextBox = new TextBox();
            projectTabControl = new TabControl();
            tabPageRequestProject = new TabPage();
            requestProjectDataGridView = new DataGridView();
            tabPage2 = new TabPage();
            listProjectDataGridView = new DataGridView();
            SelectPf = new DataGridViewButtonColumn();
            downloadProject = new DataGridViewLinkColumn();
            newProjectGroupBox.SuspendLayout();
            projectTabControl.SuspendLayout();
            tabPageRequestProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestProjectDataGridView).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listProjectDataGridView).BeginInit();
            SuspendLayout();
            // 
            // newProjectGroupBox
            // 
            newProjectGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            newProjectGroupBox.BackColor = Color.DodgerBlue;
            newProjectGroupBox.Controls.Add(descriptionProjectLabel);
            newProjectGroupBox.Controls.Add(descriptionProjectTextBox);
            newProjectGroupBox.Controls.Add(saveProjectButton);
            newProjectGroupBox.Controls.Add(nameProjectLabel);
            newProjectGroupBox.Controls.Add(nameNewProyectTextBox);
            newProjectGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newProjectGroupBox.ForeColor = Color.White;
            newProjectGroupBox.Location = new Point(0, 12);
            newProjectGroupBox.Margin = new Padding(4, 3, 4, 3);
            newProjectGroupBox.Name = "newProjectGroupBox";
            newProjectGroupBox.Padding = new Padding(4, 3, 4, 3);
            newProjectGroupBox.Size = new Size(583, 821);
            newProjectGroupBox.TabIndex = 8;
            newProjectGroupBox.TabStop = false;
            newProjectGroupBox.Text = "Añadir nuevos proyectos:";
            // 
            // descriptionProjectLabel
            // 
            descriptionProjectLabel.AutoSize = true;
            descriptionProjectLabel.Location = new Point(56, 200);
            descriptionProjectLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionProjectLabel.Name = "descriptionProjectLabel";
            descriptionProjectLabel.Size = new Size(157, 28);
            descriptionProjectLabel.TabIndex = 26;
            descriptionProjectLabel.Text = "Descripcion:";
            // 
            // descriptionProjectTextBox
            // 
            descriptionProjectTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionProjectTextBox.Location = new Point(56, 256);
            descriptionProjectTextBox.Margin = new Padding(4, 3, 4, 3);
            descriptionProjectTextBox.Multiline = true;
            descriptionProjectTextBox.Name = "descriptionProjectTextBox";
            descriptionProjectTextBox.Size = new Size(444, 227);
            descriptionProjectTextBox.TabIndex = 27;
            // 
            // saveProjectButton
            // 
            saveProjectButton.BackColor = Color.ForestGreen;
            saveProjectButton.Cursor = Cursors.Hand;
            saveProjectButton.FlatAppearance.BorderColor = Color.Black;
            saveProjectButton.FlatStyle = FlatStyle.Popup;
            saveProjectButton.ForeColor = Color.White;
            saveProjectButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveProjectButton.IconColor = Color.White;
            saveProjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveProjectButton.IconSize = 30;
            saveProjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveProjectButton.Location = new Point(145, 546);
            saveProjectButton.Margin = new Padding(4, 3, 4, 3);
            saveProjectButton.Name = "saveProjectButton";
            saveProjectButton.Size = new Size(271, 57);
            saveProjectButton.TabIndex = 23;
            saveProjectButton.Text = "Solicitar";
            saveProjectButton.UseVisualStyleBackColor = false;
            saveProjectButton.Click += iconButtonGuardarNP_Click;
            // 
            // nameProjectLabel
            // 
            nameProjectLabel.AutoSize = true;
            nameProjectLabel.Location = new Point(52, 83);
            nameProjectLabel.Margin = new Padding(4, 0, 4, 0);
            nameProjectLabel.Name = "nameProjectLabel";
            nameProjectLabel.Size = new Size(270, 28);
            nameProjectLabel.TabIndex = 0;
            nameProjectLabel.Text = "Nombre del proyecto:";
            // 
            // nameNewProyectTextBox
            // 
            nameNewProyectTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameNewProyectTextBox.Location = new Point(56, 124);
            nameNewProyectTextBox.Margin = new Padding(4, 3, 4, 3);
            nameNewProyectTextBox.Multiline = true;
            nameNewProyectTextBox.Name = "nameNewProyectTextBox";
            nameNewProyectTextBox.Size = new Size(444, 32);
            nameNewProyectTextBox.TabIndex = 1;
            // 
            // projectTabControl
            // 
            projectTabControl.Controls.Add(tabPageRequestProject);
            projectTabControl.Controls.Add(tabPage2);
            projectTabControl.Dock = DockStyle.Right;
            projectTabControl.Location = new Point(591, 0);
            projectTabControl.Margin = new Padding(4, 3, 4, 3);
            projectTabControl.Name = "projectTabControl";
            projectTabControl.SelectedIndex = 0;
            projectTabControl.Size = new Size(889, 840);
            projectTabControl.TabIndex = 9;
            // 
            // tabPageRequestProject
            // 
            tabPageRequestProject.Controls.Add(requestProjectDataGridView);
            tabPageRequestProject.Location = new Point(4, 34);
            tabPageRequestProject.Margin = new Padding(4, 3, 4, 3);
            tabPageRequestProject.Name = "tabPageRequestProject";
            tabPageRequestProject.Padding = new Padding(4, 3, 4, 3);
            tabPageRequestProject.Size = new Size(881, 802);
            tabPageRequestProject.TabIndex = 0;
            tabPageRequestProject.Text = "Solicitar proyectos";
            tabPageRequestProject.UseVisualStyleBackColor = true;
            // 
            // requestProjectDataGridView
            // 
            requestProjectDataGridView.AllowUserToAddRows = false;
            requestProjectDataGridView.BackgroundColor = Color.White;
            requestProjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestProjectDataGridView.Dock = DockStyle.Fill;
            requestProjectDataGridView.Location = new Point(4, 3);
            requestProjectDataGridView.Margin = new Padding(4, 3, 4, 3);
            requestProjectDataGridView.Name = "requestProjectDataGridView";
            requestProjectDataGridView.ReadOnly = true;
            requestProjectDataGridView.RowHeadersWidth = 51;
            requestProjectDataGridView.Size = new Size(873, 796);
            requestProjectDataGridView.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listProjectDataGridView);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(881, 802);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Proyectos en curso";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listProjectDataGridView
            // 
            listProjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listProjectDataGridView.Columns.AddRange(new DataGridViewColumn[] { SelectPf, downloadProject });
            listProjectDataGridView.Dock = DockStyle.Fill;
            listProjectDataGridView.Location = new Point(4, 3);
            listProjectDataGridView.Margin = new Padding(4, 3, 4, 3);
            listProjectDataGridView.Name = "listProjectDataGridView";
            listProjectDataGridView.RowHeadersWidth = 51;
            listProjectDataGridView.Size = new Size(873, 796);
            listProjectDataGridView.TabIndex = 0;
            listProjectDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SelectPf
            // 
            SelectPf.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SelectPf.HeaderText = "Acción";
            SelectPf.MinimumWidth = 6;
            SelectPf.Name = "SelectPf";
            SelectPf.Width = 70;
            // 
            // downloadProject
            // 
            downloadProject.ActiveLinkColor = Color.Transparent;
            downloadProject.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            downloadProject.DefaultCellStyle = dataGridViewCellStyle1;
            downloadProject.HeaderText = "Descargar";
            downloadProject.MinimumWidth = 8;
            downloadProject.Name = "downloadProject";
            downloadProject.Text = "Download";
            downloadProject.UseColumnTextForLinkValue = true;
            downloadProject.VisitedLinkColor = Color.Black;
            downloadProject.Width = 150;
            // 
            // RequestClientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1480, 840);
            Controls.Add(projectTabControl);
            Controls.Add(newProjectGroupBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RequestClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyectos";
            Load += RequestClientForm_Load;
            newProjectGroupBox.ResumeLayout(false);
            newProjectGroupBox.PerformLayout();
            projectTabControl.ResumeLayout(false);
            tabPageRequestProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestProjectDataGridView).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listProjectDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox newProjectGroupBox;
        private Label descriptionProjectLabel;
        private TextBox descriptionProjectTextBox;
        private FontAwesome.Sharp.IconButton saveProjectButton;
        private Label nameProjectLabel;
        private TextBox nameNewProyectTextBox;
        private TabControl projectTabControl;
        private TabPage tabPageRequestProject;
        private DataGridView requestProjectDataGridView;
        private TabPage tabPage2;
        private DataGridView listProjectDataGridView;
        private DataGridViewButtonColumn SelectPf;
        private DataGridViewLinkColumn downloadProject;
    }
}