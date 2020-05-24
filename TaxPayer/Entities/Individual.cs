using System;
using System.Collections.Generic;
using System.Text;

namespace TaxPayer.Entities
{
    class Individual : TaxPayer_
    {
        public double HealthExpenditures { get; set; }
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            double returnTax = 0.0;
            if (AnualIncome >= 20000)
            {
                returnTax = AnualIncome * 0.25;
            }
            else
            {
                returnTax = AnualIncome * 0.15;
            }
            if (HealthExpenditures >= 0)
            {
                returnTax -= HealthExpenditures / 2.0;
            }
            return returnTax;
        }
    }
}
