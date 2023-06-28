using Application.Services.Interfaces;
using Application.ViewModels;
using Infrastructure.Identity.DTO;

namespace Application.Services
{
    public class UserService : IUserService
    {
        //private readonly IRepository<User> _userRepository;
        //private readonly ICurrentUser _currentUser;


        //public UserService(IRepository<User> userRepository, ICurrentUser currentUser)
        //{
        //    _userRepository = userRepository;
        //    _currentUser = currentUser;
        //}

        public Task<ResultModel<UserViewModel>> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<UserViewModel>> RegisterUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<UserViewModel>> UpdateUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
