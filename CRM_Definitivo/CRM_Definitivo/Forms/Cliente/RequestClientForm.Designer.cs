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
            gbAñadirNuevosProyectos = new GroupBox();
            descriptionLabel = new Label();
            textBoxDescription = new TextBox();
            iconButtonGuardarNP = new FontAwesome.Sharp.IconButton();
            lblProyecto = new Label();
            txtNombreProyectoAñadir = new TextBox();
            tabControl1 = new TabControl();
            tabPageRequestProject = new TabPage();
            dataGridViewRequestProject = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            SelectPf = new DataGridViewButtonColumn();
            downloadProject = new DataGridViewLinkColumn();
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
            gbAñadirNuevosProyectos.Controls.Add(textBoxDescription);
            gbAñadirNuevosProyectos.Controls.Add(iconButtonGuardarNP);
            gbAñadirNuevosProyectos.Controls.Add(lblProyecto);
            gbAñadirNuevosProyectos.Controls.Add(txtNombreProyectoAñadir);
            gbAñadirNuevosProyectos.Location = new Point(0, 0);
            gbAñadirNuevosProyectos.Margin = new Padding(3, 2, 3, 2);
            gbAñadirNuevosProyectos.Name = "gbAñadirNuevosProyectos";
            gbAñadirNuevosProyectos.Padding = new Padding(3, 2, 3, 2);
            gbAñadirNuevosProyectos.Size = new Size(408, 565);
            gbAñadirNuevosProyectos.TabIndex = 8;
            gbAñadirNuevosProyectos.TabStop = false;
            gbAñadirNuevosProyectos.Text = "Añadir nuevos proyectos:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(108, 172);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(72, 15);
            descriptionLabel.TabIndex = 26;
            descriptionLabel.Text = "Descripcion:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescription.Location = new Point(106, 188);
            textBoxDescription.Margin = new Padding(3, 2, 3, 2);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(180, 88);
            textBoxDescription.TabIndex = 27;
            // 
            // iconButtonGuardarNP
            // 
            iconButtonGuardarNP.BackColor = Color.ForestGreen;
            iconButtonGuardarNP.Cursor = Cursors.Hand;
            iconButtonGuardarNP.FlatAppearance.BorderColor = Color.Black;
            iconButtonGuardarNP.FlatStyle = FlatStyle.Flat;
            iconButtonGuardarNP.ForeColor = Color.White;
            iconButtonGuardarNP.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButtonGuardarNP.IconColor = Color.White;
            iconButtonGuardarNP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonGuardarNP.IconSize = 22;
            iconButtonGuardarNP.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonGuardarNP.Location = new Point(108, 308);
            iconButtonGuardarNP.Margin = new Padding(3, 2, 3, 2);
            iconButtonGuardarNP.Name = "iconButtonGuardarNP";
            iconButtonGuardarNP.Size = new Size(178, 22);
            iconButtonGuardarNP.TabIndex = 23;
            iconButtonGuardarNP.Text = "Solicitar";
            iconButtonGuardarNP.UseVisualStyleBackColor = false;
            iconButtonGuardarNP.Click += iconButtonGuardarNP_Click;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Location = new Point(108, 123);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(123, 15);
            lblProyecto.TabIndex = 0;
            lblProyecto.Text = "Nombre del proyecto:";
            // 
            // txtNombreProyectoAñadir
            // 
            txtNombreProyectoAñadir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreProyectoAñadir.Location = new Point(106, 139);
            txtNombreProyectoAñadir.Margin = new Padding(3, 2, 3, 2);
            txtNombreProyectoAñadir.Multiline = true;
            txtNombreProyectoAñadir.Name = "txtNombreProyectoAñadir";
            txtNombreProyectoAñadir.Size = new Size(180, 21);
            txtNombreProyectoAñadir.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageRequestProject);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Right;
            tabControl1.Location = new Point(414, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(622, 566);
            tabControl1.TabIndex = 9;
            // 
            // tabPageRequestProject
            // 
            tabPageRequestProject.Controls.Add(dataGridViewRequestProject);
            tabPageRequestProject.Location = new Point(4, 24);
            tabPageRequestProject.Margin = new Padding(3, 2, 3, 2);
            tabPageRequestProject.Name = "tabPageRequestProject";
            tabPageRequestProject.Padding = new Padding(3, 2, 3, 2);
            tabPageRequestProject.Size = new Size(515, 538);
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
            dataGridViewRequestProject.Location = new Point(3, 2);
            dataGridViewRequestProject.Margin = new Padding(3, 2, 3, 2);
            dataGridViewRequestProject.Name = "dataGridViewRequestProject";
            dataGridViewRequestProject.ReadOnly = true;
            dataGridViewRequestProject.RowHeadersWidth = 51;
            dataGridViewRequestProject.Size = new Size(509, 534);
            dataGridViewRequestProject.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(614, 538);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Proyectos en curso";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SelectPf, downloadProject });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 2);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(608, 534);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            downloadProject.Name = "downloadProject";
            downloadProject.Text = "Download";
            downloadProject.UseColumnTextForLinkValue = true;
            downloadProject.VisitedLinkColor = Color.Black;
            // 
            // RequestClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 566);
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
        private TextBox textBoxDescription;
        private FontAwesome.Sharp.IconButton iconButtonGuardarNP;
        private Label lblProyecto;
        private TextBox txtNombreProyectoAñadir;
        private TabControl tabControl1;
        private TabPage tabPageRequestProject;
        private DataGridView dataGridViewRequestProject;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn SelectPf;
        private DataGridViewLinkColumn downloadProject;
    }
}