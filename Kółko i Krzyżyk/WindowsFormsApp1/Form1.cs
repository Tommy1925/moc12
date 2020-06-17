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

        private void Sprawdzenie()
        {
           if(button1.Text != "" && button1.Text == button2.Text && button1.Text == button3.Text)
            {
                Wygrana();
            }

           else if(button4.Text != "" && button4.Text == button5.Text && button4.Text == button6.Text)
            {
                Wygrana();
            }

           else if(button7.Text != "" && button7.Text == button8.Text && button7.Text == button9.Text)
            {
                Wygrana();
            }

           else if(button1.Text != "" && button1.Text == button4.Text && button1.Text == button7.Text)
            {
                Wygrana();
            }

           else if(button2.Text !="" && button2.Text == button5.Text && button2.Text == button8.Text)
            {
                Wygrana();
            }

           else if(button3.Text != "" && button3.Text == button6.Text && button3.Text == button9.Text)
            {
                Wygrana();
            }

           else if(button1.Text != "" && button1.Text == button5.Text && button1.Text == button9.Text)
            {
                Wygrana();
            }

           else if(button3.Text != "" && button3.Text == button5.Text && button3.Text == button7.Text)
            {
                Wygrana();
            }

           else if( ruch == 9)
            {
                MessageBox.Show("Remis", "Koniec Gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NowaGra();
            }
        }

        private void Wygrana()
        {
            if(gracz1)
            {
                MessageBox.Show("Wygrywa Gracz: X", "Koniec Gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NowaGra();
            }

            else
            {
                MessageBox.Show("Wygrywa Gracz: O", "Koniec Gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NowaGra();
            }
            

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
            
            ((Button)sender).Enabled = false;

            if(ruch >= 5)
            {
                Sprawdzenie();
            }
            gracz1 = !gracz1;
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

        private void button2_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1)
            {
                ((Button)sender).Text = "X";
            }

            else
            {
                ((Button)sender).Text = "O";
            }

            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            gracz1 = !gracz1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1)
            {
                ((Button)sender).Text = "X";
            }

            else
            {
                ((Button)sender).Text = "O";
            }

            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            gracz1 = !gracz1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1)
            {
                ((Button)sender).Text = "X";
            }

            else
            {
                ((Button)sender).Text = "O";
            }

            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            gracz1 = !gracz1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1)
            {
                ((Button)sender).Text = "X";
            }

            else
            {
                ((Button)sender).Text = "O";
            }

            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            gracz1 = !gracz1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1)
            {
                ((Button)sender).Text = "X";
            }

            else
            {
                ((Button)sender).Text = "O";
            }

            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            gracz1 = !gracz1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1)
            {
                ((Button)sender).Text = "X";
            }

            else
            {
                ((Button)sender).Text = "O";
            }

            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            gracz1 = !gracz1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1)
            {
                ((Button)sender).Text = "X";
            }

            else
            {
                ((Button)sender).Text = "O";
            }

            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            gracz1 = !gracz1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1)
            {
                ((Button)sender).Text = "X";
            }

            else
            {
                ((Button)sender).Text = "O";
            }

            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            gracz1 = !gracz1;
        }
    }
}
