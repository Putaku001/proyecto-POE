namespace PresentationLayer.Forms
{
    partial class UsersForm
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
            dgvUsuarios = new DataGridView();
            panelUsuarios = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblBuscar = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pbImprimir = new PictureBox();
            pbPdf = new PictureBox();
            pbEliminarUsuario = new PictureBox();
            pbEditarUsuario = new PictureBox();
            pbAñadirUsuario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImprimir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPdf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminarUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEditarUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAñadirUsuario).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(42, 70);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(1251, 635);
            dgvUsuarios.TabIndex = 0;
            // 
            // panelUsuarios
            // 
            panelUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelUsuarios.BackColor = Color.White;
            panelUsuarios.Controls.Add(iconButton2);
            panelUsuarios.Controls.Add(iconButton1);
            panelUsuarios.Controls.Add(lblBuscar);
            panelUsuarios.Controls.Add(textBox1);
            panelUsuarios.Controls.Add(panel1);
            panelUsuarios.Controls.Add(pbImprimir);
            panelUsuarios.Controls.Add(pbPdf);
            panelUsuarios.Controls.Add(pbEliminarUsuario);
            panelUsuarios.Controls.Add(pbEditarUsuario);
            panelUsuarios.Controls.Add(pbAñadirUsuario);
            panelUsuarios.Location = new Point(45, 3);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new Size(1251, 61);
            panelUsuarios.TabIndex = 1;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 25;
            iconButton2.Location = new Point(1211, 16);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(37, 29);
            iconButton2.TabIndex = 10;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(1171, 16);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(37, 29);
            iconButton1.TabIndex = 9;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            lblBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(881, 20);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(52, 20);
            lblBuscar.TabIndex = 8;
            lblBuscar.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(939, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Location = new Point(217, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 61);
            panel1.TabIndex = 6;
            // 
            // pbImprimir
            // 
            pbImprimir.Cursor = Cursors.Hand;
            pbImprimir.Image = Properties.Resources.imprimir;
            pbImprimir.Location = new Point(311, 12);
            pbImprimir.Name = "pbImprimir";
            pbImprimir.Size = new Size(42, 38);
            pbImprimir.SizeMode = PictureBoxSizeMode.Zoom;
            pbImprimir.TabIndex = 5;
            pbImprimir.TabStop = false;
            // 
            // pbPdf
            // 
            pbPdf.Cursor = Cursors.Hand;
            pbPdf.Image = Properties.Resources.pdf;
            pbPdf.Location = new Point(246, 12);
            pbPdf.Name = "pbPdf";
            pbPdf.Size = new Size(42, 38);
            pbPdf.SizeMode = PictureBoxSizeMode.Zoom;
            pbPdf.TabIndex = 4;
            pbPdf.TabStop = false;
            // 
            // pbEliminarUsuario
            // 
            pbEliminarUsuario.Cursor = Cursors.Hand;
            pbEliminarUsuario.Image = Properties.Resources.eliminar_Usuario;
            pbEliminarUsuario.Location = new Point(156, 12);
            pbEliminarUsuario.Name = "pbEliminarUsuario";
            pbEliminarUsuario.Size = new Size(42, 38);
            pbEliminarUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pbEliminarUsuario.TabIndex = 3;
            pbEliminarUsuario.TabStop = false;
            pbEliminarUsuario.Click += pbEliminarUsuario_Click;
            // 
            // pbEditarUsuario
            // 
            pbEditarUsuario.Cursor = Cursors.Hand;
            pbEditarUsuario.Image = Properties.Resources.editar_Usuario;
            pbEditarUsuario.Location = new Point(83, 12);
            pbEditarUsuario.Name = "pbEditarUsuario";
            pbEditarUsuario.Size = new Size(42, 38);
            pbEditarUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pbEditarUsuario.TabIndex = 2;
            pbEditarUsuario.TabStop = false;
            pbEditarUsuario.Click += pbEditarUsuario_Click;
            // 
            // pbAñadirUsuario
            // 
            pbAñadirUsuario.Cursor = Cursors.Hand;
            pbAñadirUsuario.Image = Properties.Resources.añadir_usuario;
            pbAñadirUsuario.Location = new Point(12, 12);
            pbAñadirUsuario.Name = "pbAñadirUsuario";
            pbAñadirUsuario.Size = new Size(42, 38);
            pbAñadirUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            pbAñadirUsuario.TabIndex = 1;
            pbAñadirUsuario.TabStop = false;
            pbAñadirUsuario.Click += pbAñadirUsuario_Click;
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1355, 744);
            Controls.Add(dgvUsuarios);
            Controls.Add(panelUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsuariosForm";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panelUsuarios.ResumeLayout(false);
            panelUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImprimir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPdf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEliminarUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEditarUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAñadirUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Panel panelUsuarios;
        private PictureBox pbAñadirUsuario;
        private Label lblBuscar;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pbImprimir;
        private PictureBox pbPdf;
        private PictureBox pbEliminarUsuario;
        private PictureBox pbEditarUsuario;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}