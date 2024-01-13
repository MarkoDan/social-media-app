using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users {get; set;}
        public DbSet<Post> Posts {get; set;}
        public DbSet<Like> Likes {get; set;}
        public DbSet<Comment> Comments {get; set;}
        public DbSet<Follow> Follows {get; set;}
        public DbSet<AppUser> AppUsers {get; set;}
    }
}