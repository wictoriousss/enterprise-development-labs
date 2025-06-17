using TaxiSystem.Domain.Models;

namespace TaxiSystem.Domain.Services.Interfaces
{
    public interface ITripRepository
    {
        Trip Add(Trip trip);
        Trip? GetById(int id);
        List<Trip> GetTrips();
        List<Trip> GetTripsByDateRange(DateTime start, DateTime end);
        List<Trip> GetTripsByDriverId(int driverId);
        List<Trip> GetTripsByUserId(int userId);
        void Update(Trip trip);
        void Delete(Trip trip);
    }
}