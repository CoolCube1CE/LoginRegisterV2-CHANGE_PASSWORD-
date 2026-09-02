namespace LoginRegisterV2
{
    partial class ChangePasswordOTP
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
            buttonVerifyOTPChPW = new Button();
            textBoxOTPChPW = new TextBox();
            labelOTPChPW = new Label();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // buttonVerifyOTPChPW
            // 
            buttonVerifyOTPChPW.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVerifyOTPChPW.Location = new Point(180, 201);
            buttonVerifyOTPChPW.Name = "buttonVerifyOTPChPW";
            buttonVerifyOTPChPW.Size = new Size(139, 35);
            buttonVerifyOTPChPW.TabIndex = 5;
            buttonVerifyOTPChPW.Text = "Verify";
            buttonVerifyOTPChPW.UseVisualStyleBackColor = true;
            buttonVerifyOTPChPW.Click += buttonVerifyOTPChPW_Click;
            // 
            // textBoxOTPChPW
            // 
            textBoxOTPChPW.Location = new Point(134, 161);
            textBoxOTPChPW.Name = "textBoxOTPChPW";
            textBoxOTPChPW.Size = new Size(227, 23);
            textBoxOTPChPW.TabIndex = 4;
            // 
            // labelOTPChPW
            // 
            labelOTPChPW.AutoSize = true;
            labelOTPChPW.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOTPChPW.Location = new Point(93, 118);
            labelOTPChPW.Name = "labelOTPChPW";
            labelOTPChPW.Size = new Size(311, 25);
            labelOTPChPW.TabIndex = 3;
            labelOTPChPW.Text = "Enter the OTP sent to your e-mail:";
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(180, 257);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(139, 35);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // ChangePasswordOTP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 341);
            Controls.Add(buttonBack);
            Controls.Add(buttonVerifyOTPChPW);
            Controls.Add(textBoxOTPChPW);
            Controls.Add(labelOTPChPW);
            Name = "ChangePasswordOTP";
            Text = "ChangePasswordOTP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVerifyOTPChPW;
        private TextBox textBoxOTPChPW;
        private Label labelOTPChPW;
        private Button buttonBack;
    }
}