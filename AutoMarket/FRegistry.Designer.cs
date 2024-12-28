namespace AutoMarket
{
    partial class FRegistry
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
            tbPassword = new TextBox();
            label5 = new Label();
            btnConfirm = new Button();
            tbUsername = new TextBox();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            tbPhone = new MaskedTextBox();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPassword.Location = new Point(12, 290);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(167, 33);
            tbPassword.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 266);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 19;
            label5.Text = "Password";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnConfirm.Location = new Point(12, 331);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(167, 37);
            btnConfirm.TabIndex = 18;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbUsername.Location = new Point(12, 230);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(167, 33);
            tbUsername.TabIndex = 17;
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbLastName.Location = new Point(12, 101);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(167, 33);
            tbLastName.TabIndex = 16;
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbFirstName.Location = new Point(12, 40);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(167, 33);
            tbFirstName.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 206);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 14;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 13;
            label2.Text = "Lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 12;
            label1.Text = "Firstname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 21;
            label4.Text = "Phone";
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPhone.Location = new Point(10, 161);
            tbPhone.Mask = "00000000000";
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(169, 33);
            tbPhone.TabIndex = 23;
            tbPhone.ValidatingType = typeof(int);
            // 
            // FRegistry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 380);
            Controls.Add(tbPhone);
            Controls.Add(label4);
            Controls.Add(tbPassword);
            Controls.Add(label5);
            Controls.Add(btnConfirm);
            Controls.Add(tbUsername);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FRegistry";
            Text = "Form Registry";
            FormClosing += FRegistry_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPassword;
        private Label label5;
        private Button btnConfirm;
        private TextBox tbUsername;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private MaskedTextBox tbPhone;
    }
}