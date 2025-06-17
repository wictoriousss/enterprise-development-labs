using TaxiSystem.Domain.Models;
using TaxiSystem.Domain.Services.Interfaces;

namespace TaxiSystem.Domain.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User AddUser(User user) => _userRepository.Add(user);

        public User? GetUserById(int id) => _userRepository.GetById(id);

        public User? GetUserByPhone(string phone) => _userRepository.GetByPhone(phone);

        public List<User> GetUsers() => _userRepository.GetUsers();

        public void UpdateUser(User user) => _userRepository.Update(user);

        public void DeleteUser(User user) => _userRepository.Delete(user);
    }
}