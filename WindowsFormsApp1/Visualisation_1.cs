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
using System.Windows.Forms.DataVisualization.Charting;



namespace WindowsFormsApp1
{
    public partial class Visualisation_1 : Form
    {
        public Visualisation_1()
        {
            InitializeComponent();
        }

        private string filter_zuid_holland = "";
        private string filter_noord_holland = "";
        private string filter_zeeland = "";
        private string filter_noord_brabant = "";
        private string filter_utrecht = "";
        private string filter_flevoland = "";
        private string filter_gelderland = "";
        private string filter_limburg = "";
        private string filter_overijssel = "";
        private string filter_drenthe = "";
        private string filter_friesland = "";
        private string filter_groningen = "";

        private string filter_vestiging = "";

        private int button_zuid_holland = 0;    // button 32
        private int button_noord_holland = 0;   // button 31
        private int button_zeeland = 0;         // button 30
        private int button_noord_brabant = 0;   // button 29
        private int button_utrecht = 0;         // button 28
        private int button_flevoland = 0;       // button 27
        private int button_gelderland = 0;      // button 26
        private int button_limburg = 0;         // button 25
        private int button_overijssel = 0;      // button 24
        private int button_drenthe = 0;         // button 23
        private int button_friesland = 0;       // button 22
        private int button_groningen = 0;       // button 21

        int[] rgb_leftclick_array = new int[] { 255, 177, 101 };
        int[] rgb_rightclick_array = new int[] { 255, 39, 113 };
        int[] rgb_emptyclick_array = new int[] { 250, 250, 250 };


        private void CheckWhichButtonsRightClicked()
        {
            if (button_zuid_holland == 2)
            {
                button_zuid_holland = 0;
                this.button32.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
            if (button_noord_holland == 2)
            {
                button_noord_holland = 0;
                this.button31.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
            if (button_zeeland == 2)
            {
                button_zeeland = 0;
                this.button30.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
            if (button_noord_brabant == 2)
            {
                button_noord_brabant = 0;
                this.button29.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
            if (button_utrecht == 2)
            {
                button_utrecht = 0;
                this.button28.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
            if (button_flevoland == 2)
            {
                button_flevoland = 0;
                this.button27.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
            if (button_gelderland == 2)
            {
                button_gelderland = 0;
                this.button26.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
            if (button_limburg == 2)
            {
                button_limburg = 0;
                this.button25.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
            if (button_overijssel == 2)
            {
                button_overijssel = 0;
                this.button24.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
            if (button_drenthe == 2)
            {
                button_drenthe = 0;
                this.button23.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
            if (button_friesland == 2)
            {
                button_friesland = 0;
                this.button22.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
            if (button_groningen == 2)
            {
                button_groningen = 0;
                this.button21.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visualisation_2 vis_2 = new Visualisation_2();
            vis_2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataVisual menu_1 = new DataVisual();
            menu_1.Show();
            this.Hide();
        }

        private void Visualisation_1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visualisation_3 vis_3 = new Visualisation_3();
            vis_3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=PRO3-Datavisualisatie;Integrated Security=True";              // Maakt verbinding met SQL server
                SqlConnection con = new SqlConnection(str);
                con.Open();
                button33.Text = "Connected";
            }
            catch
            {

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button_noord_holland == 0)
            {
                button_noord_holland = 1;
                this.button31.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_noord_holland = " OR Regio LIKE PV27";
            }
            else if (button_noord_holland == 1)
            {
                button_noord_holland = 0;
                this.button31.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_noord_holland = "";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button_groningen == 0)
            { 
                button_groningen = 1;
                this.button21.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_groningen = " OR Regio LIKE 'PV20'";
            }
            else if (button_groningen == 1)
            {
                button_groningen = 0;
                this.button21.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_groningen = "";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button_friesland == 0)
            {
                button_friesland = 1;
                this.button22.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_friesland = " OR Regio LIKE PV21";
            }
            else if (button_friesland == 1)
            {
                button_friesland = 0;
                this.button22.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_friesland = "";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button_drenthe == 0)
            {
                button_drenthe = 1;
                this.button23.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_drenthe = " OR Regio LIKE PV22";
            }
            else if (button_drenthe == 1)
            {
                button_drenthe = 0;
                this.button23.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_drenthe = "";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button_flevoland == 0)
            {
                button_flevoland = 1;
                this.button27.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_flevoland = " OR Regio LIKE PV24";
            }
            else if (button_flevoland == 1)
            {
                button_flevoland = 0;
                this.button27.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_flevoland = "";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button_overijssel == 0)
            {
                button_overijssel = 1;
                this.button24.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_overijssel = " OR Regio LIKE PV23";
            }
            else if (button_overijssel == 1)
            {
                button_overijssel = 0;
                this.button24.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_overijssel = "";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button_zuid_holland == 0)
            {
                button_zuid_holland = 1;
                this.button32.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_zuid_holland = " OR Regio LIKE PV28";
            }
            else if (button_zuid_holland == 1)
            {
                button_zuid_holland = 0;
                this.button32.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_zuid_holland = "";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button_utrecht == 0)
            {
                button_utrecht = 1;
                this.button28.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_utrecht = " OR Regio LIKE PV26";
            }
            else if (button_utrecht == 1)
            {
                button_utrecht = 0;
                this.button28.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_utrecht = "";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
           if (button_gelderland == 0)
            {
                button_gelderland = 1;
                this.button26.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_gelderland = " OR Regio LIKE PV25";
            }
            else if (button_gelderland == 1)
            {
                button_gelderland = 0;
                this.button26.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_gelderland = "";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (button_noord_brabant == 0)
            {
                button_noord_brabant = 1;
                this.button29.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_noord_brabant = " OR Regio LIKE PV30";
            }
            else if (button_noord_brabant == 1)
            {
                button_noord_brabant = 0;
                this.button29.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_noord_brabant = "";
            }
    }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button_zeeland == 0)
            {
                button_zeeland = 1;
                this.button30.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_zeeland = " OR Regio LIKE PV29";
            }
            else if (button_zeeland == 1)
            {
                button_zeeland = 0;
                this.button30.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_zeeland = "";
            }
    }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button_limburg == 0)
            {
                button_limburg = 1;
                this.button25.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                filter_limburg = " OR Regio LIKE PV31";
            }
            else if (button_limburg == 1)
            {
                button_limburg = 0;
                this.button25.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                filter_limburg = "";
            }