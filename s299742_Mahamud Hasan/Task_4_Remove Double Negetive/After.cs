using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleNegative
{
    public class Order
    {
        public void Checkout(IEnumerable<Product> products, Customer customer)
        {
            if (customer.IsFlagged)
            {
                return;
            }
        }
    }

    public class Customer
    {
        public decimal Balance { get; private set; }

        public bool IsFlagged
        {
            get { return Balance >= 30m; }
        }
    }

    public class Product
    {
    }
}
