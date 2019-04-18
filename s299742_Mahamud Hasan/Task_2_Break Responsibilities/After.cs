using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakResponsibilities
{
    /// <summary>
    /// This VideoA class has the responsibility of video renting functionality.
    /// </summary>
    public class VideoA
    {
        public void RentVideo(VideoA video, CustomerA customer)
        {
            customer.Videos.Add(video);
        }
    }

    /// <summary>
    /// This CustomerA class has reponsiblity of paying the fees.
    /// </summary>
    public class CustomerA
    {
        public IList<decimal> LateFees { get; set; }
        public IList<VideoA> Videos { get; set; }

        public void PayFee(decimal fee)
        {
        }

        public decimal CalculateBalance(CustomerA customer)
        {
            return customer.LateFees.Sum();
        }
    }

}
