using DataAccessLayer.DalModels;
using DataAccessLayer.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Implimentation
{
    public class PostInMemoryRepository : IPostRepository
    {
        private List<PostDalModel> _posts = new List<PostDalModel> { new PostDalModel("Title1", "Blah blah"), new PostDalModel("Title2", "Blah blah ba ba") };

        public Task<List<PostDalModel>> GetAllPosts()
        {
           return Task.FromResult(this._posts);
        }

        public async Task AddPost(PostDalModel post)
        {
            _posts.Add(post);
            await Task.FromResult(1);
        }
    }
}
