namespace AutoMarket
{
    partial class LoginForm
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
            label2 = new Label();
            label1 = new Label();
            tbPass = new TextBox();
            tbUN = new TextBox();
            btnLogin = new Button();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(70, 7);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(71, 75);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 8;
            label1.Text = "Password";
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Segoe UI", 15.75F);
            tbPass.Location = new Point(12, 103);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(210, 35);
            tbPass.TabIndex = 7;
            tbPass.Text = "mike";
            // 
            // tbUN
            // 
            tbUN.Font = new Font("Segoe UI", 15.75F);
            tbUN.Location = new Point(12, 35);
            tbUN.Name = "tbUN";
            tbUN.Size = new Size(210, 35);
            tbUN.TabIndex = 6;
            tbUN.Text = "mike";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(25, 148);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(91, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSignUp.Location = new Point(122, 148);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(91, 42);
            btnSignUp.TabIndex = 10;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 204);
            Controls.Add(btnSignUp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPass);
            Controls.Add(tbUN);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            Opacity = 0.9D;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox tbPass;
        private TextBox tbUN;
        private Button btnLogin;
        private Button btnSignUp;
    }
}