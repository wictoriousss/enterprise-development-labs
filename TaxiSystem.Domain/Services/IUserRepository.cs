using TaxiSystem.Domain.Models;

namespace TaxiSystem.Domain.Services.Interfaces
{
    public interface IUserRepository
    {
        User Add(User user);
        User? GetById(int id);
        User? GetByPhone(string phone);
        List<User> GetUsers();
        void Update(User user);
        void Delete(User user);
    }
}