using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncoming, double healthExpenditures) : base(name, annualIncoming)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000)
            {
                return (AnnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
