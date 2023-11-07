namespace LTTQ_Proj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDangNhap = new Label();
            groupBoxDangNhap = new GroupBox();
            buttonLoginExit = new Button();
            buttonLoginSubmit = new Button();
            inputLoginUsername = new TextBox();
            labelInputPassword = new Label();
            labelInputUsername = new Label();
            inputLoginPassword = new TextBox();
            groupBoxDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // labelDangNhap
            // 
            labelDangNhap.AutoSize = true;
            labelDangNhap.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDangNhap.Location = new Point(175, 47);
            labelDangNhap.Name = "labelDangNhap";
            labelDangNhap.Size = new Size(148, 37);
            labelDangNhap.TabIndex = 0;
            labelDangNhap.Text = "Đăng nhập";
            labelDangNhap.Click += label1_Click;
            // 
            // groupBoxDangNhap
            // 
            groupBoxDangNhap.BackColor = SystemColors.ButtonHighlight;
            groupBoxDangNhap.Controls.Add(buttonLoginExit);
            groupBoxDangNhap.Controls.Add(buttonLoginSubmit);
            groupBoxDangNhap.Controls.Add(inputLoginPassword);
            groupBoxDangNhap.Controls.Add(inputLoginUsername);
            groupBoxDangNhap.Controls.Add(labelInputPassword);
            groupBoxDangNhap.Controls.Add(labelInputUsername);
            groupBoxDangNhap.Controls.Add(labelDangNhap);
            groupBoxDangNhap.Location = new Point(165, 50);
            groupBoxDangNhap.Name = "groupBoxDangNhap";
            groupBoxDangNhap.Size = new Size(482, 322);
            groupBoxDangNhap.TabIndex = 1;
            groupBoxDangNhap.TabStop = false;
            // 
            // buttonLoginExit
            // 
            buttonLoginExit.Location = new Point(269, 238);
            buttonLoginExit.Name = "buttonLoginExit";
            buttonLoginExit.Size = new Size(93, 35);
            buttonLoginExit.TabIndex = 3;
            buttonLoginExit.Text = "Thoát";
            buttonLoginExit.UseVisualStyleBackColor = true;
            buttonLoginExit.Click += buttonLoginExit_Click;
            // 
            // buttonLoginSubmit
            // 
            buttonLoginSubmit.Location = new Point(113, 238);
            buttonLoginSubmit.Name = "buttonLoginSubmit";
            buttonLoginSubmit.Size = new Size(93, 35);
            buttonLoginSubmit.TabIndex = 3;
            buttonLoginSubmit.Text = "Đăng nhập";
            buttonLoginSubmit.UseVisualStyleBackColor = true;
            buttonLoginSubmit.Click += buttonLoginSubmit_Click;
            // 
            // inputLoginUsername
            // 
            inputLoginUsername.Location = new Point(234, 113);
            inputLoginUsername.Name = "inputLoginUsername";
            inputLoginUsername.Size = new Size(195, 23);
            inputLoginUsername.TabIndex = 2;
            // 
            // labelInputPassword
            // 
            labelInputPassword.AutoSize = true;
            labelInputPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInputPassword.Location = new Point(78, 161);
            labelInputPassword.Name = "labelInputPassword";
            labelInputPassword.Size = new Size(75, 21);
            labelInputPassword.TabIndex = 1;
            labelInputPassword.Text = "Mật khẩu";
            // 
            // labelInputUsername
            // 
            labelInputUsername.AutoSize = true;
            labelInputUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInputUsername.Location = new Point(78, 111);
            labelInputUsername.Name = "labelInputUsername";
            labelInputUsername.Size = new Size(111, 21);
            labelInputUsername.TabIndex = 1;
            labelInputUsername.Text = "Tên đăng nhập";
            // 
            // inputLoginPassword
            // 
            inputLoginPassword.Location = new Point(234, 159);
            inputLoginPassword.Name = "inputLoginPassword";
            inputLoginPassword.PasswordChar = '*';
            inputLoginPassword.Size = new Size(195, 23);
            inputLoginPassword.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxDangNhap);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxDangNhap.ResumeLayout(false);
            groupBoxDangNhap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelDangNhap;
        private GroupBox groupBoxDangNhap;
        private Label labelInputPassword;
        private Label labelInputUsername;
        private Button buttonLoginExit;
        private Button buttonLoginSubmit;
        private TextBox inputLoginUsername;
        private TextBox inputLoginPassword;
    }
}