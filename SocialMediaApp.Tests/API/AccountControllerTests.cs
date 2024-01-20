using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers;
using Core.Dtos;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Moq;
using Xunit;


namespace SocialMediaApp.Tests.API
{
    public class AccountControllerTests
    {
        private readonly AccountController _controller;
        private readonly Mock<ITokenService> _mockTokenService;
        private readonly Mock<StoreContext> _mockStoreContext;
        
        public AccountControllerTests()
        {

        }
        
        [Fact]
        public async Task Login_WithValidCredentials_ReturnsOk()
        {
            //Arrange
            var loginDto = new UserLoginDto {Username = "test", Password = "password"};
            _mockTokenService.Setup(service => service.CreateToken(It.IsAny<AppUser>()))
                .Returns("token");

            //Act
            var result = await _controller.Login(loginDto);

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<UserDto>(okResult.Value);
            Assert.Equal("test", returnValue.Username);
        }
        
    }
}