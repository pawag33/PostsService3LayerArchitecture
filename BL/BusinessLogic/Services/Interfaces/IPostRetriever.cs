using BusinessLogic.BLModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IPostRetriever
    {
        Task<List<PostBLModel>> RetriveAllPosts();
    }
}
