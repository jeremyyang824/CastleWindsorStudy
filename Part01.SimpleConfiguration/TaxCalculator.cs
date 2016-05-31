using System;

namespace Part01.SimpleConfiguration
{
    public class TaxCalculator
    {
        private decimal _rate = 0.125m;

        public decimal Rate
        {
            set { _rate = value; }
            get { return _rate; }
        }

        public decimal CalculateTax(decimal gross)
        {
            return Math.Round(_rate * gross, 2);
        }
    }
}
