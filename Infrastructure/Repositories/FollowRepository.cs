using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class FollowRepository : IFollowRepository
    {

        private readonly StoreContext _context;
        public FollowRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<int>> GetFolloweeIdsAsync(int followerId)
        {
            return await _context.Follows.Where(f => f.FolloweeId == followerId).Select(f => f.FolloweeId).ToListAsync();
        }
    }
}