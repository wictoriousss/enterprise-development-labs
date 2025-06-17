using Xunit;
using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.InMemory;
using TaxiSystem.Domain.Services.Interfaces;

namespace TaxiSystem.Domain.Tests.Repositories
{
    public class DriverRepositoryTests
    {
        private readonly IDriverRepository _repository = new DriverRepository();

        [Fact]
        public void AddDriver_ShouldAssignId()
        {
            var driver = new Driver { FullName = "Test Driver" };
            var result = _repository.Add(driver);
            Assert.True(result.Id > 0);
        }

        [Fact]
        public void GetById_ShouldReturnDriver()
        {
            var driver = _repository.Add(new Driver { FullName = "Test Driver" });
            var result = _repository.GetById(driver.Id);
            Assert.Equal(driver.Id, result?.Id);
        }

        [Fact]
        public void UpdateDriver_ShouldModifyData()
        {
            var driver = _repository.Add(new Driver { FullName = "Old Name" });
            driver.FullName = "New Name";
            _repository.Update(driver);
            var updatedDriver = _repository.GetById(driver.Id);
            Assert.Equal("New Name", updatedDriver?.FullName);
        }
    }
}