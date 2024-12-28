using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMarket
{
    public partial class UserForm : Form
    {
        public UserForm(LoginForm lf)
        {
            InitializeComponent();
            loginForm = lf;
            loginForm.Hide();

        }

        DateTime date;
        public int iduser;
        LoginForm loginForm;
        NpgsqlConnection conn;
        NpgsqlDataReader dr;
        NpgsqlCommand cmd;
        DataTable dt;
        string command;
        string connectionString;
        public string username;
        int index, valueID, indexOwn, OwnValueID;

        string brand, model, engine, drive, transmission;
        int power, year, mileage, price;
        double capacity;
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

        void ViewOwnCars()
        {
            command = $"select a.id as Identifier, b.name as Brand, bm.name as Model, e.type as Engine, e.capacity as Capacity, e.power as Power, dr.type as Drive, tr.type as Transmission, ch.year as Year, a.mileage as Mileage from characteristic ch join brandmodel bm on bm.id = ch.model_id join engine e on e.id = ch.engine_id join drive dr on dr.id = drive_id join transmission tr on tr.id = transmission_id join brand b on b.id = bm.brand_id join auto a on a.characteristic_id = ch.id where a.id = any(select auto_id from sale where customer_id = {iduser} and staffconfirm = 'true')";
            SelectTable(command, dgvOwnCar);
            indexOwn = 0;
            if (dgvOwnCar.RowCount > 0)
            {
                OwnValueID = Convert.ToInt32(dgvOwnCar.Rows[indexOwn].Cells[0].Value.ToString());
                GetPhotoAuto(pictureBox2, OwnValueID);
            }
        }

        private void MoveRow(int direction)
        {
            if (dgvCars.CurrentCell == null) return;

            int currentRowIndex = dgvCars.CurrentCell.RowIndex;
            int newRowIndex = currentRowIndex + direction;

            // Проверка границ
            if (newRowIndex < 0 || newRowIndex >= dgvCars.Rows.Count)
                return;

            // Переключение строки
            dgvCars.CurrentCell = dgvCars.Rows[newRowIndex].Cells[0];
            index = newRowIndex;
            valueID = Convert.ToInt32(dgvCars.Rows[index].Cells[0].Value.ToString());
        }

        void ViewCars()
        {
            command = "select a.id, b.name as Brand, bm.name as Model, e.type as Engine, e.capacity as Capacity, e.power as Power, dr.type as Drive, tr.type as Transmission, ch.year as Year, a.mileage as Mileage, a.price as Price from characteristic ch join brandmodel bm on bm.id = ch.model_id join engine e on e.id = ch.engine_id join drive dr on dr.id = drive_id join transmission tr on tr.id = transmission_id join brand b on b.id = bm.brand_id join auto a on a.characteristic_id = ch.id where a.state = 'Sell'";
            SelectTable(command, dgvCars);
            index = 0;
            if (dgvCars.RowCount > 0)
                valueID = Convert.ToInt32(dgvCars.Rows[index].Cells[0].Value.ToString());
            ViewCarData(valueID);
        }

        void ViewCarData(int ID)
        {

            ConnectToDB();
            command = $"select b.name as Brand, bm.name as Model, e.type as Engine, e.capacity as Capacity, e.power as Power, dr.type as Drive, tr.type as Transmission, ch.year as Year, a.mileage as Mileage, a.price as Price from characteristic ch join brandmodel bm on bm.id = ch.model_id join engine e on e.id = ch.engine_id join drive dr on dr.id = drive_id join transmission tr on tr.id = transmission_id join brand b on b.id = bm.brand_id join auto a on a.characteristic_id = ch.id where a.state = 'Sell' and a.id = {ID}";
            cmd = new NpgsqlCommand(command, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                brand = reader.GetString(0);
                model = reader.GetString(1);
                engine = reader.GetString(2);
                capacity = reader.GetDouble(3);
                power = reader.GetInt32(4);
                drive = reader.GetString(5);
                transmission = reader.GetString(6);
                year = reader.GetInt32(7);
                mileage = reader.GetInt32(8);
                price = reader.GetInt32(9);
            }
            conn.Close();

            lbBrandModel.Text = $"{brand} {model}";
            lbEngine.Text = $"Engine: {engine}";
            lbCapacity.Text = $"Volume: {capacity} liters";
            lbPower.Text = $"Power: {power}hp";
            lbDrive.Text = $"Drive: {drive}";
            lbTransmission.Text = $"Transmission: {transmission}";
            lbYear.Text = $"Year: {year}";
            lbMileage.Text = $"Mileage: {mileage}";
            lbPrice.Text = $"Price: {price}";

            GetPhotoAuto(pictureBox1, valueID);

        }

        void GetPhotoAuto(PictureBox picture, int id)
        {
            picture.Image = null;
            connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=AutoMarketDB;";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            string sQL = $"SELECT photo from auto WHERE id = {id}";
            using (var command = new NpgsqlCommand(sQL, conn))
            {
                byte[] productImageByte = null;
                conn.Open();
                var rdr = command.ExecuteReader();
                if (rdr.Read())
                {
                    if (!rdr.IsDBNull(0))
                        productImageByte = (byte[])rdr[0];
                }
                rdr.Close();
                if (productImageByte != null)
                {
                    using (MemoryStream productImageStream = new MemoryStream(productImageByte))
                    {
                        ImageConverter imageConverter = new ImageConverter();
                        picture.Image = imageConverter.ConvertFrom(productImageByte) as Image;
                    }
                }
            }
            conn.Close();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.Text = username + " - Подключен";
            ViewCars();
            if (dgvCars.Rows.Count > 0)
                dgvCars.CurrentCell = dgvCars.Rows[0].Cells[0];
            ViewOwnCars();


        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveRow(1);
            ViewCarData(valueID);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveRow(-1);
            ViewCarData(valueID);
        }

        private void dgvCars_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow is not null)
            {
                index = dgvCars.CurrentRow.Index;
                valueID = Convert.ToInt32(dgvCars.Rows[index].Cells[0].Value.ToString());
                ViewCarData(valueID);
            }
        }

        bool BuyCar(int idauto, int iduser)
        {
            ConnectToDB();
            int check = 0;
            command = $"select 1 from sale where auto_id = {idauto} and customer_id = {iduser}";
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
                command = $"insert into sale (auto_id, customer_id) values ({idauto}, {iduser})";
                cmd = new NpgsqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
        }

        private void btnBuycar_Click(object sender, EventArgs e)
        {
            if (BuyCar(valueID, iduser))
                MessageBox.Show("Заказ оформлен!");
            else
                MessageBox.Show("Этот автомобиль уже оформлен. Ожидайте");
        }

        private void dgvOwnCar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOwnCar.CurrentRow is not null)
            {
                indexOwn = dgvOwnCar.CurrentRow.Index;
                OwnValueID = Convert.ToInt32(dgvOwnCar.Rows[indexOwn].Cells[0].Value.ToString());
                GetPhotoAuto(pictureBox2, OwnValueID);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0 || tabControl1.SelectedIndex == 1)
                btnBuycar.Visible = true;
            else if(tabControl1.SelectedIndex == 2)
                btnBuycar.Visible = false;
        }
    }
}
