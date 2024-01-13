// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Core.Dtos;
// using Core.Interfaces;
// using Microsoft.AspNetCore.Http.HttpResults;
// using Microsoft.AspNetCore.Mvc;

// namespace API.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class AuthenticationController
//     {


//         private readonly IUserService? _userService;
        
//         public AuthenticationController(IUserService userService)
//         {
//             _userService = userService;
//         }

//         [HttpPost("register")]
//         public async Task<IActionResult> Register(UserRegistrationDto registrationDto)
//         {
//             // Handle registration

//             try
//             {
//                 var userDto = await _userService.RegisterUserAsync(registrationDto);
//                 return CreatedAtAction(nameof(Register), new {id = userDto.Id}, userDto);
//             }
//             catch (Exception ex)
//             {
//                 return BadRequest(ex.Message);
//             }
            
//         }

//         [HttpPost("login")]
//         public async Task<IActionResult> Login(UserLoginDto loginDto)
//         {
//             // Handle login
            
//         }


//     }
// }