using Blog.Model;
using Blog.Service;
using Blog.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly TabPost _context;
        public PostController(TabPost context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult InserirPost([FromBody] TabPost request)
        {
            var usuarioService = new PostService(_context);
            var sucesso = usuarioService.InserirPost(request);

            if (sucesso == true)
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
