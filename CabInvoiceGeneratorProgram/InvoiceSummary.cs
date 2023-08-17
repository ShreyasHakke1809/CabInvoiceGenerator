using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorProgram
{
    public class InvoiceSummary
    {
        public double totalFair;
        public int numberOfRides;
        public double average;
        public InvoiceSummary(double totalFair, int numberOfRides)
        {
            this.totalFair = totalFair;
            this.numberOfRides = numberOfRides;
            this.average = totalFair / numberOfRides;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else if (!(obj is InvoiceSummary))
            {
                return false;
            }
            else
            {
                InvoiceSummary invoiceSummary = (InvoiceSummary)obj;
                return invoiceSummary.totalFair == totalFair && invoiceSummary.numberOfRides == numberOfRides;
            }

        }
    }
}
