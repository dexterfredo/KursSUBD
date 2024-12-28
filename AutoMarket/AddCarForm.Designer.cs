namespace AutoMarket
{
    partial class AddCarForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbTrans = new ComboBox();
            cbDrive = new ComboBox();
            cbModel = new ComboBox();
            label6 = new Label();
            cbTypeEngine = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbBrand = new ComboBox();
            btnConfirm = new Button();
            label10 = new Label();
            tbPower = new MaskedTextBox();
            tbYear = new MaskedTextBox();
            tbMileage = new MaskedTextBox();
            tbPrice = new MaskedTextBox();
            tbEngCapacity = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "Brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 261);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 6;
            label2.Text = "Drive";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 308);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 7;
            label3.Text = "Transmission";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 450);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 405);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 9;
            label5.Text = "Mileage";
            // 
            // cbTrans
            // 
            cbTrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrans.FormattingEnabled = true;
            cbTrans.Items.AddRange(new object[] { "Automatic", "Manual", "CVT", "Semi-Automatic" });
            cbTrans.Location = new Point(12, 326);
            cbTrans.Name = "cbTrans";
            cbTrans.Size = new Size(121, 23);
            cbTrans.TabIndex = 10;
            // 
            // cbDrive
            // 
            cbDrive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrive.FormattingEnabled = true;
            cbDrive.Items.AddRange(new object[] { "FWD", "RWD", "AWD", "4WD" });
            cbDrive.Location = new Point(12, 279);
            cbDrive.Name = "cbDrive";
            cbDrive.Size = new Size(121, 23);
            cbDrive.TabIndex = 11;
            // 
            // cbModel
            // 
            cbModel.FormattingEnabled = true;
            cbModel.Location = new Point(12, 88);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(121, 23);
            cbModel.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 70);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 13;
            label6.Text = "Model";
            // 
            // cbTypeEngine
            // 
            cbTypeEngine.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeEngine.FormattingEnabled = true;
            cbTypeEngine.Items.AddRange(new object[] { "Gasoline", "Diesel", "Electric", "Hybrid" });
            cbTypeEngine.Location = new Point(12, 142);
            cbTypeEngine.Name = "cbTypeEngine";
            cbTypeEngine.Size = new Size(121, 23);
            cbTypeEngine.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 124);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 15;
            label7.Text = "Type Engine";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 168);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 17;
            label8.Text = "Capacity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 217);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 19;
            label9.Text = "Power";
            // 
            // cbBrand
            // 
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(12, 40);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(121, 23);
            cbBrand.TabIndex = 21;
            cbBrand.SelectedIndexChanged += cbBrand_SelectedIndexChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(12, 510);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(121, 37);
            btnConfirm.TabIndex = 22;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 354);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 23;
            label10.Text = "Year";
            // 
            // tbPower
            // 
            tbPower.Location = new Point(12, 235);
            tbPower.Mask = "0000";
            tbPower.Name = "tbPower";
            tbPower.Size = new Size(121, 23);
            tbPower.TabIndex = 25;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(12, 372);
            tbYear.Mask = "0000";
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(121, 23);
            tbYear.TabIndex = 26;
            // 
            // tbMileage
            // 
            tbMileage.Location = new Point(12, 424);
            tbMileage.Mask = "0000000";
            tbMileage.Name = "tbMileage";
            tbMileage.Size = new Size(121, 23);
            tbMileage.TabIndex = 27;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(12, 468);
            tbPrice.Mask = "00000000";
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(121, 23);
            tbPrice.TabIndex = 28;
            tbPrice.ValidatingType = typeof(int);
            // 
            // tbEngCapacity
            // 
            tbEngCapacity.Location = new Point(12, 186);
            tbEngCapacity.Mask = "0.0";
            tbEngCapacity.Name = "tbEngCapacity";
            tbEngCapacity.Size = new Size(121, 23);
            tbEngCapacity.TabIndex = 30;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(156, 553);
            Controls.Add(tbEngCapacity);
            Controls.Add(tbPrice);
            Controls.Add(tbMileage);
            Controls.Add(tbYear);
            Controls.Add(tbPower);
            Controls.Add(label10);
            Controls.Add(btnConfirm);
            Controls.Add(cbBrand);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cbTypeEngine);
            Controls.Add(label6);
            Controls.Add(cbModel);
            Controls.Add(cbDrive);
            Controls.Add(cbTrans);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddCarForm";
            Text = "Add Car Form";
            FormClosing += AEditForm_FormClosing;
            Load += AEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbTrans;
        private ComboBox cbDrive;
        private ComboBox cbModel;
        private Label label6;
        private ComboBox cbTypeEngine;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbBrand;
        private Button btnConfirm;
        private Label label10;
        private MaskedTextBox tbPower;
        private MaskedTextBox tbYear;
        private MaskedTextBox tbMileage;
        private MaskedTextBox tbPrice;
        private MaskedTextBox tbEngCapacity;
    }
}