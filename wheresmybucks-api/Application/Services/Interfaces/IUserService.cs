using Application.ViewModels;
using Infrastructure.Identity.DTO;

namespace Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<ResultModel<UserViewModel>> GetUserByEmail(string email);
        Task<ResultModel<UserViewModel>> RegisterUser(UserDto userDto);
        Task<ResultModel<UserViewModel>> UpdateUser(UserDto userDto);
    }
}
