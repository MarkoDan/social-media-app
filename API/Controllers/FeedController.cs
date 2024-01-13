using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
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

        private int GetAuthenticatedUserId()
        {
            if (!int.TryParse(AppUser.FindFirstValue(ClaimTypes.NameIdentifier)), out int userId)
            {
                throw new Exception("Invalid user ID");
            }

            return userId;
        }
    }
}