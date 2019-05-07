using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk_8_EncpslteConditional
{
    class TimeSheet
    {
        public Employee employee { get; private set; }

        public double GetCharge(int days)
        {
            double result = employee.Rate * days;
            if (employee.HasSpecialSkill)
            {
                result *= 1.05;
            }

            return result;
        }
    }



    public class Employee
    {
        public int Rate { get; private set; }
        public bool HasSpecialSkill { get; private set; }
    }
}
