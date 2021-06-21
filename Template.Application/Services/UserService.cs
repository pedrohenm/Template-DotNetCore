using AutoMapper;
using System;
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
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public List<UserViewModel> Get()
        {
            IEnumerable<User> users = _userRepository.GetAll();

            List<UserViewModel> userViewModel = _mapper.Map<List<UserViewModel>>(users);

            return userViewModel;
        }

        public bool Post(UserViewModel userViewModel)
        {
            User user = _mapper.Map<User>(userViewModel);

            _userRepository.Create(user);

            return true;
        }
    }
}
