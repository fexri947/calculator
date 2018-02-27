using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_2
{
    public partial class Calculator : Form
    {
        double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {if ((result.Text == "0")||(operation_pressed))
                result.Text = "";
            operation_pressed = false;
            Button b = (Button)sender;
            result.Text += b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void opr_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Convert.ToDouble(result.Text);
            operation_pressed = true;


        }

        private void op_5_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = (value + Convert.ToDouble(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Convert.ToDouble(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Convert.ToDouble(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Convert.ToDouble(result.Text)).ToString();
                    break;
                case "%":
                    result.Text = ((value * Convert.ToDouble(result.Text)) / 100).ToString();
                    break;
                default:
                    break;
                    
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
