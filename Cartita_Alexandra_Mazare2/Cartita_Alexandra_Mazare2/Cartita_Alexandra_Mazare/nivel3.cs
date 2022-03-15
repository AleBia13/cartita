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
    public partial class nivel3 : Form
    {
        public nivel3()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int time = 30;
        int puncte = 0;
        public static string SetValueForText1 = "";
        public static int fo = 0;
        private void invizibil()
        {
            cartita1.Visible = false;
            cartita2.Visible = false;
            cartita3.Visible = false;
            cartita4.Visible = false;
            cartita5.Visible = false;
            cartita6.Visible = false;
            cartita7.Visible = false;
            cartita8.Visible = false;
            cartita9.Visible = false;
            cartita10.Visible = false;
            cartita11.Visible = false;
            cartita12.Visible = false;

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
                cartita1.Visible = false;
            }
        }

        private void Cartita5_Click(object sender, EventArgs e)
        {
            if (cartita5.Visible == true)
            {
                puncte++;
                cartita1.Visible = false;
            }
        }

        private void Cartita3_Click(object sender, EventArgs e)
        {
            if (cartita3.Visible == true)
            {
                puncte++;
                cartita1.Visible = false;
            }
        }

        private void Cartita4_Click(object sender, EventArgs e)
        {
            if (cartita4.Visible == true)
            {
                puncte++;
                cartita1.Visible = false;
            }
        }

        private void Cartita11_Click(object sender, EventArgs e)
        {
            if (cartita11.Visible == true)
            {
                puncte++;
                cartita1.Visible = false;
            }
        }

        private void Cartita10_Click(object sender, EventArgs e)
        {
            if (cartita10.Visible == true)
            {
                puncte++;
                cartita1.Visible = false;
            }
        }

        private void Cartita9_Click(object sender, EventArgs e)
        {
            if (cartita9.Visible == true)
            {
                puncte++;
                cartita1.Visible = false;
            }
        }

        private void Cartita6_Click(object sender, EventArgs e)
        {
            if (cartita6.Visible == true)
            {
                puncte++;
                cartita1.Visible = false;
            }
        }

        private void Cartita8_Click(object sender, EventArgs e)
        {
            if (cartita8.Visible == true)
            {
                puncte++;
                cartita1.Visible = false;
            }
        }

        private void Cartita7_Click(object sender, EventArgs e)
        {
            if (cartita7.Visible == true)
            {
                puncte++;
                cartita1.Visible = false;
            }
        }

        private void Cartita12_Click(object sender, EventArgs e)
        {
            if (cartita12.Visible == true)
            {
                puncte++;
                cartita1.Visible = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(puncte);
            label2.Text = Convert.ToString(time);
            time--;
            if (time == 0)
            {
                this.Visible = false;
                EndGame f = new EndGame();
                SetValueForText1 = label1.Text;
                fo = 3;
                f.Show();
                this.Hide();
            }
            int r;
            invizibil();
            r = random.Next(1, 15);
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
            if (r == 6)
                cartita6.Visible = true;
            if (r == 7)
                cartita7.Visible = true;
            if (r == 8)
                cartita8.Visible = true;
            if (r == 9)
                cartita9.Visible = true;
            if (r == 10)
                cartita10.Visible = true;
            if (r == 11)
                cartita11.Visible = true;
            if (r == 12)
                cartita12.Visible = true;


        }
    }
}
