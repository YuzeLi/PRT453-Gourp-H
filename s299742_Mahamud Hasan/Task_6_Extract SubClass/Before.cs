using System;

namespace ExtractSubclass
{
    class JobItem
    {
        public int Quantity { get; private set; }
        public Employee Employee { get; private set; }
        public bool IsLabour { get; set; }
        private int _unitPrice;

        public int UnitPrice
        {
            get
            {
                return IsLabour ? Employee.Rate : UnitPrice;
            }
            set
            {
                _unitPrice = value;
            }
        }

        public int TotalPrice
        {
            get { return UnitPrice * Quantity; }
        }

        public JobItem(int unitPrice, int quantity, bool isLabour, Employee employee)
        {
            UnitPrice = unitPrice;
            Quantity = quantity;
            IsLabour = isLabour;
            Employee = employee;
        }

    }

    class Employee
    {
        public int Rate { get; internal set; }
    }


}