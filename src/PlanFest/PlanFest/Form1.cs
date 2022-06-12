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
        private SqlConnection CN;
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

        private void btn_connect_Click(object sender, EventArgs e)
        {
            bool temp = TestDBConnection(server_input.Text, user_input.Text, user_input.Text, password_input.Text);
            if (temp)
            {
                hideAll();
                panel_base.Show();
                panel_festivalslist.Show();
                panel_festival.Hide();
            }
            /* ---------- For testing only ----------  */
            hideAll();
            panel_base.Show();
            panel_festivalslist.Show();
            panel_festival.Hide();
            /* ---------- For testing only ----------  */
        }

        private bool TestDBConnection(string dbServer, string dbName, string userName, string userPass)
        {
            bool temp = false;
            CN = new SqlConnection("Data Source = " + dbServer + " ;" + "Initial Catalog = " + dbName + "; uid = " + userName + ";" + "password = " + userPass);
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

        private void label_festivalname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_festival_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datepicker_festivalbegining_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_editfestival_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void datepicker_festivalend_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
