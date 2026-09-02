namespace LoginRegisterV2
{
    partial class ChangePassword
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
            textBoxNewPW = new TextBox();
            textBoxChCPW = new TextBox();
            buttonChangePW = new Button();
            buttonBackChPW2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxNewPW
            // 
            textBoxNewPW.Location = new Point(171, 74);
            textBoxNewPW.Name = "textBoxNewPW";
            textBoxNewPW.Size = new Size(191, 23);
            textBoxNewPW.TabIndex = 0;
            // 
            // textBoxChCPW
            // 
            textBoxChCPW.Location = new Point(171, 113);
            textBoxChCPW.Name = "textBoxChCPW";
            textBoxChCPW.Size = new Size(191, 23);
            textBoxChCPW.TabIndex = 1;
            // 
            // buttonChangePW
            // 
            buttonChangePW.Location = new Point(161, 177);
            buttonChangePW.Name = "buttonChangePW";
            buttonChangePW.Size = new Size(128, 23);
            buttonChangePW.TabIndex = 2;
            buttonChangePW.Text = "Change Password";
            buttonChangePW.UseVisualStyleBackColor = true;
            buttonChangePW.Click += buttonChangePW_Click;
            // 
            // buttonBackChPW2
            // 
            buttonBackChPW2.Location = new Point(161, 206);
            buttonBackChPW2.Name = "buttonBackChPW2";
            buttonBackChPW2.Size = new Size(128, 23);
            buttonBackChPW2.TabIndex = 3;
            buttonBackChPW2.Text = "Back";
            buttonBackChPW2.UseVisualStyleBackColor = true;
            buttonBackChPW2.Click += buttonBackChPW2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 77);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 4;
            label1.Text = "New Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 113);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Confirm Password:";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 331);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBackChPW2);
            Controls.Add(buttonChangePW);
            Controls.Add(textBoxChCPW);
            Controls.Add(textBoxNewPW);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNewPW;
        private TextBox textBoxChCPW;
        private Button buttonChangePW;
        private Button buttonBackChPW2;
        private Label label1;
        private Label label2;
    }
}