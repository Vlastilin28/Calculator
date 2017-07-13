using System;
using System.Windows.Forms;
using Calculator.OneArgument;
using Calculator.TwoArgument;

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
            try
            {
                double numberOne = Convert.ToDouble(textBox_enterone.Text);
                double numberTwo = Convert.ToDouble(textBox_entertwo.Text);
                var calc = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
                double result = calc.Calculate(numberOne, numberTwo);
                label1.Text = Convert.ToString(result);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc.Message);
                textBox_enterone.Clear();
                textBox_entertwo.Clear();
            }
        }
        private void OneClick(object sender, EventArgs e)
        {
            try
            {
                double nubmerThree = Convert.ToDouble(textBox_enterone.Text);
                var calc = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = calc.Calculate(nubmerThree);
                label2.Text = Convert.ToString(result);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc.Message);
                textBox_enterone.Clear();
            }
        }
    }
}
