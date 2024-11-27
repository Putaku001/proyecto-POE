namespace PresentationLayer.Forms.Admin
{
    partial class infoProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoProjects));
            getTaskDataGridView = new DataGridView();
            taskLabel = new Label();
            descriptionLabel = new Label();
            taskTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            downloadTaskLinkLabel = new LinkLabel();
            downloadPictureBox = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)getTaskDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)downloadPictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // getTaskDataGridView
            // 
            getTaskDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            getTaskDataGridView.Dock = DockStyle.Bottom;
            getTaskDataGridView.Location = new Point(0, 463);
            getTaskDataGridView.Margin = new Padding(4, 4, 4, 4);
            getTaskDataGridView.Name = "getTaskDataGridView";
            getTaskDataGridView.RowHeadersWidth = 51;
            getTaskDataGridView.Size = new Size(1115, 282);
            getTaskDataGridView.TabIndex = 0;
            getTaskDataGridView.CellClick += dataGridViewGetTask_CellClick;
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskLabel.Location = new Point(264, 22);
            taskLabel.Margin = new Padding(4, 0, 4, 0);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(74, 25);
            taskLabel.TabIndex = 1;
            taskLabel.Text = "Tarea";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(248, 126);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(136, 25);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Descripcion";
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(24, 64);
            taskTextBox.Margin = new Padding(4, 4, 4, 4);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(568, 31);
            taskTextBox.TabIndex = 4;
            taskTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(22, 177);
            descriptionTextBox.Margin = new Padding(4, 4, 4, 4);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(568, 100);
            descriptionTextBox.TabIndex = 5;
            descriptionTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // downloadTaskLinkLabel
            // 
            downloadTaskLinkLabel.AutoSize = true;
            downloadTaskLinkLabel.Location = new Point(748, 141);
            downloadTaskLinkLabel.Margin = new Padding(4, 0, 4, 0);
            downloadTaskLinkLabel.Name = "downloadTaskLinkLabel";
            downloadTaskLinkLabel.Size = new Size(135, 25);
            downloadTaskLinkLabel.TabIndex = 7;
            downloadTaskLinkLabel.TabStop = true;
            downloadTaskLinkLabel.Text = "Descargar tarea";
            downloadTaskLinkLabel.Visible = false;
            downloadTaskLinkLabel.LinkClicked += linkLabelDownloadTask_LinkClicked;
            // 
            // downloadPictureBox
            // 
            downloadPictureBox.Image = (Image)resources.GetObject("downloadPictureBox.Image");
            downloadPictureBox.Location = new Point(748, 62);
            downloadPictureBox.Name = "downloadPictureBox";
            downloadPictureBox.Size = new Size(150, 75);
            downloadPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            downloadPictureBox.TabIndex = 8;
            downloadPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(taskLabel);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(taskTextBox);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Location = new Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 402);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DodgerBlue;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 10;
            label1.Text = "Informa";
            // 
            // infoProjects
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1115, 745);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(downloadPictureBox);
            Controls.Add(downloadTaskLinkLabel);
            Controls.Add(getTaskDataGridView);
            Margin = new Padding(4, 4, 4, 4);
            Name = "infoProjects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informacion Proyecto";
            Load += infoProjects_Load;
            ((System.ComponentModel.ISupportInitialize)getTaskDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)downloadPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView getTaskDataGridView;
        private Label taskLabel;
        private Label descriptionLabel;
        private TextBox taskTextBox;
        private TextBox descriptionTextBox;
        private LinkLabel downloadTaskLinkLabel;
        private PictureBox downloadPictureBox;
        private Panel panel1;
        private Label label1;
    }
}