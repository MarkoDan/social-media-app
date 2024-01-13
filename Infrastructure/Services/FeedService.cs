using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Dtos;
using Core.Interfaces;
using Core.Models;

namespace Infrastructure.Services
{
    public class FeedService : IFeedService
    {
        private readonly IFollowRepository _followRepository;
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public FeedService(IFollowRepository followRepository, IPostRepository postRepository, IMapper mapper)
        {
            _followRepository = followRepository;
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PostDto>> GetUserFeedAsync(int userId)
        {
            var followeeId = await _followRepository.GetFolloweeIdsAsync(userId);
            var posts = await _postRepository.GetPostsByUserIdsAsync(followeeId);

            var postDtos = posts.Select(post => _mapper.Map<PostDto>(post));

            return postDtos;
        }
    }
}