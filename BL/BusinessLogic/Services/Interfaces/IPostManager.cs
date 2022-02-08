using BusinessLogic.BLModels;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{  
    public interface IPostManager
    {
        Task CreatePost(PostBLModel post);
    }
}