using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Dtos;

namespace Core.Interfaces
{
    public interface IFeedService
    {
        Task<IEnumerable<PostDto>> GetUserFeedAsync(int userId);
    }
}