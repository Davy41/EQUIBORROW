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

namespace EQUIBORROW
{
    public partial class Register : Form
    {
        string constr = "Data source=DESKTOP-7AE7D3R;Initial Catalog=EquiBorrow;Integrated Security=True";
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string query = @"INSERT INTO credentials VALUES(@id,@fname,@lname,@role,@email,@password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", emailbox.Text.Trim());
            cmd.Parameters.AddWithValue("@password", passBox.Text.Trim());
            cmd.Parameters.AddWithValue("@confirmpwd", ConfPassBox.Text.Trim());
            cmd.Parameters.AddWithValue("@role", RoleCombo.Text.Trim());
            cmd.Parameters.AddWithValue("@id", idBox.Text.Trim());
            cmd.Parameters.AddWithValue("@fname", FnameBox.Text.Trim());
            cmd.Parameters.AddWithValue("@lname", LnameBox.Text.Trim());
            string chquery = "SELECT * FROM credentials WHERE UserId = @chid";
            SqlCommand cmd1 = new SqlCommand(chquery, con);
            cmd1.Parameters.AddWithValue("@chid", idBox.Text.Trim());
            SqlDataReader dr = cmd1.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Boss, User ID already exists. Please use a different one.");
                con.Close();
                return;
            }
            else
            {
                dr.Close();
                if (passBox.Text != ConfPassBox.Text)
                {
                    MessageBox.Show("Boss, Password and Confirm Password do not match.");
                    con.Close();
                    return;
                }
                if (string.IsNullOrEmpty(emailbox.Text) || string.IsNullOrEmpty(passBox.Text) || string.IsNullOrEmpty(RoleCombo.Text) || string.IsNullOrEmpty(idBox.Text) || string.IsNullOrEmpty(FnameBox.Text) || string.IsNullOrEmpty(LnameBox.Text))
                {
                    MessageBox.Show("Boss, All fields are required.");
                    con.Close();
                    return;
                }
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Boss, Registration successful!");
                this.Hide();
                Form1 lg = new Form1();
                lg.Show();
            }

        }
    }
}
