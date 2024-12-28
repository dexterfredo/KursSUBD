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
using static System.Windows.Forms.DataFormats;

namespace AutoMarket
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn;
        NpgsqlDataReader dr;
        NpgsqlCommand cmd;
        DataTable dt;
        string command;
        string connectionString;
        string username, password;

        public void ConnectToDB()
        {
            connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=AutoMarketDB;";
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
        }

        public void SelectTable(string command, DataGridView dgv)
        {
            cmd = new NpgsqlCommand(command, conn);
            dt = new DataTable();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv.DataSource = dt;
        }
        public void CheckUser(string username, string password)
        {
            ConnectToDB();
            int check = 0;
            command = $"select 1 from TUser where username = '{username}' and password = '{password}'";
            cmd = new NpgsqlCommand(command, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
                check = reader.GetInt32(0);
            conn.Close();
            if (check != 1)
                MessageBox.Show("This user isn`t registered in the DB");
            else
                CheckRole(username, password);
        }

        public void CheckRole(string username, string password)
        {
            ConnectToDB();

            UserForm uf = new UserForm(this);
            uf.username = username;
            AdmForm af = new AdmForm(this);
            string role = "";
            command = $"select role from TUser where username = '{username}' and password = '{password}'";
            cmd = new NpgsqlCommand(command, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
                role = reader.GetString(0);
            conn.Close();

            if (role == "user")
            {
                int idus = -1;
                ConnectToDB();
                command = $"select id from customer where username = '{username}'";
                cmd = new NpgsqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    idus = reader.GetInt32(0);
                conn.Close();
                if (idus != -1)
                    uf.iduser = idus;
                uf.Show();
            }
            else if (role == "admin")
            {
                int idad = -1;
                ConnectToDB();
                command = $"select id from staff where username = '{username}'";
                cmd = new NpgsqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    idad = reader.GetInt32(0);
                conn.Close();
                if (idad != -1)
                    af.idad = idad;
                af.Show();
            }
            else
                MessageBox.Show("This role isn`t registered in the DB");


        }

        void DelSpace(string input ,out string output)
        {
            output = input.Replace(" ", "");
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DelSpace(tbUN.Text.ToLower(), out username);
            DelSpace(tbPass.Text.ToLower(), out password);
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                CheckUser(username, password);
            }
            else
                MessageBox.Show("Ошибка авторизации");
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FRegistry fr = new FRegistry(this);
            fr.Show();
            this.Hide();
        }
    }
}
