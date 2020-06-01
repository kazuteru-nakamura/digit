using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitCalculator
{
    public partial class Form1 : Form
    {
        private Calculator _calculator;
        private int _maxDigit;

        public Form1()
        {
            InitializeComponent();

            _maxDigit = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cardinal.SelectedIndex = 0;
            ShowDigit();
        }

        private void Cardinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            _calculator = new Calculator(int.Parse(Cardinal.Text), _maxDigit);
            _calculator.Reset();
            ShowDigit();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            _calculator.Reset();
            ShowDigit();
        }

        private void Digit1Add_Click(object sender, EventArgs e)
        {
            _calculator.Add(1);
            ShowDigit();
        }

        private void Digit2Add_Click(object sender, EventArgs e)
        {
            _calculator.Add(2);
            ShowDigit();
        }

        private void Digit3Add_Click(object sender, EventArgs e)
        {
            _calculator.Add(3);
            ShowDigit();
        }

        private void Digit4Add_Click(object sender, EventArgs e)
        {
            _calculator.Add(4);
            ShowDigit();
        }

        private void ShowDigit()
        {
            var sb = new StringBuilder();

            foreach (var item in _calculator.GetDigit().Reverse().ToList())
            {
                sb.Append(item.ToString());
            }

            var digit = sb.ToString().PadLeft(_maxDigit, '0');

            Digit1.Text = digit.Substring(3, 1);
            Digit2.Text = digit.Substring(2, 1);
            Digit3.Text = digit.Substring(1, 1);
            Digit4.Text = digit.Substring(0, 1);
        }

    }
}
