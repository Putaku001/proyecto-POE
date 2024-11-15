namespace PresentationLayer.Forms.Admin
{
    partial class InfoEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEmployeeForm));
            labelInfo = new Label();
            textBoxProfession = new TextBox();
            panelSaveInfo = new Panel();
            labelInfo2 = new Label();
            textBoxWorkStation = new TextBox();
            iconButtonSaveInfoAditional = new FontAwesome.Sharp.IconButton();
            panelSaveInfo.SuspendLayout();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            labelInfo.ForeColor = Color.White;
            labelInfo.Location = new Point(225, 27);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(78, 18);
            labelInfo.TabIndex = 3;
            labelInfo.Text = "Profesion:";
            // 
            // textBoxProfession
            // 
            textBoxProfession.Location = new Point(53, 50);
            textBoxProfession.Multiline = true;
            textBoxProfession.Name = "textBoxProfession";
            textBoxProfession.Size = new Size(397, 59);
            textBoxProfession.TabIndex = 4;
            // 
            // panelSaveInfo
            // 
            panelSaveInfo.BackColor = Color.MediumSpringGreen;
            panelSaveInfo.Controls.Add(iconButtonSaveInfoAditional);
            panelSaveInfo.Dock = DockStyle.Right;
            panelSaveInfo.Location = new Point(484, 0);
            panelSaveInfo.Name = "panelSaveInfo";
            panelSaveInfo.Size = new Size(225, 266);
            panelSaveInfo.TabIndex = 5;
            // 
            // labelInfo2
            // 
            labelInfo2.AutoSize = true;
            labelInfo2.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            labelInfo2.ForeColor = Color.White;
            labelInfo2.Location = new Point(180, 133);
            labelInfo2.Name = "labelInfo2";
            labelInfo2.Size = new Size(140, 18);
            labelInfo2.TabIndex = 6;
            labelInfo2.Text = "Puesto de trabajo:";
            // 
            // textBoxWorkStation
            // 
            textBoxWorkStation.Location = new Point(53, 156);
            textBoxWorkStation.Name = "textBoxWorkStation";
            textBoxWorkStation.Size = new Size(397, 26);
            textBoxWorkStation.TabIndex = 7;
            // 
            // iconButtonSaveInfoAditional
            // 
            iconButtonSaveInfoAditional.BackColor = Color.DarkGreen;
            iconButtonSaveInfoAditional.Cursor = Cursors.Hand;
            iconButtonSaveInfoAditional.FlatStyle = FlatStyle.Flat;
            iconButtonSaveInfoAditional.ForeColor = Color.White;
            iconButtonSaveInfoAditional.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonSaveInfoAditional.IconColor = Color.DarkTurquoise;
            iconButtonSaveInfoAditional.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSaveInfoAditional.Location = new Point(16, 112);
            iconButtonSaveInfoAditional.Name = "iconButtonSaveInfoAditional";
            iconButtonSaveInfoAditional.Size = new Size(197, 39);
            iconButtonSaveInfoAditional.TabIndex = 0;
            iconButtonSaveInfoAditional.Text = "Guardar";
            iconButtonSaveInfoAditional.UseVisualStyleBackColor = false;
            // 
            // InfoEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(709, 266);
            Controls.Add(labelInfo2);
            Controls.Add(textBoxWorkStation);
            Controls.Add(labelInfo);
            Controls.Add(textBoxProfession);
            Controls.Add(panelSaveInfo);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InfoEmployeeForm";
            Text = "Informacion";
            panelSaveInfo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
        private TextBox textBoxProfession;
        private Panel panelSaveInfo;
        private FontAwesome.Sharp.IconButton iconButtonSaveInfoAditional;
        private Label labelInfo2;
        private TextBox textBoxWorkStation;
    }
}