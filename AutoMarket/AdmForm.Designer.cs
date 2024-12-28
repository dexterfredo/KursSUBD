namespace AutoMarket
{
    partial class AdmForm
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
            dgvTable = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cbTables = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            SuspendLayout();
            // 
            // dgvTable
            // 
            dgvTable.AllowUserToAddRows = false;
            dgvTable.AllowUserToDeleteRows = false;
            dgvTable.AllowUserToResizeColumns = false;
            dgvTable.AllowUserToResizeRows = false;
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new Point(12, 12);
            dgvTable.Name = "dgvTable";
            dgvTable.ReadOnly = true;
            dgvTable.Size = new Size(776, 296);
            dgvTable.TabIndex = 0;
            dgvTable.SelectionChanged += dgvTable_SelectionChanged;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 14.25F);
            btnInsert.Location = new Point(797, 12);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 86);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert Auto";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 14.25F);
            btnUpdate.Location = new Point(797, 104);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 86);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update sale";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F);
            btnDelete.Location = new Point(797, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 86);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete sale";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbTables
            // 
            cbTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTables.FormattingEnabled = true;
            cbTables.Items.AddRange(new object[] { "auto", "sale" });
            cbTables.Location = new Point(797, 288);
            cbTables.Name = "cbTables";
            cbTables.Size = new Size(121, 23);
            cbTables.TabIndex = 5;
            cbTables.SelectedIndexChanged += cbTables_SelectedIndexChanged;
            // 
            // AdmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 321);
            Controls.Add(cbTables);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvTable);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdmForm";
            Opacity = 0.9D;
            Text = "Admin";
            FormClosing += AdmForm_FormClosing;
            Load += AdmForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cbTables;
        public DataGridView dgvTable;
    }
}
