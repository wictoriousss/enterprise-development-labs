using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.Interfaces;

namespace TaxiSystem.Domain.Services
{
    public class DriverService
    {
        private readonly IDriverRepository _driverRepository;

        public DriverService(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        public Driver AddDriver(Driver driver) => _driverRepository.Add(driver);

        public Driver? GetDriverById(int id) => _driverRepository.GetById(id);

        public List<Driver> GetDrivers() => _driverRepository.GetDrivers();

        public void UpdateDriver(Driver driver) => _driverRepository.Update(driver);

        public void DeleteDriver(Driver driver) => _driverRepository.Delete(driver);
    }
}