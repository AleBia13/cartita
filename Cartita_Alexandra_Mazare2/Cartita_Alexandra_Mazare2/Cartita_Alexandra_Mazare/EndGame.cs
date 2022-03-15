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
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {

            if (nivel2.fo == 2)
                label1.Text = nivel2.SetValueForText1;
            else
                if (Joc.fo == 1)
                label1.Text = Joc.SetValueForText1;
            else
                    if (nivel3.fo == 3)
                label1.Text = nivel3.SetValueForText1;
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "";
            Cartita f = new Cartita();
            f.Show();
            this.Hide();
        }
    }
}
