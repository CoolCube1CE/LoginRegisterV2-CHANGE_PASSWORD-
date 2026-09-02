namespace LoginRegisterV2
{
    partial class AdminPage
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
            buttonLogOutAdmin = new Button();
            labelloggedInExitAD = new Label();
            labelWelcomeUser = new Label();
            labelHelloUser = new Label();
            buttonChangePWAD = new Button();
            SuspendLayout();
            // 
            // buttonLogOutAdmin
            // 
            buttonLogOutAdmin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOutAdmin.Location = new Point(637, 419);
            buttonLogOutAdmin.Name = "buttonLogOutAdmin";
            buttonLogOutAdmin.Size = new Size(162, 63);
            buttonLogOutAdmin.TabIndex = 4;
            buttonLogOutAdmin.Text = "Log Out";
            buttonLogOutAdmin.UseVisualStyleBackColor = true;
            buttonLogOutAdmin.Click += buttonLogOutAdmin_Click;
            // 
            // labelloggedInExitAD
            // 
            labelloggedInExitAD.AutoSize = true;
            labelloggedInExitAD.Cursor = Cursors.Hand;
            labelloggedInExitAD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelloggedInExitAD.Location = new Point(1248, 9);
            labelloggedInExitAD.Name = "labelloggedInExitAD";
            labelloggedInExitAD.Size = new Size(20, 21);
            labelloggedInExitAD.TabIndex = 7;
            labelloggedInExitAD.Text = "X";
            labelloggedInExitAD.Click += labelloggedInExitAD_Click;
            // 
            // labelWelcomeUser
            // 
            labelWelcomeUser.AutoSize = true;
            labelWelcomeUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcomeUser.Location = new Point(507, 340);
            labelWelcomeUser.Name = "labelWelcomeUser";
            labelWelcomeUser.Size = new Size(175, 30);
            labelWelcomeUser.TabIndex = 9;
            labelWelcomeUser.Text = "Welcome Admin";
            // 
            // labelHelloUser
            // 
            labelHelloUser.AutoSize = true;
            labelHelloUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHelloUser.Location = new Point(441, 340);
            labelHelloUser.Name = "labelHelloUser";
            labelHelloUser.Size = new Size(78, 30);
            labelHelloUser.TabIndex = 8;
            labelHelloUser.Text = "Hello! ";
            // 
            // buttonChangePWAD
            // 
            buttonChangePWAD.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChangePWAD.Location = new Point(440, 419);
            buttonChangePWAD.Name = "buttonChangePWAD";
            buttonChangePWAD.Size = new Size(162, 63);
            buttonChangePWAD.TabIndex = 10;
            buttonChangePWAD.Text = "Change Password";
            buttonChangePWAD.UseVisualStyleBackColor = true;
            buttonChangePWAD.Click += buttonChangePWAD_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(buttonChangePWAD);
            Controls.Add(labelWelcomeUser);
            Controls.Add(labelHelloUser);
            Controls.Add(labelloggedInExitAD);
            Controls.Add(buttonLogOutAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPage";
            Text = "AdminPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLogOutAdmin;
        private Label labelloggedInExitAD;
        private Label labelWelcomeUser;
        private Label labelHelloUser;
        private Button buttonChangePWAD;
    }
}