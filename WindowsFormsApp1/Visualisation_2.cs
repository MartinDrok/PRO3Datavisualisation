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

namespace WindowsFormsApp1
{
    public partial class Visualisation_2 : Form
    {
        // Declare variables
        // Filters
        private int periode = 2009; // Nummer is jaartal 
        private int kinderen = 0; //365 of 366 voor wel kinderen //
        private int zelfstandig = 466; //466 is zelfstandig 476 is zonder inkomen //
        private int koopwoning = 202; // 202 voor Koop, 203 voor huur
        private int nederlander = 422; // 422 voor autochtoon, > 422 voor allochtoon //
        private String leeftijdCat = "";

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
                query = "SELECT * FROM dbo.PMInkomen";

                // If a filter has been set add "WHERE..."
                if (kinderen >= 0 || periode > 2009 || leeftijdCat != "" || zelfstandig > 0 || koopwoning > 0 || nederlander > 0)
                {
                    // Periode erbij
                    query = query + " WHERE Perioden = " + periode;
                    // Zelfstandigheid
                    query = query + " AND OverigeKenmerken = " + zelfstandig;
                    // Koop of huur woning
                    query = query + " OR OverigeKenmerken = " + koopwoning;
                    // Kinderen
                    query = query + " OR OverigeKenmerken = " + kinderen;
                    // Afkomst
                    query = query + " OR OverigeKenmerken = " + nederlander;
                    // Leeftijd
                    query = query + " OR OverigeKenmerken = " + leeftijdCat;

                    MessageBox.Show(query);
                }


                // Send query
                SqlDataAdapter adapterNaam = new SqlDataAdapter(query, con);

                DataSet datasetNaam1 = new DataSet("Een_naam1");
                datasetNaam1.FillSchema(datasetNaam1, SchemaType.Source, "Een_naam1");
                datasetNaam1.Fill(datasetNaam1, " Een_naam1");
                DataTable datatable1;
                datatable1 = datasetNaam1.Tables["Een_naam1"];

                chart1.DataSource = datasetNaam1;
                chart1.Series["Inkomen"].XValueMember = "OverigeKenmerken";
                chart1.Series["Inkomen"].YValueMembers = "GemiddeldPersoonlijkInkomen_2";
                chart1.Titles["Title1"].Visible = true;
                chart1.Titles["Title1"].Text = "Aantal personen in " + filter_jaartal;
            }
            catch (Exception es)
            {
                
                MessageBox.Show(es.Message);
            }
        }

        private void periodeCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

        }

        private void kinderenGroupBox_Enter(object sender, EventArgs e)
        {

        }

        // Kinderen
        private void eenKindRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // geen kind
            kinderen = 0;
        }

        private void tweeKindRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Minderjarig kind
            kinderen = 365;
        }

        private void drieKindRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Meerderjarig kind
            kinderen = 366;
        }

        private void periodeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        // Land van herkomst
        private void autochtoonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nederlander = 422;
        }

        private void allochtoonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nederlander = 423;
        }


        // Woning
        private void koophuisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            koopwoning = 202;
        }

        private void huurhuisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            koopwoning = 203;
        }

        // Zelfstandigheid 
        private void welZelfstandigRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            zelfstandig = 466;
        }

        private void nietZelfstandigRadioButton_CheckedChanged(Object sender, EventArgs e)
        {
            zelfstandig = 476;
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            periode = 2012;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            periode = 2013;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            periode = 2014;
        }

        //Leeftijd
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            leeftijdCat = "404";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            leeftijdCat = " BETWEEN 405 AND 408";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            leeftijdCat = " BETWEEN 409 AND 412";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            leeftijdCat = " BETWEEN 413 AND 416";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            leeftijdCat = " BETWEEN 417 AND 418";
        }

        

    }
}
