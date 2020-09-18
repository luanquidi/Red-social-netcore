using Microsoft.AspNetCore.Mvc;
using RedSocial.Core.Interfaces;
using RedSocial.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace RedSocial.Api.Controllers
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
        public async Task<IActionResult> GetPosts() 
        {
            return Ok(await _postRepository.GetPosts());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            return Ok(await _postRepository.GetPost(id));
        }
    }
}
