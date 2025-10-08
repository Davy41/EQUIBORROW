using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQUIBORROW
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }
        string constr = ConfigurationManager.ConnectionStrings["EquiBorrowDb"].ConnectionString;
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = @"INSERT INTO Equipment (Identification, NAME, DESCRIPTION, TYPE, regDATE,quantity) VALUES(@idf,@name,@descr,@typ,@dat,@qua)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@idf", identBox.Text.Trim());
            cmd.Parameters.AddWithValue("@name",NameBox.Text.Trim());
            cmd.Parameters.AddWithValue("@descr", DescriptionBox.Text.Trim());
            cmd.Parameters.AddWithValue("@typ", TypeCombo.Text);
            cmd.Parameters.AddWithValue("@dat", regDate.Value);
            cmd.Parameters.AddWithValue("@qua", quaBox.Text.Trim());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(identBox.Text.Trim()+" is saved successfully");
            DisplayData();
            identBox.Clear();
            NameBox.Clear();
            DescriptionBox.Clear();
            quaBox.Clear();

        }

        private void Equipment_Load(object sender, EventArgs e) 
        {
            DisplayData();

        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(constr);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = "SELECT * FROM Equipment";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Equipment");
            EquipmentView.DataSource = ds.Tables["Equipment"];
            con.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = "UPDATE Equipment SET NAME = @name, DESCRIPTION = @descr, TYPE = @typ, regDATE = @dat, quantity= @qua WHERE Identification = @idf";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@idf", identBox.Text.Trim());
            cmd.Parameters.AddWithValue("@name", NameBox.Text.Trim());
            cmd.Parameters.AddWithValue("@descr", DescriptionBox.Text.Trim());
            cmd.Parameters.AddWithValue("@typ", TypeCombo.Text);
            cmd.Parameters.AddWithValue("@dat", regDate.Value);
            cmd.Parameters.AddWithValue("@qua", quaBox.Text.Trim());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(identBox.Text.Trim() + " is updated successfully");
            DisplayData();
            identBox.Clear();
            NameBox.Clear();
            DescriptionBox.Clear();
            quaBox.Clear();
        }

        private void EquipmentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row, not the header
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = EquipmentView.Rows[e.RowIndex];

                // Load values into the text boxes and controls
                identBox.Text = row.Cells["Identification"].Value?.ToString();
                NameBox.Text = row.Cells["NAME"].Value?.ToString();
                DescriptionBox.Text = row.Cells["DESCRIPTION"].Value?.ToString();
                TypeCombo.Text = row.Cells["TYPE"].Value?.ToString();

                // regDATE is assumed to be a DateTime column
                if (row.Cells["regDATE"].Value != null && DateTime.TryParse(row.Cells["regDATE"].Value.ToString(), out DateTime regDateValue))
                {
                    regDate.Value = regDateValue;
                }

                quaBox.Text = row.Cells["quantity"].Value?.ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            String query = "DELETE FROM Equipment WHERE Identification = @idf";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idf", identBox.Text.Trim());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(identBox.Text.Trim() + " is deleted successfully");
            DisplayData();
            identBox.Clear();
            NameBox.Clear();
            DescriptionBox.Clear();
            quaBox.Clear();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open(); 
            String query = "SELECT * FROM Equipment WHERE NAME LIKE @name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", "%" + searchBox.Text.Trim() + "%");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Equipment");
            EquipmentView.DataSource = ds.Tables["Equipment"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.Show();
            this.Hide();
        }
    }

}
