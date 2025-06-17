using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.Interfaces;

namespace TaxiSystem.Domain.Services.InMemory
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _users = new();

        public User Add(User user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
            return user;
        }

        public User? GetById(int id) => _users.FirstOrDefault(u => u.Id == id);

        public User? GetByPhone(string phone) => _users.FirstOrDefault(u => u.Phone == phone);

        public List<User> GetUsers() => _users;

        public void Update(User user)
        {
            var existing = GetById(user.Id);
            if (existing != null)
            {
                existing.FullName = user.FullName;
                existing.Phone = user.Phone;
            }
        }

        public void Delete(User user) => _users.Remove(user);
    }
}