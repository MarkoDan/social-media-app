using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Follow
    {
        public int Id {get; set;}
        
        // The Id of the user who is following another user
        public int FollowerId {get; set;}
        public virtual User ?Follower {get; set;} 

        // The Id of the user who is being followed
        public int FolloweeId {get; set;}
        public virtual AppUser ?Followee {get; set;}
    }
}