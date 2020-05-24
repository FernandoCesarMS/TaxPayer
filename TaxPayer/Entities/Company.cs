using System;
using System.Collections.Generic;
using System.Text;

namespace TaxPayer.Entities
{
    class Company : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public Company(string name,double anualIncome, double healthExpenditures) : base(name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            throw new NotImplementedException();
        }
    }
}
