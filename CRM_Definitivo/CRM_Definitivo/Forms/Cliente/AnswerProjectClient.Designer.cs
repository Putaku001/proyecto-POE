namespace PresentationLayer.Forms.Cliente
{
    partial class AnswerProyectClient
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
            IconButtonApprovedProject = new FontAwesome.Sharp.IconButton();
            labelDescription = new Label();
            textBoxDescriptionProject = new TextBox();
            iconButtonRefusedProject = new FontAwesome.Sharp.IconButton();
            groupBoxInfo = new GroupBox();
            labelNameProject = new Label();
            labelCodeProject = new Label();
            groupBoxInfo.SuspendLayout();
            SuspendLayout();
            // 
            // IconButtonApprovedProject
            // 
            IconButtonApprovedProject.BackColor = Color.ForestGreen;
            IconButtonApprovedProject.Cursor = Cursors.Hand;
            IconButtonApprovedProject.FlatAppearance.BorderColor = Color.Black;
            IconButtonApprovedProject.FlatStyle = FlatStyle.Flat;
            IconButtonApprovedProject.ForeColor = Color.White;
            IconButtonApprovedProject.IconChar = FontAwesome.Sharp.IconChar.Save;
            IconButtonApprovedProject.IconColor = Color.White;
            IconButtonApprovedProject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonApprovedProject.IconSize = 22;
            IconButtonApprovedProject.ImageAlign = ContentAlignment.MiddleLeft;
            IconButtonApprovedProject.Location = new Point(27, 274);
            IconButtonApprovedProject.Name = "IconButtonApprovedProject";
            IconButtonApprovedProject.Size = new Size(296, 29);
            IconButtonApprovedProject.TabIndex = 24;
            IconButtonApprovedProject.Text = "Aprobar";
            IconButtonApprovedProject.UseVisualStyleBackColor = false;
            IconButtonApprovedProject.Click += IconButtonApprovedProject_Click;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(222, 22);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(159, 17);
            labelDescription.TabIndex = 25;
            labelDescription.Text = "Descripcion del proyecto";
            // 
            // textBoxDescriptionProject
            // 
            textBoxDescriptionProject.Location = new Point(147, 45);
            textBoxDescriptionProject.Multiline = true;
            textBoxDescriptionProject.Name = "textBoxDescriptionProject";
            textBoxDescriptionProject.Size = new Size(349, 130);
            textBoxDescriptionProject.TabIndex = 26;
            // 
            // iconButtonRefusedProject
            // 
            iconButtonRefusedProject.BackColor = Color.Red;
            iconButtonRefusedProject.Cursor = Cursors.Hand;
            iconButtonRefusedProject.FlatAppearance.BorderColor = Color.Black;
            iconButtonRefusedProject.FlatStyle = FlatStyle.Flat;
            iconButtonRefusedProject.ForeColor = Color.White;
            iconButtonRefusedProject.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            iconButtonRefusedProject.IconColor = Color.White;
            iconButtonRefusedProject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonRefusedProject.IconSize = 22;
            iconButtonRefusedProject.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonRefusedProject.Location = new Point(367, 274);
            iconButtonRefusedProject.Name = "iconButtonRefusedProject";
            iconButtonRefusedProject.Size = new Size(296, 29);
            iconButtonRefusedProject.TabIndex = 27;
            iconButtonRefusedProject.Text = "Rechazar";
            iconButtonRefusedProject.UseVisualStyleBackColor = false;
            iconButtonRefusedProject.Click += iconButtonRefusedProject_Click;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(textBoxDescriptionProject);
            groupBoxInfo.Controls.Add(labelDescription);
            groupBoxInfo.Location = new Point(27, 54);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(636, 196);
            groupBoxInfo.TabIndex = 28;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Informacion";
            // 
            // labelNameProject
            // 
            labelNameProject.AutoSize = true;
            labelNameProject.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNameProject.Location = new Point(14, 9);
            labelNameProject.Name = "labelNameProject";
            labelNameProject.Size = new Size(109, 21);
            labelNameProject.TabIndex = 27;
            labelNameProject.Text = "nameProject";
            // 
            // labelCodeProject
            // 
            labelCodeProject.AutoSize = true;
            labelCodeProject.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCodeProject.ForeColor = SystemColors.ButtonShadow;
            labelCodeProject.Location = new Point(606, 13);
            labelCodeProject.Name = "labelCodeProject";
            labelCodeProject.Size = new Size(49, 16);
            labelCodeProject.TabIndex = 27;
            labelCodeProject.Text = "u24123";
            // 
            // AnswerProyectClient
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 348);
            Controls.Add(labelCodeProject);
            Controls.Add(labelNameProject);
            Controls.Add(iconButtonRefusedProject);
            Controls.Add(IconButtonApprovedProject);
            Controls.Add(groupBoxInfo);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "AnswerProyectClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informacion";
            Load += AnswerProyectClient_Load;
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton IconButtonApprovedProject;
        private Label labelDescription;
        private TextBox textBoxDescriptionProject;
        private FontAwesome.Sharp.IconButton iconButtonRefusedProject;
        private GroupBox groupBoxInfo;
        private Label labelNameProject;
        private Label labelCodeProject;
    }
}