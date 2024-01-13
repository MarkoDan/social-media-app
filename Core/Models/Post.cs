using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Post
    {
        public int Id {get; set;}
        public int UserId {get; set;}
        public string Content {get; set;} = string.Empty;
        public DateTime CreatedAt = DateTime.Now;
        public virtual AppUser ?User {get; set;}
    }
}