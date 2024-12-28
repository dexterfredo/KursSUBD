using Npgsql;
using System;
using System.Data;
namespace AutoMarket
{
    public partial class AdmForm : Form
    {
        public AdmForm(LoginForm lf)
        {
            InitializeComponent();
            loginForm = lf;
            loginForm.Hide();
        }
        LoginForm loginForm;
        public string username;
        public int idad;

        //NpgsqlConnectionStringBuilder cs;
        //NpgsqlTransaction transaction;
        NpgsqlConnection conn;
        NpgsqlDataReader dr;
        NpgsqlCommand cmd;
        DataTable dt;
        string command;
        string connectionString;
        string tag, namecol;
        public string table;
        int CurRow = 0;
        int id = 0;
        int Check = -1;
        bool bcheck = false;

        

        public void ConnectToDB()
        {
            connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=AutoMarketDB;";
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
        }

        public void SelectTable(string command, DataGridView dgv)
        {
            ConnectToDB();
            cmd = new NpgsqlCommand(command, conn);
            dt = new DataTable();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv.DataSource = dt;
        }

        private void AdmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        private void AdmForm_Load(object sender, EventArgs e)
        {

        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            table = cbTables.Text;
            ConnectToDB();
            command = $"select * from {table}";
            SelectTable(command, dgvTable);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            tag = "insert";
            AddCarForm aef = new AddCarForm(this);
            aef.Show();
            this.Hide();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Check = -1;
            try
            {
                Check = Convert.ToInt32(dgvTable.Rows[CurRow].Cells[2].Value);
            }
            catch { }
            tag = "update";
            if (table == "sale" && Check == -1)
            {
                AEditForm aef = new AEditForm(this);
                aef.id = id;
                aef.tag = tag;
                aef.StaffID = idad;
                aef.Show();
                this.Hide();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bcheck = false;
            try
            {
                bcheck = Convert.ToBoolean(dgvTable.Rows[CurRow].Cells[4].Value);
            }
            catch { }
            tag = "delete";
            if (table == "sale" && bcheck == false)
            {
                AEditForm aef = new AEditForm(this);
                aef.id = id;
                aef.tag = tag;
                aef.StaffID = idad;
                aef.Show();
                this.Hide();
            }
        }

        private void dgvTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTable.CurrentRow is not null)
            {
                CurRow = dgvTable.CurrentRow.Index;
                id = Convert.ToInt32(dgvTable.Rows[CurRow].Cells[0].Value.ToString());
            }
        }
    }
}
