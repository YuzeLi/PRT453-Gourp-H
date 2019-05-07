using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk_8_EncpslteConditional
{
    class TimeSheet
    {
        public IBillable Resources { get; private set; }
        public double GetCharge(int days)
        {
            double result = Resources.Rate * days;
            if (Resources.HasSpecialSkill)
            {
                result *= 1.05;
            }
            return result;
        }
    }
    interface IBillable
    {
        double Rate { get; }
        bool HasSpecialSkill { get; }
    }
    public class Employee:IBillable
    {
        public double Rate { get; private set; }
        public bool HasSpecialSkill { get; private set; }
    }
}
