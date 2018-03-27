using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
            label3.Text = "Player One : ";
        }
        bool playerTurn = false;

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button_click(object sender, EventArgs e)
        {
            label3.Text = label3.Text.EndsWith("Two :") ? "Player One :" : "Player Two :";
            playerTurn = !playerTurn;
            Button button = (Button)sender;
            if (playerTurn == true)
            {
                button.Text = "X";
            }
            else
                button.Text = "O";

             button.Enabled = false;
            
            if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "X")
            {
                label3.Text = "Player One Wins!";
                button1.BackColor= Color.Crimson;
                button2.BackColor = Color.Crimson;
                button3.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;


            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "X")
            {
                label3.Text = "Player One Wins!";
                button4.BackColor = Color.Crimson;
                button5.BackColor = Color.Crimson;
                button6.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == "X")
            {
                label3.Text = "Player One Wins!";
                button7.BackColor = Color.Crimson;
                button8.BackColor = Color.Crimson;
                button9.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else if (button1.Text == button5.Text && button5.Text == button7.Text && button7.Text == "X")
            {
                label3.Text = "Player One Wins!";
                button1.BackColor = Color.Crimson;
                button5.BackColor = Color.Crimson;
                button7.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if (button3.Text == button5.Text && button5.Text == button9.Text && button9.Text == "X")
            {
                label3.Text = "Player One Wins!";
                button3.BackColor = Color.Crimson;
                button5.BackColor = Color.Crimson;
                button9.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
            else if (button1.Text == button6.Text && button6.Text == button9.Text && button9.Text == "X")
            {
                label3.Text = "Player One Wins!";
                button1.BackColor = Color.Crimson;
                button6.BackColor = Color.Crimson;
                button9.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text == "X")
            {
                label3.Text = "Player One Wins!";
                button2.BackColor = Color.Crimson;
                button5.BackColor = Color.Crimson;
                button8.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
            }
            else if (button3.Text == button4.Text && button4.Text == button7.Text && button7.Text == "X")
            {
                label3.Text = "Player One Wins!";
                button3.BackColor = Color.Crimson;
                button4.BackColor = Color.Crimson;
                button7.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button1.Enabled = false;
                button2.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }


            if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "O")
            {
                label3.Text = "Player Two Wins!";
                button1.BackColor = Color.Crimson;
                button2.BackColor = Color.Crimson;
                button3.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "O")
            {
                label3.Text = "Player Two Wins!";
                button4.BackColor = Color.Crimson;
                button5.BackColor = Color.Crimson;
                button6.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == "O")
            {
                label3.Text = "Player Two Wins!";
                button7.BackColor = Color.Crimson;
                button8.BackColor = Color.Crimson;
                button9.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else if (button1.Text == button5.Text && button5.Text == button7.Text && button7.Text == "O")
            {
                label3.Text = "Player Two Wins!";
                button1.BackColor = Color.Crimson;
                button5.BackColor = Color.Crimson;
                button7.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if (button3.Text == button5.Text && button5.Text == button9.Text && button9.Text == "O")
            {
                label3.Text = "Player Two Wins!";
                button3.BackColor = Color.Crimson;
                button5.BackColor = Color.Crimson;
                button9.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
            else if (button1.Text == button6.Text && button6.Text == button9.Text && button9.Text == "O")
            {
                label3.Text = "Player Two Wins!";
                button1.BackColor = Color.Crimson;
                button6.BackColor = Color.Crimson;
                button9.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text == "O")
            {
                label3.Text = "Player Two Wins!";
                button2.BackColor = Color.Crimson;
                button5.BackColor = Color.Crimson;
                button8.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
            }
            else if (button3.Text == button4.Text && button4.Text == button7.Text && button7.Text == "O")
            {
                label3.Text = "Player Two Wins!";
                button3.BackColor = Color.Crimson;
                button4.BackColor = Color.Crimson;
                button7.BackColor = Color.Crimson;
                this.BackColor = Color.Gainsboro;
                button1.Enabled = false;
                button2.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button_new_game_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            playerTurn = false;
            Controls.Clear();
            InitializeComponent();
            label3.Text = "Player One : ";
            
        }

        private void m_enter(object sender, EventArgs e)
        {
            button_new_game.BackColor = Color.Orange;
        }

        private void m_leave(object sender, EventArgs e)
        {
            button_new_game.BackColor = Color.MediumSeaGreen;
        }

   
    }
}
