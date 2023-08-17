using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProgram
{
    public class Ride
    {
        public double distance;
        public int time;
        public RideCategory.RideType rideCategory;
        public readonly int MINIMUM_FAIR;
        public readonly int COST_PER_MINUTE;
        public readonly int COST_PER_KM;
        public Ride(double distance, int time, RideCategory.RideType rideCategory)
        {
            this.distance = distance;
            this.time = time;
            this.rideCategory = rideCategory;

            if (rideCategory.Equals(RideCategory.RideType.NORMAL))
            {
                MINIMUM_FAIR = 5;
                COST_PER_KM = 10;
                COST_PER_MINUTE = 1;
            }
            else
            {
                MINIMUM_FAIR = 20;
                COST_PER_KM = 15;
                COST_PER_MINUTE = 2;
            }
        }
    }
}
