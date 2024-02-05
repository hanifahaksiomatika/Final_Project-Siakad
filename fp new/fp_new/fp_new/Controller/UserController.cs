using fp_new.Model.Repository;
using fp_new.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp_new.Controller
{
    public class UserController
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public bool IsUsernameExists(string username)
        {
            return _userRepository.IsUsernameExists(username);
        }

        public bool ValidateUser(string username, string password)
        {
            return _userRepository.ValidateUser(username, password);
        }

        public string GetUserRole(string username)
        {
            return _userRepository.GetUserRole(username);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
    }
}
