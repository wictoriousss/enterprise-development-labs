using Xunit;
using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.InMemory;
using TaxiSystem.Domain.Services.Interfaces;

namespace TaxiSystem.Domain.Tests.Repositories
{
    public class CarRepositoryTests
    {
        private readonly ICarRepository _carRepository = new CarRepository();
        private readonly IDriverRepository _driverRepository = new DriverRepository();

        [Fact]
        public void GetByDriverId_ShouldReturnCar()
        {
            var driver = _driverRepository.Add(new Driver { FullName = "Test Driver" });
            var car = _carRepository.Add(new Car { DriverId = driver.Id, LicensePlate = "А123БВ" });

            var result = _carRepository.GetByDriverId(driver.Id);
            Assert.Equal(car.Id, result?.Id);
        }
    }
}