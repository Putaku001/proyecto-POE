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
            dataGridViewGetTask = new DataGridView();
            labelTask = new Label();
            labelDescription = new Label();
            textBoxTask = new TextBox();
            textBoxDescription = new TextBox();
            linkLabelDownloadTask = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGetTask).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGetTask
            // 
            dataGridViewGetTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGetTask.Dock = DockStyle.Bottom;
            dataGridViewGetTask.Location = new Point(0, 224);
            dataGridViewGetTask.Name = "dataGridViewGetTask";
            dataGridViewGetTask.RowHeadersWidth = 51;
            dataGridViewGetTask.Size = new Size(800, 226);
            dataGridViewGetTask.TabIndex = 0;
            dataGridViewGetTask.CellClick += dataGridViewGetTask_CellClick;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(212, 27);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(44, 20);
            labelTask.TabIndex = 1;
            labelTask.Text = "Tarea";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(191, 99);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(87, 20);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Descripcion";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(12, 50);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(455, 27);
            textBoxTask.TabIndex = 4;
            textBoxTask.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 122);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(455, 81);
            textBoxDescription.TabIndex = 5;
            textBoxDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // linkLabelDownloadTask
            // 
            linkLabelDownloadTask.AutoSize = true;
            linkLabelDownloadTask.Location = new Point(598, 113);
            linkLabelDownloadTask.Name = "linkLabelDownloadTask";
            linkLabelDownloadTask.Size = new Size(114, 20);
            linkLabelDownloadTask.TabIndex = 7;
            linkLabelDownloadTask.TabStop = true;
            linkLabelDownloadTask.Text = "Descargar tarea";
            linkLabelDownloadTask.Visible = false;
            linkLabelDownloadTask.LinkClicked += linkLabelDownloadTask_LinkClicked;
            // 
            // infoProjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabelDownloadTask);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxTask);
            Controls.Add(labelDescription);
            Controls.Add(labelTask);
            Controls.Add(dataGridViewGetTask);
            Name = "infoProjects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "infoProjects";
            Load += infoProjects_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGetTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewGetTask;
        private Label labelTask;
        private Label labelDescription;
        private TextBox textBoxTask;
        private TextBox textBoxDescription;
        private LinkLabel linkLabelDownloadTask;
    }
}