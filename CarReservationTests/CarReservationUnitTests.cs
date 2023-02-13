using CarReservationAPI.Controllers;
using NuGet.Protocol.Core.Types;

namespace CarReservationTests
{
    public class CarReservationUnitTests : IClassFixture<CarReservationSeedDataFixture>
    {
        private readonly CarReservationSeedDataFixture _fixture;

        public CarReservationUnitTests(CarReservationSeedDataFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void CarIsSuccesfulyRemoved()
        {
            //Arrange
            var initialCount = _fixture.CarReservationContext.Cars.Count();
            var car = _fixture.CarReservationContext.Cars.First();

            //Act
            _fixture.CarReservationContext.Cars.Remove(car);
            _fixture.CarReservationContext.SaveChanges();
            var finalCount = _fixture.CarReservationContext.Cars.Count();

            //Assert
            Assert.True(initialCount > finalCount);
        }

        //[Fact]
        //public void GetReturnsProduct()
        //{
        //    // Arrange
        //    var controller = new CarController();
        //    controller.Request = new HttpRequestMessage();
        //    controller.Configuration = new HttpConfiguration();

        //    // Act
        //    var response = controller.Get(10);

        //    // Assert
        //    Product product;
        //    Assert.IsTrue(response.TryGetContentValue<Product>(out product));
        //    Assert.AreEqual(10, product.Id);
        //}
    }
}