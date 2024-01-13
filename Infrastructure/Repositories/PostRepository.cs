using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly StoreContext _context;

        public PostRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Post>> GetPostsByUserIdsAsync(IEnumerable<int> userIds)
        {
            return await _context.Posts.Where(post => userIds.Contains(post.UserId)).ToListAsync();
            
        }
    }
}