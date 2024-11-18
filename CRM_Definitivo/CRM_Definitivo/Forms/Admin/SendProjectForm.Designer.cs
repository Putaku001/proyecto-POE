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
            iconButtonSendProject = new FontAwesome.Sharp.IconButton();
            labelUserAccount = new Label();
            labelClient = new Label();
            labelNameProject = new Label();
            groupBoxProject = new GroupBox();
            labelCodeProject = new Label();
            linkLabelFileProject = new LinkLabel();
            textBoxDescription = new TextBox();
            label1 = new Label();
            labelEnd = new Label();
            groupBoxProject.SuspendLayout();
            SuspendLayout();
            // 
            // iconButtonSendProject
            // 
            iconButtonSendProject.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSendProject.IconColor = Color.Black;
            iconButtonSendProject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSendProject.Location = new Point(178, 218);
            iconButtonSendProject.Name = "iconButtonSendProject";
            iconButtonSendProject.Size = new Size(209, 29);
            iconButtonSendProject.TabIndex = 24;
            iconButtonSendProject.Text = "Enviar proyecto";
            iconButtonSendProject.UseVisualStyleBackColor = true;
            iconButtonSendProject.Click += iconButtonSendProject_Click;
            // 
            // labelUserAccount
            // 
            labelUserAccount.AutoSize = true;
            labelUserAccount.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserAccount.Location = new Point(98, 54);
            labelUserAccount.Name = "labelUserAccount";
            labelUserAccount.Size = new Size(103, 21);
            labelUserAccount.TabIndex = 20;
            labelUserAccount.Text = "labelClient";
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClient.Location = new Point(14, 54);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(78, 21);
            labelClient.TabIndex = 19;
            labelClient.Text = "Cliente:";
            // 
            // labelNameProject
            // 
            labelNameProject.BackColor = SystemColors.ActiveCaption;
            labelNameProject.Dock = DockStyle.Top;
            labelNameProject.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNameProject.ForeColor = Color.White;
            labelNameProject.Location = new Point(0, 0);
            labelNameProject.Name = "labelNameProject";
            labelNameProject.Size = new Size(607, 33);
            labelNameProject.TabIndex = 18;
            labelNameProject.Text = "nameProject";
            // 
            // groupBoxProject
            // 
            groupBoxProject.Controls.Add(labelCodeProject);
            groupBoxProject.Controls.Add(iconButtonSendProject);
            groupBoxProject.Controls.Add(linkLabelFileProject);
            groupBoxProject.Controls.Add(textBoxDescription);
            groupBoxProject.Controls.Add(label1);
            groupBoxProject.Location = new Point(12, 88);
            groupBoxProject.Name = "groupBoxProject";
            groupBoxProject.Size = new Size(571, 278);
            groupBoxProject.TabIndex = 23;
            groupBoxProject.TabStop = false;
            groupBoxProject.Text = "Proyecto";
            // 
            // labelCodeProject
            // 
            labelCodeProject.AutoSize = true;
            labelCodeProject.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCodeProject.ForeColor = SystemColors.AppWorkspace;
            labelCodeProject.Location = new Point(6, 253);
            labelCodeProject.Name = "labelCodeProject";
            labelCodeProject.Size = new Size(70, 22);
            labelCodeProject.TabIndex = 25;
            labelCodeProject.Text = "u24123";
            // 
            // linkLabelFileProject
            // 
            linkLabelFileProject.AutoSize = true;
            linkLabelFileProject.Location = new Point(226, 161);
            linkLabelFileProject.Name = "linkLabelFileProject";
            linkLabelFileProject.Size = new Size(111, 20);
            linkLabelFileProject.TabIndex = 25;
            linkLabelFileProject.TabStop = true;
            linkLabelFileProject.Text = "Subir el archivo";
            linkLabelFileProject.LinkClicked += linkLabelFileProject_LinkClicked;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(15, 51);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(533, 74);
            textBoxDescription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Descripcion:";
            // 
            // labelEnd
            // 
            labelEnd.BackColor = SystemColors.AppWorkspace;
            labelEnd.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEnd.ForeColor = Color.White;
            labelEnd.Image = Properties.Resources.calendario1;
            labelEnd.ImageAlign = ContentAlignment.TopLeft;
            labelEnd.Location = new Point(462, 7);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(122, 21);
            labelEnd.TabIndex = 24;
            labelEnd.Text = "2024-11-12";
            labelEnd.TextAlign = ContentAlignment.TopRight;
            // 
            // SendProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 384);
            Controls.Add(labelEnd);
            Controls.Add(labelUserAccount);
            Controls.Add(labelClient);
            Controls.Add(labelNameProject);
            Controls.Add(groupBoxProject);
            Name = "SendProjectForm";
            Text = "SendProjectForm";
            Load += SendProjectForm_Load;
            groupBoxProject.ResumeLayout(false);
            groupBoxProject.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonSendProject;
        private Label labelUserAccount;
        private Label labelClient;
        private Label labelNameProject;
        private GroupBox groupBoxProject;
        private LinkLabel linkLabelFileProject;
        private TextBox textBoxDescription;
        private Label label1;
        private Label labelEnd;
        private Label labelCodeProject;
    }
}