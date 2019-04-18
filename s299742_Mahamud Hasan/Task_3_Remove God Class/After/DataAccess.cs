using GodClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodClassLibrary
{
    public static class DataAccess
    {
        public static List<CustomerModel> GetCustomer()
        {
            List<CustomerModel> output = new List<CustomerModel>
            {
                new CustomerModel { CustomerName = "Acme", hourlyRateToBill = 150 },
                new CustomerModel { CustomerName = "Abc", hourlyRateToBill = 125 }
            };
            return output;
        }

        public static EmployeeModel GetCurrentEmployee()
        {
            EmployeeModel output = new EmployeeModel { FirstName = "sue", LastName = "smith", HourlyRate = 15 };
            return output;
        }
    }
}
