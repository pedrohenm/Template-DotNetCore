using System.Collections.Generic;
using Template.Application.ViewModels;

namespace Template.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();
        bool Post(UserViewModel userViewModel);
    }
}
