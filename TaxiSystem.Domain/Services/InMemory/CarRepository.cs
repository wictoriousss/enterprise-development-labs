using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.Interfaces;

namespace TaxiSystem.Domain.Services.InMemory
{
    public class CarRepository : ICarRepository
    {
        private static List<Car> _cars = new();

        public Car Add(Car car)
        {
            car.Id = _cars.Count + 1;
            _cars.Add(car);
            return car;
        }

        public Car? GetById(int id) => _cars.FirstOrDefault(c => c.Id == id);

        public Car? GetByDriverId(int driverId) => _cars.FirstOrDefault(c => c.DriverId == driverId);

        public List<Car> GetCars() => _cars;

        public void Update(Car car)
        {
            var existing = GetById(car.Id);
            if (existing != null)
            {
                existing.LicensePlate = car.LicensePlate;
                existing.Model = car.Model;
                existing.Color = car.Color;
                existing.DriverId = car.DriverId;
            }
        }

        public void Delete(Car car) => _cars.Remove(car);
    }
}