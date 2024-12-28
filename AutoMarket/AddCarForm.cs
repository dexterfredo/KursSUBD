using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoMarket
{
    public partial class AddCarForm : Form
    {
        public AddCarForm(AdmForm af)
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
        int CheckBrand;
        int idbr, idmod, iden, iddr, idtr, idch;

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

        void InsBrandModel(string bran, string branmodel, out int idmodel)
        {
            idmodel = 0;
            ConnectToDB();
            command = $"insert into brand (name) values ( '{bran}')";
            cmd = new NpgsqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            idbr = 0;

            ConnectToDB();
            command = $"SELECT id FROM brand where name = '{bran}'";
            cmd = new NpgsqlCommand(command, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idbr = reader.GetInt32(0);
            }
            conn.Close();

            ConnectToDB();
            command = $"insert into brandmodel (name, brand_id) values ( '{branmodel}', {idbr})";
            cmd = new NpgsqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            ConnectToDB();
            command = $"SELECT id FROM brandmodel where name = '{branmodel}'";
            cmd = new NpgsqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idmodel = reader.GetInt32(0);
            }
            conn.Close();

        }

        void InsEngine(string typeen, string capacityen, int poweren, out int idengine)
        {
            idengine = 0;
            ConnectToDB();
            command = $"insert into engine (type, capacity, power) values ( '{typeen}', {capacityen}, {poweren})";
            cmd = new NpgsqlCommand(command, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            ConnectToDB();
            command = $"SELECT id FROM engine where type = '{typeen}' and capacity = {capacityen} and power = {poweren}";
            cmd = new NpgsqlCommand(command, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idengine = reader.GetInt32(0);
            }
            conn.Close();


        }


        void InsCharacteristic(int idmod, int iden, int iddr, int idtr, int year, out int idcharac)
        {
            idcharac = 0;
            int check = 0;
            ConnectToDB();
            command = $"SELECT 1 FROM characteristic where model_id = {idmod} and engine_id = {iden} and drive_id = {iddr} and transmission_id = {idtr} and year = {year}";
            cmd = new NpgsqlCommand(command, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                check = reader.GetInt32(0);
            }
            conn.Close();

            if (check == 1)
            {
                ConnectToDB();
                command = $"SELECT id FROM characteristic where model_id = {idmod} and engine_id = {iden} and drive_id = {iddr} and transmission_id = {idtr} and year = {year}";
                cmd = new NpgsqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idcharac = reader.GetInt32(0);
                }
                conn.Close();
            }
            else
            {
                ConnectToDB();
                command = $"insert into characteristic (model_id, engine_id, drive_id, transmission_id, year) values ( {idmod}, {iden}, {iddr}, {idtr}, {year})";
                cmd = new NpgsqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                ConnectToDB();
                command = $"SELECT id FROM characteristic where model_id = {idmod} and engine_id = {iden} and drive_id = {iddr} and transmission_id = {idtr} and year = {year}";
                cmd = new NpgsqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idcharac = reader.GetInt32(0);
                }
                conn.Close();
            }


        }

        void GiveInfo(string driv, out int iddrive, string trans, out int idtrans)
        {
            iddrive = 0;
            idtrans = 0;
            ConnectToDB();
            command = $"SELECT id FROM drive where type = '{driv}'";
            cmd = new NpgsqlCommand(command, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                iddrive = reader.GetInt32(0);
            }
            conn.Close();

            ConnectToDB();
            command = $"SELECT id FROM transmission where type = '{trans}'";
            cmd = new NpgsqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idtrans = reader.GetInt32(0);
            }
            conn.Close();
        }

        bool CheckEngine(string typ, string cap, int power)
        {

            int check = 0;
            ConnectToDB();
            command = $"SELECT 1 FROM engine where type = '{typ}' and capacity = {cap} and power = {power};";
            cmd = new NpgsqlCommand(command, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                check = reader.GetInt32(0);
            }
            conn.Close();

            if (check == 1)
            {
                iden = 0;
                ConnectToDB();
                command = $"SELECT id FROM engine where type = '{typ}' and capacity = {cap} and power = {power};";
                cmd = new NpgsqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    iden = reader.GetInt32(0);
                }
                conn.Close();
                return false;
            }
            else
                return true;
        }

        void InsertAuto(int idcharac, int mil, int price)
        {
            string path = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Profile car photo selection";
            if (openFileDialog.ShowDialog() == DialogResult.OK) { path = openFileDialog.FileName; }
            else
            {
                string DIR = Directory.GetCurrentDirectory();
                path = Path.Combine(DIR, @"null.jpg");
            }
            FileStream pgFileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader pgReader = new BinaryReader(new BufferedStream(pgFileStream));
            byte[] ImgByteA = pgReader.ReadBytes(Convert.ToInt32(pgFileStream.Length));
            var con = new NpgsqlConnection(connectionString);
            string sQL = "insert into auto (characteristic_id, mileage, price, photo) VALUES (@charact, @mile, @pric, @Image)";
            var com = new NpgsqlCommand(sQL, con);

            NpgsqlParameter param = com.CreateParameter();
            param.ParameterName = "@charact";
            param.Value = idcharac;
            com.Parameters.Add(param);
            param = com.CreateParameter();
            param.ParameterName = "@mile";
            param.Value = mil;
            com.Parameters.Add(param);
            param = com.CreateParameter();
            param.ParameterName = "@pric";
            param.Value = price;
            com.Parameters.Add(param);
            param = com.CreateParameter();
            param.ParameterName = "@Image";
            param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
            param.Value = ImgByteA;
            com.Parameters.Add(param);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }

        bool CheckBrandModel(string brand, string model)
        {
            int check = 0;
            ConnectToDB();
            command = $"SELECT 1 FROM brand where name = '{brand}'";
            cmd = new NpgsqlCommand(command, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                check = reader.GetInt32(0);
            }
            conn.Close();

            if (check == 1)
            {
                idbr = 0;
                ConnectToDB();
                command = $"SELECT id FROM brand where name = '{brand}'";
                cmd = new NpgsqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idbr = reader.GetInt32(0);
                }
                conn.Close();

                int check1 = 0;
                ConnectToDB();
                command = $"SELECT 1 FROM brandmodel where name = '{model}' and brand_id = (select id from brand where name = '{brand}')";
                cmd = new NpgsqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    check1 = reader.GetInt32(0);
                }
                conn.Close();

                if (check1 == 1)
                {
                    idmod = 0;
                    ConnectToDB();
                    command = $"SELECT id FROM brandmodel where name = '{model}' and brand_id = (select id from brand where name = '{brand}')";
                    cmd = new NpgsqlCommand(command, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        idmod = reader.GetInt32(0);
                    }
                    conn.Close();
                    return false;
                }
                else
                    return true;

            }
            else
            {
                return true;
            }
        }


        bool InsertData(string bran, string branmodel, string typeen, string capacityen, int poweren, string driv, string trans, int year, int mil, int pric)
        {
            try
            {
                if (CheckEngine(typeen, capacityen, poweren) && CheckBrandModel(bran, branmodel))
                {
                    InsBrandModel(bran, branmodel, out idmod);
                    InsEngine(typeen, capacityen, poweren, out iden);
                    GiveInfo(driv, out iddr, trans, out idtr);
                    InsCharacteristic(idmod, iden, iddr, idtr, year, out idch);
                    InsertAuto(idch, mil, pric);

                }
                else if (CheckEngine(typeen, capacityen, poweren) && !CheckBrandModel(bran, branmodel))
                {
                    InsEngine(typeen, capacityen, poweren, out iden);
                    GiveInfo(driv, out iddr, trans, out idtr);
                    InsCharacteristic(idmod, iden, iddr, idtr, year, out idch);
                    InsertAuto(idch, mil, pric);
                }
                else if (!CheckEngine(typeen, capacityen, poweren) && CheckBrandModel(bran, branmodel))
                {
                    InsBrandModel(bran, branmodel, out idmod);
                    GiveInfo(driv, out iddr, trans, out idtr);
                    InsCharacteristic(idmod, iden, iddr, idtr, year, out idch);
                    InsertAuto(idch, mil, pric);
                }
                else if (!CheckEngine(typeen, capacityen, poweren) && !CheckBrandModel(bran, branmodel))
                {
                    GiveInfo(driv, out iddr, trans, out idtr);
                    InsCharacteristic(idmod, iden, iddr, idtr, year, out idch);
                    InsertAuto(idch, mil, pric);
                }

                return true;
            }
            catch { return false; }

        }



        void ViewBrand()
        {

            cbBrand.Items.Clear();
            int i = 0;
            int count = 0;
            ConnectToDB();
            command = $"SELECT count(name) FROM brand;";
            cmd = new NpgsqlCommand(command, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                count = reader.GetInt32(0);
            }
            conn.Close();

            ConnectToDB();
            command = $"SELECT name FROM brand";
            cmd = new NpgsqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read() && i != count - 1)
            {
                cbBrand.Items.Add(reader.GetString(0));
                i++;
            }
            conn.Close();

            CheckBrand = 1;


        }

        void ViewModel(string brand)
        {

            if (cbBrand.Text != null && CheckBrand == 1)
            {
                cbModel.Items.Clear();
                int i = 0;
                int count = 0;
                ConnectToDB();
                command = $"SELECT count(name) FROM brandmodel where brand_id = (select id from brand where name = '{brand}')";
                cmd = new NpgsqlCommand(command, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count = reader.GetInt32(0);
                }
                conn.Close();

                ConnectToDB();
                command = $"SELECT name FROM brandmodel where brand_id = (select id from brand where name = '{brand}')";
                cmd = new NpgsqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read() && i != count)
                {
                    cbModel.Items.Add(reader.GetString(0));
                    i++;
                }
                conn.Close();



            }

        }



        private void AEditForm_Load(object sender, EventArgs e)
        {
            ViewBrand();
        }


        void DelSpace(string input, out string output)
        {
            output = input.Replace(" ", "");

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string brand, model, typeengine, capacity, drive, trans;
            try
            {
                DelSpace(cbBrand.Text, out brand); DelSpace(cbModel.Text, out model);
                DelSpace(cbTypeEngine.Text, out typeengine); DelSpace(tbEngCapacity.Text, out capacity);
                DelSpace(cbDrive.Text, out drive); DelSpace(cbTrans.Text, out trans);

                if (!string.IsNullOrWhiteSpace(brand) &&
                    !string.IsNullOrWhiteSpace(model) &&
                    !string.IsNullOrWhiteSpace(typeengine) &&
                    !string.IsNullOrWhiteSpace(capacity) &&
                    !string.IsNullOrWhiteSpace(drive) &&
                    !string.IsNullOrWhiteSpace(trans))
                {
                    if (capacity.Contains(','))
                        capacity = capacity.Replace(',', '.');
                    int power = Convert.ToInt32(tbPower.Text.Replace(" ", ""));
                    int year = Convert.ToInt32(tbYear.Text.Replace(" ", ""));
                    int mileage = Convert.ToInt32(tbMileage.Text.Replace(" ", ""));
                    int price = Convert.ToInt32(tbPrice.Text.Replace(" ", ""));

                    if (InsertData(brand, model, typeengine, capacity, power, drive, trans, year, mileage, price))
                    {
                        MessageBox.Show("Car was added!");
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Ошибка ввода");
            }
            catch { }
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModel.Text = null;
            cbModel.Items.Clear();
            ViewModel(cbBrand.Text);
        }
    }
}
