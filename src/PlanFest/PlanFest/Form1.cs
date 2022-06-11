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

namespace PlanFest
{
    public partial class PlanFest : Form
    {
        
        public PlanFest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideAll();
            form_login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            bool temp = TestDBConnection(server_input.Text, user_input.Text, user_input.Text, password_input.Text);
            if (temp)
            {
                hideAll();
                panel_base.Show();
                panel_openfestival.Show();
            }
            hideAll();
            panel_base.Show();
            panel_openfestival.Show();
        }

        private bool TestDBConnection(string dbServer, string dbName, string userName, string userPass)
        {
            bool temp = false;
            SqlConnection CN = new SqlConnection("Data Source = " + dbServer + " ;" + "Initial Catalog = " + dbName + "; uid = " + userName + ";" + "password = " + userPass);
            try
            {
                CN.Open();
                if (CN.State == ConnectionState.Open)
                {
                    MessageBox.Show("Successful connection to database " + CN.Database + " on the " + CN.DataSource + " server", "Connection Test", MessageBoxButtons.OK);
                    temp = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                temp = false;
            }

            if (CN.State == ConnectionState.Open)
                CN.Close();

            return temp;
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_festivals_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Bands_Click(object sender, EventArgs e)
        {

        }

        private void panel_home_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void hideAll()
        {

            foreach (var pnl in Controls.OfType<Panel>())
            {
                pnl.Hide();
            }
        }

        private void btn_openfestival_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
