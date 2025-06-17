using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.Interfaces;

namespace TaxiSystem.Domain.Services
{
    public class TripService
    {
        private readonly ITripRepository _tripRepository;

        public TripService(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public Trip AddTrip(Trip trip) => _tripRepository.Add(trip);

        public Trip? GetTripById(int id) => _tripRepository.GetById(id);

        public List<Trip> GetTrips() => _tripRepository.GetTrips();

        public List<Trip> GetTripsByDateRange(DateTime start, DateTime end) =>
            _tripRepository.GetTripsByDateRange(start, end);

        public List<Trip> GetTripsByDriverId(int driverId) =>
            _tripRepository.GetTripsByDriverId(driverId);

        public List<Trip> GetTripsByUserId(int userId) =>
            _tripRepository.GetTripsByUserId(userId);

        public void UpdateTrip(Trip trip) => _tripRepository.Update(trip);

        public void DeleteTrip(Trip trip) => _tripRepository.Delete(trip);
    }
}