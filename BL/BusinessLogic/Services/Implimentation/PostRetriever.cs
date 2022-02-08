using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BLModels;
using BusinessLogic.Services.Interfaces;
using DataAccessLayer.Repositories.Interfaces;

namespace BusinessLogic.Services.Implimentation
{
    public class PostRetriever : IPostRetriever
    {
        private readonly IPostRepository _postRepository;

        public PostRetriever(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<List<PostBLModel>> RetriveAllPosts()
        {
            var posts = await _postRepository.GetAllPosts();
            return posts.Select(p => new PostBLModel(p.Title, p.Content)).ToList();
        }
    }
}
