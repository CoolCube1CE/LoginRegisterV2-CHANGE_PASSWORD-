namespace LoginRegisterV2
{
    partial class OTPVerification
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
            labelOTPsent = new Label();
            textBoxOTP = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelOTPsent
            // 
            labelOTPsent.AutoSize = true;
            labelOTPsent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOTPsent.Location = new Point(59, 111);
            labelOTPsent.Name = "labelOTPsent";
            labelOTPsent.Size = new Size(311, 25);
            labelOTPsent.TabIndex = 0;
            labelOTPsent.Text = "Enter the OTP sent to your e-mail:";
            // 
            // textBoxOTP
            // 
            textBoxOTP.Location = new Point(100, 154);
            textBoxOTP.Name = "textBoxOTP";
            textBoxOTP.Size = new Size(227, 23);
            textBoxOTP.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(146, 209);
            button1.Name = "button1";
            button1.Size = new Size(139, 35);
            button1.TabIndex = 2;
            button1.Text = "Verify";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OTPVerification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 328);
            Controls.Add(button1);
            Controls.Add(textBoxOTP);
            Controls.Add(labelOTPsent);
            Name = "OTPVerification";
            Text = "OTPVerification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOTPsent;
        private TextBox textBoxOTP;
        private Button button1;
    }
}