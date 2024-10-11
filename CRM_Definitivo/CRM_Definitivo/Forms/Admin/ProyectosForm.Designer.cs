namespace PresentationLayer.Forms
{
    partial class ProyectosForm
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
            panelTarea = new Panel();
            gbAñadirNuevasTareas = new GroupBox();
            cboProyectoTareasAñadir = new ComboBox();
            btnEliminarNT = new FontAwesome.Sharp.IconButton();
            btnEditarNT = new FontAwesome.Sharp.IconButton();
            btnGuardarNT = new FontAwesome.Sharp.IconButton();
            lblTareaAñadir = new Label();
            txtTareaAñadirTarea = new TextBox();
            lblProyectoSeleccionar = new Label();
            dgvTareas = new DataGridView();
            tpAñadirNuevaCategoria = new TabPage();
            panelCategoria = new Panel();
            gbAñadirNuevasCategorias = new GroupBox();
            cboProyectoCategoria = new ComboBox();
            btnEliminarNC = new FontAwesome.Sharp.IconButton();
            btnEditarNC = new FontAwesome.Sharp.IconButton();
            btnGuardarNC = new FontAwesome.Sharp.IconButton();
            lblCategoriaAñadir = new Label();
            textBox8 = new TextBox();
            lblSeleccionProyectoCategoria = new Label();
            dgvCategorias = new DataGridView();
            tbAñadirProyectos = new TabPage();
            panel2 = new Panel();
            gbAñadirNuevosProyectos = new GroupBox();
            btnEliminarNP = new FontAwesome.Sharp.IconButton();
            btnEditarNP = new FontAwesome.Sharp.IconButton();
            btnGuardarNP = new FontAwesome.Sharp.IconButton();
            lblTareas = new Label();
            txtTareasProyectoAñadir = new TextBox();
            lblCategoria = new Label();
            txtCategoriaProyectoAñadir = new TextBox();
            lblProyecto = new Label();
            txtNombreProyectoAñadir = new TextBox();
            dgvAñadirProyectos = new DataGridView();
            tpListaProyectos = new TabPage();
            dgvListaProyectos = new DataGridView();
            tpAsignarProyectos = new TabPage();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            gbListaProyecto = new GroupBox();
            cboClientes = new ComboBox();
            label1 = new Label();
            cboEmpleados = new ComboBox();
            cboCategorias = new ComboBox();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            lblFechaFin = new Label();
            dtpFechaEntrega = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            cboTareas = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            cboProyectos = new ComboBox();
            lblProyectos = new Label();
            txtCodigo = new TextBox();
            tbProyectos = new TabControl();
            tpAñadirNuevasTareas.SuspendLayout();
            gbAñadirNuevasTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            tpAñadirNuevaCategoria.SuspendLayout();
            gbAñadirNuevasCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tbAñadirProyectos.SuspendLayout();
            gbAñadirNuevosProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAñadirProyectos).BeginInit();
            tpListaProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProyectos).BeginInit();
            tpAsignarProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbListaProyecto.SuspendLayout();
            tbProyectos.SuspendLayout();
            SuspendLayout();
            // 
            // tpAñadirNuevasTareas
            // 
            tpAñadirNuevasTareas.Controls.Add(panelTarea);
            tpAñadirNuevasTareas.Controls.Add(gbAñadirNuevasTareas);
            tpAñadirNuevasTareas.Controls.Add(dgvTareas);
            tpAñadirNuevasTareas.Location = new Point(4, 4);
            tpAñadirNuevasTareas.Name = "tpAñadirNuevasTareas";
            tpAñadirNuevasTareas.Padding = new Padding(3);
            tpAñadirNuevasTareas.Size = new Size(1365, 655);
            tpAñadirNuevasTareas.TabIndex = 5;
            tpAñadirNuevasTareas.Text = "Añadir nuevas tareas";
            tpAñadirNuevasTareas.UseVisualStyleBackColor = true;
            // 
            // panelTarea
            // 
            panelTarea.BackColor = Color.DimGray;
            panelTarea.Location = new Point(572, 61);
            panelTarea.Name = "panelTarea";
            panelTarea.Size = new Size(10, 545);
            panelTarea.TabIndex = 13;
            // 
            // gbAñadirNuevasTareas
            // 
            gbAñadirNuevasTareas.Controls.Add(cboProyectoTareasAñadir);
            gbAñadirNuevasTareas.Controls.Add(btnEliminarNT);
            gbAñadirNuevasTareas.Controls.Add(btnEditarNT);
            gbAñadirNuevasTareas.Controls.Add(btnGuardarNT);
            gbAñadirNuevasTareas.Controls.Add(lblTareaAñadir);
            gbAñadirNuevasTareas.Controls.Add(txtTareaAñadirTarea);
            gbAñadirNuevasTareas.Controls.Add(lblProyectoSeleccionar);
            gbAñadirNuevasTareas.Location = new Point(31, 49);
            gbAñadirNuevasTareas.Name = "gbAñadirNuevasTareas";
            gbAñadirNuevasTareas.Size = new Size(507, 557);
            gbAñadirNuevasTareas.TabIndex = 12;
            gbAñadirNuevasTareas.TabStop = false;
            gbAñadirNuevasTareas.Text = "Añadir nuevas tareas:";
            // 
            // cboProyectoTareasAñadir
            // 
            cboProyectoTareasAñadir.FormattingEnabled = true;
            cboProyectoTareasAñadir.Location = new Point(32, 125);
            cboProyectoTareasAñadir.Name = "cboProyectoTareasAñadir";
            cboProyectoTareasAñadir.Size = new Size(319, 28);
            cboProyectoTareasAñadir.TabIndex = 26;
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
            btnEliminarNT.Location = new Point(32, 377);
            btnEliminarNT.Name = "btnEliminarNT";
            btnEliminarNT.Size = new Size(319, 29);
            btnEliminarNT.TabIndex = 25;
            btnEliminarNT.Text = "Eliminar";
            btnEliminarNT.UseVisualStyleBackColor = false;
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
            btnEditarNT.Location = new Point(32, 342);
            btnEditarNT.Name = "btnEditarNT";
            btnEditarNT.Size = new Size(319, 29);
            btnEditarNT.TabIndex = 24;
            btnEditarNT.Text = "Editar";
            btnEditarNT.UseVisualStyleBackColor = false;
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
            btnGuardarNT.Location = new Point(32, 307);
            btnGuardarNT.Name = "btnGuardarNT";
            btnGuardarNT.Size = new Size(319, 29);
            btnGuardarNT.TabIndex = 23;
            btnGuardarNT.Text = "Añadir";
            btnGuardarNT.UseVisualStyleBackColor = false;
            // 
            // lblTareaAñadir
            // 
            lblTareaAñadir.AutoSize = true;
            lblTareaAñadir.Location = new Point(32, 175);
            lblTareaAñadir.Name = "lblTareaAñadir";
            lblTareaAñadir.Size = new Size(47, 20);
            lblTareaAñadir.TabIndex = 4;
            lblTareaAñadir.Text = "Tarea:";
            // 
            // txtTareaAñadirTarea
            // 
            txtTareaAñadirTarea.Location = new Point(32, 198);
            txtTareaAñadirTarea.Name = "txtTareaAñadirTarea";
            txtTareaAñadirTarea.Size = new Size(319, 27);
            txtTareaAñadirTarea.TabIndex = 5;
            // 
            // lblProyectoSeleccionar
            // 
            lblProyectoSeleccionar.AutoSize = true;
            lblProyectoSeleccionar.Location = new Point(32, 102);
            lblProyectoSeleccionar.Name = "lblProyectoSeleccionar";
            lblProyectoSeleccionar.Size = new Size(162, 20);
            lblProyectoSeleccionar.TabIndex = 0;
            lblProyectoSeleccionar.Text = "Seleccione el proyecto:";
            // 
            // dgvTareas
            // 
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(620, 61);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.ReadOnly = true;
            dgvTareas.RowHeadersWidth = 51;
            dgvTareas.Size = new Size(713, 545);
            dgvTareas.TabIndex = 11;
            // 
            // tpAñadirNuevaCategoria
            // 
            tpAñadirNuevaCategoria.Controls.Add(panelCategoria);
            tpAñadirNuevaCategoria.Controls.Add(gbAñadirNuevasCategorias);
            tpAñadirNuevaCategoria.Controls.Add(dgvCategorias);
            tpAñadirNuevaCategoria.Location = new Point(4, 4);
            tpAñadirNuevaCategoria.Name = "tpAñadirNuevaCategoria";
            tpAñadirNuevaCategoria.Padding = new Padding(3);
            tpAñadirNuevaCategoria.Size = new Size(1365, 655);
            tpAñadirNuevaCategoria.TabIndex = 4;
            tpAñadirNuevaCategoria.Text = "Añadir nuevas categorias";
            tpAñadirNuevaCategoria.UseVisualStyleBackColor = true;
            // 
            // panelCategoria
            // 
            panelCategoria.BackColor = Color.DimGray;
            panelCategoria.Location = new Point(572, 61);
            panelCategoria.Name = "panelCategoria";
            panelCategoria.Size = new Size(10, 545);
            panelCategoria.TabIndex = 10;
            // 
            // gbAñadirNuevasCategorias
            // 
            gbAñadirNuevasCategorias.Controls.Add(cboProyectoCategoria);
            gbAñadirNuevasCategorias.Controls.Add(btnEliminarNC);
            gbAñadirNuevasCategorias.Controls.Add(btnEditarNC);
            gbAñadirNuevasCategorias.Controls.Add(btnGuardarNC);
            gbAñadirNuevasCategorias.Controls.Add(lblCategoriaAñadir);
            gbAñadirNuevasCategorias.Controls.Add(textBox8);
            gbAñadirNuevasCategorias.Controls.Add(lblSeleccionProyectoCategoria);
            gbAñadirNuevasCategorias.Location = new Point(31, 49);
            gbAñadirNuevasCategorias.Name = "gbAñadirNuevasCategorias";
            gbAñadirNuevasCategorias.Size = new Size(507, 557);
            gbAñadirNuevasCategorias.TabIndex = 9;
            gbAñadirNuevasCategorias.TabStop = false;
            gbAñadirNuevasCategorias.Text = "Añadir nuevas categorias:";
            // 
            // cboProyectoCategoria
            // 
            cboProyectoCategoria.FormattingEnabled = true;
            cboProyectoCategoria.Location = new Point(32, 125);
            cboProyectoCategoria.Name = "cboProyectoCategoria";
            cboProyectoCategoria.Size = new Size(319, 28);
            cboProyectoCategoria.TabIndex = 26;
            // 
            // btnEliminarNC
            // 
            btnEliminarNC.BackColor = Color.Crimson;
            btnEliminarNC.Cursor = Cursors.Hand;
            btnEliminarNC.FlatAppearance.BorderColor = Color.Black;
            btnEliminarNC.FlatStyle = FlatStyle.Flat;
            btnEliminarNC.ForeColor = Color.White;
            btnEliminarNC.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminarNC.IconColor = Color.White;
            btnEliminarNC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarNC.IconSize = 22;
            btnEliminarNC.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarNC.Location = new Point(32, 377);
            btnEliminarNC.Name = "btnEliminarNC";
            btnEliminarNC.Size = new Size(319, 29);
            btnEliminarNC.TabIndex = 25;
            btnEliminarNC.Text = "Eliminar";
            btnEliminarNC.UseVisualStyleBackColor = false;
            // 
            // btnEditarNC
            // 
            btnEditarNC.BackColor = Color.DodgerBlue;
            btnEditarNC.Cursor = Cursors.Hand;
            btnEditarNC.FlatAppearance.BorderColor = Color.Black;
            btnEditarNC.FlatStyle = FlatStyle.Flat;
            btnEditarNC.ForeColor = Color.White;
            btnEditarNC.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditarNC.IconColor = Color.White;
            btnEditarNC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarNC.IconSize = 22;
            btnEditarNC.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarNC.Location = new Point(32, 342);
            btnEditarNC.Name = "btnEditarNC";
            btnEditarNC.Size = new Size(319, 29);
            btnEditarNC.TabIndex = 24;
            btnEditarNC.Text = "Editar";
            btnEditarNC.UseVisualStyleBackColor = false;
            // 
            // btnGuardarNC
            // 
            btnGuardarNC.BackColor = Color.ForestGreen;
            btnGuardarNC.Cursor = Cursors.Hand;
            btnGuardarNC.FlatAppearance.BorderColor = Color.Black;
            btnGuardarNC.FlatStyle = FlatStyle.Flat;
            btnGuardarNC.ForeColor = Color.White;
            btnGuardarNC.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarNC.IconColor = Color.White;
            btnGuardarNC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarNC.IconSize = 22;
            btnGuardarNC.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarNC.Location = new Point(32, 307);
            btnGuardarNC.Name = "btnGuardarNC";
            btnGuardarNC.Size = new Size(319, 29);
            btnGuardarNC.TabIndex = 23;
            btnGuardarNC.Text = "Añadir";
            btnGuardarNC.UseVisualStyleBackColor = false;
            // 
            // lblCategoriaAñadir
            // 
            lblCategoriaAñadir.AutoSize = true;
            lblCategoriaAñadir.Location = new Point(32, 175);
            lblCategoriaAñadir.Name = "lblCategoriaAñadir";
            lblCategoriaAñadir.Size = new Size(77, 20);
            lblCategoriaAñadir.TabIndex = 4;
            lblCategoriaAñadir.Text = "Categoria:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(32, 198);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(319, 27);
            textBox8.TabIndex = 5;
            // 
            // lblSeleccionProyectoCategoria
            // 
            lblSeleccionProyectoCategoria.AutoSize = true;
            lblSeleccionProyectoCategoria.Location = new Point(32, 102);
            lblSeleccionProyectoCategoria.Name = "lblSeleccionProyectoCategoria";
            lblSeleccionProyectoCategoria.Size = new Size(166, 20);
            lblSeleccionProyectoCategoria.TabIndex = 0;
            lblSeleccionProyectoCategoria.Text = "Seleccione un proyecto:";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(620, 61);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(713, 545);
            dgvCategorias.TabIndex = 8;
            // 
            // tbAñadirProyectos
            // 
            tbAñadirProyectos.Controls.Add(panel2);
            tbAñadirProyectos.Controls.Add(gbAñadirNuevosProyectos);
            tbAñadirProyectos.Controls.Add(dgvAñadirProyectos);
            tbAñadirProyectos.Location = new Point(4, 4);
            tbAñadirProyectos.Name = "tbAñadirProyectos";
            tbAñadirProyectos.Padding = new Padding(3);
            tbAñadirProyectos.Size = new Size(1365, 655);
            tbAñadirProyectos.TabIndex = 3;
            tbAñadirProyectos.Text = "Añadir nuevos proyectos";
            tbAñadirProyectos.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(561, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 545);
            panel2.TabIndex = 7;
            // 
            // gbAñadirNuevosProyectos
            // 
            gbAñadirNuevosProyectos.Controls.Add(btnEliminarNP);
            gbAñadirNuevosProyectos.Controls.Add(btnEditarNP);
            gbAñadirNuevosProyectos.Controls.Add(btnGuardarNP);
            gbAñadirNuevosProyectos.Controls.Add(lblTareas);
            gbAñadirNuevosProyectos.Controls.Add(txtTareasProyectoAñadir);
            gbAñadirNuevosProyectos.Controls.Add(lblCategoria);
            gbAñadirNuevosProyectos.Controls.Add(txtCategoriaProyectoAñadir);
            gbAñadirNuevosProyectos.Controls.Add(lblProyecto);
            gbAñadirNuevosProyectos.Controls.Add(txtNombreProyectoAñadir);
            gbAñadirNuevosProyectos.Location = new Point(20, 58);
            gbAñadirNuevosProyectos.Name = "gbAñadirNuevosProyectos";
            gbAñadirNuevosProyectos.Size = new Size(507, 557);
            gbAñadirNuevosProyectos.TabIndex = 6;
            gbAñadirNuevosProyectos.TabStop = false;
            gbAñadirNuevosProyectos.Text = "Añadir nuevos proyectos:";
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
            btnEliminarNP.Location = new Point(32, 439);
            btnEliminarNP.Name = "btnEliminarNP";
            btnEliminarNP.Size = new Size(319, 29);
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
            btnEditarNP.Location = new Point(32, 404);
            btnEditarNP.Name = "btnEditarNP";
            btnEditarNP.Size = new Size(319, 29);
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
            btnGuardarNP.Location = new Point(32, 369);
            btnGuardarNP.Name = "btnGuardarNP";
            btnGuardarNP.Size = new Size(319, 29);
            btnGuardarNP.TabIndex = 23;
            btnGuardarNP.Text = "Añadir";
            btnGuardarNP.UseVisualStyleBackColor = false;
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.Location = new Point(32, 254);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(141, 20);
            lblTareas.TabIndex = 8;
            lblTareas.Text = "Tareas del proyecto:";
            // 
            // txtTareasProyectoAñadir
            // 
            txtTareasProyectoAñadir.Location = new Point(32, 277);
            txtTareasProyectoAñadir.Name = "txtTareasProyectoAñadir";
            txtTareasProyectoAñadir.Size = new Size(319, 27);
            txtTareasProyectoAñadir.TabIndex = 9;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(32, 175);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(165, 20);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria del proyecto:";
            // 
            // txtCategoriaProyectoAñadir
            // 
            txtCategoriaProyectoAñadir.Location = new Point(32, 198);
            txtCategoriaProyectoAñadir.Name = "txtCategoriaProyectoAñadir";
            txtCategoriaProyectoAñadir.Size = new Size(319, 27);
            txtCategoriaProyectoAñadir.TabIndex = 5;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Location = new Point(32, 102);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(155, 20);
            lblProyecto.TabIndex = 0;
            lblProyecto.Text = "Nombre del proyecto:";
            // 
            // txtNombreProyectoAñadir
            // 
            txtNombreProyectoAñadir.Location = new Point(32, 125);
            txtNombreProyectoAñadir.Name = "txtNombreProyectoAñadir";
            txtNombreProyectoAñadir.Size = new Size(319, 27);
            txtNombreProyectoAñadir.TabIndex = 1;
            // 
            // dgvAñadirProyectos
            // 
            dgvAñadirProyectos.AllowUserToAddRows = false;
            dgvAñadirProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAñadirProyectos.Location = new Point(609, 70);
            dgvAñadirProyectos.Name = "dgvAñadirProyectos";
            dgvAñadirProyectos.ReadOnly = true;
            dgvAñadirProyectos.RowHeadersWidth = 51;
            dgvAñadirProyectos.Size = new Size(713, 545);
            dgvAñadirProyectos.TabIndex = 5;
            // 
            // tpListaProyectos
            // 
            tpListaProyectos.Controls.Add(dgvListaProyectos);
            tpListaProyectos.Location = new Point(4, 4);
            tpListaProyectos.Name = "tpListaProyectos";
            tpListaProyectos.Padding = new Padding(3);
            tpListaProyectos.Size = new Size(1365, 655);
            tpListaProyectos.TabIndex = 2;
            tpListaProyectos.Text = "Lista de proyectos";
            tpListaProyectos.UseVisualStyleBackColor = true;
            tpListaProyectos.Click += tpListaProyectos_Click;
            // 
            // dgvListaProyectos
            // 
            dgvListaProyectos.AllowUserToAddRows = false;
            dgvListaProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProyectos.Location = new Point(28, 55);
            dgvListaProyectos.Name = "dgvListaProyectos";
            dgvListaProyectos.ReadOnly = true;
            dgvListaProyectos.RowHeadersWidth = 51;
            dgvListaProyectos.Size = new Size(1313, 580);
            dgvListaProyectos.TabIndex = 5;
            // 
            // tpAsignarProyectos
            // 
            tpAsignarProyectos.Controls.Add(panel1);
            tpAsignarProyectos.Controls.Add(dataGridView1);
            tpAsignarProyectos.Controls.Add(gbListaProyecto);
            tpAsignarProyectos.Location = new Point(4, 4);
            tpAsignarProyectos.Name = "tpAsignarProyectos";
            tpAsignarProyectos.Padding = new Padding(3);
            tpAsignarProyectos.Size = new Size(1365, 655);
            tpAsignarProyectos.TabIndex = 1;
            tpAsignarProyectos.Text = "Asignar Proyectos";
            tpAsignarProyectos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(577, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 545);
            panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(632, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(713, 545);
            dataGridView1.TabIndex = 4;
            // 
            // gbListaProyecto
            // 
            gbListaProyecto.Controls.Add(cboClientes);
            gbListaProyecto.Controls.Add(label1);
            gbListaProyecto.Controls.Add(cboEmpleados);
            gbListaProyecto.Controls.Add(cboCategorias);
            gbListaProyecto.Controls.Add(btnEliminar);
            gbListaProyecto.Controls.Add(btnEditar);
            gbListaProyecto.Controls.Add(btnGuardar);
            gbListaProyecto.Controls.Add(lblFechaFin);
            gbListaProyecto.Controls.Add(dtpFechaEntrega);
            gbListaProyecto.Controls.Add(label5);
            gbListaProyecto.Controls.Add(label4);
            gbListaProyecto.Controls.Add(cboTareas);
            gbListaProyecto.Controls.Add(label3);
            gbListaProyecto.Controls.Add(label2);
            gbListaProyecto.Controls.Add(cboProyectos);
            gbListaProyecto.Controls.Add(lblProyectos);
            gbListaProyecto.Controls.Add(txtCodigo);
            gbListaProyecto.Location = new Point(29, 76);
            gbListaProyecto.Name = "gbListaProyecto";
            gbListaProyecto.Size = new Size(507, 557);
            gbListaProyecto.TabIndex = 3;
            gbListaProyecto.TabStop = false;
            gbListaProyecto.Text = "Asignar proyectos:";
            // 
            // cboClientes
            // 
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(32, 327);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(319, 28);
            cboClientes.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 250);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 28;
            label1.Text = "Empleado:";
            // 
            // cboEmpleados
            // 
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(32, 273);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(319, 28);
            cboEmpleados.TabIndex = 27;
            // 
            // cboCategorias
            // 
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(32, 165);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(319, 28);
            cboCategorias.TabIndex = 26;
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
            btnEliminar.Location = new Point(32, 513);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(319, 29);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
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
            btnEditar.Location = new Point(32, 478);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(319, 29);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
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
            btnGuardar.Location = new Point(32, 443);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(319, 29);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Añadir";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(32, 377);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(126, 20);
            lblFechaFin.TabIndex = 11;
            lblFechaFin.Text = "Fecha de entrega:";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(32, 400);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(319, 27);
            dtpFechaEntrega.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 304);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 8;
            label5.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 196);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 7;
            label4.Text = "Tareas:";
            // 
            // cboTareas
            // 
            cboTareas.FormattingEnabled = true;
            cboTareas.Location = new Point(32, 219);
            cboTareas.Name = "cboTareas";
            cboTareas.Size = new Size(319, 28);
            cboTareas.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 142);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 88);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Proyecto:";
            // 
            // cboProyectos
            // 
            cboProyectos.FormattingEnabled = true;
            cboProyectos.Location = new Point(32, 111);
            cboProyectos.Name = "cboProyectos";
            cboProyectos.Size = new Size(319, 28);
            cboProyectos.TabIndex = 2;
            // 
            // lblProyectos
            // 
            lblProyectos.AutoSize = true;
            lblProyectos.Location = new Point(32, 36);
            lblProyectos.Name = "lblProyectos";
            lblProyectos.Size = new Size(61, 20);
            lblProyectos.TabIndex = 0;
            lblProyectos.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(32, 59);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(319, 27);
            txtCodigo.TabIndex = 1;
            // 
            // tbProyectos
            // 
            tbProyectos.Alignment = TabAlignment.Bottom;
            tbProyectos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbProyectos.Controls.Add(tpAsignarProyectos);
            tbProyectos.Controls.Add(tpListaProyectos);
            tbProyectos.Controls.Add(tbAñadirProyectos);
            tbProyectos.Controls.Add(tpAñadirNuevaCategoria);
            tbProyectos.Controls.Add(tpAñadirNuevasTareas);
            tbProyectos.Location = new Point(12, 32);
            tbProyectos.Name = "tbProyectos";
            tbProyectos.SelectedIndex = 0;
            tbProyectos.Size = new Size(1373, 688);
            tbProyectos.TabIndex = 0;
            // 
            // ProyectosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 753);
            Controls.Add(tbProyectos);
            Name = "ProyectosForm";
            Text = "ProyectosForm";
            tpAñadirNuevasTareas.ResumeLayout(false);
            gbAñadirNuevasTareas.ResumeLayout(false);
            gbAñadirNuevasTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            tpAñadirNuevaCategoria.ResumeLayout(false);
            gbAñadirNuevasCategorias.ResumeLayout(false);
            gbAñadirNuevasCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tbAñadirProyectos.ResumeLayout(false);
            gbAñadirNuevosProyectos.ResumeLayout(false);
            gbAñadirNuevosProyectos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAñadirProyectos).EndInit();
            tpListaProyectos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaProyectos).EndInit();
            tpAsignarProyectos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbListaProyecto.ResumeLayout(false);
            gbListaProyecto.PerformLayout();
            tbProyectos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpAñadirNuevasTareas;
        private TabPage tpAñadirNuevaCategoria;
        private TabPage tbAñadirProyectos;
        private TabPage tpListaProyectos;
        private TabPage tpAsignarProyectos;
        private Panel panel1;
        private DataGridView dataGridView1;
        private GroupBox gbListaProyecto;
        private ComboBox cboProyectos;
        private Label lblProyectos;
        private TextBox txtCodigo;
        private TabControl tbProyectos;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaEntrega;
        private Label label5;
        private Label label4;
        private ComboBox cboTareas;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private DataGridView dgvListaProyectos;
        private Panel panel2;
        private GroupBox gbAñadirNuevosProyectos;
        private FontAwesome.Sharp.IconButton btnEliminarNP;
        private FontAwesome.Sharp.IconButton btnEditarNP;
        private FontAwesome.Sharp.IconButton btnGuardarNP;
        private DateTimePicker dateTimePicker2;
        private Label lblTareas;
        private TextBox txtTareasProyectoAñadir;
        private Label lblCategoria;
        private TextBox txtCategoriaProyectoAñadir;
        private Label lblProyecto;
        private TextBox txtNombreProyectoAñadir;
        private DataGridView dgvAñadirProyectos;
        private Panel panelTarea;
        private GroupBox gbAñadirNuevasTareas;
        private ComboBox cboProyectoTareasAñadir;
        private FontAwesome.Sharp.IconButton btnEliminarNT;
        private FontAwesome.Sharp.IconButton btnEditarNT;
        private FontAwesome.Sharp.IconButton btnGuardarNT;
        private Label lblTareaAñadir;
        private TextBox txtTareaAñadirTarea;
        private Label lblProyectoSeleccionar;
        private DataGridView dgvTareas;
        private Panel panelCategoria;
        private GroupBox gbAñadirNuevasCategorias;
        private FontAwesome.Sharp.IconButton btnEliminarNC;
        private FontAwesome.Sharp.IconButton btnEditarNC;
        private FontAwesome.Sharp.IconButton btnGuardarNC;
        private Label lblCategoriaAñadir;
        private TextBox textBox8;
        private Label lblSeleccionProyectoCategoria;
        private DataGridView dgvCategorias;
        private ComboBox cboClientes;
        private Label label1;
        private ComboBox cboEmpleados;
        private ComboBox cboCategorias;
        private ComboBox cboProyectoCategoria;
    }
}