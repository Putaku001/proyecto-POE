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
            tabPageProjects = new TabPage();
            panelSearchPip = new Panel();
            iconButtonCleanPip = new FontAwesome.Sharp.IconButton();
            iconButtonSearchPip = new FontAwesome.Sharp.IconButton();
            labelSearchpip = new Label();
            comboBoxSearchPip = new ComboBox();
            dataGridViewProjectsInProgress = new DataGridView();
            tpListaProyectos = new TabPage();
            dataGridViewRequestProjects = new DataGridView();
            SelectPr = new DataGridViewButtonColumn();
            tbTask = new TabControl();
            tabPage1 = new TabPage();
            panelSearchpf = new Panel();
            iconButtonClearpf = new FontAwesome.Sharp.IconButton();
            iconButtonSearchpf = new FontAwesome.Sharp.IconButton();
            labelSearchpf = new Label();
            comboBoxSearchpf = new ComboBox();
            dataGridViewProjectsEnd = new DataGridView();
            SelectPe = new DataGridViewButtonColumn();
            tabPageProjectsRefused = new TabPage();
            panelSearchPr = new Panel();
            iconButtonClearPr = new FontAwesome.Sharp.IconButton();
            iconButtonSearchPr = new FontAwesome.Sharp.IconButton();
            labelSearchPr = new Label();
            comboBoxSearchPr = new ComboBox();
            dataGridViewProjectsRefused = new DataGridView();
            SelectRp = new DataGridViewButtonColumn();
            tabPageWaitClient = new TabPage();
            panelSearchWr = new Panel();
            iconButtonClearSearchWr = new FontAwesome.Sharp.IconButton();
            iconButtonSearchWr = new FontAwesome.Sharp.IconButton();
            labelSearchWr = new Label();
            comboBoxSearchWr = new ComboBox();
            dataGridViewProjectsWaitingResponse = new DataGridView();
            SelectProjectInProgress = new DataGridViewButtonColumn();
            tabPageProjects.SuspendLayout();
            panelSearchPip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectsInProgress).BeginInit();
            tpListaProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequestProjects).BeginInit();
            tbTask.SuspendLayout();
            tabPage1.SuspendLayout();
            panelSearchpf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectsEnd).BeginInit();
            tabPageProjectsRefused.SuspendLayout();
            panelSearchPr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectsRefused).BeginInit();
            tabPageWaitClient.SuspendLayout();
            panelSearchWr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectsWaitingResponse).BeginInit();
            SuspendLayout();
            // 
            // tabPageProjects
            // 
            tabPageProjects.Controls.Add(panelSearchPip);
            tabPageProjects.Controls.Add(dataGridViewProjectsInProgress);
            tabPageProjects.Location = new Point(4, 29);
            tabPageProjects.Name = "tabPageProjects";
            tabPageProjects.Padding = new Padding(3);
            tabPageProjects.Size = new Size(1122, 561);
            tabPageProjects.TabIndex = 6;
            tabPageProjects.Text = "Proyectos en curso";
            tabPageProjects.UseVisualStyleBackColor = true;
            // 
            // panelSearchPip
            // 
            panelSearchPip.Controls.Add(iconButtonCleanPip);
            panelSearchPip.Controls.Add(iconButtonSearchPip);
            panelSearchPip.Controls.Add(labelSearchpip);
            panelSearchPip.Controls.Add(comboBoxSearchPip);
            panelSearchPip.Dock = DockStyle.Top;
            panelSearchPip.Location = new Point(3, 3);
            panelSearchPip.Name = "panelSearchPip";
            panelSearchPip.Size = new Size(1116, 69);
            panelSearchPip.TabIndex = 1;
            // 
            // iconButtonCleanPip
            // 
            iconButtonCleanPip.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonCleanPip.IconColor = Color.Black;
            iconButtonCleanPip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonCleanPip.Location = new Point(326, 21);
            iconButtonCleanPip.Name = "iconButtonCleanPip";
            iconButtonCleanPip.Size = new Size(32, 29);
            iconButtonCleanPip.TabIndex = 3;
            iconButtonCleanPip.UseVisualStyleBackColor = true;
            // 
            // iconButtonSearchPip
            // 
            iconButtonSearchPip.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSearchPip.IconColor = Color.Black;
            iconButtonSearchPip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSearchPip.Location = new Point(288, 21);
            iconButtonSearchPip.Name = "iconButtonSearchPip";
            iconButtonSearchPip.Size = new Size(32, 29);
            iconButtonSearchPip.TabIndex = 2;
            iconButtonSearchPip.UseVisualStyleBackColor = true;
            // 
            // labelSearchpip
            // 
            labelSearchpip.AutoSize = true;
            labelSearchpip.Location = new Point(8, 25);
            labelSearchpip.Name = "labelSearchpip";
            labelSearchpip.Size = new Size(52, 20);
            labelSearchpip.TabIndex = 1;
            labelSearchpip.Text = "Buscar";
            // 
            // comboBoxSearchPip
            // 
            comboBoxSearchPip.FormattingEnabled = true;
            comboBoxSearchPip.Location = new Point(66, 22);
            comboBoxSearchPip.Name = "comboBoxSearchPip";
            comboBoxSearchPip.Size = new Size(216, 28);
            comboBoxSearchPip.TabIndex = 0;
            // 
            // dataGridViewProjectsInProgress
            // 
            dataGridViewProjectsInProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProjectsInProgress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectsInProgress.Columns.AddRange(new DataGridViewColumn[] { SelectProjectInProgress });
            dataGridViewProjectsInProgress.Location = new Point(3, 78);
            dataGridViewProjectsInProgress.Name = "dataGridViewProjectsInProgress";
            dataGridViewProjectsInProgress.RowHeadersWidth = 51;
            dataGridViewProjectsInProgress.Size = new Size(1116, 480);
            dataGridViewProjectsInProgress.TabIndex = 0;
            dataGridViewProjectsInProgress.CellContentClick += dataGridViewProjectsInProgress_CellContentClick;
            dataGridViewProjectsInProgress.CellDoubleClick += dataGridViewProjectsInProgress_CellDoubleClick;
            // 
            // tpListaProyectos
            // 
            tpListaProyectos.Controls.Add(dataGridViewRequestProjects);
            tpListaProyectos.Location = new Point(4, 29);
            tpListaProyectos.Name = "tpListaProyectos";
            tpListaProyectos.Padding = new Padding(3);
            tpListaProyectos.Size = new Size(1122, 561);
            tpListaProyectos.TabIndex = 2;
            tpListaProyectos.Text = "Proyectos solicitados";
            tpListaProyectos.UseVisualStyleBackColor = true;
            tpListaProyectos.Click += tpListaProyectos_Click;
            // 
            // dataGridViewRequestProjects
            // 
            dataGridViewRequestProjects.AllowUserToAddRows = false;
            dataGridViewRequestProjects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRequestProjects.BackgroundColor = Color.White;
            dataGridViewRequestProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequestProjects.Columns.AddRange(new DataGridViewColumn[] { SelectPr });
            dataGridViewRequestProjects.Location = new Point(33, 55);
            dataGridViewRequestProjects.Name = "dataGridViewRequestProjects";
            dataGridViewRequestProjects.ReadOnly = true;
            dataGridViewRequestProjects.RowHeadersWidth = 51;
            dataGridViewRequestProjects.Size = new Size(1070, 486);
            dataGridViewRequestProjects.TabIndex = 5;
            dataGridViewRequestProjects.CellContentClick += dataGridViewRequestProjects_CellContentClick;
            // 
            // SelectPr
            // 
            SelectPr.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SelectPr.HeaderText = "Select";
            SelectPr.MinimumWidth = 6;
            SelectPr.Name = "SelectPr";
            SelectPr.ReadOnly = true;
            SelectPr.Width = 70;
            // 
            // tbTask
            // 
            tbTask.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbTask.Controls.Add(tpListaProyectos);
            tbTask.Controls.Add(tabPageProjects);
            tbTask.Controls.Add(tabPage1);
            tbTask.Controls.Add(tabPageProjectsRefused);
            tbTask.Controls.Add(tabPageWaitClient);
            tbTask.Location = new Point(12, 32);
            tbTask.Name = "tbTask";
            tbTask.SelectedIndex = 0;
            tbTask.Size = new Size(1130, 594);
            tbTask.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panelSearchpf);
            tabPage1.Controls.Add(dataGridViewProjectsEnd);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1122, 561);
            tabPage1.TabIndex = 7;
            tabPage1.Text = "Proyectos finalizados";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelSearchpf
            // 
            panelSearchpf.Controls.Add(iconButtonClearpf);
            panelSearchpf.Controls.Add(iconButtonSearchpf);
            panelSearchpf.Controls.Add(labelSearchpf);
            panelSearchpf.Controls.Add(comboBoxSearchpf);
            panelSearchpf.Dock = DockStyle.Top;
            panelSearchpf.Location = new Point(3, 3);
            panelSearchpf.Name = "panelSearchpf";
            panelSearchpf.Size = new Size(1116, 69);
            panelSearchpf.TabIndex = 3;
            // 
            // iconButtonClearpf
            // 
            iconButtonClearpf.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonClearpf.IconColor = Color.Black;
            iconButtonClearpf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonClearpf.Location = new Point(325, 21);
            iconButtonClearpf.Name = "iconButtonClearpf";
            iconButtonClearpf.Size = new Size(32, 29);
            iconButtonClearpf.TabIndex = 3;
            iconButtonClearpf.UseVisualStyleBackColor = true;
            // 
            // iconButtonSearchpf
            // 
            iconButtonSearchpf.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSearchpf.IconColor = Color.Black;
            iconButtonSearchpf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSearchpf.Location = new Point(287, 21);
            iconButtonSearchpf.Name = "iconButtonSearchpf";
            iconButtonSearchpf.Size = new Size(32, 29);
            iconButtonSearchpf.TabIndex = 2;
            iconButtonSearchpf.UseVisualStyleBackColor = true;
            // 
            // labelSearchpf
            // 
            labelSearchpf.AutoSize = true;
            labelSearchpf.Location = new Point(7, 25);
            labelSearchpf.Name = "labelSearchpf";
            labelSearchpf.Size = new Size(52, 20);
            labelSearchpf.TabIndex = 1;
            labelSearchpf.Text = "Buscar";
            // 
            // comboBoxSearchpf
            // 
            comboBoxSearchpf.FormattingEnabled = true;
            comboBoxSearchpf.Location = new Point(65, 22);
            comboBoxSearchpf.Name = "comboBoxSearchpf";
            comboBoxSearchpf.Size = new Size(216, 28);
            comboBoxSearchpf.TabIndex = 0;
            // 
            // dataGridViewProjectsEnd
            // 
            dataGridViewProjectsEnd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProjectsEnd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectsEnd.Columns.AddRange(new DataGridViewColumn[] { SelectPe });
            dataGridViewProjectsEnd.Location = new Point(3, 78);
            dataGridViewProjectsEnd.Name = "dataGridViewProjectsEnd";
            dataGridViewProjectsEnd.RowHeadersWidth = 51;
            dataGridViewProjectsEnd.Size = new Size(1116, 480);
            dataGridViewProjectsEnd.TabIndex = 2;
            dataGridViewProjectsEnd.CellContentClick += dataGridViewProjectsEnd_CellContentClick;
            // 
            // SelectPe
            // 
            SelectPe.HeaderText = "Select";
            SelectPe.MinimumWidth = 6;
            SelectPe.Name = "SelectPe";
            SelectPe.Resizable = DataGridViewTriState.True;
            SelectPe.SortMode = DataGridViewColumnSortMode.Automatic;
            SelectPe.Width = 70;
            // 
            // tabPageProjectsRefused
            // 
            tabPageProjectsRefused.Controls.Add(panelSearchPr);
            tabPageProjectsRefused.Controls.Add(dataGridViewProjectsRefused);
            tabPageProjectsRefused.Location = new Point(4, 29);
            tabPageProjectsRefused.Name = "tabPageProjectsRefused";
            tabPageProjectsRefused.Padding = new Padding(3);
            tabPageProjectsRefused.Size = new Size(1122, 561);
            tabPageProjectsRefused.TabIndex = 8;
            tabPageProjectsRefused.Text = "Proyectos rechazados";
            tabPageProjectsRefused.UseVisualStyleBackColor = true;
            // 
            // panelSearchPr
            // 
            panelSearchPr.Controls.Add(iconButtonClearPr);
            panelSearchPr.Controls.Add(iconButtonSearchPr);
            panelSearchPr.Controls.Add(labelSearchPr);
            panelSearchPr.Controls.Add(comboBoxSearchPr);
            panelSearchPr.Dock = DockStyle.Top;
            panelSearchPr.Location = new Point(3, 3);
            panelSearchPr.Name = "panelSearchPr";
            panelSearchPr.Size = new Size(1116, 69);
            panelSearchPr.TabIndex = 5;
            // 
            // iconButtonClearPr
            // 
            iconButtonClearPr.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonClearPr.IconColor = Color.Black;
            iconButtonClearPr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonClearPr.Location = new Point(324, 18);
            iconButtonClearPr.Name = "iconButtonClearPr";
            iconButtonClearPr.Size = new Size(32, 29);
            iconButtonClearPr.TabIndex = 3;
            iconButtonClearPr.UseVisualStyleBackColor = true;
            // 
            // iconButtonSearchPr
            // 
            iconButtonSearchPr.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSearchPr.IconColor = Color.Black;
            iconButtonSearchPr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSearchPr.Location = new Point(286, 18);
            iconButtonSearchPr.Name = "iconButtonSearchPr";
            iconButtonSearchPr.Size = new Size(32, 29);
            iconButtonSearchPr.TabIndex = 2;
            iconButtonSearchPr.UseVisualStyleBackColor = true;
            // 
            // labelSearchPr
            // 
            labelSearchPr.AutoSize = true;
            labelSearchPr.Location = new Point(6, 22);
            labelSearchPr.Name = "labelSearchPr";
            labelSearchPr.Size = new Size(52, 20);
            labelSearchPr.TabIndex = 1;
            labelSearchPr.Text = "Buscar";
            // 
            // comboBoxSearchPr
            // 
            comboBoxSearchPr.FormattingEnabled = true;
            comboBoxSearchPr.Location = new Point(64, 19);
            comboBoxSearchPr.Name = "comboBoxSearchPr";
            comboBoxSearchPr.Size = new Size(216, 28);
            comboBoxSearchPr.TabIndex = 0;
            // 
            // dataGridViewProjectsRefused
            // 
            dataGridViewProjectsRefused.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProjectsRefused.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectsRefused.Columns.AddRange(new DataGridViewColumn[] { SelectRp });
            dataGridViewProjectsRefused.Location = new Point(3, 78);
            dataGridViewProjectsRefused.Name = "dataGridViewProjectsRefused";
            dataGridViewProjectsRefused.RowHeadersWidth = 51;
            dataGridViewProjectsRefused.Size = new Size(1116, 480);
            dataGridViewProjectsRefused.TabIndex = 4;
            dataGridViewProjectsRefused.CellContentClick += dataGridViewProjectsRefused_CellContentClick;
            // 
            // SelectRp
            // 
            SelectRp.HeaderText = "Select";
            SelectRp.MinimumWidth = 6;
            SelectRp.Name = "SelectRp";
            SelectRp.Resizable = DataGridViewTriState.True;
            SelectRp.SortMode = DataGridViewColumnSortMode.Automatic;
            SelectRp.Width = 70;
            // 
            // tabPageWaitClient
            // 
            tabPageWaitClient.Controls.Add(panelSearchWr);
            tabPageWaitClient.Controls.Add(dataGridViewProjectsWaitingResponse);
            tabPageWaitClient.Location = new Point(4, 29);
            tabPageWaitClient.Name = "tabPageWaitClient";
            tabPageWaitClient.Padding = new Padding(3);
            tabPageWaitClient.Size = new Size(1122, 561);
            tabPageWaitClient.TabIndex = 9;
            tabPageWaitClient.Text = "Esperando respuesta del cliente";
            tabPageWaitClient.UseVisualStyleBackColor = true;
            // 
            // panelSearchWr
            // 
            panelSearchWr.Controls.Add(iconButtonClearSearchWr);
            panelSearchWr.Controls.Add(iconButtonSearchWr);
            panelSearchWr.Controls.Add(labelSearchWr);
            panelSearchWr.Controls.Add(comboBoxSearchWr);
            panelSearchWr.Dock = DockStyle.Top;
            panelSearchWr.Location = new Point(3, 3);
            panelSearchWr.Name = "panelSearchWr";
            panelSearchWr.Size = new Size(1116, 69);
            panelSearchWr.TabIndex = 7;
            // 
            // iconButtonClearSearchWr
            // 
            iconButtonClearSearchWr.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonClearSearchWr.IconColor = Color.Black;
            iconButtonClearSearchWr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonClearSearchWr.Location = new Point(324, 18);
            iconButtonClearSearchWr.Name = "iconButtonClearSearchWr";
            iconButtonClearSearchWr.Size = new Size(32, 29);
            iconButtonClearSearchWr.TabIndex = 3;
            iconButtonClearSearchWr.UseVisualStyleBackColor = true;
            // 
            // iconButtonSearchWr
            // 
            iconButtonSearchWr.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSearchWr.IconColor = Color.Black;
            iconButtonSearchWr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSearchWr.Location = new Point(286, 18);
            iconButtonSearchWr.Name = "iconButtonSearchWr";
            iconButtonSearchWr.Size = new Size(32, 29);
            iconButtonSearchWr.TabIndex = 2;
            iconButtonSearchWr.UseVisualStyleBackColor = true;
            // 
            // labelSearchWr
            // 
            labelSearchWr.AutoSize = true;
            labelSearchWr.Location = new Point(6, 22);
            labelSearchWr.Name = "labelSearchWr";
            labelSearchWr.Size = new Size(52, 20);
            labelSearchWr.TabIndex = 1;
            labelSearchWr.Text = "Buscar";
            // 
            // comboBoxSearchWr
            // 
            comboBoxSearchWr.FormattingEnabled = true;
            comboBoxSearchWr.Location = new Point(64, 19);
            comboBoxSearchWr.Name = "comboBoxSearchWr";
            comboBoxSearchWr.Size = new Size(216, 28);
            comboBoxSearchWr.TabIndex = 0;
            // 
            // dataGridViewProjectsWaitingResponse
            // 
            dataGridViewProjectsWaitingResponse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProjectsWaitingResponse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectsWaitingResponse.Location = new Point(3, 78);
            dataGridViewProjectsWaitingResponse.Name = "dataGridViewProjectsWaitingResponse";
            dataGridViewProjectsWaitingResponse.RowHeadersWidth = 51;
            dataGridViewProjectsWaitingResponse.Size = new Size(1116, 480);
            dataGridViewProjectsWaitingResponse.TabIndex = 6;
            dataGridViewProjectsWaitingResponse.CellContentClick += dataGridViewProjectsWaitingResponse_CellContentClick;
            // 
            // SelectProjectInProgress
            // 
            SelectProjectInProgress.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SelectProjectInProgress.HeaderText = "Subir";
            SelectProjectInProgress.MinimumWidth = 6;
            SelectProjectInProgress.Name = "SelectProjectInProgress";
            SelectProjectInProgress.Resizable = DataGridViewTriState.True;
            SelectProjectInProgress.SortMode = DataGridViewColumnSortMode.Automatic;
            SelectProjectInProgress.Width = 70;
            // 
            // ProyectsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 659);
            Controls.Add(tbTask);
            Name = "ProyectsForm";
            Text = "ProyectosForm";
            tabPageProjects.ResumeLayout(false);
            panelSearchPip.ResumeLayout(false);
            panelSearchPip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectsInProgress).EndInit();
            tpListaProyectos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequestProjects).EndInit();
            tbTask.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panelSearchpf.ResumeLayout(false);
            panelSearchpf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectsEnd).EndInit();
            tabPageProjectsRefused.ResumeLayout(false);
            panelSearchPr.ResumeLayout(false);
            panelSearchPr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectsRefused).EndInit();
            tabPageWaitClient.ResumeLayout(false);
            panelSearchWr.ResumeLayout(false);
            panelSearchWr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectsWaitingResponse).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker2;
        private TabPage tabPageProjects;
        private TabPage tpListaProyectos;
        private DataGridView dataGridViewRequestProjects;
        private TabControl tbTask;
        private TabPage tabPage1;
        private Panel panelSearchPip;
        private Label labelSearchpip;
        private ComboBox comboBoxSearchPip;
        private DataGridView dataGridViewProjectsInProgress;
        private FontAwesome.Sharp.IconButton iconButtonCleanPip;
        private FontAwesome.Sharp.IconButton iconButtonSearchPip;
        private Panel panelSearchpf;
        private FontAwesome.Sharp.IconButton iconButtonClearpf;
        private FontAwesome.Sharp.IconButton iconButtonSearchpf;
        private Label labelSearchpf;
        private ComboBox comboBoxSearchpf;
        private DataGridView dataGridViewProjectsEnd;
        private TabPage tabPageProjectsRefused;
        private Panel panelSearchPr;
        private FontAwesome.Sharp.IconButton iconButtonClearPr;
        private FontAwesome.Sharp.IconButton iconButtonSearchPr;
        private Label labelSearchPr;
        private ComboBox comboBoxSearchPr;
        private DataGridView dataGridViewProjectsRefused;
        private DataGridViewButtonColumn SelectPr;
        private DataGridViewButtonColumn SelectPe;
        private DataGridViewButtonColumn SelectRp;
        private TabPage tabPageWaitClient;
        private Panel panelSearchWr;
        private FontAwesome.Sharp.IconButton iconButtonClearSearchWr;
        private FontAwesome.Sharp.IconButton iconButtonSearchWr;
        private Label labelSearchWr;
        private ComboBox comboBoxSearchWr;
        private DataGridView dataGridViewProjectsWaitingResponse;
        private DataGridViewButtonColumn SelectProjectInProgress;
    }
}