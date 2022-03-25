using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufacturedDate)
            : base (name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) - ${Price.ToString("F2", CultureInfo.InvariantCulture)} ({ManufacturedDate.ToString("dd/MM/yyyy")})";
        }
    }
}
