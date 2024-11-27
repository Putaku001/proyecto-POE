namespace PresentationLayer.Forms
{
    partial class ProjectsForm
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
            processProjectTabPage = new TabPage();
            searchPipPanel = new Panel();
            iconCleanProcessButton = new FontAwesome.Sharp.IconButton();
            iconSearchProcessButton = new FontAwesome.Sharp.IconButton();
            searchProcessLabel = new Label();
            searchProcessComboBox = new ComboBox();
            projectProgressDataGridView = new DataGridView();
            SelectProjectInProgress = new DataGridViewButtonColumn();
            listProjectTabPage = new TabPage();
            requestProjectsDataGridView = new DataGridView();
            SelectPr = new DataGridViewButtonColumn();
            taskTabControl = new TabControl();
            finishProjectTabPage = new TabPage();
            finishSearchPanel = new Panel();
            iconClearFinishProjectButton = new FontAwesome.Sharp.IconButton();
            iconSearchFinishButton = new FontAwesome.Sharp.IconButton();
            labelSearchpf = new Label();
            finishSearchComboBox = new ComboBox();
            projectsEndDataGridView = new DataGridView();
            SelectPe = new DataGridViewButtonColumn();
            projectsRefusedTabPage = new TabPage();
            searchDismissedPanel = new Panel();
            iconClearDismissedButton = new FontAwesome.Sharp.IconButton();
            iconSearchDismissedButton = new FontAwesome.Sharp.IconButton();
            searchDismissedLabel = new Label();
            searchDismissedComboBox = new ComboBox();
            projectsRefusedDataGridView = new DataGridView();
            SelectRp = new DataGridViewButtonColumn();
            waitClientTabPage = new TabPage();
            searchWaitPanel = new Panel();
            iconClearSearchWaitButtn = new FontAwesome.Sharp.IconButton();
            iconSearchWaitButton = new FontAwesome.Sharp.IconButton();
            searchWaitLabel = new Label();
            searchWaitComboBox = new ComboBox();
            projectsWaitingResponseDataGridView = new DataGridView();
            processProjectTabPage.SuspendLayout();
            searchPipPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectProgressDataGridView).BeginInit();
            listProjectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestProjectsDataGridView).BeginInit();
            taskTabControl.SuspendLayout();
            finishProjectTabPage.SuspendLayout();
            finishSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectsEndDataGridView).BeginInit();
            projectsRefusedTabPage.SuspendLayout();
            searchDismissedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectsRefusedDataGridView).BeginInit();
            waitClientTabPage.SuspendLayout();
            searchWaitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectsWaitingResponseDataGridView).BeginInit();
            SuspendLayout();
            // 
            // processProjectTabPage
            // 
            processProjectTabPage.Controls.Add(searchPipPanel);
            processProjectTabPage.Controls.Add(projectProgressDataGridView);
            processProjectTabPage.Location = new Point(4, 34);
            processProjectTabPage.Margin = new Padding(4);
            processProjectTabPage.Name = "processProjectTabPage";
            processProjectTabPage.Padding = new Padding(4);
            processProjectTabPage.Size = new Size(1404, 704);
            processProjectTabPage.TabIndex = 6;
            processProjectTabPage.Text = "Proyectos en curso";
            processProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // searchPipPanel
            // 
            searchPipPanel.Controls.Add(iconCleanProcessButton);
            searchPipPanel.Controls.Add(iconSearchProcessButton);
            searchPipPanel.Controls.Add(searchProcessLabel);
            searchPipPanel.Controls.Add(searchProcessComboBox);
            searchPipPanel.Dock = DockStyle.Top;
            searchPipPanel.Location = new Point(4, 4);
            searchPipPanel.Margin = new Padding(4);
            searchPipPanel.Name = "searchPipPanel";
            searchPipPanel.Size = new Size(1396, 86);
            searchPipPanel.TabIndex = 1;
            // 
            // iconCleanProcessButton
            // 
            iconCleanProcessButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconCleanProcessButton.IconColor = Color.Black;
            iconCleanProcessButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCleanProcessButton.Location = new Point(408, 26);
            iconCleanProcessButton.Margin = new Padding(4);
            iconCleanProcessButton.Name = "iconCleanProcessButton";
            iconCleanProcessButton.Size = new Size(40, 36);
            iconCleanProcessButton.TabIndex = 3;
            iconCleanProcessButton.UseVisualStyleBackColor = true;
            // 
            // iconSearchProcessButton
            // 
            iconSearchProcessButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSearchProcessButton.IconColor = Color.Black;
            iconSearchProcessButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSearchProcessButton.Location = new Point(360, 26);
            iconSearchProcessButton.Margin = new Padding(4);
            iconSearchProcessButton.Name = "iconSearchProcessButton";
            iconSearchProcessButton.Size = new Size(40, 36);
            iconSearchProcessButton.TabIndex = 2;
            iconSearchProcessButton.UseVisualStyleBackColor = true;
            // 
            // searchProcessLabel
            // 
            searchProcessLabel.AutoSize = true;
            searchProcessLabel.Location = new Point(10, 31);
            searchProcessLabel.Margin = new Padding(4, 0, 4, 0);
            searchProcessLabel.Name = "searchProcessLabel";
            searchProcessLabel.Size = new Size(63, 25);
            searchProcessLabel.TabIndex = 1;
            searchProcessLabel.Text = "Buscar";
            // 
            // searchProcessComboBox
            // 
            searchProcessComboBox.FormattingEnabled = true;
            searchProcessComboBox.Location = new Point(82, 28);
            searchProcessComboBox.Margin = new Padding(4);
            searchProcessComboBox.Name = "searchProcessComboBox";
            searchProcessComboBox.Size = new Size(269, 33);
            searchProcessComboBox.TabIndex = 0;
            // 
            // projectProgressDataGridView
            // 
            projectProgressDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectProgressDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectProgressDataGridView.Columns.AddRange(new DataGridViewColumn[] { SelectProjectInProgress });
            projectProgressDataGridView.Location = new Point(4, 98);
            projectProgressDataGridView.Margin = new Padding(4);
            projectProgressDataGridView.Name = "projectProgressDataGridView";
            projectProgressDataGridView.RowHeadersWidth = 51;
            projectProgressDataGridView.Size = new Size(1395, 600);
            projectProgressDataGridView.TabIndex = 0;
            projectProgressDataGridView.CellContentClick += projectProgressDataGridView_CellContentClick;
            projectProgressDataGridView.CellDoubleClick += projectProgressDataGridView_CellDoubleClick;
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
            // listProjectTabPage
            // 
            listProjectTabPage.Controls.Add(requestProjectsDataGridView);
            listProjectTabPage.Location = new Point(4, 34);
            listProjectTabPage.Margin = new Padding(4);
            listProjectTabPage.Name = "listProjectTabPage";
            listProjectTabPage.Padding = new Padding(4);
            listProjectTabPage.Size = new Size(1404, 704);
            listProjectTabPage.TabIndex = 2;
            listProjectTabPage.Text = "Proyectos solicitados";
            listProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // requestProjectsDataGridView
            // 
            requestProjectsDataGridView.AllowUserToAddRows = false;
            requestProjectsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            requestProjectsDataGridView.BackgroundColor = Color.Gainsboro;
            requestProjectsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestProjectsDataGridView.Columns.AddRange(new DataGridViewColumn[] { SelectPr });
            requestProjectsDataGridView.Location = new Point(41, 69);
            requestProjectsDataGridView.Margin = new Padding(4);
            requestProjectsDataGridView.Name = "requestProjectsDataGridView";
            requestProjectsDataGridView.ReadOnly = true;
            requestProjectsDataGridView.RowHeadersWidth = 51;
            requestProjectsDataGridView.Size = new Size(1338, 608);
            requestProjectsDataGridView.TabIndex = 5;
            requestProjectsDataGridView.CellContentClick += requestProjectsDataGridView_CellContentClick;
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
            // taskTabControl
            // 
            taskTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taskTabControl.Controls.Add(listProjectTabPage);
            taskTabControl.Controls.Add(processProjectTabPage);
            taskTabControl.Controls.Add(finishProjectTabPage);
            taskTabControl.Controls.Add(projectsRefusedTabPage);
            taskTabControl.Controls.Add(waitClientTabPage);
            taskTabControl.Location = new Point(15, 40);
            taskTabControl.Margin = new Padding(4);
            taskTabControl.Name = "taskTabControl";
            taskTabControl.SelectedIndex = 0;
            taskTabControl.Size = new Size(1412, 742);
            taskTabControl.TabIndex = 0;
            // 
            // finishProjectTabPage
            // 
            finishProjectTabPage.Controls.Add(finishSearchPanel);
            finishProjectTabPage.Controls.Add(projectsEndDataGridView);
            finishProjectTabPage.Location = new Point(4, 34);
            finishProjectTabPage.Margin = new Padding(4);
            finishProjectTabPage.Name = "finishProjectTabPage";
            finishProjectTabPage.Padding = new Padding(4);
            finishProjectTabPage.Size = new Size(1404, 704);
            finishProjectTabPage.TabIndex = 7;
            finishProjectTabPage.Text = "Proyectos finalizados";
            finishProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // finishSearchPanel
            // 
            finishSearchPanel.Controls.Add(iconClearFinishProjectButton);
            finishSearchPanel.Controls.Add(iconSearchFinishButton);
            finishSearchPanel.Controls.Add(labelSearchpf);
            finishSearchPanel.Controls.Add(finishSearchComboBox);
            finishSearchPanel.Dock = DockStyle.Top;
            finishSearchPanel.Location = new Point(4, 4);
            finishSearchPanel.Margin = new Padding(4);
            finishSearchPanel.Name = "finishSearchPanel";
            finishSearchPanel.Size = new Size(1396, 86);
            finishSearchPanel.TabIndex = 3;
            // 
            // iconClearFinishProjectButton
            // 
            iconClearFinishProjectButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconClearFinishProjectButton.IconColor = Color.Black;
            iconClearFinishProjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClearFinishProjectButton.Location = new Point(406, 26);
            iconClearFinishProjectButton.Margin = new Padding(4);
            iconClearFinishProjectButton.Name = "iconClearFinishProjectButton";
            iconClearFinishProjectButton.Size = new Size(40, 36);
            iconClearFinishProjectButton.TabIndex = 3;
            iconClearFinishProjectButton.UseVisualStyleBackColor = true;
            // 
            // iconSearchFinishButton
            // 
            iconSearchFinishButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSearchFinishButton.IconColor = Color.Black;
            iconSearchFinishButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSearchFinishButton.Location = new Point(359, 26);
            iconSearchFinishButton.Margin = new Padding(4);
            iconSearchFinishButton.Name = "iconSearchFinishButton";
            iconSearchFinishButton.Size = new Size(40, 36);
            iconSearchFinishButton.TabIndex = 2;
            iconSearchFinishButton.UseVisualStyleBackColor = true;
            // 
            // labelSearchpf
            // 
            labelSearchpf.AutoSize = true;
            labelSearchpf.Location = new Point(9, 31);
            labelSearchpf.Margin = new Padding(4, 0, 4, 0);
            labelSearchpf.Name = "labelSearchpf";
            labelSearchpf.Size = new Size(63, 25);
            labelSearchpf.TabIndex = 1;
            labelSearchpf.Text = "Buscar";
            // 
            // finishSearchComboBox
            // 
            finishSearchComboBox.FormattingEnabled = true;
            finishSearchComboBox.Location = new Point(81, 28);
            finishSearchComboBox.Margin = new Padding(4);
            finishSearchComboBox.Name = "finishSearchComboBox";
            finishSearchComboBox.Size = new Size(269, 33);
            finishSearchComboBox.TabIndex = 0;
            // 
            // projectsEndDataGridView
            // 
            projectsEndDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectsEndDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsEndDataGridView.Columns.AddRange(new DataGridViewColumn[] { SelectPe });
            projectsEndDataGridView.Location = new Point(4, 98);
            projectsEndDataGridView.Margin = new Padding(4);
            projectsEndDataGridView.Name = "projectsEndDataGridView";
            projectsEndDataGridView.RowHeadersWidth = 51;
            projectsEndDataGridView.Size = new Size(1395, 600);
            projectsEndDataGridView.TabIndex = 2;
            projectsEndDataGridView.CellContentClick += projectsEndDataGridView_CellContentClick;
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
            // projectsRefusedTabPage
            // 
            projectsRefusedTabPage.Controls.Add(searchDismissedPanel);
            projectsRefusedTabPage.Controls.Add(projectsRefusedDataGridView);
            projectsRefusedTabPage.Location = new Point(4, 34);
            projectsRefusedTabPage.Margin = new Padding(4);
            projectsRefusedTabPage.Name = "projectsRefusedTabPage";
            projectsRefusedTabPage.Padding = new Padding(4);
            projectsRefusedTabPage.Size = new Size(1404, 704);
            projectsRefusedTabPage.TabIndex = 8;
            projectsRefusedTabPage.Text = "Proyectos rechazados";
            projectsRefusedTabPage.UseVisualStyleBackColor = true;
            // 
            // searchDismissedPanel
            // 
            searchDismissedPanel.Controls.Add(iconClearDismissedButton);
            searchDismissedPanel.Controls.Add(iconSearchDismissedButton);
            searchDismissedPanel.Controls.Add(searchDismissedLabel);
            searchDismissedPanel.Controls.Add(searchDismissedComboBox);
            searchDismissedPanel.Dock = DockStyle.Top;
            searchDismissedPanel.Location = new Point(4, 4);
            searchDismissedPanel.Margin = new Padding(4);
            searchDismissedPanel.Name = "searchDismissedPanel";
            searchDismissedPanel.Size = new Size(1396, 86);
            searchDismissedPanel.TabIndex = 5;
            // 
            // iconClearDismissedButton
            // 
            iconClearDismissedButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconClearDismissedButton.IconColor = Color.Black;
            iconClearDismissedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClearDismissedButton.Location = new Point(405, 22);
            iconClearDismissedButton.Margin = new Padding(4);
            iconClearDismissedButton.Name = "iconClearDismissedButton";
            iconClearDismissedButton.Size = new Size(40, 36);
            iconClearDismissedButton.TabIndex = 3;
            iconClearDismissedButton.UseVisualStyleBackColor = true;
            // 
            // iconSearchDismissedButton
            // 
            iconSearchDismissedButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSearchDismissedButton.IconColor = Color.Black;
            iconSearchDismissedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSearchDismissedButton.Location = new Point(358, 22);
            iconSearchDismissedButton.Margin = new Padding(4);
            iconSearchDismissedButton.Name = "iconSearchDismissedButton";
            iconSearchDismissedButton.Size = new Size(40, 36);
            iconSearchDismissedButton.TabIndex = 2;
            iconSearchDismissedButton.UseVisualStyleBackColor = true;
            // 
            // searchDismissedLabel
            // 
            searchDismissedLabel.AutoSize = true;
            searchDismissedLabel.Location = new Point(8, 28);
            searchDismissedLabel.Margin = new Padding(4, 0, 4, 0);
            searchDismissedLabel.Name = "searchDismissedLabel";
            searchDismissedLabel.Size = new Size(63, 25);
            searchDismissedLabel.TabIndex = 1;
            searchDismissedLabel.Text = "Buscar";
            // 
            // searchDismissedComboBox
            // 
            searchDismissedComboBox.FormattingEnabled = true;
            searchDismissedComboBox.Location = new Point(80, 24);
            searchDismissedComboBox.Margin = new Padding(4);
            searchDismissedComboBox.Name = "searchDismissedComboBox";
            searchDismissedComboBox.Size = new Size(269, 33);
            searchDismissedComboBox.TabIndex = 0;
            // 
            // projectsRefusedDataGridView
            // 
            projectsRefusedDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectsRefusedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsRefusedDataGridView.Columns.AddRange(new DataGridViewColumn[] { SelectRp });
            projectsRefusedDataGridView.Location = new Point(4, 98);
            projectsRefusedDataGridView.Margin = new Padding(4);
            projectsRefusedDataGridView.Name = "projectsRefusedDataGridView";
            projectsRefusedDataGridView.RowHeadersWidth = 51;
            projectsRefusedDataGridView.Size = new Size(1395, 600);
            projectsRefusedDataGridView.TabIndex = 4;
            projectsRefusedDataGridView.CellContentClick += projectsRefusedDataGridView_CellContentClick;
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
            // waitClientTabPage
            // 
            waitClientTabPage.Controls.Add(searchWaitPanel);
            waitClientTabPage.Controls.Add(projectsWaitingResponseDataGridView);
            waitClientTabPage.Location = new Point(4, 34);
            waitClientTabPage.Margin = new Padding(4);
            waitClientTabPage.Name = "waitClientTabPage";
            waitClientTabPage.Padding = new Padding(4);
            waitClientTabPage.Size = new Size(1404, 704);
            waitClientTabPage.TabIndex = 9;
            waitClientTabPage.Text = "Esperando respuesta del cliente";
            waitClientTabPage.UseVisualStyleBackColor = true;
            // 
            // searchWaitPanel
            // 
            searchWaitPanel.Controls.Add(iconClearSearchWaitButtn);
            searchWaitPanel.Controls.Add(iconSearchWaitButton);
            searchWaitPanel.Controls.Add(searchWaitLabel);
            searchWaitPanel.Controls.Add(searchWaitComboBox);
            searchWaitPanel.Dock = DockStyle.Top;
            searchWaitPanel.Location = new Point(4, 4);
            searchWaitPanel.Margin = new Padding(4);
            searchWaitPanel.Name = "searchWaitPanel";
            searchWaitPanel.Size = new Size(1396, 86);
            searchWaitPanel.TabIndex = 7;
            // 
            // iconClearSearchWaitButtn
            // 
            iconClearSearchWaitButtn.IconChar = FontAwesome.Sharp.IconChar.None;
            iconClearSearchWaitButtn.IconColor = Color.Black;
            iconClearSearchWaitButtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClearSearchWaitButtn.Location = new Point(405, 22);
            iconClearSearchWaitButtn.Margin = new Padding(4);
            iconClearSearchWaitButtn.Name = "iconClearSearchWaitButtn";
            iconClearSearchWaitButtn.Size = new Size(40, 36);
            iconClearSearchWaitButtn.TabIndex = 3;
            iconClearSearchWaitButtn.UseVisualStyleBackColor = true;
            // 
            // iconSearchWaitButton
            // 
            iconSearchWaitButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSearchWaitButton.IconColor = Color.Black;
            iconSearchWaitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSearchWaitButton.Location = new Point(358, 22);
            iconSearchWaitButton.Margin = new Padding(4);
            iconSearchWaitButton.Name = "iconSearchWaitButton";
            iconSearchWaitButton.Size = new Size(40, 36);
            iconSearchWaitButton.TabIndex = 2;
            iconSearchWaitButton.UseVisualStyleBackColor = true;
            // 
            // searchWaitLabel
            // 
            searchWaitLabel.AutoSize = true;
            searchWaitLabel.Location = new Point(8, 28);
            searchWaitLabel.Margin = new Padding(4, 0, 4, 0);
            searchWaitLabel.Name = "searchWaitLabel";
            searchWaitLabel.Size = new Size(63, 25);
            searchWaitLabel.TabIndex = 1;
            searchWaitLabel.Text = "Buscar";
            // 
            // searchWaitComboBox
            // 
            searchWaitComboBox.FormattingEnabled = true;
            searchWaitComboBox.Location = new Point(80, 24);
            searchWaitComboBox.Margin = new Padding(4);
            searchWaitComboBox.Name = "searchWaitComboBox";
            searchWaitComboBox.Size = new Size(269, 33);
            searchWaitComboBox.TabIndex = 0;
            // 
            // projectsWaitingResponseDataGridView
            // 
            projectsWaitingResponseDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectsWaitingResponseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsWaitingResponseDataGridView.Location = new Point(4, 98);
            projectsWaitingResponseDataGridView.Margin = new Padding(4);
            projectsWaitingResponseDataGridView.Name = "projectsWaitingResponseDataGridView";
            projectsWaitingResponseDataGridView.RowHeadersWidth = 51;
            projectsWaitingResponseDataGridView.Size = new Size(1395, 600);
            projectsWaitingResponseDataGridView.TabIndex = 6;
            projectsWaitingResponseDataGridView.CellContentClick += projectsWaitingResponseDataGridView_CellContentClick;
            // 
            // ProjectsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 824);
            Controls.Add(taskTabControl);
            Margin = new Padding(4);
            Name = "ProjectsForm";
            Text = "ProyectosForm";
            processProjectTabPage.ResumeLayout(false);
            searchPipPanel.ResumeLayout(false);
            searchPipPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectProgressDataGridView).EndInit();
            listProjectTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestProjectsDataGridView).EndInit();
            taskTabControl.ResumeLayout(false);
            finishProjectTabPage.ResumeLayout(false);
            finishSearchPanel.ResumeLayout(false);
            finishSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectsEndDataGridView).EndInit();
            projectsRefusedTabPage.ResumeLayout(false);
            searchDismissedPanel.ResumeLayout(false);
            searchDismissedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectsRefusedDataGridView).EndInit();
            waitClientTabPage.ResumeLayout(false);
            searchWaitPanel.ResumeLayout(false);
            searchWaitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectsWaitingResponseDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker2;
        private TabPage processProjectTabPage;
        private TabPage listProjectTabPage;
        private DataGridView requestProjectsDataGridView;
        private TabControl taskTabControl;
        private TabPage finishProjectTabPage;
        private Panel searchPipPanel;
        private Label searchProcessLabel;
        private ComboBox searchProcessComboBox;
        private DataGridView projectProgressDataGridView;
        private FontAwesome.Sharp.IconButton iconCleanProcessButton;
        private FontAwesome.Sharp.IconButton iconSearchProcessButton;
        private Panel finishSearchPanel;
        private FontAwesome.Sharp.IconButton iconClearFinishProjectButton;
        private FontAwesome.Sharp.IconButton iconSearchFinishButton;
        private Label labelSearchpf;
        private ComboBox finishSearchComboBox;
        private DataGridView projectsEndDataGridView;
        private TabPage projectsRefusedTabPage;
        private Panel searchDismissedPanel;
        private FontAwesome.Sharp.IconButton iconClearDismissedButton;
        private FontAwesome.Sharp.IconButton iconSearchDismissedButton;
        private Label searchDismissedLabel;
        private ComboBox searchDismissedComboBox;
        private DataGridView projectsRefusedDataGridView;
        private DataGridViewButtonColumn SelectPr;
        private DataGridViewButtonColumn SelectPe;
        private DataGridViewButtonColumn SelectRp;
        private TabPage waitClientTabPage;
        private Panel searchWaitPanel;
        private FontAwesome.Sharp.IconButton iconClearSearchWaitButtn;
        private FontAwesome.Sharp.IconButton iconSearchWaitButton;
        private Label searchWaitLabel;
        private ComboBox searchWaitComboBox;
        private DataGridView projectsWaitingResponseDataGridView;
        private DataGridViewButtonColumn SelectProjectInProgress;
    }
}