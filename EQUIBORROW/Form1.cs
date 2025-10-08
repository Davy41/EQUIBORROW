using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQUIBORROW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Use connection string from configuration
        string constr = ConfigurationManager.ConnectionStrings["EquiBorrowDb"].ConnectionString;

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailBox.Text) || string.IsNullOrEmpty(pwdBox.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Boss, Username, Password, and Role can't be empty");
                return;
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string lgquery = "SELECT role FROM credentials WHERE email = @email AND password = @password AND role = @role";
                using (SqlCommand cmd = new SqlCommand(lgquery, con))
                {
                    cmd.Parameters.AddWithValue("@email", emailBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", pwdBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", comboBox1.Text.Trim());

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {

                        string role = result.ToString().Trim();
                        if (role == "Admin")
                        {
                            Equipment eqt = new Equipment();
                            eqt.Show();
                            this.Hide();

                        }
                        else if (role == "Client")
                        {
                            string clientId = ""; // Fetch this from the database based on the login
                            string query = "SELECT UserId FROM credentials WHERE LOWER(email) = @email AND LOWER(password) = @password AND LOWER(role) = @role";
                            using (SqlCommand cmd2 = new SqlCommand(query, con))
                            {
                                cmd2.Parameters.AddWithValue("@email", emailBox.Text.Trim().ToLower());
                                cmd2.Parameters.AddWithValue("@password", pwdBox.Text.Trim().ToLower());
                                cmd2.Parameters.AddWithValue("@role", comboBox1.Text.Trim().ToLower());
                                object result2 = cmd2.ExecuteScalar();
                                if (result2 != null)
                                {
                                    clientId = result2.ToString();
                                    ClientPage cp = new ClientPage(clientId);
                                    cp.Show();
                                    this.Hide();
                                }
                                // ... rest of your logic ...
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Boss, incorrect username and/or password or role.");
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
