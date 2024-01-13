using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Like
    {
        public int Id {get; set;}
        public int PostId {get; set;}
        public int UserID {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public virtual Post ?Post {get; set;}
        public virtual AppUser ?User {get; set;}
    }
}