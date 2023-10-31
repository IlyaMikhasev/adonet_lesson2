using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace adonet_lesson2
{
    public partial class Form1 : Form
    {
        DataSet set = new DataSet();
        SQLiteDataAdapter adpter;
        public Form1()
        {
            InitializeComponent();
        }

        private void b_connect_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = " Data Source = qqq.db3";
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            if (chb_add.Checked)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = $"insert into tmp{numericUpDown1}(id,tt) values (@id,@tt);";
                SQLiteParameter param1 = new SQLiteParameter();
                param1.ParameterName = "id";
                param1.Value = tb_id.Text;
                cmd.Parameters.Add(param1);
                SQLiteParameter param2 = new SQLiteParameter();
                param2.ParameterName = "tt";
                param2.Value = t_tt.Text;
                cmd.Parameters.Add(param2);
            }
            else
            {
                cmd.CommandText = "create table tmp0 (id int primary key, tt varchar(20)); " +
                    "create table tmp1 (id int primary key, tt varchar(20), na varchar(20)); " +
                    "create table tmp2 (id int primary key, tt varchar(20), no varchar(20)); " +
                    "create table tmp3 (id int primary key, tt varchar(20), nu varchar(20));";
            }
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void b_con2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = " Data Source = qqq.db3";
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tmp;";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) { 
                textBox1.Text = textBox1.Text + reader[0]+" " + reader[1] + "\r\n";
            }
            reader = null;
            conn.Close();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = " Data Source = qqq.db3";
            SQLiteCommand cmd = new SQLiteCommand();
            adpter = new SQLiteDataAdapter("select * from tmp0; "+"select * from tmp1; "+"select * from tmp2; "+"select * from tmp3;", conn);
            SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adpter);
            set = new DataSet();
            adpter.Fill(set);
            dataGridView1.DataSource= set.Tables[(int)numericUpDown1.Value];
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            adpter.Update(set);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = " Data Source = qqq.db3";
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT name FROM sqlite_master where type ='table'";
            SQLiteDataReader reader= cmd.ExecuteReader();
            for (int i = 0; reader.Read(); i++) {
                textBox1.Text += reader[0]+"\r\n";
                comboBox1.Items.Add(reader[0]);
            }           
            reader = null;
            conn.Close();
        }
    }
}
