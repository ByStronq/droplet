using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentMetasController : ControllerBase
    {
        ICommentMetaService _commentMetaService;

        public CommentMetasController(ICommentMetaService commentMetaService)
        {
            _commentMetaService = commentMetaService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _commentMetaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CommentMeta commentMeta)
        {
            var result = _commentMetaService.Add(commentMeta);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CommentMeta commentMeta)
        {
            var result = _commentMetaService.Update(commentMeta);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
