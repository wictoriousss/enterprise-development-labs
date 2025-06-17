using TaxiSystem.Domain.Models;

namespace TaxiSystem.Domain.Services.Interfaces
{
    public interface ICarRepository
    {
        Car Add(Car car);
        Car? GetById(int id);
        Car? GetByDriverId(int driverId);
        List<Car> GetCars();
        void Update(Car car);
        void Delete(Car car);
    }
}