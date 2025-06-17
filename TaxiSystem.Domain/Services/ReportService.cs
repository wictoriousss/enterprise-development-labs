using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.InMemory;
using TaxiSystem.Domain.Services.Interfaces;

namespace TaxiSystem.Domain.Services
{
    public class ReportService
    {
        private readonly IDriverRepository _driverRepository;
        private readonly ICarRepository _carRepository; // Добавлено
        private readonly IUserRepository _userRepository;
        private readonly ITripRepository _tripRepository;
        private DriverRepository driverRepo;
        private UserRepository userRepo;
        private TripRepository tripRepo;

        public ReportService(DriverRepository driverRepo, UserRepository userRepo, TripRepository tripRepo)
        {
            this.driverRepo = driverRepo;
            this.userRepo = userRepo;
            this.tripRepo = tripRepo;
        }

        public ReportService(
            IDriverRepository driverRepository,
            ICarRepository carRepository, // Добавлено
            IUserRepository userRepository,
            ITripRepository tripRepository)
        {
            _driverRepository = driverRepository;
            _carRepository = carRepository; // Добавлено
            _userRepository = userRepository;
            _tripRepository = tripRepository;
        }

        // 1. Сведения о водителе и его автомобиле
        public (Driver? Driver, Car? Car) GetDriverWithCarDetails(int driverId)
        {
            var driver = _driverRepository.GetById(driverId);
            var car = driver != null ? _carRepository.GetByDriverId(driver.Id) : null;
            return (driver, car);
        }

      

        public class DriverTripStats
        {
            public Driver Driver { get; set; }
            public int TripCount { get; set; }
            public TimeSpan AverageDuration { get; set; }
            public TimeSpan MaxDuration { get; set; }
        }
    }
}