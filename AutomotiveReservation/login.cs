using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotiveReservation
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TbxUsername.Text == "Username" || TbxPassword.Text == "Password")
            {
                MessageBox.Show("Please enter your username and password to log in", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string username = TbxUsername.Text;
                string password = TbxPassword.Text;

                string hashedPassword = HashPassword(password);

                string query = "SELECT * FROM login WHERE username = '" + username + "'";

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
                            string pass = reader.GetString(1);

                            if (pass == hashedPassword && username == reader.GetString(0))
                            {
                                Reservation reserve = new Reservation();
                                this.Hide();
                                reserve.Show();
                            }
                            else
                            {
                                MessageBox.Show("Account does not exist. Check the username and password and try again.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account does not exist. Check the username and password and try again.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show("Query error: " + x.Message);
                }
            }

        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a hexadecimal string
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
