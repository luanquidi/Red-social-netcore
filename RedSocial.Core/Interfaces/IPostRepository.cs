using RedSocial.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedSocial.Core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPosts();
        Task<Post> GetPost(int id);
    }
}
