using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoMarket
{
    public partial class FRegistry : Form
    {
        public FRegistry(LoginForm lf)
        {
            InitializeComponent();
            loginForm = lf;
        }
        LoginForm loginForm;
        NpgsqlConnection conn;
        NpgsqlDataReader dr;
        NpgsqlCommand cmd;
        DataTable dt;
        string command;
        string connectionString;
        string firstname, lastname, phone, username, password;

        bool CheckUser(string first, string last, string usern)
        {
            ConnectToDB();
            int check = 0;
            int check1 = 0;
            command = $"select 1 from customer where first_name = '{first}' and last_name = '{last}'";
            cmd = new NpgsqlCommand(command, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
                check = reader.GetInt32(0);
            conn.Close();
            if (check == 1)
                return false;
            else
            {
                ConnectToDB();
                command = $"select 1 from tuser where username = '{usern}'";
                cmd = new NpgsqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    check1 = reader.GetInt32(0);
                if (check1 == 1)
                    return false;
                else
                    return true;
            }
        }

        private void FRegistry_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }
        public void ConnectToDB()
        {
            connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=AutoMarketDB;";
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
        }

        void DelSpace(string input, out string output)
        {
            output = input.Replace(" ", "");

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                DelSpace(tbFirstName.Text.ToLower(), out firstname);
                DelSpace(tbFirstName.Text.ToLower(), out lastname);
                DelSpace(tbFirstName.Text.ToLower(), out phone);
                DelSpace(tbFirstName.Text.ToLower(), out username);
                DelSpace(tbFirstName.Text.ToLower(), out password);

                if (!string.IsNullOrWhiteSpace(firstname) &&
                    !string.IsNullOrWhiteSpace(lastname) &&
                    !string.IsNullOrWhiteSpace(phone) &&
                    !string.IsNullOrWhiteSpace(password))
                {


                    if (CheckUser(firstname,lastname,username))
                    {
                        ConnectToDB();
                        command = $"call AddCustomer('{firstname}', '{lastname}', '{phone}', '{username}', '{password}')";
                        cmd = new NpgsqlCommand(command, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();


                        if(!CheckUser(firstname,lastname,username))
                            MessageBox.Show("Пользователь добавлен!");
                    }
                }
                MessageBox.Show("Ошибка!");
            }
            catch {}
        }
    }
}
