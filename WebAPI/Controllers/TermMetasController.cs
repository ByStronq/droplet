using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TermMetasController : ControllerBase
    {
        ITermMetaService _termMetaService;

        public TermMetasController(ITermMetaService termMetaService)
        {
            _termMetaService = termMetaService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _termMetaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("add")]
        public IActionResult Add(TermMeta termMeta)
        {
            var result = _termMetaService.Add(termMeta);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("update")]
        public IActionResult Update(TermMeta termMeta)
        {
            var result = _termMetaService.Update(termMeta);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
