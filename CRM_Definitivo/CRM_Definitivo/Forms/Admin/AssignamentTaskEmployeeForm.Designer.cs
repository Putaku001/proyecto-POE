namespace PresentationLayer.Forms.Admin
{
    partial class AssignamentTaskEmployeeForm
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
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            labelEmployee = new Label();
            textBoxTask = new TextBox();
            labelTask = new Label();
            labelNameProject = new Label();
            label6 = new Label();
            labelUserAccount = new Label();
            comboBoxEmployee = new ComboBox();
            dataGridViewAssignamentTasks = new DataGridView();
            dateTimePickerEnd = new DateTimePicker();
            labelDateEnd = new Label();
            groupBoxDate = new GroupBox();
            groupBoxAssignamentTask = new GroupBox();
            iconButtonAssignamentTask = new FontAwesome.Sharp.IconButton();
            labelCodeProject = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignamentTasks).BeginInit();
            groupBoxDate.SuspendLayout();
            groupBoxAssignamentTask.SuspendLayout();
            SuspendLayout();
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(17, 28);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(100, 20);
            labelDescription.TabIndex = 0;
            labelDescription.Text = "Descripcion:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(15, 51);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(361, 74);
            textBoxDescription.TabIndex = 1;
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Location = new Point(15, 190);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(176, 20);
            labelEmployee.TabIndex = 2;
            labelEmployee.Text = "Seleccionar empleado";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(15, 151);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(361, 26);
            textBoxTask.TabIndex = 5;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(15, 128);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(49, 20);
            labelTask.TabIndex = 4;
            labelTask.Text = "Tarea";
            // 
            // labelNameProject
            // 
            labelNameProject.BackColor = SystemColors.ActiveCaption;
            labelNameProject.Dock = DockStyle.Top;
            labelNameProject.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNameProject.ForeColor = Color.White;
            labelNameProject.Location = new Point(0, 0);
            labelNameProject.Name = "labelNameProject";
            labelNameProject.Size = new Size(900, 33);
            labelNameProject.TabIndex = 8;
            labelNameProject.Text = "nameProject";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 54);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 9;
            label6.Text = "Cliente:";
            // 
            // labelUserAccount
            // 
            labelUserAccount.AutoSize = true;
            labelUserAccount.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserAccount.Location = new Point(98, 54);
            labelUserAccount.Name = "labelUserAccount";
            labelUserAccount.Size = new Size(103, 21);
            labelUserAccount.TabIndex = 10;
            labelUserAccount.Text = "labelClient";
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(15, 213);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(360, 28);
            comboBoxEmployee.TabIndex = 11;
            // 
            // dataGridViewAssignamentTasks
            // 
            dataGridViewAssignamentTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssignamentTasks.Dock = DockStyle.Bottom;
            dataGridViewAssignamentTasks.Location = new Point(0, 450);
            dataGridViewAssignamentTasks.Name = "dataGridViewAssignamentTasks";
            dataGridViewAssignamentTasks.RowHeadersWidth = 51;
            dataGridViewAssignamentTasks.Size = new Size(900, 200);
            dataGridViewAssignamentTasks.TabIndex = 12;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(68, 132);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(304, 26);
            dateTimePickerEnd.TabIndex = 13;
            // 
            // labelDateEnd
            // 
            labelDateEnd.AutoSize = true;
            labelDateEnd.Location = new Point(68, 109);
            labelDateEnd.Name = "labelDateEnd";
            labelDateEnd.Size = new Size(146, 20);
            labelDateEnd.TabIndex = 14;
            labelDateEnd.Text = "Fecha de entrega:";
            // 
            // groupBoxDate
            // 
            groupBoxDate.Controls.Add(labelDateEnd);
            groupBoxDate.Controls.Add(dateTimePickerEnd);
            groupBoxDate.Location = new Point(484, 79);
            groupBoxDate.Name = "groupBoxDate";
            groupBoxDate.Size = new Size(404, 287);
            groupBoxDate.TabIndex = 15;
            groupBoxDate.TabStop = false;
            groupBoxDate.Text = "Fecha";
            // 
            // groupBoxAssignamentTask
            // 
            groupBoxAssignamentTask.Controls.Add(textBoxDescription);
            groupBoxAssignamentTask.Controls.Add(comboBoxEmployee);
            groupBoxAssignamentTask.Controls.Add(labelDescription);
            groupBoxAssignamentTask.Controls.Add(labelEmployee);
            groupBoxAssignamentTask.Controls.Add(labelTask);
            groupBoxAssignamentTask.Controls.Add(textBoxTask);
            groupBoxAssignamentTask.Location = new Point(12, 88);
            groupBoxAssignamentTask.Name = "groupBoxAssignamentTask";
            groupBoxAssignamentTask.Size = new Size(394, 278);
            groupBoxAssignamentTask.TabIndex = 16;
            groupBoxAssignamentTask.TabStop = false;
            groupBoxAssignamentTask.Text = "Asignar tareas";
            // 
            // iconButtonAssignamentTask
            // 
            iconButtonAssignamentTask.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonAssignamentTask.IconColor = Color.Black;
            iconButtonAssignamentTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAssignamentTask.Location = new Point(328, 395);
            iconButtonAssignamentTask.Name = "iconButtonAssignamentTask";
            iconButtonAssignamentTask.Size = new Size(209, 29);
            iconButtonAssignamentTask.TabIndex = 17;
            iconButtonAssignamentTask.Text = "Asignar";
            iconButtonAssignamentTask.UseVisualStyleBackColor = true;
            iconButtonAssignamentTask.Click += iconButtonAssignamentTask_Click;
            // 
            // labelCodeProject
            // 
            labelCodeProject.AutoSize = true;
            labelCodeProject.BackColor = SystemColors.ActiveCaption;
            labelCodeProject.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCodeProject.ForeColor = Color.White;
            labelCodeProject.Location = new Point(817, 7);
            labelCodeProject.Name = "labelCodeProject";
            labelCodeProject.Size = new Size(70, 22);
            labelCodeProject.TabIndex = 18;
            labelCodeProject.Text = "u24123";
            // 
            // AssignamentTaskEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 650);
            Controls.Add(labelCodeProject);
            Controls.Add(iconButtonAssignamentTask);
            Controls.Add(dataGridViewAssignamentTasks);
            Controls.Add(labelUserAccount);
            Controls.Add(label6);
            Controls.Add(labelNameProject);
            Controls.Add(groupBoxDate);
            Controls.Add(groupBoxAssignamentTask);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AssignamentTaskEmployeeForm";
            Text = "AssignamentTaskEmployeeForm";
            Load += AssignamentTaskEmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssignamentTasks).EndInit();
            groupBoxDate.ResumeLayout(false);
            groupBoxDate.PerformLayout();
            groupBoxAssignamentTask.ResumeLayout(false);
            groupBoxAssignamentTask.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelEmployee;
        private TextBox textBoxTask;
        private Label labelTask;
        private Label labelNameProject;
        private Label label6;
        private Label labelUserAccount;
        private ComboBox comboBoxEmployee;
        private DataGridView dataGridViewAssignamentTasks;
        private DateTimePicker dateTimePickerEnd;
        private Label labelDateEnd;
        private GroupBox groupBoxDate;
        private GroupBox groupBoxAssignamentTask;
        private FontAwesome.Sharp.IconButton iconButtonAssignamentTask;
        private Label labelCodeProject;
    }
}