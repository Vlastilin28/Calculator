using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            double result;
            switch (((Button)sender).Name)
            {
                case "button_plus":
                    result = numberone + numbertwo;
                    break;
                case "button_minus":
                    result = numberone - numbertwo;
                    break;
                case "button_multiply":
                    result = numberone * numbertwo;
                    break;
                case "button_divide":
                    result = numberone / numbertwo;
                    
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }

            label1.Text = Convert.ToString(result);
        }
    }
}
