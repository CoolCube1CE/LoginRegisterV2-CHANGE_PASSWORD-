namespace LoginRegisterV2
{
    partial class RegisterPage
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
            labelregisterFN = new Label();
            labelBD = new Label();
            labelAdd = new Label();
            labelEM = new Label();
            labelNum = new Label();
            labelPW = new Label();
            labelCPW = new Label();
            labelAccess = new Label();
            textBoxFN = new TextBox();
            textBoxAdd = new TextBox();
            textBoxEM = new TextBox();
            textBoxNum = new TextBox();
            textBoxregisterPW = new TextBox();
            textBoxregisterCPW = new TextBox();
            dateTimeBirthDate = new DateTimePicker();
            labelinvalidFN = new Label();
            labelinvalidBD = new Label();
            labelinvalidAdd = new Label();
            labelinvalidEM = new Label();
            labelinvalidNum = new Label();
            labelinvalidPW = new Label();
            labelinvalidCPW = new Label();
            labelinvalidAcc = new Label();
            buttonregisterRegister = new Button();
            buttonregisterBack = new Button();
            labelregisterExit = new Label();
            comboBoxAcc = new ComboBox();
            buttonshowregPW = new Button();
            buttonhideregPW = new Button();
            buttonhideregCPW = new Button();
            buttonshowregCPW = new Button();
            labelLength = new Label();
            labelUpperc = new Label();
            labelLowerc = new Label();
            labelNumPW = new Label();
            labelSP = new Label();
            labelPWStrength = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // labelregisterFN
            // 
            labelregisterFN.AutoSize = true;
            labelregisterFN.Location = new Point(476, 47);
            labelregisterFN.Name = "labelregisterFN";
            labelregisterFN.Size = new Size(61, 15);
            labelregisterFN.TabIndex = 0;
            labelregisterFN.Text = "Full Name";
            // 
            // labelBD
            // 
            labelBD.AutoSize = true;
            labelBD.Location = new Point(478, 105);
            labelBD.Name = "labelBD";
            labelBD.Size = new Size(59, 15);
            labelBD.TabIndex = 1;
            labelBD.Text = "Birth Date";
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Location = new Point(488, 164);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(49, 15);
            labelAdd.TabIndex = 2;
            labelAdd.Text = "Address";
            // 
            // labelEM
            // 
            labelEM.AutoSize = true;
            labelEM.Location = new Point(451, 229);
            labelEM.Name = "labelEM";
            labelEM.Size = new Size(86, 15);
            labelEM.TabIndex = 3;
            labelEM.Text = "E-mail Address";
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Location = new Point(449, 292);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(88, 15);
            labelNum.TabIndex = 4;
            labelNum.Text = "Phone Number";
            // 
            // labelPW
            // 
            labelPW.AutoSize = true;
            labelPW.Location = new Point(476, 355);
            labelPW.Name = "labelPW";
            labelPW.Size = new Size(57, 15);
            labelPW.TabIndex = 5;
            labelPW.Text = "Password";
            // 
            // labelCPW
            // 
            labelCPW.AutoSize = true;
            labelCPW.Location = new Point(420, 488);
            labelCPW.Name = "labelCPW";
            labelCPW.Size = new Size(117, 15);
            labelCPW.TabIndex = 6;
            labelCPW.Text = "Confirmed Password";
            // 
            // labelAccess
            // 
            labelAccess.AutoSize = true;
            labelAccess.Location = new Point(470, 573);
            labelAccess.Name = "labelAccess";
            labelAccess.Size = new Size(71, 15);
            labelAccess.TabIndex = 7;
            labelAccess.Text = "Access Type";
            // 
            // textBoxFN
            // 
            textBoxFN.Location = new Point(541, 45);
            textBoxFN.Name = "textBoxFN";
            textBoxFN.Size = new Size(228, 23);
            textBoxFN.TabIndex = 8;
            // 
            // textBoxAdd
            // 
            textBoxAdd.Location = new Point(541, 154);
            textBoxAdd.Name = "textBoxAdd";
            textBoxAdd.Size = new Size(228, 23);
            textBoxAdd.TabIndex = 9;
            // 
            // textBoxEM
            // 
            textBoxEM.Location = new Point(541, 224);
            textBoxEM.Name = "textBoxEM";
            textBoxEM.Size = new Size(228, 23);
            textBoxEM.TabIndex = 10;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(541, 287);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(228, 23);
            textBoxNum.TabIndex = 11;
            // 
            // textBoxregisterPW
            // 
            textBoxregisterPW.Location = new Point(541, 353);
            textBoxregisterPW.Name = "textBoxregisterPW";
            textBoxregisterPW.PasswordChar = '*';
            textBoxregisterPW.Size = new Size(228, 23);
            textBoxregisterPW.TabIndex = 12;
            textBoxregisterPW.TextChanged += textBoxregisterPW_TextChanged;
            // 
            // textBoxregisterCPW
            // 
            textBoxregisterCPW.Location = new Point(541, 486);
            textBoxregisterCPW.Name = "textBoxregisterCPW";
            textBoxregisterCPW.PasswordChar = '*';
            textBoxregisterCPW.Size = new Size(228, 23);
            textBoxregisterCPW.TabIndex = 13;
            textBoxregisterCPW.TextChanged += textBoxregisterCPW_TextChanged;
            textBoxregisterCPW.KeyDown += textBoxregisterCPW_KeyDown;
            textBoxregisterCPW.MouseDown += textBoxregisterCPW_MouseDown;
            // 
            // dateTimeBirthDate
            // 
            dateTimeBirthDate.Location = new Point(541, 97);
            dateTimeBirthDate.Name = "dateTimeBirthDate";
            dateTimeBirthDate.Size = new Size(228, 23);
            dateTimeBirthDate.TabIndex = 15;
            // 
            // labelinvalidFN
            // 
            labelinvalidFN.AutoSize = true;
            labelinvalidFN.Font = new Font("Segoe UI", 8F);
            labelinvalidFN.ForeColor = Color.Red;
            labelinvalidFN.Location = new Point(541, 71);
            labelinvalidFN.Name = "labelinvalidFN";
            labelinvalidFN.Size = new Size(0, 13);
            labelinvalidFN.TabIndex = 16;
            // 
            // labelinvalidBD
            // 
            labelinvalidBD.AutoSize = true;
            labelinvalidBD.Font = new Font("Segoe UI", 8F);
            labelinvalidBD.ForeColor = Color.Red;
            labelinvalidBD.Location = new Point(541, 123);
            labelinvalidBD.Name = "labelinvalidBD";
            labelinvalidBD.Size = new Size(0, 13);
            labelinvalidBD.TabIndex = 17;
            // 
            // labelinvalidAdd
            // 
            labelinvalidAdd.AutoSize = true;
            labelinvalidAdd.Font = new Font("Segoe UI", 8F);
            labelinvalidAdd.ForeColor = Color.Red;
            labelinvalidAdd.Location = new Point(541, 180);
            labelinvalidAdd.Name = "labelinvalidAdd";
            labelinvalidAdd.Size = new Size(0, 13);
            labelinvalidAdd.TabIndex = 18;
            // 
            // labelinvalidEM
            // 
            labelinvalidEM.AutoSize = true;
            labelinvalidEM.Font = new Font("Segoe UI", 8F);
            labelinvalidEM.ForeColor = Color.Red;
            labelinvalidEM.Location = new Point(541, 250);
            labelinvalidEM.Name = "labelinvalidEM";
            labelinvalidEM.Size = new Size(0, 13);
            labelinvalidEM.TabIndex = 19;
            // 
            // labelinvalidNum
            // 
            labelinvalidNum.AutoSize = true;
            labelinvalidNum.Font = new Font("Segoe UI", 8F);
            labelinvalidNum.ForeColor = Color.Red;
            labelinvalidNum.Location = new Point(541, 313);
            labelinvalidNum.Name = "labelinvalidNum";
            labelinvalidNum.Size = new Size(0, 13);
            labelinvalidNum.TabIndex = 20;
            // 
            // labelinvalidPW
            // 
            labelinvalidPW.AutoSize = true;
            labelinvalidPW.Font = new Font("Segoe UI", 8F);
            labelinvalidPW.ForeColor = Color.Black;
            labelinvalidPW.Location = new Point(541, 379);
            labelinvalidPW.Name = "labelinvalidPW";
            labelinvalidPW.Size = new Size(133, 13);
            labelinvalidPW.TabIndex = 21;
            labelinvalidPW.Text = "Password Requirements:";
            // 
            // labelinvalidCPW
            // 
            labelinvalidCPW.AutoSize = true;
            labelinvalidCPW.Font = new Font("Segoe UI", 8F);
            labelinvalidCPW.ForeColor = Color.Red;
            labelinvalidCPW.Location = new Point(541, 512);
            labelinvalidCPW.Name = "labelinvalidCPW";
            labelinvalidCPW.Size = new Size(0, 13);
            labelinvalidCPW.TabIndex = 22;
            // 
            // labelinvalidAcc
            // 
            labelinvalidAcc.AutoSize = true;
            labelinvalidAcc.Font = new Font("Segoe UI", 8F);
            labelinvalidAcc.ForeColor = Color.Red;
            labelinvalidAcc.Location = new Point(549, 594);
            labelinvalidAcc.Name = "labelinvalidAcc";
            labelinvalidAcc.Size = new Size(0, 13);
            labelinvalidAcc.TabIndex = 23;
            // 
            // buttonregisterRegister
            // 
            buttonregisterRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonregisterRegister.Location = new Point(561, 646);
            buttonregisterRegister.Name = "buttonregisterRegister";
            buttonregisterRegister.Size = new Size(165, 36);
            buttonregisterRegister.TabIndex = 24;
            buttonregisterRegister.Text = "Register";
            buttonregisterRegister.UseVisualStyleBackColor = true;
            buttonregisterRegister.Click += buttonregisterRegister_Click;
            // 
            // buttonregisterBack
            // 
            buttonregisterBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonregisterBack.Location = new Point(428, 17);
            buttonregisterBack.Name = "buttonregisterBack";
            buttonregisterBack.Size = new Size(75, 23);
            buttonregisterBack.TabIndex = 25;
            buttonregisterBack.Text = "Back";
            buttonregisterBack.UseVisualStyleBackColor = true;
            buttonregisterBack.Click += buttonregisterBack_Click;
            // 
            // labelregisterExit
            // 
            labelregisterExit.AutoSize = true;
            labelregisterExit.Cursor = Cursors.Hand;
            labelregisterExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelregisterExit.Location = new Point(1248, 16);
            labelregisterExit.Name = "labelregisterExit";
            labelregisterExit.Size = new Size(20, 21);
            labelregisterExit.TabIndex = 26;
            labelregisterExit.Text = "X";
            labelregisterExit.Click += labelregisterExit_Click;
            // 
            // comboBoxAcc
            // 
            comboBoxAcc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxAcc.FormattingEnabled = true;
            comboBoxAcc.Items.AddRange(new object[] { "Super Admin", "Admin", "User" });
            comboBoxAcc.Location = new Point(549, 570);
            comboBoxAcc.Name = "comboBoxAcc";
            comboBoxAcc.Size = new Size(228, 23);
            comboBoxAcc.TabIndex = 27;
            comboBoxAcc.Text = "Choose Access Type";
            // 
            // buttonshowregPW
            // 
            buttonshowregPW.BackColor = Color.White;
            buttonshowregPW.FlatStyle = FlatStyle.Flat;
            buttonshowregPW.Image = Properties.Resources.pngwing_com25open;
            buttonshowregPW.Location = new Point(775, 353);
            buttonshowregPW.Name = "buttonshowregPW";
            buttonshowregPW.Size = new Size(30, 21);
            buttonshowregPW.TabIndex = 30;
            buttonshowregPW.UseVisualStyleBackColor = false;
            buttonshowregPW.Click += buttonshowregPW_Click;
            // 
            // buttonhideregPW
            // 
            buttonhideregPW.BackColor = Color.White;
            buttonhideregPW.FlatStyle = FlatStyle.Flat;
            buttonhideregPW.Image = Properties.Resources.pngwing_com25close;
            buttonhideregPW.Location = new Point(775, 353);
            buttonhideregPW.Name = "buttonhideregPW";
            buttonhideregPW.Size = new Size(30, 21);
            buttonhideregPW.TabIndex = 31;
            buttonhideregPW.UseVisualStyleBackColor = false;
            buttonhideregPW.Click += buttonhideregPW_Click;
            // 
            // buttonhideregCPW
            // 
            buttonhideregCPW.BackColor = Color.White;
            buttonhideregCPW.FlatStyle = FlatStyle.Flat;
            buttonhideregCPW.Image = Properties.Resources.pngwing_com25close;
            buttonhideregCPW.Location = new Point(775, 488);
            buttonhideregCPW.Name = "buttonhideregCPW";
            buttonhideregCPW.Size = new Size(30, 21);
            buttonhideregCPW.TabIndex = 33;
            buttonhideregCPW.UseVisualStyleBackColor = false;
            buttonhideregCPW.Click += buttonhideregCPW_Click;
            // 
            // buttonshowregCPW
            // 
            buttonshowregCPW.BackColor = Color.White;
            buttonshowregCPW.FlatStyle = FlatStyle.Flat;
            buttonshowregCPW.Image = Properties.Resources.pngwing_com25open;
            buttonshowregCPW.Location = new Point(775, 488);
            buttonshowregCPW.Name = "buttonshowregCPW";
            buttonshowregCPW.Size = new Size(30, 21);
            buttonshowregCPW.TabIndex = 32;
            buttonshowregCPW.UseVisualStyleBackColor = false;
            buttonshowregCPW.Click += buttonshowregCPW_Click;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(541, 392);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(87, 15);
            labelLength.TabIndex = 34;
            labelLength.Text = "8-16 characters";
            // 
            // labelUpperc
            // 
            labelUpperc.AutoSize = true;
            labelUpperc.Location = new Point(541, 407);
            labelUpperc.Name = "labelUpperc";
            labelUpperc.Size = new Size(91, 15);
            labelUpperc.TabIndex = 35;
            labelUpperc.Text = "uppercase letter";
            // 
            // labelLowerc
            // 
            labelLowerc.AutoSize = true;
            labelLowerc.Location = new Point(541, 422);
            labelLowerc.Name = "labelLowerc";
            labelLowerc.Size = new Size(89, 15);
            labelLowerc.TabIndex = 36;
            labelLowerc.Text = "lowercase letter";
            // 
            // labelNumPW
            // 
            labelNumPW.AutoSize = true;
            labelNumPW.Location = new Point(541, 437);
            labelNumPW.Name = "labelNumPW";
            labelNumPW.Size = new Size(49, 15);
            labelNumPW.TabIndex = 37;
            labelNumPW.Text = "number";
            // 
            // labelSP
            // 
            labelSP.AutoSize = true;
            labelSP.Location = new Point(541, 452);
            labelSP.Name = "labelSP";
            labelSP.Size = new Size(95, 15);
            labelSP.TabIndex = 38;
            labelSP.Text = "special character";
            // 
            // labelPWStrength
            // 
            labelPWStrength.AutoSize = true;
            labelPWStrength.Location = new Point(811, 356);
            labelPWStrength.Name = "labelPWStrength";
            labelPWStrength.Size = new Size(0, 15);
            labelPWStrength.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(407, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 684);
            panel1.TabIndex = 40;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(labelSP);
            Controls.Add(labelNumPW);
            Controls.Add(labelLowerc);
            Controls.Add(labelUpperc);
            Controls.Add(labelLength);
            Controls.Add(buttonshowregCPW);
            Controls.Add(buttonhideregCPW);
            Controls.Add(buttonshowregPW);
            Controls.Add(buttonhideregPW);
            Controls.Add(comboBoxAcc);
            Controls.Add(buttonregisterBack);
            Controls.Add(buttonregisterRegister);
            Controls.Add(labelinvalidAcc);
            Controls.Add(labelinvalidCPW);
            Controls.Add(labelinvalidPW);
            Controls.Add(labelinvalidNum);
            Controls.Add(labelinvalidEM);
            Controls.Add(labelinvalidAdd);
            Controls.Add(labelinvalidBD);
            Controls.Add(labelinvalidFN);
            Controls.Add(dateTimeBirthDate);
            Controls.Add(textBoxregisterCPW);
            Controls.Add(textBoxregisterPW);
            Controls.Add(textBoxNum);
            Controls.Add(textBoxEM);
            Controls.Add(textBoxAdd);
            Controls.Add(textBoxFN);
            Controls.Add(labelAccess);
            Controls.Add(labelCPW);
            Controls.Add(labelPW);
            Controls.Add(labelNum);
            Controls.Add(labelEM);
            Controls.Add(labelAdd);
            Controls.Add(labelBD);
            Controls.Add(labelregisterFN);
            Controls.Add(panel1);
            Controls.Add(labelPWStrength);
            Controls.Add(labelregisterExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += RegisterPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelregisterFN;
        private Label labelBD;
        private Label labelAdd;
        private Label labelEM;
        private Label labelNum;
        private Label labelPW;
        private Label labelCPW;
        private Label labelAccess;
        private TextBox textBoxFN;
        private TextBox textBoxAdd;
        private TextBox textBoxEM;
        private TextBox textBoxNum;
        private TextBox textBoxregisterPW;
        private TextBox textBoxregisterCPW;
        private DateTimePicker dateTimeBirthDate;
        private Label labelinvalidFN;
        private Label labelinvalidBD;
        private Label labelinvalidAdd;
        private Label labelinvalidEM;
        private Label labelinvalidNum;
        private Label labelinvalidPW;
        private Label labelinvalidCPW;
        private Label labelinvalidAcc;
        private Button buttonregisterRegister;
        private Button buttonregisterBack;
        private Label labelregisterExit;
        private ComboBox comboBoxAcc;
        private Button buttonshowregPW;
        private Button buttonhideregPW;
        private Button buttonhideregCPW;
        private Button buttonshowregCPW;
        private Label labelLength;
        private Label labelUpperc;
        private Label labelLowerc;
        private Label labelNumPW;
        private Label labelSP;
        private Label labelPWStrength;
        private Panel panel1;
    }
}