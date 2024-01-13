using Core.Dtos;

namespace Core.Interfaces
{
    public interface IUserService
    {
        
        Task<UserDto> RegisterUserAsync(UserRegistrationDto registrationDto);
        Task<UserDto> AuthenticaUserAsync(UserLoginDto loginDto);
    }

}