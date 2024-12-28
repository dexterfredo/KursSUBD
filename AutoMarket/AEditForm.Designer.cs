namespace AutoMarket
{
    partial class AEditForm
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
            cbTrue = new CheckBox();
            cbFalse = new CheckBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnConfirm = new Button();
            tbAuto = new MaskedTextBox();
            tbCustomer = new MaskedTextBox();
            SuspendLayout();
            // 
            // cbTrue
            // 
            cbTrue.AutoSize = true;
            cbTrue.Location = new Point(11, 131);
            cbTrue.Name = "cbTrue";
            cbTrue.Size = new Size(34, 19);
            cbTrue.TabIndex = 3;
            cbTrue.Text = "+";
            cbTrue.UseVisualStyleBackColor = true;
            cbTrue.CheckedChanged += cbTrue_CheckedChanged;
            // 
            // cbFalse
            // 
            cbFalse.AutoSize = true;
            cbFalse.Location = new Point(80, 131);
            cbFalse.Name = "cbFalse";
            cbFalse.Size = new Size(31, 19);
            cbFalse.TabIndex = 4;
            cbFalse.Text = "-";
            cbFalse.UseVisualStyleBackColor = true;
            cbFalse.CheckedChanged += cbFalse_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 5;
            label1.Text = "auto_id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 60);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "customer_id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 104);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "staffconfirm";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(11, 167);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(100, 23);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // tbAuto
            // 
            tbAuto.Location = new Point(11, 34);
            tbAuto.Mask = "000";
            tbAuto.Name = "tbAuto";
            tbAuto.Size = new Size(100, 23);
            tbAuto.TabIndex = 10;
            tbAuto.ValidatingType = typeof(int);
            // 
            // tbCustomer
            // 
            tbCustomer.Location = new Point(11, 78);
            tbCustomer.Mask = "000";
            tbCustomer.Name = "tbCustomer";
            tbCustomer.Size = new Size(100, 23);
            tbCustomer.TabIndex = 11;
            tbCustomer.ValidatingType = typeof(int);
            // 
            // AEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(129, 192);
            Controls.Add(tbCustomer);
            Controls.Add(tbAuto);
            Controls.Add(btnConfirm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbFalse);
            Controls.Add(cbTrue);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AEditForm";
            Text = "EditForm";
            FormClosing += AEditForm_FormClosing;
            Load += AEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbTrue;
        private CheckBox cbFalse;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnConfirm;
        private MaskedTextBox tbAuto;
        private MaskedTextBox tbCustomer;
    }
}