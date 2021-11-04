using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKH
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-R5S76EL\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable();


        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dataGridView1.DataSource = table1;
        }

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            loadData();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NgayLap_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HoaDon values('" + tb_MaHD.Text + "','" + tb_MaKH.Text + "','" + tb_NgayLap.Text + "','" + tb_TongTien.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DataTable table2 = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select year(NgayLap) as Năm, month(NgayLap) as Tháng, sum(CONVERT(BIGINT, TongTien)) as TổngTiền from HoaDon group by year(NgayLap), month(NgayLap) order by year(NgayLap), month(NgayLap)";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dataGridView2.DataSource = table2;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tb_NgayLap_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
