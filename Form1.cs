using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_assignment
{
    public partial class Form1 : Form
    {
        double r = 0;
        String operation = "";
        bool change = false;
        public Form1()
        {
            InitializeComponent();
        }

        

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
         
                operation = button.Text;
                r = Double.Parse(textBox1.Text);
                label1.Text = r + " " + operation;
                change = true;
           
        }

        private void num_button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(change))
                textBox1.Clear();
            change = false;
            Button button= (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                textBox1.Text=(r+Double.Parse(textBox1.Text)).ToString();
            break;
                case "-":
            textBox1.Text = (r - Double.Parse(textBox1.Text)).ToString();
            break;
                case "*":
            textBox1.Text = (r * Double.Parse(textBox1.Text)).ToString();
            break;
                case "/":
            textBox1.Text = (r / Double.Parse(textBox1.Text)).ToString();
            break;
                default:
            break;
            }
            r = Double.Parse(textBox1.Text);
            label1.Text = "";
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.BlanchedAlmond;

        }

        private void operator_color(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.BurlyWood;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
