using DotNetCore.Core.Entities;
using DotNetCore.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchitectureDotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPost()
        {
            try
            {
                var post = await _postRepository.GetPost();
                return Ok(post);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Post post)
        {
            try
            {
                await _postRepository.AddPost(post);
                return Ok(post);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
