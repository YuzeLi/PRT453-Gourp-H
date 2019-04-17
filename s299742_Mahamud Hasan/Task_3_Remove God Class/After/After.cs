using GodClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GodClassLibrary.Model;

namespace GodClass
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            List<TimeSheetEntryAModel> timeSheets = LoadTimeSheets(); // Load employees timesheet
            List<CustomerModel> customers = DataAccess.GetCustomer(); // Load Customer's information
            EmployeeModel currentEmployee = DataAccess.GetCurrentEmployee(); // Load Employee's information
            customers.ForEach(x => BillCustomers(timeSheets, x));
            PayEmployee(timeSheets, currentEmployee); // Load employee payment information
            Console.WriteLine();
            Console.Write("Press any key to exit...............");
            Console.ReadKey();
        }

        /// <summary>
        /// This method calculate the employee payment
        /// </summary>
        /// <param name="timeSheets"></param>
        /// <param name="employee"></param>
        public static void PayEmployee(List<TimeSheetEntryAModel> timeSheets, EmployeeModel employee)
        {
            decimal totalPay = TimeSheetProcessor.calculateEmployeePay(timeSheets, employee);
            Console.WriteLine($"You will get paid${totalPay} for your time.");
        }
        
        /// <summary>
        /// This method calculating the customer's bill
        /// </summary>
        /// <param name="timeSheets"></param>
        /// <param name="customer"></param>
        private static void BillCustomers(List<TimeSheetEntryAModel> timeSheets, CustomerModel customer)
        {
            double totalHours = TimeSheetProcessor.GetHoursWorkForComapany(timeSheets, customer.CustomerName);
            Console.WriteLine($"Simulating sending mail to :{customer.CustomerName}");
            Console.WriteLine("Your bill is &" + (decimal)totalHours * customer.hourlyRateToBill + "for the hours worked.");
            Console.WriteLine();
        }
        
        /// <summary>
        /// Load employees work time
        /// </summary>
        /// <returns></returns>
        private static List<TimeSheetEntryAModel> LoadTimeSheets()
        {
            List<TimeSheetEntryAModel> output = new List<TimeSheetEntryAModel>();
            string entermoreTimeSheet = "";
            do
            {
                Console.Write("Enter what you did: ");
                string workDone = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                string rawTimeWorked = Console.ReadLine();
                double hoursworked;
                while (double.TryParse(rawTimeWorked, out hoursworked) == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid number given.");
                    Console.Write("How long did you do it for:");
                    rawTimeWorked = Console.ReadLine();
                }
                TimeSheetEntryAModel timeSheet = new TimeSheetEntryAModel()
                {
                    HoursWorked = hoursworked,
                    WorkDone = workDone
                };
                output.Add(timeSheet);
                Console.Write("Do you want to enter more item (y/n): ");
                entermoreTimeSheet = Console.ReadLine();
            } while (entermoreTimeSheet.ToLower() == "yes");
            Console.WriteLine();
            return output;
        }
    }
}
