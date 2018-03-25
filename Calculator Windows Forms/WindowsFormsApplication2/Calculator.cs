using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Calculator : Form
    {
        Double result = 0;
        String operation = "";
        bool isOpreationClicked = false;
        public Calculator()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOpreationClicked))
                textBox1.Clear();

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
            textBox1.Text = textBox1.Text + button.Text;
            isOpreationClicked = false;
        }

        private void button_all_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = textBox1.Text + "0";
            result = 0;
            button_plus.BackColor = Color.DarkOrange;
            button_plus.ForeColor = Color.White;
            button_minus.BackColor = Color.DarkOrange;
            button_minus.ForeColor = Color.White;
            button_division.BackColor = Color.DarkOrange;
            button_division.ForeColor = Color.White;
            button_multiplication.BackColor = Color.DarkOrange;
            button_multiplication.ForeColor = Color.White;
        }
        
        private void operator_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (result != 0)
            {
                button_equals.PerformClick();
                operation = button.Text;
                isOpreationClicked = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(textBox1.Text);
                isOpreationClicked = true;
            }
            button_plus.BackColor = Color.DarkOrange;
            button_plus.ForeColor = Color.White;
            button_minus.BackColor = Color.DarkOrange;
            button_minus.ForeColor = Color.White;
            button_division.BackColor = Color.DarkOrange;
            button_division.ForeColor = Color.White;
            button_multiplication.BackColor = Color.DarkOrange;
            button_multiplication.ForeColor = Color.White;
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "x":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "÷":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                
                default:
                    break;
            }
            button_plus.BackColor = Color.DarkOrange;
            button_plus.ForeColor = Color.White;
            button_minus.BackColor = Color.DarkOrange;
            button_minus.ForeColor = Color.White;
            button_division.BackColor = Color.DarkOrange;
            button_division.ForeColor = Color.White;
            button_multiplication.BackColor = Color.DarkOrange;
            button_multiplication.ForeColor = Color.White;
            result = Double.Parse(textBox1.Text);
        }
        
        private void m_click(object sender, EventArgs e)
        {
            button_plus.BackColor = Color.White;
            button_plus.ForeColor = Color.DarkOrange;   
        }

        private void m1_click(object sender, MouseEventArgs e)
        {
            button_division.BackColor = Color.White;
            button_division.ForeColor = Color.DarkOrange;
        }

        private void m2_click(object sender, MouseEventArgs e)
        {
            button_multiplication.BackColor = Color.White;
            button_multiplication.ForeColor = Color.DarkOrange;
        }

        private void m3_click(object sender, MouseEventArgs e)
        {
            button_minus.BackColor = Color.White;
            button_minus.ForeColor = Color.DarkOrange;
        }

        private void button_plus_minus_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOpreationClicked))
                textBox1.Clear();

            Button button = (Button)sender;
            if (button.Text == "+/-")
            {
                if (!textBox1.Text.Contains("-"))
                    textBox1.Text = "-"+ textBox1.Text;
            }
            else
                textBox1.Text = "-" + textBox1.Text; 
        }

        private void button_percentage_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = (result * Double.Parse(textBox1.Text) / 100).ToString();   
        }
    }
}
