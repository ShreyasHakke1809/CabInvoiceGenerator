using CabInvoiceGeneratorProgram;
using Microsoft.VisualStudio.TestPlatform.TestHost;


namespace CabInvoiceGeneratorMSTest
{
    [TestClass]
    public class CabInvoiceMSTest
    {
        [TestMethod]    
        public void Given_Ride_Details_Should_Return_Total_Fair()
        {
            //AAA
            //Arrange
            Ride ride = new Ride(5, 5, RideCategory.RideType.NORMAL);
            double expected = 55;
            CabInvoiceGenerator cabInvoice = new CabInvoiceGenerator();
            //Act
            double actual = cabInvoice.CalculateFair(ride);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}