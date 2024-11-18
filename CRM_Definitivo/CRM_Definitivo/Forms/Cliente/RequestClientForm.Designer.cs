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
            gbAñadirNuevosProyectos = new GroupBox();
            descriptionLabel = new Label();
            textBox1 = new TextBox();
            btnGuardarNP = new FontAwesome.Sharp.IconButton();
            lblProyecto = new Label();
            txtNombreProyectoAñadir = new TextBox();
            tabControl1 = new TabControl();
            tabPageRequestProject = new TabPage();
            dataGridViewRequestProject = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            SelectPf = new DataGridViewButtonColumn();
            gbAñadirNuevosProyectos.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageRequestProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequestProject).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbAñadirNuevosProyectos
            // 
            gbAñadirNuevosProyectos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbAñadirNuevosProyectos.Controls.Add(descriptionLabel);
            gbAñadirNuevosProyectos.Controls.Add(textBox1);
            gbAñadirNuevosProyectos.Controls.Add(btnGuardarNP);
            gbAñadirNuevosProyectos.Controls.Add(lblProyecto);
            gbAñadirNuevosProyectos.Controls.Add(txtNombreProyectoAñadir);
            gbAñadirNuevosProyectos.Location = new Point(0, 0);
            gbAñadirNuevosProyectos.Name = "gbAñadirNuevosProyectos";
            gbAñadirNuevosProyectos.Size = new Size(580, 753);
            gbAñadirNuevosProyectos.TabIndex = 8;
            gbAñadirNuevosProyectos.TabStop = false;
            gbAñadirNuevosProyectos.Text = "Añadir nuevos proyectos:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(124, 230);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(90, 20);
            descriptionLabel.TabIndex = 26;
            descriptionLabel.Text = "Descripcion:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(121, 250);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 116);
            textBox1.TabIndex = 27;
            // 
            // btnGuardarNP
            // 
            btnGuardarNP.BackColor = Color.ForestGreen;
            btnGuardarNP.Cursor = Cursors.Hand;
            btnGuardarNP.FlatAppearance.BorderColor = Color.Black;
            btnGuardarNP.FlatStyle = FlatStyle.Flat;
            btnGuardarNP.ForeColor = Color.White;
            btnGuardarNP.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarNP.IconColor = Color.White;
            btnGuardarNP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarNP.IconSize = 22;
            btnGuardarNP.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarNP.Location = new Point(124, 410);
            btnGuardarNP.Name = "btnGuardarNP";
            btnGuardarNP.Size = new Size(319, 29);
            btnGuardarNP.TabIndex = 23;
            btnGuardarNP.Text = "Solicitar";
            btnGuardarNP.UseVisualStyleBackColor = false;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Location = new Point(124, 164);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(155, 20);
            lblProyecto.TabIndex = 0;
            lblProyecto.Text = "Nombre del proyecto:";
            // 
            // txtNombreProyectoAñadir
            // 
            txtNombreProyectoAñadir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreProyectoAñadir.Location = new Point(121, 185);
            txtNombreProyectoAñadir.Multiline = true;
            txtNombreProyectoAñadir.Name = "txtNombreProyectoAñadir";
            txtNombreProyectoAñadir.Size = new Size(319, 27);
            txtNombreProyectoAñadir.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageRequestProject);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Right;
            tabControl1.Location = new Point(586, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(598, 754);
            tabControl1.TabIndex = 9;
            // 
            // tabPageRequestProject
            // 
            tabPageRequestProject.Controls.Add(dataGridViewRequestProject);
            tabPageRequestProject.Location = new Point(4, 29);
            tabPageRequestProject.Name = "tabPageRequestProject";
            tabPageRequestProject.Padding = new Padding(3);
            tabPageRequestProject.Size = new Size(590, 721);
            tabPageRequestProject.TabIndex = 0;
            tabPageRequestProject.Text = "Solicitar proyectos";
            tabPageRequestProject.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRequestProject
            // 
            dataGridViewRequestProject.AllowUserToAddRows = false;
            dataGridViewRequestProject.BackgroundColor = Color.White;
            dataGridViewRequestProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequestProject.Dock = DockStyle.Fill;
            dataGridViewRequestProject.Location = new Point(3, 3);
            dataGridViewRequestProject.Name = "dataGridViewRequestProject";
            dataGridViewRequestProject.ReadOnly = true;
            dataGridViewRequestProject.RowHeadersWidth = 51;
            dataGridViewRequestProject.Size = new Size(584, 715);
            dataGridViewRequestProject.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(590, 721);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Proyectos en curso";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SelectPf });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(584, 715);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SelectPf
            // 
            SelectPf.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SelectPf.HeaderText = "Select";
            SelectPf.MinimumWidth = 6;
            SelectPf.Name = "SelectPf";
            SelectPf.Width = 70;
            // 
            // RequestClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 754);
            Controls.Add(tabControl1);
            Controls.Add(gbAñadirNuevosProyectos);
            Margin = new Padding(2);
            Name = "RequestClientForm";
            Text = "ClientForm";
            Load += RequestClientForm_Load;
            gbAñadirNuevosProyectos.ResumeLayout(false);
            gbAñadirNuevosProyectos.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageRequestProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequestProject).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAñadirNuevosProyectos;
        private Label descriptionLabel;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnGuardarNP;
        private Label lblProyecto;
        private TextBox txtNombreProyectoAñadir;
        private TabControl tabControl1;
        private TabPage tabPageRequestProject;
        private DataGridView dataGridViewRequestProject;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn SelectPf;
    }
}