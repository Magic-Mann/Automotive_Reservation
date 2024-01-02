using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutomotiveReservation
{
    public partial class ListData : Form
    {
        public ListData()
        {
            InitializeComponent();
            DTPDate.MinDate = DateTime.Now;

        }
        DateTime currentDate = DateTime.Now;

        public void load()
        {

            DGVlist.Rows.Clear();

            DGVlist.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(DGVlist.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] { "ID", "Name", "Type", "Location", "Date " };

            DGVlist.ColumnCount = 5;

            for (int a = 0; a < columnNames.Length; a++)
            {
                DGVlist.Columns[a].Name = columnNames[a];
            }

            string query = "SELECT * FROM reservation WHERE status = '1'";
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

                        DGVlist.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
            finally
            {
                connect.Close();
            }

        }

        private void ListData_Load(object sender, EventArgs e)
        {
            load();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            string query = "UPDATE reservation SET status = '0' WHERE customerId = " + Connection.IdContent;
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
                    LblID.Text = "0";
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
            finally
            {
                connect.Close();
                load();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE reservation SET name = '"+TbxName.Text + "', type = '" + CbxType.Text + "', location = '"+ CbxLocation.Text + "', datereserve = '" + DTPDate.Text +  "' WHERE customerId = " + Connection.IdContent + "";
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
                    LblID.Text = "0";
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
            finally
            {
                connect.Close();
                load();
            }
        }

        private void DGVlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrow;
                selectedrow = e.RowIndex;
                DataGridViewRow row = DGVlist.Rows[selectedrow];

                Connection.IdContent = row.Cells[0].Value.ToString();


                string query = "SELECT * FROM reservation WHERE customerId = '" + Connection.IdContent + "'";

                using (MySqlConnection connect = new MySqlConnection(Connection.ConnectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connect))
                    {
                        command.CommandTimeout = 60;

                        try
                        {
                            connect.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        LblID.Text = reader.GetString(0);
                                        TbxName.Text = reader.GetString(1);
                                        CbxType.Text = reader.GetString(2);
                                        CbxLocation.Text = reader.GetString(3);
                                        DTPDate.Text = reader.GetString(4);
                                    }
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
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            string query = "UPDATE reservation SET status = '2' WHERE customerId = " + Connection.IdContent;
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
                    LblID.Text = "0";
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
            finally
            {
                connect.Close();
                load();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Reservation rs = new Reservation();
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
