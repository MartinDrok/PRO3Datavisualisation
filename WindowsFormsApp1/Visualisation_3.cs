using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Visualisation_3 : Form
    {
        public Visualisation_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataVisual menu_1 = new DataVisual();
            menu_1.Show();
            this.Hide();
            /// test
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visualisation_1 vis_1 = new Visualisation_1();
            vis_1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visualisation_2 vis_2 = new Visualisation_2();
            vis_2.Show();
            this.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Visualisation_3_Load(object sender, EventArgs e)
        {
            
        }

        private int button_zuid_holland = 0;
        private int button_noord_holland = 0;
        private int button_zeeland = 0;
        private int button_noord_brabant = 0;
        private int button_limburg = 0;
        private int button_utrecht = 0;
        private int button_flevoland = 0;
        private int button_gelderland = 0;
        private int button_overijssel = 0;
        private int button_drenthe = 0;
        private int button_friesland = 0;
        private int button_groningen = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            if (button_zuid_holland == 0)
            {
                button_zuid_holland = 1;
                this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_zuid_holland == 1)
            {
                button_zuid_holland = 0;
                this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }
 
        private void button5_Click(object sender, EventArgs e)
        {
            if (button_noord_holland == 0)
            {
                button_noord_holland = 1;
                this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_noord_holland == 1)
            {
                button_noord_holland = 0;
                this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button_zeeland == 0)
            {
                button_zeeland = 1;
                this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_zeeland == 1)
            {
                button_zeeland = 0;
                this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button_groningen == 0)
            {
                button_groningen = 1;
                this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_groningen == 1)
            {
                button_groningen = 0;
                this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button_noord_brabant == 0)
            {
                button_noord_brabant = 1;
                this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_noord_brabant == 1)
            {
                button_noord_brabant = 0;
                this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button_limburg == 0)
            {
                button_limburg = 1;
                this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_limburg == 1)
            {
                button_limburg = 0;
                this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button_utrecht == 0)
            {
                button_utrecht = 1;
                this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_utrecht == 1)
            {
                button_utrecht = 0;
                this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button_gelderland == 0)
            {
                button_gelderland = 1;
                this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_gelderland == 1)
            {
                button_gelderland = 0;
                this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button_overijssel == 0)
            {
                button_overijssel = 1;
                this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_overijssel == 1)
            {
                button_overijssel = 0;
                this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button_flevoland == 0)
            {
                button_flevoland = 1;
                this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_flevoland == 1)
            {
                button_flevoland = 0;
                this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button_drenthe == 0)
            {
                button_drenthe = 1;
                this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_drenthe == 1)
            {
                button_drenthe = 0;
                this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button_friesland == 0)
            {
                button_friesland = 1;
                this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            }
            else if (button_friesland == 1)
            {
                button_friesland = 0;
                this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            }
        }
    }
}
