using Xunit;
using System;
using System.Linq;
using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services;
using TaxiSystem.Domain.Services.InMemory;

namespace TaxiSystem.Domain.Tests.Services
{
    public class ReportServiceTests
    {
        private readonly ReportService _service;
        private readonly DriverRepository _driverRepo = new();
        private readonly UserRepository _userRepo = new();
        private readonly TripRepository _tripRepo = new();

        public ReportServiceTests()
        {
            _service = new ReportService(_driverRepo, _userRepo, _tripRepo);
            SeedTestData();
        }

        private void SeedTestData()
        {
            var driver = _driverRepo.Add(new Driver { FullName = "Driver 1" });
            var user = _userRepo.Add(new User { FullName = "User 1" });
            
            _tripRepo.Add(new Trip { 
                DriverId = driver.Id, 
                UserId = user.Id, 
                Date = DateTime.Now 
            });
        }

  
    }
}