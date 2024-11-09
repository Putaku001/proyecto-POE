namespace PresentationLayer.Forms
{
    partial class ProjectsHistoric
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
            dataGridViewHistoricProjectsUser = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoricProjectsUser).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistoricProjectsUser
            // 
            dataGridViewHistoricProjectsUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistoricProjectsUser.Location = new Point(28, 105);
            dataGridViewHistoricProjectsUser.Name = "dataGridViewHistoricProjectsUser";
            dataGridViewHistoricProjectsUser.RowHeadersWidth = 51;
            dataGridViewHistoricProjectsUser.Size = new Size(1179, 521);
            dataGridViewHistoricProjectsUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1236, 83);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // ProjectsHistoric
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 638);
            Controls.Add(label1);
            Controls.Add(dataGridViewHistoricProjectsUser);
            Name = "ProjectsHistoric";
            Text = "ProjectsHistoric";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoricProjectsUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewHistoricProjectsUser;
        private Label label1;
    }
}