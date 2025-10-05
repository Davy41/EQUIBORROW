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
    public partial class ClientPage : Form
    {
        private string clientId;

        public ClientPage(string clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
        }

        public ClientPage()
        {
            InitializeComponent();
        }
        string constr = "Data source=DESKTOP-7AE7D3R;Initial Catalog=EquiBorrow;Integrated Security=True";

        private void LoadAllEquipment()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "SELECT * FROM Equipment";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Equipment");
                AvailableEquipmentView.DataSource = ds.Tables["Equipment"];
            }
        }

        private void ClientPage_Load(object sender, EventArgs e)
        {
            LoadAllEquipment();
            DisplayBorrowings();

            // Display the name of the currently logged in user
            string dquery = "SELECT fname FROM credentials WHERE UserId = @clientId";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(dquery, con))
                {
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        label4.Text = result.ToString();
                    }
                    else
                    {
                        label4.Text = "Unknown User";
                    }
                }
            }
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
            AvailableEquipmentView.DataSource = ds.Tables["Equipment"];
            con.Close();
        }

        private void BorrowBtn_Click_1(object sender, EventArgs e)
        {
            if (AvailableEquipmentView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an equipment to borrow.");
                return;
            }

            string equipmentId = AvailableEquipmentView.SelectedRows[0].Cells["Identification"].Value.ToString();

            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();

                // 1. Check if quantity > 0
                string checkQuery = "SELECT quantity FROM Equipment WHERE Identification = @equipmentId";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                int quantity = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (quantity > 0)
                {
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        // Generate a new borrowid (e.g., "BRW" + yyyymmddHHmmss + random 2 digits)
                        string borrowId = "BRW" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(10, 99).ToString();
                        if (borrowId.Length > 10)
                            borrowId = borrowId.Substring(0, 10);

                        // 2. Insert into Borrowing
                        string insertQuery = @"
                            INSERT INTO Borrowing (borrowid, clientid, eqptid, borrowingDate, quantity, returndate, fine)
                            VALUES (@borrowid, @clientid, @eqptid, @borrowingDate, @borrowQty, @returndate, @fine)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, con, transaction);
                        insertCmd.Parameters.AddWithValue("@borrowid", borrowId);
                        insertCmd.Parameters.AddWithValue("@clientid", clientId);
                        insertCmd.Parameters.AddWithValue("@eqptid", equipmentId);
                        insertCmd.Parameters.AddWithValue("@borrowingDate", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@borrowQty", 1);
                        insertCmd.Parameters.AddWithValue("@returndate", DBNull.Value); // Not returned yet
                        insertCmd.Parameters.AddWithValue("@fine", 0);
                        insertCmd.ExecuteNonQuery();

                        // 3. Decrement Equipment quantity
                        string updateEquipQuery = "UPDATE Equipment SET quantity = quantity - 1 WHERE Identification = @equipmentId";
                        SqlCommand updateEquipCmd = new SqlCommand(updateEquipQuery, con, transaction);
                        updateEquipCmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                        updateEquipCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Equipment borrowed successfully!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while borrowing equipment.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This equipment is not available for borrowing (quantity is 0).");
                }
            }

            DisplayBorrowings();
            LoadAllEquipment();
        }

        private void DisplayBorrowings()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                string query = "SELECT * FROM Borrowing WHERE clientid = @clientid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@clientid", clientId);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Borrowing");
                BorrowedItemView.DataSource = ds.Tables["Borrowing"];
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        
    }
}
