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
        [TestMethod]
        public void Given_Ride_Details_Should_Return_Total_Fair_For_All()
        {
            //AAA
            //Arrange
            Ride[] rides =
            {
                new Ride(5, 5, RideCategory.RideType.NORMAL) ,//55
                new Ride(10,3,RideCategory.RideType.PREMIUM)  //10*15+3*2=156=156+55=211
            };
            CabInvoiceGenerator cabInvoice = new CabInvoiceGenerator();
            double expected = 211;
            //Act
            double actual = cabInvoice.CalculateFair(rides);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Given_Ride_Details_Should_Return_Total_Fair_For_All_Average()
        {
            //AAA
            //Arrange
            Ride[] rides =
            {
                new Ride(5, 5, RideCategory.RideType.NORMAL) ,//55
                new Ride(10,3,RideCategory.RideType.PREMIUM)  //10*15+3*2=156=156+55=211
            };
            CabInvoiceGenerator cabInvoice = new CabInvoiceGenerator();
            Program expected = new Program();
            //Act
            InvoiceSummary actual = cabInvoice.CalculateFair3(rides);
            //Assert
            expected.Equals(actual);
        }
    }
}