using DotNetCore.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCore.Core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPost();
        Task<IEnumerable<User>> GetEmployee();
        Task AddPost(Post post);
    }
}
