namespace PresentationLayer.Forms
{
    partial class VerificationForm
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
            verificationCodeTexBox = new TextBox();
            verifyButton = new Button();
            messageLabel = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // verificationCodeTexBox
            // 
            verificationCodeTexBox.Location = new Point(106, 133);
            verificationCodeTexBox.Name = "verificationCodeTexBox";
            verificationCodeTexBox.Size = new Size(129, 29);
            verificationCodeTexBox.TabIndex = 0;
            // 
            // verifyButton
            // 
            verifyButton.Location = new Point(134, 183);
            verifyButton.Name = "verifyButton";
            verifyButton.Size = new Size(75, 30);
            verifyButton.TabIndex = 1;
            verifyButton.Text = "Verificar";
            verifyButton.UseVisualStyleBackColor = true;
            verifyButton.Click += verifyButton_Click;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(6, 43);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(301, 34);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Se a enviado un codigo de 6 digitos a su numero \r\nde telefono\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(messageLabel);
            groupBox1.Controls.Add(verifyButton);
            groupBox1.Controls.Add(verificationCodeTexBox);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(222, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 230);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Se a enviado un codigo de Verificacion ";
            // 
            // VerificationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "VerificationForm";
            Text = "VerificationForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox verificationCodeTexBox;
        private Button verifyButton;
        private Label messageLabel;
        private GroupBox groupBox1;
    }
}