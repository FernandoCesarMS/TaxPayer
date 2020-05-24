using System;
using System.Collections.Generic;
using System.Text;

namespace TaxPayer.Entities
{
    class Company : TaxPayer_
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double returnTax = 0.0;
            if (NumberOfEmployees > 10)
            {
                returnTax = AnualIncome * 0.14;
            }
            else if (NumberOfEmployees >= 0)
            {
                returnTax = AnualIncome * 0.16;
            }
            return returnTax;
        }
    }
}
