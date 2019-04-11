using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverterWindow
{
    public partial class Form1 : Form
    {
        decimal converter1 = 0, converter2 = 0;
        string combo1, combo2;
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            converter1 = AddingConverter(comboBox1.SelectedItem.ToString());
            combo1 = comboBox1.SelectedItem.ToString();
            Calculation();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            Calculation();
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            converter2 = AddingConverter(comboBox3.SelectedItem.ToString());
            combo2 = comboBox3.SelectedItem.ToString();
            Calculation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedItem = "m";
            this.comboBox3.SelectedItem = "m";
        }

        private decimal AddingConverter(string name)
        {
            decimal converter = 0;
            switch (name)
            {
                case "mm":
                    converter = 1000M;
                    break;
                case "cm":
                    converter = 100M;
                    break;
                case "m":
                    converter = 1M;
                    break;
                case "km":
                    converter = 0.001M;
                    break;
                case "mi":
                    converter = 0.000621371192M;
                    break;
                case "in":
                    converter = 39.3700787M;
                    break;
                case "ft":
                    converter = 3.2808399M;
                    break;
                case "yd":
                    converter = 1.0936133M;
                    break;
            }

            return converter;
        }

        private void Calculation()
        {
            decimal x2 = (numericUpDown1.Value / converter1) * converter2;
            this.ResultLabel.Text = string.Concat(numericUpDown1.Value, " ", combo1, " is ", x2, " ", combo2);
        }
    }
}
