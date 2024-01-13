using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class User
    {
        public int Id {get; set;}
        public required string Username {get; set;}
        public string Email {get; set;} = string.Empty;
        public string PasswordHash {get; set;} = string.Empty;
        public DateTime CreatedAt = DateTime.Now;
        public virtual ICollection<Post> ?Posts {get; set;}

    }
}