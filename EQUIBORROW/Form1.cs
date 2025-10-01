using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string correctEmail = "admin@auca.ac.rw";
            string correctPwd = "I am rich";
            if(!string.IsNullOrEmpty(emailBox.Text) || !string.IsNullOrEmpty(pwdBox.Text)) {
                if (emailBox.Text==correctEmail && pwdBox.Text==(correctPwd)){
                    Equipment eqt = new Equipment();
                    eqt.Show();
                    this.Hide();
                }else{
                    MessageBox.Show("Boss, incorrect username and Or Password");
                }
            }else{
                MessageBox.Show("Boss, Username and Password can't be empty");
            }
        }
    }
}
