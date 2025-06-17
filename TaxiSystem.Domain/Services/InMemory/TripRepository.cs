using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.Interfaces;

namespace TaxiSystem.Domain.Services.InMemory
{
    public class TripRepository : ITripRepository
    {
        private static List<Trip> _trips = new();

        public Trip Add(Trip trip)
        {
            trip.Id = _trips.Count + 1;
            _trips.Add(trip);
            return trip;
        }

        public Trip? GetById(int id) => _trips.FirstOrDefault(t => t.Id == id);

        public List<Trip> GetTrips() => _trips;

        public List<Trip> GetTripsByDateRange(DateTime start, DateTime end) =>
            _trips.Where(t => t.Date >= start && t.Date <= end).ToList();

        public List<Trip> GetTripsByDriverId(int driverId) =>
            _trips.Where(t => t.DriverId == driverId).ToList();

        public List<Trip> GetTripsByUserId(int userId) =>
            _trips.Where(t => t.UserId == userId).ToList();

        public void Update(Trip trip)
        {
            var existing = GetById(trip.Id);
            if (existing != null)
            {
                existing.StartPoint = trip.StartPoint;
                existing.EndPoint = trip.EndPoint;
                existing.Date = trip.Date;
                existing.Duration = trip.Duration;
                existing.Cost = trip.Cost;
                existing.DriverId = trip.DriverId;
                existing.UserId = trip.UserId;
            }
        }

        public void Delete(Trip trip) => _trips.Remove(trip);
    }
}