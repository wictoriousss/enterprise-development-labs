using Xunit;
using System;
using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.InMemory;

namespace TaxiSystem.Domain.Tests.Repositories
{
    public class TripRepositoryTests
    {
        private readonly TripRepository _repo = new();

        [Fact]
        public void GetTripsByDateRange_ShouldFilterCorrectly()
        {
            var trip1 = _repo.Add(new Trip { Date = DateTime.Now.AddDays(-1) });
            var trip2 = _repo.Add(new Trip { Date = DateTime.Now.AddDays(1) });

            var results = _repo.GetTripsByDateRange(DateTime.Now.AddDays(-2), DateTime.Now);

            Assert.Single(results);
            Assert.Contains(trip1, results);
            Assert.DoesNotContain(trip2, results);
        }
    }
}