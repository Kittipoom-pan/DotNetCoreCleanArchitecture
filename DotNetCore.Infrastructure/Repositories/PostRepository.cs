using DotNetCore.Core.Entities;
using DotNetCore.Core.Interfaces;
using DotNetCore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SocialMediaContext _context;
        public PostRepository(SocialMediaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employees>> GetEmployee()
        {
            var employee = await _context.Employees.ToListAsync();
            return employee;
        }

        public async Task<IEnumerable<Post>> GetPost()
        {
            var post = Enumerable.Range(1, 10).Select(x => new Post
            {
                Id = x,
                Desc = $"Desc {x}"
            });
            await Task.Delay(10);
            return post;
        }
    }
}
