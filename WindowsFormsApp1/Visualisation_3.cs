﻿using System;
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

        int[] rgb_leftclick_array = new int[] { 255, 177, 101 };
        int[] rgb_rightclick_array = new int[] { 255, 39, 113 };
        int[] rgb_emptyclick_array = new int[] { 250, 250, 250 };


        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_zuid_holland == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_zuid_holland = 1;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_zuid_holland = " OR RegioVanVertrek LIKE 'Zuid-Holland'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zuid_holland = 2;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Zuid-Holland'";
                }
            }
            else if (button_zuid_holland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_zuid_holland = 0;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_zuid_holland = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zuid_holland = 2;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_zuid_holland = "";
                    filter_vestiging = "'Zuid-Holland'";
                }
            }
            else if (button_zuid_holland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_zuid_holland = 1;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_zuid_holland = " OR RegioVanVertrek LIKE 'Zuid-Holland'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zuid_holland = 0;
                    this.button4.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
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
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_noord_holland = " OR RegioVanVertrek LIKE 'Noord-Holland'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_holland = 2;
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Noord-Holland'";
                }
            }
            else if (button_noord_holland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_noord_holland = 0;
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_noord_holland = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_holland = 2;
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_noord_holland = "";
                    filter_vestiging = "'Noord-Holland'";
                }
            }
            else if (button_noord_holland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_noord_holland = 1;
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_noord_holland = " OR RegioVanVertrek LIKE 'Noord-Holland'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_holland = 0;
                    this.button5.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
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
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_zeeland = " OR RegioVanVertrek LIKE 'Zeeland'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zeeland = 2;
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Zeeland'";
                }
            }
            else if (button_zeeland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_zeeland = 0;
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_zeeland = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zeeland = 2;
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_zeeland = "";
                    filter_vestiging = "'Zeeland'";
                }
            }
            else if (button_zeeland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_zeeland = 1;
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_zeeland = " OR RegioVanVertrek LIKE 'Zeeland'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_zeeland = 0;
                    this.button6.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
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
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_noord_brabant = " OR RegioVanVertrek LIKE 'Noord-Brabant'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_brabant = 2;
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Noord-Brabant'";
                }
            }
            else if (button_noord_brabant == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_noord_brabant = 0;
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_noord_brabant = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_brabant = 2;
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_noord_brabant = "";
                    filter_vestiging = "'Noord-Brabant'";
                }
            }
            else if (button_noord_brabant == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_noord_brabant = 1;
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_noord_brabant = " OR RegioVanVertrek LIKE 'Noord-Brabant'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_noord_brabant = 0;
                    this.button7.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
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
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_utrecht = " OR RegioVanVertrek LIKE 'Utrecht'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_utrecht = 2;
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Utrecht'";
                }
            }
            else if (button_utrecht == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_utrecht = 0;
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_utrecht = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_utrecht = 2;
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_utrecht = "";
                    filter_vestiging = "'Utrecht'";
                }
            }
            else if (button_utrecht == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_utrecht = 1;
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_utrecht = " OR RegioVanVertrek LIKE 'Utrecht'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_utrecht = 0;
                    this.button8.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
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
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_flevoland = " OR RegioVanVertrek LIKE 'Flevoland'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_flevoland = 2;
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Flevoland'";
                }
            }
            else if (button_flevoland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_flevoland = 0;
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_flevoland = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_flevoland = 2;
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_flevoland = "";
                    filter_vestiging = "'Flevoland'";
                }
            }
            else if (button_flevoland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_flevoland = 1;
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_flevoland = " OR RegioVanVertrek LIKE 'Flevoland'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_flevoland = 0;
                    this.button9.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
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
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_gelderland = " OR RegioVanVertrek LIKE 'Gelderland'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_gelderland = 2;
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Gelderland'";
                }
            }
            else if (button_gelderland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_gelderland = 0;
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_gelderland = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_gelderland = 2;
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_gelderland = "";
                    filter_vestiging = "'Gelderland'";
                }
            }
            else if (button_gelderland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_gelderland = 1;
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_gelderland = " OR RegioVanVertrek LIKE 'Gelderland'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_gelderland = 0;
                    this.button10.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
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
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_limburg = " OR RegioVanVertrek LIKE 'Limburg'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_limburg = 2;
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Limburg'";
                }
            }
            else if (button_limburg == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_limburg = 0;
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_limburg = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_limburg = 2;
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_limburg = "";
                    filter_vestiging = "'Limburg'";
                }
            }
            else if (button_limburg == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_limburg = 1;
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_limburg = " OR RegioVanVertrek LIKE 'Limburg'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_limburg = 0;
                    this.button11.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
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
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_overijssel = " OR RegioVanVertrek LIKE 'Overijssel'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_overijssel = 2;
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Overijssel'";
                }
            }
            else if (button_overijssel == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_overijssel = 0;
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_overijssel = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_overijssel = 2;
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_overijssel = "";
                    filter_vestiging = "'Overijssel'";
                }
            }
            else if (button_overijssel == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_overijssel = 1;
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_overijssel = " OR RegioVanVertrek LIKE 'Overijssel'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_overijssel = 0;
                    this.button12.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
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
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_drenthe = " OR RegioVanVertrek LIKE 'Drenthe'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_drenthe = 2;
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Drenthe'";
                }
            }
            else if (button_drenthe == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_drenthe = 0;
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_drenthe = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_drenthe = 2;
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_drenthe = "";
                    filter_vestiging = "'Drenthe'";
                }
            }
            else if (button_drenthe == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_drenthe = 1;
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_drenthe = " OR RegioVanVertrek LIKE 'Drenthe'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_drenthe = 0;
                    this.button13.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
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
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_friesland = " OR RegioVanVertrek LIKE 'Friesland'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_friesland = 2;
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Friesland'";
                }
            }
            else if (button_friesland == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_friesland = 0;
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_friesland = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_friesland = 2;
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_friesland = "";
                    filter_vestiging = "'Friesland'";
                }
            }
            else if (button_friesland == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_friesland = 1;
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_friesland = " OR RegioVanVertrek LIKE 'Friesland'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_friesland = 0;
                    this.button14.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
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
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_groningen = " OR RegioVanVertrek LIKE 'Groningen'";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_groningen = 2;
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_vestiging = "'Groningen'";
                }
            }
            else if (button_groningen == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_groningen = 0;
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_groningen = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_groningen = 2;
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(rgb_rightclick_array[0])))), ((int)(((byte)(rgb_rightclick_array[1])))), ((int)(((byte)(rgb_rightclick_array[2])))));
                    filter_groningen = "";
                    filter_vestiging = "'Groningen'";
                }
            }
            else if (button_groningen == 2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    button_groningen = 1;
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(rgb_leftclick_array[0])))), ((int)(((byte)(rgb_leftclick_array[1])))), ((int)(((byte)(rgb_leftclick_array[2])))));
                    filter_groningen = " OR RegioVanVertrek LIKE 'Groningen'";
                    filter_vestiging = "";
                }
                else if (e.Button == MouseButtons.Right)
                {
                    button_groningen = 0;
                    this.button15.BackColor = Color.FromArgb(((int)(((byte)(rgb_emptyclick_array[0])))), ((int)(((byte)(rgb_emptyclick_array[1])))), ((int)(((byte)(rgb_emptyclick_array[2])))));
                    filter_vestiging = "";
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private int button_jaar2011 = 0;
        private int button_jaar2012 = 0;
        private int button_jaar2013 = 0;
        private int button_jaar2014 = 0;
        private int button_jaar2015 = 0;
        private int button_jaar2016 = 0;

        private string filter_Perioden = "";

        private void buttonjaar2011_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2011 == 0)
            {
                button_jaar2011 = 1;
                this.buttonjaar2011.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
                button_jaar2012 = 0;
                button_jaar2013 = 0;
                button_jaar2014 = 0;
                button_jaar2015 = 0;
                button_jaar2016 = 0;
                this.buttonjaar2012.Image = null;
                this.buttonjaar2013.Image = null;
                this.buttonjaar2014.Image = null;
                this.buttonjaar2015.Image = null;
                this.buttonjaar2016.Image = null;
                filter_Perioden = "'%2011%'";
            }
            else
            {
                button_jaar2011 = 0;
                this.buttonjaar2011.Image = null;
                filter_Perioden = "";
            }           
        }

        private void buttonjaar2012_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2012 == 0)
            {
                button_jaar2012 = 1;
                this.buttonjaar2012.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
                button_jaar2011 = 0;
                button_jaar2013 = 0;
                button_jaar2014 = 0;
                button_jaar2015 = 0;
                button_jaar2016 = 0;
                this.buttonjaar2011.Image = null;
                this.buttonjaar2013.Image = null;
                this.buttonjaar2014.Image = null;
                this.buttonjaar2015.Image = null;
                this.buttonjaar2016.Image = null;
                filter_Perioden = "'%2012%'";
            }
            else
            {
                button_jaar2012 = 0;
                this.buttonjaar2012.Image = null;
                filter_Perioden = "";
            }
        }

        private void buttonjaar2013_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2013 == 0)
            {
                button_jaar2013 = 1;
                this.buttonjaar2013.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
                button_jaar2011 = 0;
                button_jaar2012 = 0;
                button_jaar2014 = 0;
                button_jaar2015 = 0;
                button_jaar2016 = 0;
                this.buttonjaar2011.Image = null;
                this.buttonjaar2012.Image = null;
                this.buttonjaar2014.Image = null;
                this.buttonjaar2015.Image = null;
                this.buttonjaar2016.Image = null;
                filter_Perioden = "'%2013%'";
            }
            else
            {
                button_jaar2013 = 0;
                this.buttonjaar2013.Image = null;
                filter_Perioden = "";
            }
        }

        private void buttonjaar2014_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2014 == 0)
            {
                button_jaar2014 = 1;
                this.buttonjaar2014.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
                button_jaar2011 = 0;
                button_jaar2012 = 0;
                button_jaar2013 = 0;
                button_jaar2015 = 0;
                button_jaar2016 = 0;
                this.buttonjaar2011.Image = null;
                this.buttonjaar2012.Image = null;
                this.buttonjaar2013.Image = null;
                this.buttonjaar2015.Image = null;
                this.buttonjaar2016.Image = null;
                filter_Perioden = "'%2014%'";
            }
            else
            {
                button_jaar2014 = 0;
                this.buttonjaar2014.Image = null;
                filter_Perioden = "";
            }
        }

        private void buttonjaar2015_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2015 == 0)
            {
                button_jaar2015 = 1;
                this.buttonjaar2015.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
                button_jaar2011 = 0;
                button_jaar2012 = 0;
                button_jaar2013 = 0;
                button_jaar2014 = 0;
                button_jaar2016 = 0;
                this.buttonjaar2011.Image = null;
                this.buttonjaar2012.Image = null;
                this.buttonjaar2013.Image = null;
                this.buttonjaar2014.Image = null;
                this.buttonjaar2016.Image = null;
                filter_Perioden = "'%2015%'";
            }
            else
            {
                button_jaar2015 = 0;
                this.buttonjaar2015.Image = null;
                filter_Perioden = "";
            }
        }

        private void buttonjaar2016_MouseDown(object sender, MouseEventArgs e)
        {
            if (button_jaar2016 == 0)
            {
                button_jaar2016 = 1;
                this.buttonjaar2016.Image = global::WindowsFormsApp1.Properties.Resources.checkedbox56x29;
                button_jaar2011 = 0;
                button_jaar2012 = 0;
                button_jaar2013 = 0;
                button_jaar2014 = 0;
                button_jaar2015 = 0;
                this.buttonjaar2011.Image = null;
                this.buttonjaar2012.Image = null;
                this.buttonjaar2013.Image = null;
                this.buttonjaar2014.Image = null;
                this.buttonjaar2015.Image = null;
                filter_Perioden = "'%2016%'";
            }
            else
            {
                button_jaar2016 = 0;
                this.buttonjaar2016.Image = null;
                filter_Perioden = "";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLaden_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (filter_Perioden != "")
                {
                    string str = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=PRO3-Datavisualisatie;Integrated Security=True";              // Maakt verbinding met SQL server
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    this.textBox10.Text = "Database Status: Verbonden";

                    string queryExclude = "'Nederland'";

                    SqlDataAdapter adapterVerhuizingen = new SqlDataAdapter(                                                                //  Maakt DataAdapter aan met SQL query
                        "SELECT * FROM MMVerhuizingen" +
                        " WHERE "
                        + " RegioVanVestiging LIKE " + filter_vestiging
                        + " AND Perioden LIKE " + filter_Perioden
                        + " AND (RegioVanVertrek LIKE 'Nederland'"
                        + filter_zuid_holland
                        + filter_noord_holland
                        + filter_zeeland
                        + filter_noord_brabant
                        + filter_utrecht
                        + filter_flevoland
                        + filter_gelderland
                        + filter_limburg
                        + filter_overijssel
                        + filter_drenthe
                        + filter_friesland
                        + filter_groningen
                        + ") AND RegioVanVertrek NOT LIKE" + queryExclude
                        + " AND RegioVanVertrek NOT LIKE" + filter_vestiging
                        , con);

                    DataSet datasetMM1 = new DataSet("MM-Verhuizingen");                                                                                      // Maakt DataSet aan
                    adapterVerhuizingen.FillSchema(datasetMM1, SchemaType.Source, "MMVerhuizingen");                                      // Vult DataSet met data uit SQL database
                    adapterVerhuizingen.Fill(datasetMM1, "MMVerhuizingen");
                    DataTable tableVerhuizingen;                                                                                                // Maakt DataTables aan in DataSet
                    tableVerhuizingen = datasetMM1.Tables["MMVerhuizingen"];

                    SqlDataAdapter adapterBedrijven = new SqlDataAdapter("SELECT * FROM MMVestigingen", con);                                  // Maakt DataAdapter en DataSet aan
                    DataSet datasetMM2 = new DataSet("MMVestigingen");
                    adapterBedrijven.FillSchema(datasetMM2, SchemaType.Source, "MMVestigingen");                                         // Vult DataSet met data uit SQL database
                    adapterBedrijven.Fill(datasetMM2, "MMVestigingen");
                    DataTable tableBedrijven;                                                                                                   // Maakt DataTables aan in DataSet
                    tableBedrijven = datasetMM2.Tables["MMVestigingen"];

                    foreach (DataRow row in tableVerhuizingen.Rows)                      // Vult console met waarden uit DataTable, goee manier om werking van datatable te testen
                    {
                        foreach (DataColumn col in tableVerhuizingen.Columns)
                            Console.Write(string.Format("{0, -10}", row[col].ToString()));
                        //Console.WriteLine(col.ColumnName);
                        Console.WriteLine();
                    }

                    chart3.DataSource = datasetMM1;                                                                                                      // vult de chart met data
                    chart3.Series["Aantal personen"].XValueMember = "RegioVanVertrek";
                    chart3.Series["Aantal personen"].YValueMembers = "TussenGemeentenVerhuisdePersonen_1";
                    chart3.Titles.Add("Verhuisde personen naar " + filter_vestiging + filter_Perioden);
                }
                else if (filter_Perioden == "")
                {
                    MessageBox.Show("Selecteer eerst een jaartaal.");
                }
            }
            catch (Exception es)                                                                                                               // Als de verbinding is mislukt
            {
                this.textBox10.Text = "Database Status: Niet Verbonden";
                MessageBox.Show(es.Message);
            }
        }

        private void buttonLaden_Click(object sender, EventArgs e)
        {

        }
    }
}
