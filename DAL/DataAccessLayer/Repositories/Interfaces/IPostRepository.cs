using DataAccessLayer.DalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IPostRepository
    {
        Task AddPost(PostDalModel post);

        Task<List<PostDalModel>> GetAllPosts();
    }
}
