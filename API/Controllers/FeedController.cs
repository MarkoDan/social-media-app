using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Core.Dtos;
using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FeedController : BaseApiController
    {
        private readonly IFeedService _feedService;
        public FeedController(IFeedService feedService)
        {
            _feedService = feedService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFeed()
        {
            var userId = GetAuthenticatedUserId();

            var feed = await _feedService.GetUserFeedAsync(userId);

            return Ok(feed);
        }

        // private int GetAuthenticatedUserId()
        // {
        //     if (!int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier)), out int userId)
        //     {
        //         throw new Exception("Invalid user ID");
        //     }

        //     return userId;
        // }

        private int GetAuthenticatedUserId()
        {
            //Check if the user is authenticated
            if (User.Identity.IsAuthenticated)
            {
                // Assuming the user's ID is stored as NameIdentifier in the claims
                var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);

                if(userIdClaim != null && int.TryParse(userIdClaim.Value, out int userId))
                {
                    return userId;
                }
                else
                {
                    throw new Exception("User ID claim not found or is not valid integer");
                }
            }
            else
            {
                throw new Exception("User is not authenticated");
            }
        }
    }
}