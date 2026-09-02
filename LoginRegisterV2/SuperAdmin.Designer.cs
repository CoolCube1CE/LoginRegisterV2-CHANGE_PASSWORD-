namespace LoginRegisterV2
{
    partial class SuperAdmin
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
            buttonLogOutSuperAdmin = new Button();
            labelWelcomeUser = new Label();
            labelHelloUser = new Label();
            buttonChangePWSAD = new Button();
            labelloggedInExitSAD = new Label();
            SuspendLayout();
            // 
            // buttonLogOutSuperAdmin
            // 
            buttonLogOutSuperAdmin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOutSuperAdmin.Location = new Point(578, 424);
            buttonLogOutSuperAdmin.Name = "buttonLogOutSuperAdmin";
            buttonLogOutSuperAdmin.Size = new Size(162, 63);
            buttonLogOutSuperAdmin.TabIndex = 4;
            buttonLogOutSuperAdmin.Text = "Log Out";
            buttonLogOutSuperAdmin.UseVisualStyleBackColor = true;
            buttonLogOutSuperAdmin.Click += buttonLogOutSuperAdmin_Click;
            // 
            // labelWelcomeUser
            // 
            labelWelcomeUser.AutoSize = true;
            labelWelcomeUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcomeUser.Location = new Point(455, 293);
            labelWelcomeUser.Name = "labelWelcomeUser";
            labelWelcomeUser.Size = new Size(238, 30);
            labelWelcomeUser.TabIndex = 6;
            labelWelcomeUser.Text = "Welcome Super Admin";
            // 
            // labelHelloUser
            // 
            labelHelloUser.AutoSize = true;
            labelHelloUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHelloUser.Location = new Point(389, 293);
            labelHelloUser.Name = "labelHelloUser";
            labelHelloUser.Size = new Size(78, 30);
            labelHelloUser.TabIndex = 5;
            labelHelloUser.Text = "Hello! ";
            // 
            // buttonChangePWSAD
            // 
            buttonChangePWSAD.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChangePWSAD.Location = new Point(389, 424);
            buttonChangePWSAD.Name = "buttonChangePWSAD";
            buttonChangePWSAD.Size = new Size(162, 63);
            buttonChangePWSAD.TabIndex = 7;
            buttonChangePWSAD.Text = "Change Password";
            buttonChangePWSAD.UseVisualStyleBackColor = true;
            buttonChangePWSAD.Click += buttonChangePWSAD_Click;
            // 
            // labelloggedInExitSAD
            // 
            labelloggedInExitSAD.AutoSize = true;
            labelloggedInExitSAD.Cursor = Cursors.Hand;
            labelloggedInExitSAD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelloggedInExitSAD.Location = new Point(1248, 9);
            labelloggedInExitSAD.Name = "labelloggedInExitSAD";
            labelloggedInExitSAD.Size = new Size(20, 21);
            labelloggedInExitSAD.TabIndex = 8;
            labelloggedInExitSAD.Text = "X";
            labelloggedInExitSAD.Click += labelloggedInExitSAD_Click;
            // 
            // SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(labelloggedInExitSAD);
            Controls.Add(buttonChangePWSAD);
            Controls.Add(labelWelcomeUser);
            Controls.Add(labelHelloUser);
            Controls.Add(buttonLogOutSuperAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuperAdmin";
            Text = "SuperAdmin";
            Load += SuperAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLogOutSuperAdmin;
        private Label labelWelcomeUser;
        private Label labelHelloUser;
        private Button buttonChangePWSAD;
        private Label labelloggedInExitSAD;
    }
}