namespace PresentationLayer.Forms
{
    partial class MenuForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            pbMinimizar = new PictureBox();
            pbEliminar = new PictureBox();
            pictureBox1 = new PictureBox();
            lblHoraUsuario = new Label();
            lblNombreUsuario = new Label();
            btnUsuariosForm = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            lblNombreProyecto = new Label();
            pictureBox2 = new PictureBox();
            btnAcercaDe = new Button();
            btnAjustesForm = new Button();
            btnHistorialForm = new Button();
            btnProyectosForm = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            contenedor = new Panel();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pbMinimizar);
            panel1.Controls.Add(pbEliminar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblHoraUsuario);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(242, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 96);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(69, 64);
            label2.Name = "label2";
            label2.Size = new Size(126, 22);
            label2.TabIndex = 6;
            label2.Text = "Cerrar sesion";
            label2.Click += label2_Click;
            // 
            // pbMinimizar
            // 
            pbMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbMinimizar.Cursor = Cursors.Hand;
            pbMinimizar.Image = Properties.Resources.negative_sign_icon_icons_com_70439;
            pbMinimizar.Location = new Point(1100, 3);
            pbMinimizar.Name = "pbMinimizar";
            pbMinimizar.Size = new Size(34, 36);
            pbMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pbMinimizar.TabIndex = 8;
            pbMinimizar.TabStop = false;
            pbMinimizar.Click += pbMinimizar_Click;
            pbMinimizar.MouseHover += pbMinimizar_MouseHover;
            // 
            // pbEliminar
            // 
            pbEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbEliminar.Cursor = Cursors.Hand;
            pbEliminar.Image = Properties.Resources.close_remove_delete_icon_148989;
            pbEliminar.Location = new Point(1140, 3);
            pbEliminar.Name = "pbEliminar";
            pbEliminar.Size = new Size(34, 36);
            pbEliminar.SizeMode = PictureBoxSizeMode.Zoom;
            pbEliminar.TabIndex = 7;
            pbEliminar.TabStop = false;
            pbEliminar.Click += pbEliminar_Click;
            pbEliminar.MouseHover += pbEliminar_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user_icon_icons_com_57997;
            pictureBox1.Location = new Point(5, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblHoraUsuario
            // 
            lblHoraUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHoraUsuario.AutoSize = true;
            lblHoraUsuario.Font = new Font("Century Gothic", 12F);
            lblHoraUsuario.ForeColor = Color.White;
            lblHoraUsuario.Location = new Point(1033, 58);
            lblHoraUsuario.Name = "lblHoraUsuario";
            lblHoraUsuario.Size = new Size(150, 23);
            lblHoraUsuario.TabIndex = 5;
            lblHoraUsuario.Text = "lblHoraUsuario";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Century Gothic", 12F);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(69, 35);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(183, 23);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "lblNombreUsuario";
            // 
            // btnUsuariosForm
            // 
            btnUsuariosForm.FlatAppearance.BorderSize = 0;
            btnUsuariosForm.FlatStyle = FlatStyle.Flat;
            btnUsuariosForm.Font = new Font("Century Gothic", 13.8F);
            btnUsuariosForm.ForeColor = Color.White;
            btnUsuariosForm.Image = Properties.Resources.round_account_button_with_user_inside_icon_icons1;
            btnUsuariosForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuariosForm.Location = new Point(12, 187);
            btnUsuariosForm.Name = "btnUsuariosForm";
            btnUsuariosForm.Size = new Size(238, 36);
            btnUsuariosForm.TabIndex = 3;
            btnUsuariosForm.Text = "Usuarios";
            btnUsuariosForm.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuariosForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuariosForm.UseVisualStyleBackColor = true;
            btnUsuariosForm.Click += btnUsuariosForm_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblNombreProyecto);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnAcercaDe);
            panel2.Controls.Add(btnAjustesForm);
            panel2.Controls.Add(btnHistorialForm);
            panel2.Controls.Add(btnProyectosForm);
            panel2.Controls.Add(btnUsuariosForm);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 772);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom;
            panel4.BackColor = Color.Azure;
            panel4.Location = new Point(3, 671);
            panel4.Name = "panel4";
            panel4.Size = new Size(247, 10);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Location = new Point(0, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 10);
            panel3.TabIndex = 0;
            // 
            // lblNombreProyecto
            // 
            lblNombreProyecto.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreProyecto.ForeColor = Color.White;
            lblNombreProyecto.Location = new Point(12, 99);
            lblNombreProyecto.Name = "lblNombreProyecto";
            lblNombreProyecto.Size = new Size(215, 46);
            lblNombreProyecto.TabIndex = 7;
            lblNombreProyecto.Text = "Proyectos Los Tilines";
            lblNombreProyecto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.projects_icon_142976;
            pictureBox2.Location = new Point(60, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.FlatAppearance.BorderSize = 0;
            btnAcercaDe.FlatStyle = FlatStyle.Flat;
            btnAcercaDe.Font = new Font("Century Gothic", 13.8F);
            btnAcercaDe.ForeColor = Color.White;
            btnAcercaDe.Image = Properties.Resources.info;
            btnAcercaDe.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcercaDe.Location = new Point(12, 467);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(238, 36);
            btnAcercaDe.TabIndex = 7;
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.TextAlign = ContentAlignment.MiddleLeft;
            btnAcercaDe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAcercaDe.UseVisualStyleBackColor = true;
            // 
            // btnAjustesForm
            // 
            btnAjustesForm.FlatAppearance.BorderSize = 0;
            btnAjustesForm.FlatStyle = FlatStyle.Flat;
            btnAjustesForm.Font = new Font("Century Gothic", 13.8F);
            btnAjustesForm.ForeColor = Color.White;
            btnAjustesForm.Image = Properties.Resources.ajustes;
            btnAjustesForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnAjustesForm.Location = new Point(12, 401);
            btnAjustesForm.Name = "btnAjustesForm";
            btnAjustesForm.Size = new Size(238, 36);
            btnAjustesForm.TabIndex = 6;
            btnAjustesForm.Text = "Ajustes";
            btnAjustesForm.TextAlign = ContentAlignment.MiddleLeft;
            btnAjustesForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAjustesForm.UseVisualStyleBackColor = true;
            // 
            // btnHistorialForm
            // 
            btnHistorialForm.FlatAppearance.BorderSize = 0;
            btnHistorialForm.FlatStyle = FlatStyle.Flat;
            btnHistorialForm.Font = new Font("Century Gothic", 13.8F);
            btnHistorialForm.ForeColor = Color.White;
            btnHistorialForm.Image = Properties.Resources.historial;
            btnHistorialForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorialForm.Location = new Point(12, 331);
            btnHistorialForm.Name = "btnHistorialForm";
            btnHistorialForm.Size = new Size(238, 36);
            btnHistorialForm.TabIndex = 5;
            btnHistorialForm.Text = "Historial";
            btnHistorialForm.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorialForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistorialForm.UseVisualStyleBackColor = true;
            // 
            // btnProyectosForm
            // 
            btnProyectosForm.FlatAppearance.BorderSize = 0;
            btnProyectosForm.FlatStyle = FlatStyle.Flat;
            btnProyectosForm.Font = new Font("Century Gothic", 13.8F);
            btnProyectosForm.ForeColor = Color.White;
            btnProyectosForm.Image = Properties.Resources.Proyecto;
            btnProyectosForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnProyectosForm.Location = new Point(12, 260);
            btnProyectosForm.Name = "btnProyectosForm";
            btnProyectosForm.Size = new Size(198, 36);
            btnProyectosForm.TabIndex = 4;
            btnProyectosForm.Text = "Proyectos";
            btnProyectosForm.TextAlign = ContentAlignment.MiddleLeft;
            btnProyectosForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProyectosForm.UseVisualStyleBackColor = true;
            btnProyectosForm.Click += btnProyectosForm_Click;
            // 
            // contenedor
            // 
            contenedor.BackColor = SystemColors.ControlDark;
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(242, 96);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1186, 676);
            contenedor.TabIndex = 0;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1428, 772);
            Controls.Add(contenedor);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            Text = "E";
            WindowState = FormWindowState.Maximized;
            Load += MenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lblHoraUsuario;
        private Label lblNombreUsuario;
        private Button btnUsuariosForm;
        private Panel panel2;
        private Button btnAcercaDe;
        private Button btnAjustesForm;
        private Button btnHistorialForm;
        private Button btnProyectosForm;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel contenedor;
        private Label lblNombreProyecto;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pbMinimizar;
        private PictureBox pbEliminar;
        private ToolTip toolTip1;
    }
}