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
            btnEliminarNP = new FontAwesome.Sharp.IconButton();
            btnEditarNP = new FontAwesome.Sharp.IconButton();
            btnGuardarNP = new FontAwesome.Sharp.IconButton();
            lblProyecto = new Label();
            txtNombreProyectoAñadir = new TextBox();
            dgvAñadirProyectos = new DataGridView();
            gbAñadirNuevosProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAñadirProyectos).BeginInit();
            SuspendLayout();
            // 
            // gbAñadirNuevosProyectos
            // 
            gbAñadirNuevosProyectos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbAñadirNuevosProyectos.Controls.Add(descriptionLabel);
            gbAñadirNuevosProyectos.Controls.Add(textBox1);
            gbAñadirNuevosProyectos.Controls.Add(btnEliminarNP);
            gbAñadirNuevosProyectos.Controls.Add(btnEditarNP);
            gbAñadirNuevosProyectos.Controls.Add(btnGuardarNP);
            gbAñadirNuevosProyectos.Controls.Add(lblProyecto);
            gbAñadirNuevosProyectos.Controls.Add(txtNombreProyectoAñadir);
            gbAñadirNuevosProyectos.Location = new Point(0, 0);
            gbAñadirNuevosProyectos.Margin = new Padding(5);
            gbAñadirNuevosProyectos.Name = "gbAñadirNuevosProyectos";
            gbAñadirNuevosProyectos.Padding = new Padding(5);
            gbAñadirNuevosProyectos.Size = new Size(943, 1205);
            gbAñadirNuevosProyectos.TabIndex = 8;
            gbAñadirNuevosProyectos.TabStop = false;
            gbAñadirNuevosProyectos.Text = "Añadir nuevos proyectos:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(149, 179);
            descriptionLabel.Margin = new Padding(5, 0, 5, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(143, 32);
            descriptionLabel.TabIndex = 26;
            descriptionLabel.Text = "Descripcion:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(145, 212);
            textBox1.Margin = new Padding(5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(516, 184);
            textBox1.TabIndex = 27;
            // 
            // btnEliminarNP
            // 
            btnEliminarNP.BackColor = Color.Crimson;
            btnEliminarNP.Cursor = Cursors.Hand;
            btnEliminarNP.FlatAppearance.BorderColor = Color.Black;
            btnEliminarNP.FlatStyle = FlatStyle.Flat;
            btnEliminarNP.ForeColor = Color.White;
            btnEliminarNP.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminarNP.IconColor = Color.White;
            btnEliminarNP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarNP.IconSize = 22;
            btnEliminarNP.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarNP.Location = new Point(145, 825);
            btnEliminarNP.Margin = new Padding(5);
            btnEliminarNP.Name = "btnEliminarNP";
            btnEliminarNP.Size = new Size(518, 46);
            btnEliminarNP.TabIndex = 25;
            btnEliminarNP.Text = "Eliminar";
            btnEliminarNP.UseVisualStyleBackColor = false;
            // 
            // btnEditarNP
            // 
            btnEditarNP.BackColor = Color.DodgerBlue;
            btnEditarNP.Cursor = Cursors.Hand;
            btnEditarNP.FlatAppearance.BorderColor = Color.Black;
            btnEditarNP.FlatStyle = FlatStyle.Flat;
            btnEditarNP.ForeColor = Color.White;
            btnEditarNP.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditarNP.IconColor = Color.White;
            btnEditarNP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarNP.IconSize = 22;
            btnEditarNP.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarNP.Location = new Point(145, 769);
            btnEditarNP.Margin = new Padding(5);
            btnEditarNP.Name = "btnEditarNP";
            btnEditarNP.Size = new Size(518, 46);
            btnEditarNP.TabIndex = 24;
            btnEditarNP.Text = "Editar";
            btnEditarNP.UseVisualStyleBackColor = false;
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
            btnGuardarNP.Location = new Point(145, 713);
            btnGuardarNP.Margin = new Padding(5);
            btnGuardarNP.Name = "btnGuardarNP";
            btnGuardarNP.Size = new Size(518, 46);
            btnGuardarNP.TabIndex = 23;
            btnGuardarNP.Text = "Añadir";
            btnGuardarNP.UseVisualStyleBackColor = false;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Location = new Point(149, 74);
            lblProyecto.Margin = new Padding(5, 0, 5, 0);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(248, 32);
            lblProyecto.TabIndex = 0;
            lblProyecto.Text = "Nombre del proyecto:";
            // 
            // txtNombreProyectoAñadir
            // 
            txtNombreProyectoAñadir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreProyectoAñadir.Location = new Point(145, 107);
            txtNombreProyectoAñadir.Margin = new Padding(5);
            txtNombreProyectoAñadir.Multiline = true;
            txtNombreProyectoAñadir.Name = "txtNombreProyectoAñadir";
            txtNombreProyectoAñadir.Size = new Size(516, 41);
            txtNombreProyectoAñadir.TabIndex = 1;
            // 
            // dgvAñadirProyectos
            // 
            dgvAñadirProyectos.AllowUserToAddRows = false;
            dgvAñadirProyectos.BackgroundColor = Color.White;
            dgvAñadirProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAñadirProyectos.Dock = DockStyle.Right;
            dgvAñadirProyectos.Location = new Point(1023, 0);
            dgvAñadirProyectos.Margin = new Padding(5);
            dgvAñadirProyectos.Name = "dgvAñadirProyectos";
            dgvAñadirProyectos.ReadOnly = true;
            dgvAñadirProyectos.RowHeadersWidth = 51;
            dgvAñadirProyectos.Size = new Size(1297, 1205);
            dgvAñadirProyectos.TabIndex = 7;
            // 
            // RequestClientForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2320, 1205);
            Controls.Add(gbAñadirNuevosProyectos);
            Controls.Add(dgvAñadirProyectos);
            Name = "RequestClientForm";
            Text = "ClientForm";
            gbAñadirNuevosProyectos.ResumeLayout(false);
            gbAñadirNuevosProyectos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAñadirProyectos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAñadirNuevosProyectos;
        private Label descriptionLabel;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnEliminarNP;
        private FontAwesome.Sharp.IconButton btnEditarNP;
        private FontAwesome.Sharp.IconButton btnGuardarNP;
        private Label lblProyecto;
        private TextBox txtNombreProyectoAñadir;
        private DataGridView dgvAñadirProyectos;
    }
}