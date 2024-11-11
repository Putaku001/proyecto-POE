namespace PresentationLayer.Forms.Empleados
{
    partial class HomeUserEmployeeForm
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label1.Location = new Point(460, 320);
            label1.Name = "label1";
            label1.Size = new Size(256, 27);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido de vuelta ";
            // 
            // HomeUserEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 734);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeUserEmployeeForm";
            Text = "HomeUserEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblHoraUsuario;
        private Panel panelUsersView;
        private Panel panel10;
        private Label label7;
        private Panel panel9;
        private Label labelRegistration;
        private Label labelNumberPhone;
        private Label labelEmail;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Panel panel7;
        private PictureBox pictureBox6;
        private ListBox listBoxRequestProjects;
        private Label label4;
        private Panel panel6;
        private PictureBox pictureBox4;
        private ListBox listBoxProjectsAsignamment;
        private Label label5;
        private Label labelnameUser;
        private Label label3;
        private Label labelCity;
        private Label labelCountryByUser;
        private Label labelByAgeUser;
        private PictureBox pictureBoxSelectedUser;
        private Label labelByUser;
        private Label label1;
        private Panel panel8;
        private Label label11;
        private Panel panelInfoUsers;
        private DataGridView dataGridViewUsers;
        private DataGridViewButtonColumn viewUser;
        private FontAwesome.Sharp.IconButton iconButtonUserClients;
        private FontAwesome.Sharp.IconButton iconButtonUserAdministrator;
        private FontAwesome.Sharp.IconButton iconButtonUserEmployee;
        private Label labelUserAccount;
        private Panel panelPrijectsAssignament;
    }
}