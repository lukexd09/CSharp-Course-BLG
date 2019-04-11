using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ValueField_ValueChanged(object sender, EventArgs e)
        {
            double pln = Convert.ToDouble(this.ValueField.Value);
            double usd = pln / 3.80401704;
            this.LabelTxt.Text = pln + " PLN = " + Math.Round(usd, 2) + " USD"; 
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
