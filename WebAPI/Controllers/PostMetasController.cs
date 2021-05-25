using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostMetasController : ControllerBase
    {
        IPostMetaService _postMetaService;

        public PostMetasController(IPostMetaService postMetaService)
        {
            _postMetaService = postMetaService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _postMetaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(PostMeta postMeta)
        {
            var result = _postMetaService.Add(postMeta);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(PostMeta postMeta)
        {
            var result = _postMetaService.Update(postMeta);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
