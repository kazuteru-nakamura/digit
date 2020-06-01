using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCalculator
{
    public class Calculator
    {

        private int _cardinal;
        private int _maxDigit;
        private int _current;

        public Calculator(int cardinal, int maxDigit)
        {
            _cardinal = cardinal;
            _maxDigit = maxDigit;
            _current = 0;
        }

        public void Add(int digit)
        {
            _current += (int)Math.Pow(_cardinal, digit - 1);

            if (_current > (int)Math.Pow(_cardinal, _maxDigit) - 1)
            {
                Reset();
            }
        }

        public void Reset()
        {
            _current = 0;
        }

        public IList<int> GetDigit()
        {
            int dividend = _current;
            IList<int> digitTable = new List<int>();

            if (dividend < _cardinal)
            {
                digitTable.Add(dividend);
                return digitTable;
            }

            while (dividend / _cardinal > 0)
            {
                if (dividend / _cardinal < _cardinal)
                {
                    digitTable.Add(dividend % _cardinal);
                    digitTable.Add(dividend / _cardinal);
                    break;
                }

                digitTable.Add(dividend % _cardinal);
                dividend /= _cardinal;
            }

            return digitTable;
        }

    }
}
