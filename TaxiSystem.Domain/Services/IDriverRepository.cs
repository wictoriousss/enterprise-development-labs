using TaxiSystem.Domain.Models;

namespace TaxiSystem.Domain.Services
{
    public interface IDriverRepository
    {
        Driver Add(Driver driver);
        Driver? GetById(int id);
        List<Driver> GetDrivers();
        void Update(Driver driver);
        void Delete(Driver driver);
    }
}