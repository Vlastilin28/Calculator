using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_click(object sender, EventArgs e)
        {
            double numberone = Convert.ToDouble(textBox_enterone.Text);
            double numbertwo = Convert.ToDouble(textBox_entertwo.Text);
            var calc = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calc.Calculate(numberone, numbertwo);
            label1.Text = Convert.ToString(result);
        }

    }
}
