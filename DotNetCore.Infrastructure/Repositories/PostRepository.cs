using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCore.Core.Entities;
using DotNetCore.Core.Interfaces;
using DotNetCore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SocialMediaContext _context;
        public PostRepository(SocialMediaContext context)
        {
            _context = context;
        }

        public async Task AddPost(Post post)
        {
            _context.Post.Add(post);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetEmployee()
        {
            var employee = await _context.User.ToListAsync();
            return employee;
        }

        public async Task<IEnumerable<Post>> GetPost()
        {
            var post = await _context.Post.ToListAsync();
            return post;
        }
    }
}
