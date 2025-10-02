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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }
        string constr = "Data Source=DESKTOP-7AE7D3R;Initial Catalog=EQUIIBORROW;Integrated Security=True";
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = @"INSERT INTO Equipment (identification, NAME, DESCRIPTION, TYPE, DATE) VALUES(@idf,@name,@descr,@typ,@dat)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@idf", identBox.Text.Trim());
            cmd.Parameters.AddWithValue("@name",NameBox.Text.Trim());
            cmd.Parameters.AddWithValue("@descr", DescriptionBox.Text.Trim());
            cmd.Parameters.AddWithValue("@typ", TypeCombo.Text);
            cmd.Parameters.AddWithValue("@dat", regDate.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(identBox.Text.Trim()+" is saved successfully");
            DisplayData();

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
            string query = "UPDATE Equipment SET NAME = @name, DESCRIPTION = @descr, TYPE = @typ, DATE = @dat WHERE identification = @idf";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@idf", identBox.Text.Trim());
            cmd.Parameters.AddWithValue("@name", NameBox.Text.Trim());
            cmd.Parameters.AddWithValue("@descr", DescriptionBox.Text.Trim());
            cmd.Parameters.AddWithValue("@typ", TypeCombo.Text);
            cmd.Parameters.AddWithValue("@dat", regDate.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(identBox.Text.Trim() + " is updated successfully");
            DisplayData();
        }
    }

}
