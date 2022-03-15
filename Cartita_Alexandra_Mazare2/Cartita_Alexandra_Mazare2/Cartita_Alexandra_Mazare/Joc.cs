using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartita_Alexandra_Mazare
{
    public partial class Joc : Form
    {
        public Joc()
        {
            InitializeComponent();
            
        }
        Random random = new Random();
        int time = 30;
        int puncte = 0;
        public static string SetValueForText1 = "";
        public static int fo = 0;
        private void Hole1_Click(object sender, EventArgs e)
        {

        }
        private void invizibil()
        {
            cartita1.Visible = false;
            cartita2.Visible = false;
            cartita3.Visible = false;
            cartita4.Visible = false;
            cartita5.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(time);
            label2.Text = Convert.ToString(puncte);
            time--;
            if (time == 0)
            {
                this.Visible = false;
                EndGame f = new EndGame();
                SetValueForText1 = label2.Text;
                fo = 1;
                f.Show();
                this.Hide();
            }
            int r;
            invizibil();
            r = random.Next(1, 7);
            if (r == 1)
                cartita1.Visible = true;
            if (r == 2)
                cartita2.Visible = true;
            if (r == 3)
                cartita3.Visible = true;
            if (r == 4)
                cartita4.Visible = true;
            if (r == 5)
                cartita5.Visible = true;

        }

        private void Cartita1_Click(object sender, EventArgs e)
        {
            if (cartita1.Visible == true)
            {
                puncte++;
                cartita1.Visible = false;
            }
        }

        private void Cartita2_Click(object sender, EventArgs e)
        {
            if (cartita2.Visible == true)
            {
                puncte++;
                cartita2.Visible = false;
            }
        }

        private void Cartita3_Click(object sender, EventArgs e)
        {
            if (cartita3.Visible == true)
            {
                puncte++;
                cartita3.Visible = false;
            }
        }

        private void Cartita4_Click(object sender, EventArgs e)
        {
            if (cartita4.Visible == true)
            {
                puncte++;
                cartita4.Visible = false;
            }
        }

        private void Cartita5_Click(object sender, EventArgs e)
        {
            if (cartita5.Visible == true)
            {
                puncte++;
                cartita5.Visible = false;
            }
        }

        private void Joc_Load(object sender, EventArgs e)
        {

        }
    }
}

