using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICE_GAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            button1.Enabled = false;

        }
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random random = new Random();
            int zar1, zar2;
            zar1 = random.Next(0, 6);
            zar2 = random.Next(0, 6);
            pictureBox1.Image = ımageList1.Images[zar1];
            pictureBox2.Image = ımageList1.Images[zar2];

            sayac++;

            if(sayac == 30) 
            {
                timer1.Stop();
                sayac = 0;
                button1.Enabled = true;
            }
            
        }
    }
}
