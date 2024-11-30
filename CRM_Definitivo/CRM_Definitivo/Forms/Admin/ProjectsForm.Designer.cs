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
            waitClientTabPage = new TabPage();
            searchWaitPanel = new Panel();
            iconClearSearchWaitButtn = new FontAwesome.Sharp.IconButton();
            iconSearchWaitButton = new FontAwesome.Sharp.IconButton();
            searchWaitLabel = new Label();
            searchWaitComboBox = new ComboBox();
            projectsWaitingResponseDataGridView = new DataGridView();
            projectsRefusedTabPage = new TabPage();
            searchDismissedPanel = new Panel();
            iconClearDismissedButton = new FontAwesome.Sharp.IconButton();
            iconSearchDismissedButton = new FontAwesome.Sharp.IconButton();
            searchDismissedLabel = new Label();
            searchDismissedComboBox = new ComboBox();
            projectsRefusedDataGridView = new DataGridView();
            processProjectTabPage = new TabPage();
            searchPipPanel = new Panel();
            searProjectProgresstextBox = new TextBox();
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
            SelectRp = new DataGridViewButtonColumn();
            Rechazo = new DataGridViewLinkColumn();
            waitClientTabPage.SuspendLayout();
            searchWaitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectsWaitingResponseDataGridView).BeginInit();
            projectsRefusedTabPage.SuspendLayout();
            searchDismissedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectsRefusedDataGridView).BeginInit();
            processProjectTabPage.SuspendLayout();
            searchPipPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectProgressDataGridView).BeginInit();
            listProjectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestProjectsDataGridView).BeginInit();
            taskTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // waitClientTabPage
            // 
            waitClientTabPage.Controls.Add(searchWaitPanel);
            waitClientTabPage.Controls.Add(projectsWaitingResponseDataGridView);
            waitClientTabPage.Location = new Point(4, 29);
            waitClientTabPage.Name = "waitClientTabPage";
            waitClientTabPage.Padding = new Padding(3);
            waitClientTabPage.Size = new Size(1122, 561);
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
            searchWaitPanel.Location = new Point(3, 3);
            searchWaitPanel.Name = "searchWaitPanel";
            searchWaitPanel.Size = new Size(1116, 69);
            searchWaitPanel.TabIndex = 7;
            // 
            // iconClearSearchWaitButtn
            // 
            iconClearSearchWaitButtn.IconChar = FontAwesome.Sharp.IconChar.None;
            iconClearSearchWaitButtn.IconColor = Color.Black;
            iconClearSearchWaitButtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClearSearchWaitButtn.Location = new Point(324, 18);
            iconClearSearchWaitButtn.Name = "iconClearSearchWaitButtn";
            iconClearSearchWaitButtn.Size = new Size(32, 29);
            iconClearSearchWaitButtn.TabIndex = 3;
            iconClearSearchWaitButtn.UseVisualStyleBackColor = true;
            // 
            // iconSearchWaitButton
            // 
            iconSearchWaitButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSearchWaitButton.IconColor = Color.Black;
            iconSearchWaitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSearchWaitButton.Location = new Point(286, 18);
            iconSearchWaitButton.Name = "iconSearchWaitButton";
            iconSearchWaitButton.Size = new Size(32, 29);
            iconSearchWaitButton.TabIndex = 2;
            iconSearchWaitButton.UseVisualStyleBackColor = true;
            // 
            // searchWaitLabel
            // 
            searchWaitLabel.AutoSize = true;
            searchWaitLabel.Location = new Point(6, 22);
            searchWaitLabel.Name = "searchWaitLabel";
            searchWaitLabel.Size = new Size(52, 20);
            searchWaitLabel.TabIndex = 1;
            searchWaitLabel.Text = "Buscar";
            // 
            // searchWaitComboBox
            // 
            searchWaitComboBox.FormattingEnabled = true;
            searchWaitComboBox.Location = new Point(64, 19);
            searchWaitComboBox.Name = "searchWaitComboBox";
            searchWaitComboBox.Size = new Size(216, 28);
            searchWaitComboBox.TabIndex = 0;
            // 
            // projectsWaitingResponseDataGridView
            // 
            projectsWaitingResponseDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectsWaitingResponseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsWaitingResponseDataGridView.Location = new Point(3, 78);
            projectsWaitingResponseDataGridView.Name = "projectsWaitingResponseDataGridView";
            projectsWaitingResponseDataGridView.RowHeadersWidth = 51;
            projectsWaitingResponseDataGridView.Size = new Size(1116, 480);
            projectsWaitingResponseDataGridView.TabIndex = 6;
            // 
            // projectsRefusedTabPage
            // 
            projectsRefusedTabPage.Controls.Add(searchDismissedPanel);
            projectsRefusedTabPage.Controls.Add(projectsRefusedDataGridView);
            projectsRefusedTabPage.Location = new Point(4, 29);
            projectsRefusedTabPage.Name = "projectsRefusedTabPage";
            projectsRefusedTabPage.Padding = new Padding(3);
            projectsRefusedTabPage.Size = new Size(1122, 561);
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
            searchDismissedPanel.Location = new Point(3, 3);
            searchDismissedPanel.Name = "searchDismissedPanel";
            searchDismissedPanel.Size = new Size(1116, 69);
            searchDismissedPanel.TabIndex = 5;
            // 
            // iconClearDismissedButton
            // 
            iconClearDismissedButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconClearDismissedButton.IconColor = Color.Black;
            iconClearDismissedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClearDismissedButton.Location = new Point(324, 18);
            iconClearDismissedButton.Name = "iconClearDismissedButton";
            iconClearDismissedButton.Size = new Size(32, 29);
            iconClearDismissedButton.TabIndex = 3;
            iconClearDismissedButton.UseVisualStyleBackColor = true;
            // 
            // iconSearchDismissedButton
            // 
            iconSearchDismissedButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSearchDismissedButton.IconColor = Color.Black;
            iconSearchDismissedButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSearchDismissedButton.Location = new Point(286, 18);
            iconSearchDismissedButton.Name = "iconSearchDismissedButton";
            iconSearchDismissedButton.Size = new Size(32, 29);
            iconSearchDismissedButton.TabIndex = 2;
            iconSearchDismissedButton.UseVisualStyleBackColor = true;
            // 
            // searchDismissedLabel
            // 
            searchDismissedLabel.AutoSize = true;
            searchDismissedLabel.Location = new Point(6, 22);
            searchDismissedLabel.Name = "searchDismissedLabel";
            searchDismissedLabel.Size = new Size(52, 20);
            searchDismissedLabel.TabIndex = 1;
            searchDismissedLabel.Text = "Buscar";
            // 
            // searchDismissedComboBox
            // 
            searchDismissedComboBox.FormattingEnabled = true;
            searchDismissedComboBox.Location = new Point(64, 19);
            searchDismissedComboBox.Name = "searchDismissedComboBox";
            searchDismissedComboBox.Size = new Size(216, 28);
            searchDismissedComboBox.TabIndex = 0;
            // 
            // projectsRefusedDataGridView
            // 
            projectsRefusedDataGridView.AllowUserToDeleteRows = false;
            projectsRefusedDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectsRefusedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsRefusedDataGridView.Columns.AddRange(new DataGridViewColumn[] { SelectRp, Rechazo });
            projectsRefusedDataGridView.Location = new Point(3, 78);
            projectsRefusedDataGridView.Name = "projectsRefusedDataGridView";
            projectsRefusedDataGridView.ReadOnly = true;
            projectsRefusedDataGridView.RowHeadersWidth = 51;
            projectsRefusedDataGridView.Size = new Size(1116, 480);
            projectsRefusedDataGridView.TabIndex = 4;
            projectsRefusedDataGridView.CellContentClick += projectsRefusedDataGridView_CellContentClick;
            // 
            // processProjectTabPage
            // 
            processProjectTabPage.Controls.Add(searchPipPanel);
            processProjectTabPage.Controls.Add(projectProgressDataGridView);
            processProjectTabPage.Location = new Point(4, 29);
            processProjectTabPage.Name = "processProjectTabPage";
            processProjectTabPage.Padding = new Padding(3);
            processProjectTabPage.Size = new Size(1122, 561);
            processProjectTabPage.TabIndex = 6;
            processProjectTabPage.Text = "Proyectos en curso";
            processProjectTabPage.UseVisualStyleBackColor = true;
            // 
            // searchPipPanel
            // 
            searchPipPanel.Controls.Add(searProjectProgresstextBox);
            searchPipPanel.Controls.Add(iconCleanProcessButton);
            searchPipPanel.Controls.Add(iconSearchProcessButton);
            searchPipPanel.Controls.Add(searchProcessLabel);
            searchPipPanel.Controls.Add(searchProcessComboBox);
            searchPipPanel.Dock = DockStyle.Top;
            searchPipPanel.Location = new Point(3, 3);
            searchPipPanel.Name = "searchPipPanel";
            searchPipPanel.Size = new Size(1116, 69);
            searchPipPanel.TabIndex = 1;
            // 
            // searProjectProgresstextBox
            // 
            searProjectProgresstextBox.Location = new Point(288, 23);
            searProjectProgresstextBox.Name = "searProjectProgresstextBox";
            searProjectProgresstextBox.Size = new Size(177, 27);
            searProjectProgresstextBox.TabIndex = 4;
            // 
            // iconCleanProcessButton
            // 
            iconCleanProcessButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconCleanProcessButton.IconColor = Color.Black;
            iconCleanProcessButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCleanProcessButton.Location = new Point(509, 21);
            iconCleanProcessButton.Name = "iconCleanProcessButton";
            iconCleanProcessButton.Size = new Size(32, 29);
            iconCleanProcessButton.TabIndex = 3;
            iconCleanProcessButton.UseVisualStyleBackColor = true;
            iconCleanProcessButton.Click += iconCleanProcessButton_Click;
            // 
            // iconSearchProcessButton
            // 
            iconSearchProcessButton.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSearchProcessButton.IconColor = Color.Black;
            iconSearchProcessButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSearchProcessButton.Location = new Point(471, 21);
            iconSearchProcessButton.Name = "iconSearchProcessButton";
            iconSearchProcessButton.Size = new Size(32, 29);
            iconSearchProcessButton.TabIndex = 2;
            iconSearchProcessButton.UseVisualStyleBackColor = true;
            iconSearchProcessButton.Click += iconSearchProcessButton_Click;
            // 
            // searchProcessLabel
            // 
            searchProcessLabel.AutoSize = true;
            searchProcessLabel.Location = new Point(8, 25);
            searchProcessLabel.Name = "searchProcessLabel";
            searchProcessLabel.Size = new Size(52, 20);
            searchProcessLabel.TabIndex = 1;
            searchProcessLabel.Text = "Buscar";
            // 
            // searchProcessComboBox
            // 
            searchProcessComboBox.FormattingEnabled = true;
            searchProcessComboBox.Location = new Point(66, 22);
            searchProcessComboBox.Name = "searchProcessComboBox";
            searchProcessComboBox.Size = new Size(216, 28);
            searchProcessComboBox.TabIndex = 0;
            // 
            // projectProgressDataGridView
            // 
            projectProgressDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectProgressDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectProgressDataGridView.Columns.AddRange(new DataGridViewColumn[] { SelectProjectInProgress });
            projectProgressDataGridView.Location = new Point(3, 78);
            projectProgressDataGridView.Name = "projectProgressDataGridView";
            projectProgressDataGridView.RowHeadersWidth = 51;
            projectProgressDataGridView.Size = new Size(1116, 480);
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
            listProjectTabPage.Location = new Point(4, 29);
            listProjectTabPage.Name = "listProjectTabPage";
            listProjectTabPage.Padding = new Padding(3);
            listProjectTabPage.Size = new Size(1122, 561);
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
            requestProjectsDataGridView.Location = new Point(33, 55);
            requestProjectsDataGridView.Name = "requestProjectsDataGridView";
            requestProjectsDataGridView.ReadOnly = true;
            requestProjectsDataGridView.RowHeadersWidth = 51;
            requestProjectsDataGridView.Size = new Size(1070, 486);
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
            taskTabControl.Controls.Add(projectsRefusedTabPage);
            taskTabControl.Controls.Add(waitClientTabPage);
            taskTabControl.Location = new Point(12, 32);
            taskTabControl.Name = "taskTabControl";
            taskTabControl.SelectedIndex = 0;
            taskTabControl.Size = new Size(1130, 594);
            taskTabControl.TabIndex = 0;
            // 
            // SelectRp
            // 
            SelectRp.HeaderText = "Select";
            SelectRp.MinimumWidth = 6;
            SelectRp.Name = "SelectRp";
            SelectRp.ReadOnly = true;
            SelectRp.Resizable = DataGridViewTriState.True;
            SelectRp.SortMode = DataGridViewColumnSortMode.Automatic;
            SelectRp.Width = 70;
            // 
            // Rechazo
            // 
            Rechazo.HeaderText = "Rechazo";
            Rechazo.MinimumWidth = 6;
            Rechazo.Name = "Rechazo";
            Rechazo.ReadOnly = true;
            Rechazo.Text = "Rechazo";
            Rechazo.UseColumnTextForLinkValue = true;
            Rechazo.Width = 125;
            // 
            // ProjectsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 659);
            Controls.Add(taskTabControl);
            Name = "ProjectsForm";
            Text = "ProyectosForm";
            waitClientTabPage.ResumeLayout(false);
            searchWaitPanel.ResumeLayout(false);
            searchWaitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectsWaitingResponseDataGridView).EndInit();
            projectsRefusedTabPage.ResumeLayout(false);
            searchDismissedPanel.ResumeLayout(false);
            searchDismissedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectsRefusedDataGridView).EndInit();
            processProjectTabPage.ResumeLayout(false);
            searchPipPanel.ResumeLayout(false);
            searchPipPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projectProgressDataGridView).EndInit();
            listProjectTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestProjectsDataGridView).EndInit();
            taskTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker2;
        private TabPage waitClientTabPage;
        private Panel searchWaitPanel;
        private FontAwesome.Sharp.IconButton iconClearSearchWaitButtn;
        private FontAwesome.Sharp.IconButton iconSearchWaitButton;
        private Label searchWaitLabel;
        private ComboBox searchWaitComboBox;
        private DataGridView projectsWaitingResponseDataGridView;
        private TabPage projectsRefusedTabPage;
        private Panel searchDismissedPanel;
        private FontAwesome.Sharp.IconButton iconClearDismissedButton;
        private FontAwesome.Sharp.IconButton iconSearchDismissedButton;
        private Label searchDismissedLabel;
        private ComboBox searchDismissedComboBox;
        private DataGridView projectsRefusedDataGridView;
        private TabPage processProjectTabPage;
        private Panel searchPipPanel;
        private FontAwesome.Sharp.IconButton iconCleanProcessButton;
        private FontAwesome.Sharp.IconButton iconSearchProcessButton;
        private Label searchProcessLabel;
        private ComboBox searchProcessComboBox;
        private DataGridView projectProgressDataGridView;
        private DataGridViewButtonColumn SelectProjectInProgress;
        private TabPage listProjectTabPage;
        private DataGridView requestProjectsDataGridView;
        private DataGridViewButtonColumn SelectPr;
        private TabControl taskTabControl;
        private TextBox searProjectProgresstextBox;
        private DataGridViewButtonColumn SelectRp;
        private DataGridViewLinkColumn Rechazo;
    }
}