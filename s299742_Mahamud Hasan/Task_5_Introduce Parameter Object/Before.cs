using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceParameterObject
{
    class Account
    {
        private List<Entry> lstEntries { get; set; }

        public double GetResult(DateTime start, DateTime end)
        {
            double result = 0;
            foreach (var entry in lstEntries)
            {
                if (start <= entry.ChargeDate && end >= entry.ChargeDate)
                {
                    result += entry.value;
                }
            }
            return result;
        }
    }

    internal class Entry
    {
        internal double value;

        public DateTime ChargeDate { get; internal set; }
    }
}
