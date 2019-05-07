using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_ExtractSuperClass
{
    class Employee
    {
        public string Name { get; private set; }
        public string ID { get; private set; }
        public int AnnualCost { get; private set; }

        public Employee(string name, string id, int cost)
        {
            Name = name;
            ID = id;
            AnnualCost = cost;
        }
    }
    class Department
    {
        public string Name { get; private set; }
        public IEnumerable<Employee> Staff { get; private set; }
        public int TotalAnnualCost
        {
            get { return Staff.Sum(s => s.AnnualCost); }
        }
        public int HeadCount
        {
            get { return Staff.Count(); }
        }
        public Department(string name)
        {
            Name = name;
            Staff = new List<Employee>();
        }
        public void AddStaff(Employee employee)
        {
            ((IList<Employee>)Staff).Add(employee);
        }
    }
}
