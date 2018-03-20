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

namespace WindowsFormsApp1
{
    public partial class DataVisual : Form
    {

        public DataVisual()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string str = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=PRO3-Datavisualisatie;Integrated Security=True";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                this.textBox10.Text = "Database Status: Verbonden";
            }
            catch (Exception es)
            {
                this.textBox10.Text = "Database Status: Niet Verbonden";
                MessageBox.Show(es.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visualisation_1 vis_1 = new Visualisation_1();
            vis_1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visualisation_2 vis_2 = new Visualisation_2();
            vis_2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visualisation_3 vis_3 = new Visualisation_3();
            vis_3.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public PictureBox NetherlandsMap;
    }
}
