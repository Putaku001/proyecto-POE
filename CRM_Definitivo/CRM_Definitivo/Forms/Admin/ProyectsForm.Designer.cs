namespace PresentationLayer.Forms
{
    partial class ProyectsForm
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
            tpAñadirNuevasTareas = new TabPage();
            dgvTareas = new DataGridView();
            gbAñadirNuevasTareas = new GroupBox();
            lblProyectoSeleccionar = new Label();
            txtTareaAñadirTarea = new TextBox();
            lblTareaAñadir = new Label();
            btnGuardarNT = new FontAwesome.Sharp.IconButton();
            btnEditarNT = new FontAwesome.Sharp.IconButton();
            btnEliminarNT = new FontAwesome.Sharp.IconButton();
            cboProyectoTareasAñadir = new ComboBox();
            tpListaProyectos = new TabPage();
            dgvListaProyectos = new DataGridView();
            tpAsignarProyectos = new TabPage();
            gbListaProyecto = new GroupBox();
            cboProyectos = new ComboBox();
            cboEmpleados = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cboTareas = new ComboBox();
            lblFechaFin = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            dtpFechaEntrega = new DateTimePicker();
            btnEditar = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            comboBox1 = new ComboBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            tbTask = new TabControl();
            tpAñadirNuevasTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            gbAñadirNuevasTareas.SuspendLayout();
            tpListaProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProyectos).BeginInit();
            tpAsignarProyectos.SuspendLayout();
            gbListaProyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbTask.SuspendLayout();
            SuspendLayout();
            // 
            // tpAñadirNuevasTareas
            // 
            tpAñadirNuevasTareas.Controls.Add(gbAñadirNuevasTareas);
            tpAñadirNuevasTareas.Controls.Add(dgvTareas);
            tpAñadirNuevasTareas.Location = new Point(8, 46);
            tpAñadirNuevasTareas.Margin = new Padding(5);
            tpAñadirNuevasTareas.Name = "tpAñadirNuevasTareas";
            tpAñadirNuevasTareas.Padding = new Padding(5);
            tpAñadirNuevasTareas.Size = new Size(2215, 1047);
            tpAñadirNuevasTareas.TabIndex = 5;
            tpAñadirNuevasTareas.Text = "Añadir nuevas tareas";
            tpAñadirNuevasTareas.UseVisualStyleBackColor = true;
            // 
            // dgvTareas
            // 
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTareas.BackgroundColor = Color.White;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(1008, 98);
            dgvTareas.Margin = new Padding(5);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.ReadOnly = true;
            dgvTareas.RowHeadersWidth = 51;
            dgvTareas.Size = new Size(1159, 872);
            dgvTareas.TabIndex = 11;
            // 
            // gbAñadirNuevasTareas
            // 
            gbAñadirNuevasTareas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbAñadirNuevasTareas.Controls.Add(cboProyectoTareasAñadir);
            gbAñadirNuevasTareas.Controls.Add(btnEliminarNT);
            gbAñadirNuevasTareas.Controls.Add(btnEditarNT);
            gbAñadirNuevasTareas.Controls.Add(btnGuardarNT);
            gbAñadirNuevasTareas.Controls.Add(lblTareaAñadir);
            gbAñadirNuevasTareas.Controls.Add(txtTareaAñadirTarea);
            gbAñadirNuevasTareas.Controls.Add(lblProyectoSeleccionar);
            gbAñadirNuevasTareas.Location = new Point(50, 78);
            gbAñadirNuevasTareas.Margin = new Padding(5);
            gbAñadirNuevasTareas.Name = "gbAñadirNuevasTareas";
            gbAñadirNuevasTareas.Padding = new Padding(5);
            gbAñadirNuevasTareas.Size = new Size(824, 891);
            gbAñadirNuevasTareas.TabIndex = 12;
            gbAñadirNuevasTareas.TabStop = false;
            gbAñadirNuevasTareas.Text = "Añadir nuevas tareas:";
            // 
            // lblProyectoSeleccionar
            // 
            lblProyectoSeleccionar.AutoSize = true;
            lblProyectoSeleccionar.Location = new Point(52, 58);
            lblProyectoSeleccionar.Margin = new Padding(5, 0, 5, 0);
            lblProyectoSeleccionar.Name = "lblProyectoSeleccionar";
            lblProyectoSeleccionar.Size = new Size(260, 32);
            lblProyectoSeleccionar.TabIndex = 0;
            lblProyectoSeleccionar.Text = "Seleccione el proyecto:";
            // 
            // txtTareaAñadirTarea
            // 
            txtTareaAñadirTarea.Location = new Point(52, 216);
            txtTareaAñadirTarea.Margin = new Padding(5);
            txtTareaAñadirTarea.Name = "txtTareaAñadirTarea";
            txtTareaAñadirTarea.Size = new Size(516, 39);
            txtTareaAñadirTarea.TabIndex = 5;
            // 
            // lblTareaAñadir
            // 
            lblTareaAñadir.AutoSize = true;
            lblTareaAñadir.Location = new Point(52, 179);
            lblTareaAñadir.Margin = new Padding(5, 0, 5, 0);
            lblTareaAñadir.Name = "lblTareaAñadir";
            lblTareaAñadir.Size = new Size(74, 32);
            lblTareaAñadir.TabIndex = 4;
            lblTareaAñadir.Text = "Tarea:";
            // 
            // btnGuardarNT
            // 
            btnGuardarNT.BackColor = Color.ForestGreen;
            btnGuardarNT.Cursor = Cursors.Hand;
            btnGuardarNT.FlatAppearance.BorderColor = Color.Black;
            btnGuardarNT.FlatStyle = FlatStyle.Flat;
            btnGuardarNT.ForeColor = Color.White;
            btnGuardarNT.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarNT.IconColor = Color.White;
            btnGuardarNT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarNT.IconSize = 22;
            btnGuardarNT.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarNT.Location = new Point(52, 491);
            btnGuardarNT.Margin = new Padding(5);
            btnGuardarNT.Name = "btnGuardarNT";
            btnGuardarNT.Size = new Size(518, 46);
            btnGuardarNT.TabIndex = 23;
            btnGuardarNT.Text = "Añadir";
            btnGuardarNT.UseVisualStyleBackColor = false;
            // 
            // btnEditarNT
            // 
            btnEditarNT.BackColor = Color.DodgerBlue;
            btnEditarNT.Cursor = Cursors.Hand;
            btnEditarNT.FlatAppearance.BorderColor = Color.Black;
            btnEditarNT.FlatStyle = FlatStyle.Flat;
            btnEditarNT.ForeColor = Color.White;
            btnEditarNT.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditarNT.IconColor = Color.White;
            btnEditarNT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarNT.IconSize = 22;
            btnEditarNT.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarNT.Location = new Point(52, 547);
            btnEditarNT.Margin = new Padding(5);
            btnEditarNT.Name = "btnEditarNT";
            btnEditarNT.Size = new Size(518, 46);
            btnEditarNT.TabIndex = 24;
            btnEditarNT.Text = "Editar";
            btnEditarNT.UseVisualStyleBackColor = false;
            // 
            // btnEliminarNT
            // 
            btnEliminarNT.BackColor = Color.Crimson;
            btnEliminarNT.Cursor = Cursors.Hand;
            btnEliminarNT.FlatAppearance.BorderColor = Color.Black;
            btnEliminarNT.FlatStyle = FlatStyle.Flat;
            btnEliminarNT.ForeColor = Color.White;
            btnEliminarNT.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminarNT.IconColor = Color.White;
            btnEliminarNT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarNT.IconSize = 22;
            btnEliminarNT.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarNT.Location = new Point(52, 603);
            btnEliminarNT.Margin = new Padding(5);
            btnEliminarNT.Name = "btnEliminarNT";
            btnEliminarNT.Size = new Size(518, 46);
            btnEliminarNT.TabIndex = 25;
            btnEliminarNT.Text = "Eliminar";
            btnEliminarNT.UseVisualStyleBackColor = false;
            // 
            // cboProyectoTareasAñadir
            // 
            cboProyectoTareasAñadir.FormattingEnabled = true;
            cboProyectoTareasAñadir.Location = new Point(52, 95);
            cboProyectoTareasAñadir.Margin = new Padding(5);
            cboProyectoTareasAñadir.Name = "cboProyectoTareasAñadir";
            cboProyectoTareasAñadir.Size = new Size(516, 40);
            cboProyectoTareasAñadir.TabIndex = 26;
            // 
            // tpListaProyectos
            // 
            tpListaProyectos.Controls.Add(dgvListaProyectos);
            tpListaProyectos.Location = new Point(8, 46);
            tpListaProyectos.Margin = new Padding(5);
            tpListaProyectos.Name = "tpListaProyectos";
            tpListaProyectos.Padding = new Padding(5);
            tpListaProyectos.Size = new Size(2215, 1047);
            tpListaProyectos.TabIndex = 2;
            tpListaProyectos.Text = "Lista de proyectos";
            tpListaProyectos.UseVisualStyleBackColor = true;
            tpListaProyectos.Click += tpListaProyectos_Click;
            // 
            // dgvListaProyectos
            // 
            dgvListaProyectos.AllowUserToAddRows = false;
            dgvListaProyectos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaProyectos.BackgroundColor = Color.White;
            dgvListaProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProyectos.Location = new Point(46, 88);
            dgvListaProyectos.Margin = new Padding(5);
            dgvListaProyectos.Name = "dgvListaProyectos";
            dgvListaProyectos.ReadOnly = true;
            dgvListaProyectos.RowHeadersWidth = 51;
            dgvListaProyectos.Size = new Size(2134, 928);
            dgvListaProyectos.TabIndex = 5;
            // 
            // tpAsignarProyectos
            // 
            tpAsignarProyectos.Controls.Add(dataGridView1);
            tpAsignarProyectos.Controls.Add(gbListaProyecto);
            tpAsignarProyectos.Location = new Point(8, 46);
            tpAsignarProyectos.Margin = new Padding(5);
            tpAsignarProyectos.Name = "tpAsignarProyectos";
            tpAsignarProyectos.Padding = new Padding(5);
            tpAsignarProyectos.Size = new Size(2215, 1047);
            tpAsignarProyectos.TabIndex = 1;
            tpAsignarProyectos.Text = "Asignar Tareas";
            tpAsignarProyectos.UseVisualStyleBackColor = true;
            // 
            // gbListaProyecto
            // 
            gbListaProyecto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbListaProyecto.Controls.Add(label3);
            gbListaProyecto.Controls.Add(comboBox1);
            gbListaProyecto.Controls.Add(btnEliminar);
            gbListaProyecto.Controls.Add(label4);
            gbListaProyecto.Controls.Add(btnEditar);
            gbListaProyecto.Controls.Add(dtpFechaEntrega);
            gbListaProyecto.Controls.Add(btnGuardar);
            gbListaProyecto.Controls.Add(lblFechaFin);
            gbListaProyecto.Controls.Add(cboTareas);
            gbListaProyecto.Controls.Add(label1);
            gbListaProyecto.Controls.Add(label2);
            gbListaProyecto.Controls.Add(cboEmpleados);
            gbListaProyecto.Controls.Add(cboProyectos);
            gbListaProyecto.Location = new Point(47, 53);
            gbListaProyecto.Margin = new Padding(5);
            gbListaProyecto.Name = "gbListaProyecto";
            gbListaProyecto.Padding = new Padding(5);
            gbListaProyecto.Size = new Size(2109, 371);
            gbListaProyecto.TabIndex = 3;
            gbListaProyecto.TabStop = false;
            gbListaProyecto.Text = "Asignar Tareas:";
            // 
            // cboProyectos
            // 
            cboProyectos.FormattingEnabled = true;
            cboProyectos.Location = new Point(48, 94);
            cboProyectos.Margin = new Padding(5);
            cboProyectos.Name = "cboProyectos";
            cboProyectos.Size = new Size(516, 40);
            cboProyectos.TabIndex = 2;
            // 
            // cboEmpleados
            // 
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(741, 181);
            cboEmpleados.Margin = new Padding(5);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(516, 40);
            cboEmpleados.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 57);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 3;
            label2.Text = "Proyecto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(741, 144);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 28;
            label1.Text = "Empleado:";
            // 
            // cboTareas
            // 
            cboTareas.FormattingEnabled = true;
            cboTareas.Location = new Point(741, 94);
            cboTareas.Margin = new Padding(5);
            cboTareas.Name = "cboTareas";
            cboTareas.Size = new Size(516, 40);
            cboTareas.TabIndex = 6;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(741, 246);
            lblFechaFin.Margin = new Padding(5, 0, 5, 0);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(204, 32);
            lblFechaFin.TabIndex = 11;
            lblFechaFin.Text = "Fecha de entrega:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 22;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(1341, 117);
            btnGuardar.Margin = new Padding(5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(518, 46);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(741, 282);
            dtpFechaEntrega.Margin = new Padding(5);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(516, 39);
            dtpFechaEntrega.TabIndex = 10;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DodgerBlue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.Black;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.White;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 22;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(1341, 173);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(518, 46);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(741, 58);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 7;
            label4.Text = "Tareas:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 22;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(1341, 229);
            btnEliminar.Margin = new Padding(5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(518, 46);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(48, 183);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(516, 40);
            comboBox1.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 146);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 31;
            label3.Text = "Estado:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 434);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(2109, 579);
            dataGridView1.TabIndex = 4;
            // 
            // tbTask
            // 
            tbTask.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbTask.Controls.Add(tpAsignarProyectos);
            tbTask.Controls.Add(tpListaProyectos);
            tbTask.Controls.Add(tpAñadirNuevasTareas);
            tbTask.Location = new Point(20, 51);
            tbTask.Margin = new Padding(5);
            tbTask.Name = "tbTask";
            tbTask.SelectedIndex = 0;
            tbTask.Size = new Size(2231, 1101);
            tbTask.TabIndex = 0;
            // 
            // ProyectsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2320, 1205);
            Controls.Add(tbTask);
            Margin = new Padding(5);
            Name = "ProyectsForm";
            Text = "ProyectosForm";
            tpAñadirNuevasTareas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            gbAñadirNuevasTareas.ResumeLayout(false);
            gbAñadirNuevasTareas.PerformLayout();
            tpListaProyectos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaProyectos).EndInit();
            tpAsignarProyectos.ResumeLayout(false);
            gbListaProyecto.ResumeLayout(false);
            gbListaProyecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbTask.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker2;
        private TabPage tpAñadirNuevasTareas;
        private GroupBox gbAñadirNuevasTareas;
        private ComboBox cboProyectoTareasAñadir;
        private FontAwesome.Sharp.IconButton btnEliminarNT;
        private FontAwesome.Sharp.IconButton btnEditarNT;
        private FontAwesome.Sharp.IconButton btnGuardarNT;
        private Label lblTareaAñadir;
        private TextBox txtTareaAñadirTarea;
        private Label lblProyectoSeleccionar;
        private DataGridView dgvTareas;
        private TabPage tpListaProyectos;
        private DataGridView dgvListaProyectos;
        private TabPage tpAsignarProyectos;
        private DataGridView dataGridView1;
        private GroupBox gbListaProyecto;
        private Label label3;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnEditar;
        private DateTimePicker dtpFechaEntrega;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblFechaFin;
        private ComboBox cboTareas;
        private Label label1;
        private Label label2;
        private ComboBox cboEmpleados;
        private ComboBox cboProyectos;
        private TabControl tbTask;
    }
}