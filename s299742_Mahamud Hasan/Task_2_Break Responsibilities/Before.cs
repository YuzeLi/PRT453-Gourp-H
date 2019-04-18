using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakResponsibilities
{
    public class Before
    {
        public void PayFee(decimal fee)
        {
        }
        public void RentVideo(Video video, Customer customer)
        {
            customer.Videos.Add(video);
        }

        public decimal CalculateBalance(Customer customer)
        {
            return customer.LateFees.Sum();
        }
    }

    public class Customer
    {
        public IList<decimal> LateFees { get; set; }
        public IList<Video> Videos { get; set; }
    }

    public class Video
    {
    }
}
