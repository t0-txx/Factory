﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // ต้องนำเข้า database

namespace Factory
{
    public partial class Equipment : Form
    {
        //ประกาศตัวแปล
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Equipment()
        {
            InitializeComponent();
            connectDB();
            getEquipment();
        }
        public void connectDB()
        {
            //Computer มหาลัย
            //conn.ConnectionString = "Data Source=4924-F3;Initial Catalog=CScompany2567 ;Integrated Security=True;";

            //Computer หอ
            conn.ConnectionString = "Data Source=DESKTOP-LIDE7TR;Initial Catalog=Factory;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
        }

        public void getEquipment()
        {
            cmd.CommandText = "select * from Equipment";

            //ดึงข้อมูล มาใส่ใน adapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            //สร้าง table มารับข้อมูลใน adapter
            DataTable table = new DataTable();
            adapter.Fill(table);

            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns[0].HeaderText = "รหัส";
            dataGridView1.Columns[1].HeaderText = "หมายเลขประจำเครื่อง";
            dataGridView1.Columns[2].HeaderText = "ประเภท";
            dataGridView1.Columns[3].HeaderText = "เลขที่ใบนำเข้าอุปกรณ์";
            dataGridView1.Columns[4].HeaderText = "ราคา";
            dataGridView1.Columns[5].HeaderText = "วันที่เริ่มประกัน";
            dataGridView1.Columns[6].HeaderText = "วันที่สิ้นสุดประกัน";
            dataGridView1.Columns[7].HeaderText = "สถานะอุปกรณ์";
            dataGridView1.Columns[8].HeaderText = "รูป";
        }

        private void bNew_Click(object sender, EventArgs e)
        {

        }
    }
}
