using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCalculator;

namespace MyCalculator
{
    public partial class FormMain : Form
    {
        TheCalculator.Calculator cal = new TheCalculator.Calculator();

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }

        private void OutPutBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InPutBox_TextChanged(object sender, EventArgs e)
        {
            cal.NewExpression(Convert.ToString(this.InPutBox.Text.Trim()));
        }

        private void FixBotton_Click(object sender, EventArgs e)
        {
            string result = cal.FixExpression();
            this.OutPutBox.Text = result.ToString();
        }
    }
}


