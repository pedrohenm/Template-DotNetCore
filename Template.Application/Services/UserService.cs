using System.Collections.Generic;
using Template.Application.Interfaces;
using Template.Application.ViewModels;
using Template.Domain.Entities;
using Template.Domain.Interfaces;

namespace Template.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserViewModel> Get()
        {
            List<UserViewModel> userViewModel = new List<UserViewModel>();

            IEnumerable<User> users = _userRepository.GetAll();

            foreach (var item in users)
                userViewModel.Add
                (
                    new UserViewModel
                    {
                        Id = item.Id,
                        Email = item.Email,
                        Nome = item.Email
                    }
                );

            return userViewModel;
        }
    }
}
