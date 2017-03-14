using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorClass;

namespace MyCalculator
{
    public partial class FormMain : Form
    {
        Calculator cal = new Calculator();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void inPut2_TextChanged(object sender, EventArgs e)
        {
            cal.b = Convert.ToDouble(this.inPut2.Text.Trim());
        }

        private void inPut1_TextChanged(object sender, EventArgs e)
        {
            cal.a = Convert.ToDouble(this.inPut1.Text.Trim());
        }

        private void outPut1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            double result = cal.Add();
            this.outPut1.Text = result.ToString();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            double result = cal.Sub();
            this.outPut1.Text = result.ToString();
        }

        private void Max_Click_1(object sender, EventArgs e)
        {
            double result = cal.Max();
            this.outPut1.Text = result.ToString();
        }

        private void Min_Click(object sender, EventArgs e)
        {
            double result = cal.Min();
            this.outPut1.Text = result.ToString();
        }
    }
}
    
