using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.Interfaces;

namespace TaxiSystem.Domain.Services.InMemory
{
    public class DriverRepository : IDriverRepository
    {
        private static List<Driver> _drivers = new();

        public Driver Add(Driver driver)
        {
            driver.Id = _drivers.Count + 1;
            _drivers.Add(driver);
            return driver;
        }

        public Driver? GetById(int id) => _drivers.FirstOrDefault(d => d.Id == id);

        public List<Driver> GetDrivers() => _drivers;

        public void Update(Driver driver)
        {
            var existing = GetById(driver.Id);
            if (existing != null)
            {
                existing.FullName = driver.FullName;
                existing.PassportNumber = driver.PassportNumber;
                existing.Address = driver.Address;
                existing.Phone = driver.Phone;
            }
        }

        public void Delete(Driver driver) => _drivers.Remove(driver);

        public object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}