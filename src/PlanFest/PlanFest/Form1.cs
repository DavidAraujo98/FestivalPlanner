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
        private Festival festival = new Festival();
        private Promoter promoter = new Promoter();
        private Manager manager = new Manager();
        public PlanFest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideAll();
            form_login.Show();
        }

        private void hideAll()
        {
            
            foreach (var pnl in Controls.OfType<Panel>())
            {
                pnl.Hide();
            }
        }

        private void openPanel(Panel e)
        {
            hideAll();
            panel_base.Show();
            e.BringToFront();
            e.Show();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            bool temp = TestDBConnection();
            CN.Close();
            if (temp)
            {
                loadFestivals();
                openPanel(panel_openinglist);
                
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
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM FP.Evento", CN);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox_festivalsview.Items.Clear();

            while (reader.Read())
            {
                Festival F = new Festival(
                    name: reader["nome"].ToString(),
                    id: reader["id"].ToString(),
                    dateBegin: reader["dataInicio"].ToString(),
                    dateEnd: reader["dataFim"].ToString(),
                    dateProposal: reader["dataProposta"].ToString(),
                    nDays: Int32.Parse(reader["nDias"].ToString()),
                    nTickets: Int32.Parse(reader["nBilhetes"].ToString())
                    );
                
                listBox_festivalsview.Items.Add(F);
            }

            CN.Close();
        }

        private void listBox_festivalsview_SelectChange(object sender, EventArgs e)
        {
            if (listBox_festivalsview.SelectedIndex >= 0)
                btn_openfestival.Enabled = true;
        }

        private void btn_openfestival_Click(object sender, EventArgs e)
        {
            openPanel(panel_festival);

            if (!verifySGBDConnection())
                return;

            this.festival = (Festival)listBox_festivalsview.Items[listBox_festivalsview.SelectedIndex];
            updateFestivalView();
            hideAll();
            panel_base.Show();
            panel_festival.Show();
        }

        private void readFestivalView()
        {
            DateTime start = datepicker_festivalbegin.Value;
            DateTime end = datepicker_festivalend.Value;
            int numdias = (int)(end - start).TotalDays;

            this.festival = new Festival(
                id: label_festivalid.Text,
                name: textBox_festivalname.Text,
                dateBegin: datepicker_festivalbegin.Value.ToString(),
                dateEnd: datepicker_festivalend.Value.ToString(),
                dateProposal: datepicker_proposal.Value.ToString(),
                nDays: numdias,
                nTickets: (int)numericUpDown_ticketssold.Value,
                promoter: this.promoter,
                manager: this.manager
                );
        }
        private void updateFestivalView()
        {
            textBox_festivalname.Text = this.festival.name;
            datepicker_festivalbegin.Value = DateTime.Parse(this.festival.dateBegin);
            datepicker_festivalend.Value = DateTime.Parse(this.festival.dateEnd);
            datepicker_proposal.Value = DateTime.Parse(this.festival.dateProposal);
            numericUpDown_ticketssold.Value = this.festival.nTickets;
            label_festivalid.Text = this.festival.id.ToString();
            loadPromoter();
            loadManager();
        }

        private void loadPromoter()
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = "SELECT Pessoa.* FROM FP.Evento INNER JOIN (SELECT FP.Promotor.tipo, FP.Pessoa.* FROM FP.Promotor INNER JOIN FP.Pessoa ON FP.Promotor.cc = FP.Pessoa.cc) AS Pessoa ON FP.Evento.cc_promotor = Pessoa.cc WHERE FP.Evento.id = @festivalID";
            cmd.Parameters.AddWithValue("@festivalID", this.festival.id);
            SqlDataReader reader = cmd.ExecuteReader();
            
            reader.Read();
            this.promoter.name = promoter_name.Text = reader["nome"].ToString();
            this.promoter.email = promoter_email.Text = reader["email"].ToString();
            this.promoter.sex = promoter_sex.Text = reader["sexo"].ToString();
            this.promoter.telephone = promoter_phone.Text = reader["telefone"].ToString();
            this.promoter.cc = textBox_promoter_cc.Text = reader["cc"].ToString();
            this.promoter.type = promoter_type.Text = reader["tipo"].ToString();
            this.promoter.festival = this.festival;


            CN.Close();
        }
        private void loadManager()
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = "SELECT Pessoa.* FROM FP.Evento INNER JOIN (SELECT FP.Manager.tipo, FP.Pessoa.* FROM FP.Manager INNER JOIN FP.Pessoa ON FP.Manager.cc = FP.Pessoa.cc) AS Pessoa ON FP.Evento.cc_manager = Pessoa.cc WHERE FP.Evento.id = @festivalID";
            cmd.Parameters.AddWithValue("@festivalID", this.festival.id);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            this.manager.name = manager_name.Text = reader["nome"].ToString();
            this.manager.email = manager_email.Text = reader["email"].ToString();
            this.manager.sex = manager_sex.Text = reader["sexo"].ToString();
            this.manager.telephone = manager_phone.Text = reader["telefone"].ToString();
            this.manager.cc = textBox_manager_cc.Text = reader["cc"].ToString();
            this.manager.type = manager_type.Text = reader["tipo"].ToString();
            this.manager.festival = this.festival;

            CN.Close();
        }
        private void btn_editfestival_Click(object sender, EventArgs e)
        {
            if (btn_editfestival.Text == "Edit")
            {
                btn_editfestival.Text = "Save";
                textBox_festivalname.Enabled = true;
                datepicker_festivalbegin.Enabled = true;
                datepicker_festivalend.Enabled = true;
                datepicker_festivalend.Enabled = true;
                datepicker_proposal.Enabled = true;
                numericUpDown_ticketssold.Enabled = true;
                textBox_promoter_cc.Enabled = true;
                textBox_manager_cc.Enabled = true;
            }
            else
            {
                btn_editfestival.Text = "Edit";
                textBox_festivalname.Enabled = false;
                datepicker_festivalbegin.Enabled = false;
                datepicker_festivalend.Enabled = false;
                datepicker_festivalend.Enabled = false;
                datepicker_proposal.Enabled = false;
                numericUpDown_ticketssold.Enabled = false;
                textBox_promoter_cc.Enabled = false;
                textBox_manager_cc.Enabled = false;

                readFestivalView();

                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CN;
                cmd.CommandText = "EXEC alter_evento @festivalID," + "@festival_name," + "@num_dias,"+"@begin_date,"+"@end_date,"+"@num_tickets,"+"@proposal_date,"+"@promoter_cc,"+"@manager_cc;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@festivalID", this.festival.id);
                cmd.Parameters.AddWithValue("@festival_name", this.festival.name);
                cmd.Parameters.AddWithValue("@num_dias", this.festival.nDays);
                cmd.Parameters.AddWithValue("@begin_date", this.festival.dateBegin);
                cmd.Parameters.AddWithValue("@end_date", this.festival.dateEnd);
                cmd.Parameters.AddWithValue("@num_tickets", this.festival.nTickets);
                cmd.Parameters.AddWithValue("@proposal_date", this.festival.dateProposal);
                cmd.Parameters.AddWithValue("@promoter_cc", this.festival.promoter.cc);
                cmd.Parameters.AddWithValue("@manager_cc", this.festival.manager.cc);

                try
                {
                    cmd.ExecuteNonQuery();
                    CN.Close();
                    updateFestivalView();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to update festival in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                
            }
        }

        private void btn_deletefestival_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + this.festival.name + " event ?", "Connection Test", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CN;
                cmd.CommandText = "EXEC delete_evento_byId @festivalID;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@festivalID", this.festival.id);
                try
                {
                    Console.WriteLine(cmd.ExecuteNonQuery());
                    CN.Close();
                    loadFestivals();
                    openPanel(panel_openinglist);
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to delete festival in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
            }
        }

        private void menu_Paint(object sender, PaintEventArgs e)
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
        
        

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel_festival_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datepicker_festivalbegining_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datepicker_festivalend_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel_openinglist_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
