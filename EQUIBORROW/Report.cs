using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EQUIBORROW
{
    public partial class Report : Form
    {
        private string constr = "Data source=DESKTOP-7AE7D3R;Initial Catalog=EquiBorrow;Integrated Security=True";

        public Report()
        {
            InitializeComponent();
            this.Load += Report_Load;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EqptBtn_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
            this.Hide();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                // Query to get all equipment, borrowed, returned status, and client info
                string query = @"
                    SELECT 
                        e.Identification, 
                        e.NAME AS EquipmentName, 
                        e.quantity AS AvailableQuantity,
                        b.borrowid, 
                        b.clientid, 
                        c.fname AS ClientFirstName,
                        c.lname AS ClientLastName,
                        b.borrowingDate, 
                        b.returndate,
                        CASE 
                            WHEN b.borrowid IS NULL THEN 'Added'
                            WHEN b.returndate IS NULL THEN 'Borrowed'
                            ELSE 'Returned'
                        END AS Status
                    FROM Equipment e
                    LEFT JOIN Borrowing b ON e.Identification = b.eqptid
                    LEFT JOIN credentials c ON b.clientid = c.UserId
                    ORDER BY e.Identification, b.borrowingDate DESC
                ";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Report");
                reportGridView.DataSource = ds.Tables["Report"];
            }
        }
    }
}
