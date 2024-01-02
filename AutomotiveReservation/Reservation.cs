using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutomotiveReservation
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            DTPDate.MinDate = DateTime.Now;
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListData ld = new ListData();
            this.Hide();
            ld.Show();
        }
        int id = 1;
        DateTime currentDate = DateTime.Now;


        

        private void Reservation_Load(object sender, EventArgs e)
        {
            string query = "SELECT count(*) from reservation";
            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);

            connect.Open();
            long rowCount = (long)command.ExecuteScalar();
            connect.Close();
            if (rowCount == 0)
            {
                LblID.Text = id.ToString();
            }
            else
            {
                string query2 = "SELECT customerId from reservation order by customerId desc limit 1;";
                MySqlConnection connect2 = new MySqlConnection(Connection.ConnectionString);
                MySqlCommand command2 = new MySqlCommand(query2, connect2);
                connect2.Open();
                id = (int)command2.ExecuteScalar();
                id += 1;
                LblID.Text = id.ToString();
                connect2.Close();
            }
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO reservation(customerId,name,type,location,datereserve,status) VALUES (" + LblID.Text + ",'" + TbxName.Text + "','" +CbxType.Text + "','" + CbxLocation.Text + "','" + DTPDate.Text + "','1')";
            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);
            command.CommandTimeout = 60;

            try
            {
                connect.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                }
                else
                {
                    MessageBox.Show("Successfully Reserved");
                    id++;
                    LblID.Text = id.ToString();
                    TbxName.Clear();
                    CbxType.ResetText();
                    CbxLocation.ResetText();
                    DTPDate.ResetText();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
        }

        private void rECORDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Records rs = new Records();
            this.Hide();
            rs.Show();
        }

        private void DTPDate_ValueChanged(object sender, EventArgs e)
        {
            if (DTPDate.Value < DateTime.Now)
            {
                DTPDate.Value = DateTime.Now;
            }
        }
    }
}
