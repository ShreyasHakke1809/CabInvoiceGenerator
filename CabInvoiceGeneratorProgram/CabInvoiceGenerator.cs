using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProgram
{
    public class CabInvoiceGenerator
    {
        public double CalculateFair(Ride ride)
        {
            double totalFair = 0;
            if (ride.distance <= 0)
            {
                throw new CabInvoiceException("Invalid Distance", CabInvoiceException.ExceptionType.INVALID_DISTANCE);
            }
            else if (ride.time <= 0)
            {
                throw new CabInvoiceException("Incalid Time", CabInvoiceException.ExceptionType.INVALID_TIME);
            }
            else
            {
                totalFair = ride.distance * ride.COST_PER_KM + ride.time * ride.COST_PER_MINUTE;
                return Math.Max(ride.MINIMUM_FAIR, totalFair);
            }
        }
       
    }
}
