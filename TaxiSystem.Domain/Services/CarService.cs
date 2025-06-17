using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.Interfaces;

namespace TaxiSystem.Domain.Services
{
    public class CarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Car AddCar(Car car) => _carRepository.Add(car);

        public Car? GetCarById(int id) => _carRepository.GetById(id);

        public Car? GetCarByDriverId(int driverId) => _carRepository.GetByDriverId(driverId);

        public List<Car> GetCars() => _carRepository.GetCars();

        public void UpdateCar(Car car) => _carRepository.Update(car);

        public void DeleteCar(Car car) => _carRepository.Delete(car);
    }
}