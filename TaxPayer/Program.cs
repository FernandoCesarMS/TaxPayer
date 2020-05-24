using System;
using System.Collections.Generic;
using System.Globalization;
using TaxPayer.Entities;

namespace TaxPayer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer_> list = new List<TaxPayer_>();
            Console.Write("Enter the number of tax payers: ");
            int amountPayers = int.Parse(Console.ReadLine());
            for(int i = 1; i <= amountPayers; i++)
            {
                Console.WriteLine("Tax payer #{0} data:",i);
                Console.Write("Individual or company (i/c)? ");
                char choicePayerKind = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (choicePayerKind == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    Individual individual = new Individual(name, anualIncome, healthExpenditures);
                    list.Add(individual);
                }
                else if (choicePayerKind == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    Company company = new Company(name, anualIncome, numberOfEmployees);
                    list.Add(company);
                }
            }
            double totalTaxes = 0.0;
            Console.WriteLine("\nTAXES PAID: ");
            foreach(TaxPayer_ taxPayer in list)
            {
                totalTaxes += taxPayer.Tax();
                Console.WriteLine("{0}: $ {1}",taxPayer.Name,taxPayer.Tax().ToString("F2",CultureInfo.InvariantCulture));
            }
            Console.WriteLine("\nTOTAL TAXES: $ {0}",totalTaxes.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
