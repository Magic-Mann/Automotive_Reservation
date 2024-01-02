using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotiveReservation
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void rECORDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation rs = new Reservation();
            this.Hide();
            rs.Show();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListData ld = new ListData();
            this.Hide();
            ld.Show();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM reservation WHERE status = '1'";
            string query2 = "SELECT * FROM reservation WHERE status = '2' ";

            load(query, DGVCusNot);
            load(query2, DGVCusDone);
        }

        public void load(string query, DataGridView dgv)
        {
            dgv.Rows.Clear();

            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(DGVCusNot.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] { "ID", "Name", "Type", "Location", "Date " };


            dgv.ColumnCount = 5;

            for (int a = 0; a < columnNames.Length; a++)
            {
                dgv.Columns[a].Name = columnNames[a];
            }

            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);
            command.CommandTimeout = 60;

            try
            {
                connect.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
        }

    }
}
