using Xunit;
using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.InMemory;

namespace TaxiSystem.Domain.Tests.Repositories
{
    public class DriverRepositoryTests
    {
        private readonly DriverRepository _repo = new();

        [Fact]
        public void Add_ShouldAssignId()
        {
            var driver = new Driver { FullName = "Test" };
            var result = _repo.Add(driver);
            Assert.True(result.Id > 0);
            Assert.Equal("Test", _repo.GetById(result.Id)?.FullName);
        }

        [Fact]
        public void Delete_ShouldRemoveDriver()
        {
            var driver = _repo.Add(new Driver());
            _repo.Delete(driver);
            Assert.Null(_repo.GetById(driver.Id));
        }
    }
}