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
            
        }

        private void FixBotton_Click(object sender, EventArgs e)
		{
			var result = Calculator.FixExpression(Convert.ToString(this.InPutBox.Text.Trim()));
			this.OutPutBox.Clear();
            this.OutPutBox.Text = result;
        }
    }
}


