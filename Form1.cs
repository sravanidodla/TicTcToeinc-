using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        static char currentIndex = 'X';
        bool r = false, t = false;
        bool c = false, d = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void flipplayer()
        {
            if (currentIndex == 'X')
            {
                currentIndex = 'O';
            }
            else if (currentIndex == 'O')
            {
                currentIndex = 'X';
            }
        }
        bool b1 = false, b2 = false, b3 = false, b4 = false, b5 = false, b6 = false, b7 = false, b8 = false, b9 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = currentIndex.ToString();
            if (button1.Text == "X")
            {
                button1.ForeColor = Color.Fuchsia;
            }
            else if (button1.Text == "O")
            {
                button1.ForeColor = Color.LavenderBlush;
            }
            b1 = true;
            flipplayer();
            disable();
            if (b1)
            {
                button1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = currentIndex.ToString();
            if (button2.Text == "X")
            {
                button2.ForeColor = Color.Fuchsia;
            }
            else if (button2.Text == "O")
            {
                button2.ForeColor = Color.LavenderBlush;
            }
            b2 = true;
            flipplayer();
            disable();
            if (b2)
            {
                button2.Enabled = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = currentIndex.ToString();
            if (button3.Text == "X")
            {
                button3.ForeColor = Color.Fuchsia;
            }
            else if (button3.Text == "O")
            {
                button3.ForeColor = Color.LavenderBlush;
            }
            b3 = true;
            flipplayer();
            disable();
            if (b3)
            {
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = currentIndex.ToString();
            if (button4.Text == "X")
            {
                button4.ForeColor = Color.Fuchsia;
            }
            else if (button4.Text == "O")
            {
                button4.ForeColor = Color.LavenderBlush;
            }
            flipplayer();
            disable();
            b4 = true;

            if (b4)
            {
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = currentIndex.ToString();
            if (button5.Text == "X")
            {
                button5.ForeColor = Color.Fuchsia;
            }
            else if (button5.Text == "O")
            {
                button5.ForeColor = Color.LavenderBlush;
            }
            b5 = true;
            flipplayer();
            disable();
            if (b5)
            {
                button5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = currentIndex.ToString();
            if (button5.Text == "X")
            {
                button5.ForeColor = Color.Fuchsia;
            }
            else if (button5.Text == "O")
            {
                button5.ForeColor = Color.LavenderBlush;
            }
            b6 = true;
            flipplayer();
            disable();
            if (b6)
            {
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = currentIndex.ToString();
            if (button7.Text == "X")
            {
                button7.ForeColor = Color.Fuchsia;
            }
            else if (button7.Text == "O")
            {
                button7.ForeColor = Color.LavenderBlush;
            }
            b7 = true;
            flipplayer();
            disable();
            if (b7)
            {
                button7.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = currentIndex.ToString();
            if (button8.Text == "X")
            {
                button8.ForeColor = Color.Fuchsia;
            }
            else if (button8.Text == "O")
            {
                button8.ForeColor = Color.LavenderBlush;
            }
            b8 = true;
            flipplayer();
            disable();
            if (b8)
            {
                button8.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = currentIndex.ToString();
            if (button9.Text == "X")
            {
                button9.ForeColor = Color.Fuchsia;
            }
            else if (button9.Text == "O")
            {
                button9.ForeColor = Color.LavenderBlush;
            }
            b9 = true;
            flipplayer();
            disable();
            if (b9)
            {
                button9.Enabled = false;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Your game started";


        }
        private string checkrows()
        {

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                textBox1.Text = "X won the game";
                r = true;
             

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                textBox1.Text = "O won the game";
                r = true;           

            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                textBox1.Text = "X won the game";
                r = true;
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                textBox1.Text = "O won the game";
                r = true;
             
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                textBox1.Text = "X won the game";
                r = true;
               
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                textBox1.Text = "O won the game";
                r = true;
               
            }

            return textBox1.Text;
        }
        private string checkcolumns()
        {
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                textBox1.Text = "X won the game";
                c = true;
                
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                textBox1.Text = "O won the game";
                c = true;
                
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                textBox1.Text = "X won the game";
                c = true;
                
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                textBox1.Text = "O won the game";
                c = true;
                
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                textBox1.Text = "X won the game";
                c = true;
                
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                textBox1.Text = "O won the game";
                c = true;
                
            }

            return textBox1.Text;
        }
        private string checkdiagonal()
        {
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                textBox1.Text = "X won the game";
                d = true;
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                textBox1.Text = "O won the game";
                d = true;
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                textBox1.Text = "X won the game";
                d = true;
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                textBox1.Text = "O won the game";
                d = true;
            }

            return textBox1.Text;
        }
        private string checktie()
        {
            //if (r && d || c && d || trow || tcol)

            if (button1.Text != "-" && button2.Text != "-" && button3.Text != "-" && button4.Text != "-" && button5.Text != "-" && button6.Text != "-"&&button7.Text != "-"&& button8.Text != "-"&& button9.Text != "-")
            {
                textBox1.Text = "Its a tie, Play again";
                t = true;
            }
            return textBox1.Text;
        }
        private void disable()
        {
            textBox1.Text = checkrows();
            textBox1.Text = checkcolumns();
            textBox1.Text = checkdiagonal();
            textBox1.Text = checktie();
            if (r || c || d || t)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                return;
            }
        }
    }
}
