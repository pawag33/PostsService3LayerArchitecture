using BusinessLogic.BLModels;
using BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.ApiModels;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostControllers : ControllerBase
    {
        private readonly IPostRetriever  _postRetriever;
        private readonly IPostManager _postManager;

        public PostControllers(IPostRetriever postRetriever,IPostManager postManager)
        {
            _postRetriever = postRetriever;
            _postManager = postManager;
        }
   

        [HttpPost]
        [Route("Post")]

        public async Task<ActionResult> CreatePost(PostApiModel post)
        {
            var postBLModel = new PostBLModel(post.Title, post.Content);
            await _postManager.CreatePost(postBLModel);
            return Ok();
        }

        [HttpGet]
        [Route("Post")]

        public async Task<ActionResult<List<PostApiModel>>> GetAllPosts()
        {
            var posts = await _postRetriever.RetriveAllPosts();
            return posts.Select(p => new PostApiModel(p.Title, p.Content)).ToList();
        }
    }
}
