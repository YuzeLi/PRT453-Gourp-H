using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakMethod
{
    public class CashRegister
    {
        public CashRegister()
        {
            Tax = 0.06m;
        }

        private decimal Tax { get; set; }

        private IEnumerable<Product> Products { get; set; }

       /// <summary>
       /// This method using for accepting payment
       /// </summary>
       /// <param name="customer"></param>
       /// <param name="products"></param>
       /// <param name="payment"></param>
        public void AcceptPayment(Customer customer, IEnumerable<Product> products, decimal payment)
        {
            decimal subTotal = CalculateSubtotal();

            subTotal = SubtractDiscounts(subTotal); 

            decimal grandTotal = AddTax(subTotal);

            SubtractFromCustomerBalance(customer, grandTotal);
        }

        /// <summary>
        /// This method calculate the deducted balance
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="grandTotal"></param>
        private void SubtractFromCustomerBalance(Customer customer, decimal grandTotal)
        {
            customer.DeductFromAccountBalance(grandTotal);
        }

        /// <summary>
        /// This method calculate the TAX based on subtotal
        /// </summary>
        /// <param name="subTotal"></param>
        /// <returns></returns>
        private decimal AddTax(decimal subTotal)
        {
            return subTotal * Tax;
        }

        /// <summary>
        /// This method calculate discount
        /// </summary>
        /// <param name="subTotal"></param>
        /// <returns></returns>
        private decimal SubtractDiscounts(decimal subTotal)
        {
            foreach (Product product in Products)
            {
                subTotal -= product.AvailableDiscounts;
            }
            return subTotal;
        }

        /// <summary>
        /// This method calculate the subtotal of the product price. 
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="grandTotal"></param>
        private decimal CalculateSubtotal()
        {
            decimal subTotal = 0m;
            foreach (Product product in Products)
            {
                subTotal += product.Price;
            }
            return subTotal;
        }
    }

    public class Customer
    {
        public void DeductFromAccountBalance(decimal amount)
        {
            // deduct from balance
        }
    }

    public class Product
    {
        public decimal Price { get; set; }
        public decimal AvailableDiscounts { get; set; }
    }
}
