using System;
using System.Collections.Generic;
using System.Text;

namespace TaxPayer.Entities
{
    class Individual : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Individual(string name,double anualIncome, int numberOfEmployees) : base(name,anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            throw new NotImplementedException();
        }
    }
}
