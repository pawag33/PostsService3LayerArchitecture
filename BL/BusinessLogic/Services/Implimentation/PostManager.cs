using BusinessLogic.BLModels;
using BusinessLogic.Services.Interfaces;
using DataAccessLayer.DalModels;
using DataAccessLayer.Repositories.Interfaces;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Implimentation
{
    public class PostManager : IPostManager
    {
        private readonly IPostRepository _postRepository;
        private readonly IContentModerator _contentModerator;

        public PostManager(IPostRepository postRepository, IContentModerator contentModerator)
        {
            _postRepository = postRepository;
            _contentModerator = contentModerator;
        }

        public async Task CreatePost(PostBLModel post)
        {
            // TODO : Add validation here

            _contentModerator.ModerateContent(post.Content);

            var postDalModel = new PostDalModel(post.Title,post.Content);
            await _postRepository.AddPost(postDalModel);
        }

    }
}