using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSubClass
{
    class JobItem
    {
        public int Quantity { get; private set; }
        public bool IsLabour { get; set; }
        public virtual int UnitPrice { get; set; }
        public int TotalPrice
        {
            get { return UnitPrice * Quantity; }
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitPrice"></param>
        /// <param name="quantity"></param>
        protected JobItem(int unitPrice, int quantity)
        {
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }

    class LaborItem : JobItem
    {
        public Employee Employee { get; protected set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="employee"></param>
        public LaborItem(int quantity, Employee employee) : base(0, quantity)
        {
            Employee = employee;
        }
        public override int UnitPrice
        {
            get
            {
                return Employee.Rate;
            }
            set
            {
                base.UnitPrice = value;
            }
        }
    }

    class Employee
    {
        public int Rate { get; internal set; }
    }
}
