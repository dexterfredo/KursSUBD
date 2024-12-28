namespace AutoMarket
{
    partial class UserForm
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
            pictureBox1 = new PictureBox();
            lbBrandModel = new Label();
            groupBox1 = new GroupBox();
            lbMileage = new Label();
            lbYear = new Label();
            lbTransmission = new Label();
            lbDrive = new Label();
            lbPower = new Label();
            lbCapacity = new Label();
            lbEngine = new Label();
            btnUp = new Button();
            btnDown = new Button();
            btnBuycar = new Button();
            groupBox2 = new GroupBox();
            lbPrice = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dgvCars = new DataGridView();
            tabPage3 = new TabPage();
            dgvOwnCar = new DataGridView();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOwnCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 339);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbBrandModel
            // 
            lbBrandModel.AutoSize = true;
            lbBrandModel.Location = new Point(20, 27);
            lbBrandModel.Name = "lbBrandModel";
            lbBrandModel.Size = new Size(16, 15);
            lbBrandModel.TabIndex = 2;
            lbBrandModel.Text = "...";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbMileage);
            groupBox1.Controls.Add(lbYear);
            groupBox1.Controls.Add(lbTransmission);
            groupBox1.Controls.Add(lbDrive);
            groupBox1.Controls.Add(lbPower);
            groupBox1.Controls.Add(lbCapacity);
            groupBox1.Controls.Add(lbEngine);
            groupBox1.Location = new Point(480, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 241);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Характеристики авто";
            // 
            // lbMileage
            // 
            lbMileage.AutoSize = true;
            lbMileage.Location = new Point(20, 204);
            lbMileage.Name = "lbMileage";
            lbMileage.Size = new Size(16, 15);
            lbMileage.TabIndex = 10;
            lbMileage.Text = "...";
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new Point(20, 174);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(16, 15);
            lbYear.TabIndex = 9;
            lbYear.Text = "...";
            // 
            // lbTransmission
            // 
            lbTransmission.AutoSize = true;
            lbTransmission.Location = new Point(20, 144);
            lbTransmission.Name = "lbTransmission";
            lbTransmission.Size = new Size(16, 15);
            lbTransmission.TabIndex = 8;
            lbTransmission.Text = "...";
            // 
            // lbDrive
            // 
            lbDrive.AutoSize = true;
            lbDrive.Location = new Point(20, 114);
            lbDrive.Name = "lbDrive";
            lbDrive.Size = new Size(16, 15);
            lbDrive.TabIndex = 7;
            lbDrive.Text = "...";
            // 
            // lbPower
            // 
            lbPower.AutoSize = true;
            lbPower.Location = new Point(20, 84);
            lbPower.Name = "lbPower";
            lbPower.Size = new Size(16, 15);
            lbPower.TabIndex = 6;
            lbPower.Text = "...";
            // 
            // lbCapacity
            // 
            lbCapacity.AutoSize = true;
            lbCapacity.Location = new Point(20, 54);
            lbCapacity.Name = "lbCapacity";
            lbCapacity.Size = new Size(16, 15);
            lbCapacity.TabIndex = 5;
            lbCapacity.Text = "...";
            // 
            // lbEngine
            // 
            lbEngine.AutoSize = true;
            lbEngine.Location = new Point(20, 24);
            lbEngine.Name = "lbEngine";
            lbEngine.Size = new Size(16, 15);
            lbEngine.TabIndex = 4;
            lbEngine.Text = "...";
            // 
            // btnUp
            // 
            btnUp.Location = new Point(6, 390);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(75, 23);
            btnUp.TabIndex = 4;
            btnUp.Text = "<-";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(87, 390);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(75, 23);
            btnDown.TabIndex = 5;
            btnDown.Text = "->";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // btnBuycar
            // 
            btnBuycar.Location = new Point(16, 513);
            btnBuycar.Name = "btnBuycar";
            btnBuycar.Size = new Size(750, 37);
            btnBuycar.TabIndex = 7;
            btnBuycar.Text = "Заказать";
            btnBuycar.UseVisualStyleBackColor = true;
            btnBuycar.Click += btnBuycar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbPrice);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(btnDown);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(btnUp);
            groupBox2.Controls.Add(lbBrandModel);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(688, 459);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Фото авто";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(500, 324);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(16, 15);
            lbPrice.TabIndex = 11;
            lbPrice.Text = "...";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(758, 499);
            tabControl1.TabIndex = 9;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(750, 471);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Выбор авто";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCars);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(750, 471);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Список авто";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AllowUserToResizeColumns = false;
            dgvCars.AllowUserToResizeRows = false;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(3, 3);
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.Size = new Size(738, 462);
            dgvCars.TabIndex = 0;
            dgvCars.SelectionChanged += dgvCars_SelectionChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvOwnCar);
            tabPage3.Controls.Add(pictureBox2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(750, 471);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Мои авто";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvOwnCar
            // 
            dgvOwnCar.AllowUserToAddRows = false;
            dgvOwnCar.AllowUserToDeleteRows = false;
            dgvOwnCar.AllowUserToResizeColumns = false;
            dgvOwnCar.AllowUserToResizeRows = false;
            dgvOwnCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOwnCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwnCar.Location = new Point(3, 348);
            dgvOwnCar.Name = "dgvOwnCar";
            dgvOwnCar.ReadOnly = true;
            dgvOwnCar.Size = new Size(744, 120);
            dgvOwnCar.TabIndex = 2;
            dgvOwnCar.SelectionChanged += dgvOwnCar_SelectionChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(137, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(468, 339);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 569);
            Controls.Add(tabControl1);
            Controls.Add(btnBuycar);
            Name = "UserForm";
            Text = "User";
            FormClosing += UserForm_FormClosing;
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOwnCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbBrandModel;
        private GroupBox groupBox1;
        private Label lbPower;
        private Label lbCapacity;
        private Label lbEngine;
        private Button btnUp;
        private Button btnDown;
        private Label lbTransmission;
        private Label lbDrive;
        private Button btnBuycar;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvCars;
        private Label lbMileage;
        private Label lbYear;
        private Label lbPrice;
        private TabPage tabPage3;
        private DataGridView dgvOwnCar;
        private PictureBox pictureBox2;
    }
}