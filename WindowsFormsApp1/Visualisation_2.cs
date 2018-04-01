using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Visualisation_2 : Form
    {
        // Declare variables
        // Filters
        private int periode = 0; // Nummer is jaartal 
        private int geslacht = 320; // 321 is Mannen en 322 is vrouwen



        // Misc
        private String query;

        // Other code
        public Visualisation_2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visualisation_1 vis_1 = new Visualisation_1();
            vis_1.Show();
            this.Hide();
        }

        private void Visualisation_2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visualisation_3 vis_3 = new Visualisation_3();
            vis_3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataVisual menu_1 = new DataVisual();
            menu_1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        // own code
        private void calculateButton_Click(object sender, MouseEventArgs e)
        {
            // Connect with database and give status
            try
            {
                // Maakt verbinding met SQL server
                string str = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=PRO3-Datavisualisatie;Integrated Security=True";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                

                // Calculate query and send it
                query = ("SELECT * FROM dbo.PMInkomen");

                // If a filter has been set add "WHERE..."
                if (geslacht > 319 || periode > 2009)
                {
                    // Periode erbij
                    query = query + " WHERE Perioden = " + periode;
                    query = query + " AND OverigeKenmerken >= 231 AND OverigeKenmerken <= 242";
                    query = query + " AND SociaalEconomischeCategorie = 481";
                    query = query + " AND Geslacht = " + geslacht;
                    query = query + " AND Populatie = 491";
                    query = query + ";";
                    // Zelfstandigheid
                    //query = query + " AND OverigeKenmerken = " + zelfstandig;
                    // Koop of huur woning
                    //query = query + " OR OverigeKenmerken = " + koopwoning;
                    // Kinderen
                    //query = query + " OR OverigeKenmerken = " + kinderen;
                    // Afkomst
                    //query = query + " OR OverigeKenmerken = " + nederlander;
                    // Leeftijd
                    //query = query + " OR OverigeKenmerken = " + leeftijdCat;



                    //MessageBox.Show(query);
                }


                // Send query
                SqlDataAdapter adapterInkomen = new SqlDataAdapter(query, con);

                DataSet datasetMP = new DataSet("MP-Inkomen");
                adapterInkomen.FillSchema(datasetMP, SchemaType.Source, "MP-Inkomen");
                adapterInkomen.Fill(datasetMP, "MP-Inkomen");
                DataTable tableInkomen;
                tableInkomen = datasetMP.Tables["MP-Inkomen"];

                chart1.DataSource = datasetMP;
                chart1.Series["Inkomen"].XValueMember = "OverigeKenmerken";
                chart1.Series["Inkomen"].YValueMembers = "GemiddeldPersoonlijkInkomen_2";
                chart1.Titles["Title1"].Visible = true;
                chart1.Titles["Title1"].Text = "Gemiddeld inkomen in " + periode;
            }
            catch (Exception es)
            {
                
                //MessageBox.Show(es.Message);
            }
        }

        private void periodeCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int provincie1 = 231;
            string verandering1 = provincie1.ToString();
            string nieuw1 = verandering1.Replace("231", "Groningen");

            int provincie2 = 232;
            string verandering2 = provincie2.ToString();
            string nieuw2 = verandering2.Replace("232", "Friesland");

            int provincie3 = 233;
            string verandering3 = provincie3.ToString();
            string nieuw3 = verandering3.Replace("233", "Drenthe");

            int provincie4 = 234;
            string verandering4 = provincie4.ToString();
            string nieuw4 = verandering4.Replace("234", "Overijsel");

            int provincie5 = 235;
            string verandering5 = provincie5.ToString();
            string nieuw5 = verandering5.Replace("235", "Flevoland");

            int provincie6 = 236;
            string verandering6 = provincie6.ToString();
            string nieuw6 = verandering6.Replace("236", "Gelderland");

            int provincie7 = 237;
            string verandering7 = provincie7.ToString();
            string nieuw7 = verandering7.Replace("237", "Utrecht");

            int provincie8 = 238;
            string verandering8 = provincie8.ToString();
            string nieuw8 = verandering8.Replace("238", "Noor-Holland");

            int provincie9 = 239;
            string verandering9 = provincie9.ToString();
            string nieuw9 = verandering9.Replace("239", "Zuid-Holland");

            int provincie10 = 240;
            string verandering10 = provincie10.ToString();
            string nieuw10 = verandering10.Replace("240", "Zeeland");

            int provincie11 = 241;
            string verandering11 = provincie11.ToString();
            string nieuw11 = verandering11.Replace("241", "Noord-Brabant");

            int provincie12 = 242;
            string verandering12 = provincie12.ToString();
            string nieuw12 = verandering12.Replace("242", "Limburg");
        }

        private void kinderenGroupBox_Enter(object sender, EventArgs e)
        {

        }


        private void periodeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        // Periode
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            periode = 2010;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            periode = 2011;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            periode = 2012;
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            periode = 2013;
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            periode = 2014;
        }

        //Geslacht
        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            geslacht = 321;
        }

        private void radioButton10_CheckedChanged_1(object sender, EventArgs e)
        {
            geslacht = 322;
        }


        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
