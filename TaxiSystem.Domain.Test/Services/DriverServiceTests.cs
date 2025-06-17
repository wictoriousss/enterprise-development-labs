using Xunit;
using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services;
using TaxiSystem.Domain.Services.InMemory;

namespace TaxiSystem.Domain.Tests.Services
{
    public class DriverServiceTests
    {
        private readonly DriverService _service;
        private readonly DriverRepository _repo = new();

        public DriverServiceTests()
        {
            _service = new DriverService(_repo);
        }

        [Fact]
        public void UpdateDriver_ShouldModifyData()
        {
            var driver = _service.AddDriver(new Driver { FullName = "Old" });
            driver.FullName = "New";
            _service.UpdateDriver(driver);

            Assert.Equal("New", _service.GetDriverById(driver.Id)?.FullName);
        }
    }
}