using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Comment
    {
        public int Id {get; set;}
        public int PostId {get; set;}
        public int UserId {get; set;}
        public string Content {get; set;} = string.Empty;
        public DateTime CreatedAt = DateTime.Now;
        public virtual Post ?Post {get; set;}
        public virtual User ?User {get; set;}
        
    }
}