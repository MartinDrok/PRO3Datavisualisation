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
    public partial class DataVisual : Form
    {

        public DataVisual()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NetherlandsMap = pictureBox1;
            NetherlandsMap.Image = Properties.Resources.netherlands_303419_1280;
            NetherlandsMap.SizeMode = PictureBoxSizeMode.Zoom;
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
