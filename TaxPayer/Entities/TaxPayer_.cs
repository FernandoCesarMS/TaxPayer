using System;
using System.Collections.Generic;
using System.Text;

namespace TaxPayer.Entities
{
    abstract class TaxPayer_
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer_(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
