using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMarket
{
    public partial class AEditForm : Form
    {
        public AEditForm(AdmForm af)
        {
            InitializeComponent();
            admForm = af;
        }
        AdmForm admForm;
        NpgsqlConnection conn;
        NpgsqlDataReader dr;
        NpgsqlCommand cmd;
        DataTable dt;
        string command;
        string connectionString;
        public int id;
        public int StaffID;
        public string tag;

        int idauto, idstaff, idcustomer;
        string staffconfirm;
        public void ConnectToDB()
        {
            connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=AutoMarketDB;";
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
        }
        private void AEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            admForm.Show();
        }

        void UpdateSale()
        {
            if (staffconfirm == "true")
            {
                ConnectToDB();
                command = $"update sale set staff_id = {StaffID}, staffconfirm = '{staffconfirm}' where id = {id}"; 
                cmd = new NpgsqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                ConnectToDB();
                command = $"update auto set state = 'Sold' where id = {idauto}";
                cmd = new NpgsqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if (staffconfirm == "false")
            {
                ConnectToDB();
                command = $"delete from sale where id = {id}";
                cmd = new NpgsqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                ConnectToDB();
                command = $"update auto set state = 'Sell' where id = {idauto}"; 
                cmd = new NpgsqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Success");
        }

        void DeleteSale()
        {
            ConnectToDB();
            command = $"delete from sale where id = {id}"; 
            cmd = new NpgsqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Success");
        }

        void ViewData(int id)
        {
            try
            {
                ConnectToDB();
                command = $"select auto_id from sale where id = {id}";
                cmd = new NpgsqlCommand(command, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idauto = reader.GetInt32(0);
                }
                conn.Close();
            }
            catch { }
            try
            {
                ConnectToDB();
                command = $"select customer_id from sale where id = {id}";
                cmd = new NpgsqlCommand(command, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idcustomer = reader.GetInt32(0);
                }
                conn.Close();
            }
            catch { }

            tbAuto.Text = $"{idauto}";
            tbCustomer.Text = $"{idcustomer}";
        }

        private void AEditForm_Load(object sender, EventArgs e)
        {
            if (tag == "update")
                ViewData(id);
            else if (tag == "delete")
            {
                ViewData(id);

                tbAuto.Enabled = false;
                tbCustomer.Enabled = false;
                cbFalse.Enabled = false;
                cbTrue.Enabled = false;
            }
        }

        private void cbTrue_CheckedChanged(object sender, EventArgs e)
        {
            cbTrue.Enabled = false;
            cbFalse.Enabled = true;
            staffconfirm = "true";
        }

        private void cbFalse_CheckedChanged(object sender, EventArgs e)
        {
            cbTrue.Enabled = true;
            cbFalse.Enabled = false;
            staffconfirm = "false";
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            if (tag == "update")
                UpdateSale();
            else if (tag == "delete")
                DeleteSale();

            this.Close();

            ConnectToDB();
            command = $"select * from {admForm.table}";
            admForm.SelectTable(command, admForm.dgvTable);
        }
    }
}
