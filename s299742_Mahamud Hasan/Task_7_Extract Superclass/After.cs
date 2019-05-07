using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_ExtractSuperClass
{
    /// <summary>
    /// SuperClass
    /// </summary>
    abstract class Party
    {
        public string Name { get; private set; }
        public abstract int AnnualCost { get; }
        protected Party(string name)
        {
            Name = name;
        }
    }

    class Employee : Party
    {
        public string ID { get; private set; }
        private int _annualCost;
        public override int AnnualCost
        {
            get { return _annualCost; }
        }
        public Employee(string name, string id, int cost)
        : base(name)
        {
            ID = id;
            _annualCost = cost;
        }
    }

    class Department : Party
    {
        public IEnumerable<Party> Parties { get; private set; }
        public override int AnnualCost
        {
            get { return Parties.Sum(s => s.AnnualCost); }
        }
        public int HeadCount
        {
            get { return Parties.Count(); }
        }
        public Department(string name)
            : base(name)
        {
            Parties = new List<Party>();
        }
        public void AddParty(Party party)
        {
            ((IList<Party>)Parties).Add(party);
        }
    }
}
