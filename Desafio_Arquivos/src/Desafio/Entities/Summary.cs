using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Entities
{
    internal class Summary
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public double GetTotal()
        {
            return Product.Price * Quantity;
        }
    }
}
