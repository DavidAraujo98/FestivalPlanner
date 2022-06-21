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

        private void Form1_Load(object sender, EventArgs e)
        {
            hideAll();
            form_login.Show();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            bool temp = TestDBConnection();
            CN.Close();
            if (temp)
            {
                loadFestivals();
                hideAll();
                panel_base.Show();
                panel_festivalslist.Show();
                panel_festival.Hide();
            }
        }

        private SqlConnection getSGBDConnection()
        {
            /* ---------- For testing only ----------  */
            return new SqlConnection("data source=WIN11\\SQLEXPRESS;integrated security=true;initial catalog=Projeto");
            /* ---------- For testing only ----------  */
            
            //return new SqlConnection("Data Source = " + server_input.Text + " ;" + "Initial Catalog = " + user_input.Text + "; uid = " + user_input.Text + ";" + "password = " + password_input.Text);
        }

        private bool TestDBConnection()
        {
            bool temp = false;
            CN = getSGBDConnection();
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

            return temp;
        }

        private bool verifySGBDConnection()
        {
            if (CN == null)
                CN = getSGBDConnection();

            if (CN.State != ConnectionState.Open)
                CN.Open();

            return CN.State == ConnectionState.Open;
        }

        private void loadFestivals()
        {
            if (!TestDBConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM FP.Evento", CN);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox_festivalsview.Items.Clear();

            while (reader.Read())
            {
                Festival F = new Festival();
                F.name = reader["nome"].ToString();
                F.id = reader["id"].ToString();
                F.dateBegin = reader["dataInicio"].ToString();
                F.dateEnd = reader["dataFim"].ToString();
                F.nDays = (int) reader["nDias"];
                F.nTickets = (int)reader["nBilhetes"];
                listBox_festivalsview.Items.Add(F);
                Console.WriteLine(F.name);
            }

            if(listBox_festivalsview.Items.Count > 0)
                btn_openfestival.Enabled = true;

            CN.Close();
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
            if (!verifySGBDConnection())
                return;

            Festival festival = new Festival();
            festival = (Festival)listBox_festivalsview.Items[listBox_festivalsview.SelectedIndex];
            textBox_festivalname.Text = festival.name;
            datepicker_festivalbegin.Value = DateTime.Parse(festival.dateBegin);
            datepicker_festivalend.Value = DateTime.Parse(festival.dateEnd);
            numericUpDown_ticketssold.Value = festival.nTickets;
            label_festivalid.Text = festival.id;

            loadPromoter(Int32.Parse(festival.id));
            loadManager(Int32.Parse(festival.id));

            hideAll();
            panel_base.Show();
            panel_festival.Show();
        }

        private void loadPromoter(int id)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = "SELECT Pessoa.* FROM FP.Evento INNER JOIN (SELECT FP.Promotor.tipo, FP.Pessoa.* FROM FP.Promotor INNER JOIN FP.Pessoa ON FP.Promotor.cc = FP.Pessoa.cc) AS Pessoa ON FP.Evento.cc_promotor = Pessoa.cc WHERE FP.Evento.id = @festivalID";
            cmd.Parameters.AddWithValue("@festivalID", id);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            textBox_promotername.Text = reader["nome"].ToString();
            textBox_promoteremail.Text = reader["email"].ToString();
            comboBox_promotersex.Text = reader["sexo"].ToString();
            textBox_promotertelephone.Text = reader["telefone"].ToString();
            textBox_promoteridnumber.Text = reader["cc"].ToString();
            comboBox_promotertype.Text = reader["tipo"].ToString();

            CN.Close();
        }

        private void loadManager(int id)
        {
            if (!verifySGBDConnection())
                return;


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = "SELECT Pessoa.* FROM FP.Evento INNER JOIN (SELECT FP.Manager.tipo, FP.Pessoa.* FROM FP.Manager INNER JOIN FP.Pessoa ON FP.Manager.cc = FP.Pessoa.cc) AS Pessoa ON FP.Evento.cc_manager = Pessoa.cc WHERE FP.Evento.id = @festivalID";
            cmd.Parameters.AddWithValue("@festivalID", id);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            textBox_managername.Text = reader["nome"].ToString();
            textBox_manageremail.Text = reader["email"].ToString();
            comboBox_managersex.Text = reader["sexo"].ToString();
            textBox_managertelephone.Text = reader["telefone"].ToString();
            textBox_manageridnumber.Text = reader["cc"].ToString();
            comboBox_managertype.Text = reader["tipo"].ToString();

            CN.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel_festival_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datepicker_festivalbegining_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_editfestival_Click(object sender, EventArgs e)
        {

        }

        private void datepicker_festivalend_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
