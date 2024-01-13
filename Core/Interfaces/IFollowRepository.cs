using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IFollowRepository
    {
       Task<IEnumerable<int>> GetFolloweeIdsAsync(int followerId);
    }
}