// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Core.Dtos;
// using Core.Interfaces;
// using Core.Models;


// namespace Infrastructure.Services
// {
//     public class UserService : IUserService
//     {
//         private readonly IUserRepository _userRepository;

//         public UserService(IUserRepository userRepository)
//         {
//             _userRepository = userRepository;
//         }

//         public async Task<UserDto> AuthenticaUserAsync(UserLoginDto loginDto)
//         {
//             //Validate login data
//             if (string.IsNullOrWhiteSpace(loginDto.Email) || string.IsNullOrWhiteSpace(loginDto.Password))
//             {
//                 throw new ArgumentException("Email and password are required.");
//             }

//             //Retrieve the user by email
//             var user = await _userRepository.GetUserByEmailAsync(loginDto.Email);
//             if (user == null)
//             {
//                 throw new ArgumentException("User not found");
//             }

//             //Check if the password is correct
//             if (!VerifyPassword(loginDto.Password, user.PasswordHash))
//             {
//                 throw new ArgumentException("Invalid password.");
//             }

//             //Map the UserDto
//             var userDto = new UserDto
//             {
//                 Id = user.Id,
//                 Username = user.Username,
//                 Email = user.Email
//             };

//             return userDto;
//         }

//         public async Task<UserDto> RegisterUserAsync(UserRegistrationDto registrationDto)
//         {
//             //Validate the the registration data
//             if (string.IsNullOrWhiteSpace(registrationDto.Email) || string.IsNullOrWhiteSpace(registrationDto.Password))
//             {
//                 throw new ArgumentException("Email and password are required");
//             }

//             //Check if user already exists
//             var existingUser = await _userRepository.GetUserByEmailAsync(registrationDto.Email);
//             if(existingUser != null)
//             {
//                 throw new ArgumentException("User alredy exists with this email");
//             }

//             //Hash the password (use proper password hashing method here)
//             var hashedPassword = HashPassword(registrationDto.Password);


//             //Create a new User entity adn fill it with registration data
//             var newUser = new User
//             {
//                 Username = registrationDto.Username,
//                 Email = registrationDto.Email,
//                 PasswordHash = registrationDto.Password
//             };

//             //Save the new user
//             await _userRepository.CreateUserAsync(newUser);

//             //Map the saver user to UserDto
//             var userDto = new UserDto
//             {
//                 Id = newUser.Id,
//                 Username = newUser.Username,
//                 Email = newUser.Email
//             };

//             return userDto;
//         }

//         private string HashPassword(string password)
//         {
//             string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
//             return passwordHash;
//         }

//         private bool VerifyPassword(string password, string hashedPassword)
//         {
//             //Implement password verification here
//             bool verified = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
//             return verified;
//         }
//     }
// }