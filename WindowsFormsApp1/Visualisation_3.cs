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

        private int button_zuid_holland = 0;    // button 4
        private int button_noord_holland = 0;   // button 5
        private int button_zeeland = 0;         // button 6
        private int button_noord_brabant = 0;   // button 7
        private int button_utrecht = 0;         // button 8
        private int button_flevoland = 0;       // button 9
        private int button_gelderland = 0;      // button 10
        private int button_limburg = 0;         // button 11
        private int button_overijssel = 0;      // button 12
        private int button_drenthe = 0;         // button 13
        private int button_friesland = 0;       // button 14
        private int button_groningen = 0;       // button 15

        private int button_jaar2011 = 0;
        private int button_jaar2012 = 0;
        private int button_jaar2013 = 0;
        private int button_jaar2014 = 0;
        private int button_jaar2015 = 0;
        private int button_jaar2016 = 0;

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_zuid_holland == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_zuid_holland = 1;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zuid_holland = 2;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_zuid_holland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_zuid_holland = 0;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zuid_holland = 2;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_zuid_holland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_zuid_holland = 1;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zuid_holland = 0;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_noord_holland == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_noord_holland = 1;
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_holland = 2;
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_noord_holland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_noord_holland = 0;
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_holland = 2;
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_noord_holland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_noord_holland = 1;
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_holland = 0;
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_zeeland == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_zeeland = 1;
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zeeland = 2;
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_zeeland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_zeeland = 0;
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zeeland = 2;
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_zeeland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_zeeland = 1;
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zeeland = 0;
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_noord_brabant == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_noord_brabant = 1;
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_brabant = 2;
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_noord_brabant == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_noord_brabant = 0;
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_brabant = 2;
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_noord_brabant == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_noord_brabant = 1;
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_brabant = 0;
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_utrecht == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_utrecht = 1;
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_utrecht = 2;
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_utrecht == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_utrecht = 0;
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_utrecht = 2;
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_utrecht == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_utrecht = 1;
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_utrecht = 0;
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_flevoland == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_flevoland = 1;
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_flevoland = 2;
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_flevoland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_flevoland = 0;
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_flevoland = 2;
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_flevoland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_flevoland = 1;
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_flevoland = 0;
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_gelderland == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_gelderland = 1;
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_gelderland = 2;
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_gelderland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_gelderland = 0;
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_gelderland = 2;
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_gelderland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_gelderland = 1;
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_gelderland = 0;
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_limburg == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_limburg = 1;
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_limburg = 2;
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_limburg == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_limburg = 0;
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_limburg = 2;
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_limburg == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_limburg = 1;
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_limburg = 0;
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_overijssel == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_overijssel = 1;
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_overijssel = 2;
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_overijssel == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_overijssel = 0;
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_overijssel = 2;
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_overijssel == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_overijssel = 1;
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_overijssel = 0;
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_drenthe == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_drenthe = 1;
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_drenthe = 2;
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_drenthe == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_drenthe = 0;
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_drenthe = 2;
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_drenthe == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_drenthe = 1;
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_drenthe = 0;
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_friesland == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_friesland = 1;
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_friesland = 2;
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_friesland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_friesland = 0;
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_friesland = 2;
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_friesland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_friesland = 1;
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_friesland = 0;
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void button15_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_groningen == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_groningen = 1;
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_groningen = 2;
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_groningen == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_groningen = 0;
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_groningen = 2;
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                }
            }
            else if (button_groningen == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_groningen = 1;
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_groningen = 0;
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonjaar2011_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2011 == 0)
            {
                button_jaar2011 = 1;
                this.buttonjaar2011.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
            }
            else
            {
                button_jaar2011 = 0;
                this.buttonjaar2011.Image = null;
            }
            
        }

        private void buttonjaar2012_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2012 == 0)
            {
                button_jaar2012 = 1;
                this.buttonjaar2012.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
            }
            else
            {
                button_jaar2012 = 0;
                this.buttonjaar2012.Image = null;
            }
        }

        private void buttonjaar2013_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2013 == 0)
            {
                button_jaar2013 = 1;
                this.buttonjaar2013.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
            }
            else
            {
                button_jaar2013 = 0;
                this.buttonjaar2013.Image = null;
            }
        }

        private void buttonjaar2014_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2014 == 0)
            {
                button_jaar2014 = 1;
                this.buttonjaar2014.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
            }
            else
            {
                button_jaar2014 = 0;
                this.buttonjaar2014.Image = null;
            }
        }

        private void buttonjaar2015_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2015 == 0)
            {
                button_jaar2015 = 1;
                this.buttonjaar2015.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
            }
            else
            {
                button_jaar2015 = 0;
                this.buttonjaar2015.Image = null;
            }
        }

        private void buttonjaar2016_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2016 == 0)
            {
                button_jaar2016 = 1;
                this.buttonjaar2016.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
            }
            else
            {
                button_jaar2016 = 0;
                this.buttonjaar2016.Image = null;
            }
        }
    }
}
