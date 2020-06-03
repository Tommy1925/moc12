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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ruch++;
            if(gracz1)
            {
                ((Button)sender).Text = "X";
            }

            else
            {
                ((Button)sender).Text = "O";
            }
        }

        bool gracz1 = true;
        int  ruch = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            NowaGra();
            gracz1 = true;
        }

        private void NowaGra()
        {
            ruch = 0;
            Button[] wszystkie = new Button[9];
            wszystkie[0] = button1;
            wszystkie[1] = button2;
            wszystkie[2] = button3;
            wszystkie[3] = button4;
            wszystkie[4] = button5;
            wszystkie[5] = button6;
            wszystkie[6] = button7;
            wszystkie[7] = button8;
            wszystkie[8] = button9;

            foreach(Button przycisk in wszystkie)
            {
                przycisk.Enabled = true;
                przycisk.Text = "";
            }
        
        }
    }
}
