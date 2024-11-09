namespace PresentationLayer.Forms
{
    partial class ChangePasswordForm
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
            newPasswordTexBox = new TextBox();
            confirmPasswordTexBox = new TextBox();
            changePasswordButton = new Button();
            MenuChangePassGroupBox = new GroupBox();
            NewPassLabel = new Label();
            label1 = new Label();
            MenuChangePassGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // newPasswordTexBox
            // 
            newPasswordTexBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordTexBox.Location = new Point(20, 67);
            newPasswordTexBox.Name = "newPasswordTexBox";
            newPasswordTexBox.Size = new Size(188, 23);
            newPasswordTexBox.TabIndex = 0;
            // 
            // confirmPasswordTexBox
            // 
            confirmPasswordTexBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTexBox.Location = new Point(20, 151);
            confirmPasswordTexBox.Name = "confirmPasswordTexBox";
            confirmPasswordTexBox.Size = new Size(188, 23);
            confirmPasswordTexBox.TabIndex = 1;
            // 
            // changePasswordButton
            // 
            changePasswordButton.Location = new Point(167, 214);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(75, 30);
            changePasswordButton.TabIndex = 2;
            changePasswordButton.Text = "Guardar";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // MenuChangePassGroupBox
            // 
            MenuChangePassGroupBox.Controls.Add(label1);
            MenuChangePassGroupBox.Controls.Add(changePasswordButton);
            MenuChangePassGroupBox.Controls.Add(NewPassLabel);
            MenuChangePassGroupBox.Controls.Add(newPasswordTexBox);
            MenuChangePassGroupBox.Controls.Add(confirmPasswordTexBox);
            MenuChangePassGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuChangePassGroupBox.Location = new Point(173, 62);
            MenuChangePassGroupBox.Name = "MenuChangePassGroupBox";
            MenuChangePassGroupBox.Size = new Size(417, 274);
            MenuChangePassGroupBox.TabIndex = 3;
            MenuChangePassGroupBox.TabStop = false;
            MenuChangePassGroupBox.Text = "Cambiar Contraseña";
            // 
            // NewPassLabel
            // 
            NewPassLabel.AutoSize = true;
            NewPassLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPassLabel.Location = new Point(20, 47);
            NewPassLabel.Name = "NewPassLabel";
            NewPassLabel.Size = new Size(170, 17);
            NewPassLabel.TabIndex = 1;
            NewPassLabel.Text = "Ingresar Nueva Contraseña:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 131);
            label1.Name = "label1";
            label1.Size = new Size(195, 17);
            label1.TabIndex = 2;
            label1.Text = "Vuelva a escribir la  Contraseña:\r\n";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuChangePassGroupBox);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            MenuChangePassGroupBox.ResumeLayout(false);
            MenuChangePassGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox newPasswordTexBox;
        private TextBox confirmPasswordTexBox;
        private Button changePasswordButton;
        private GroupBox MenuChangePassGroupBox;
        private Label label1;
        private Label NewPassLabel;
    }
}