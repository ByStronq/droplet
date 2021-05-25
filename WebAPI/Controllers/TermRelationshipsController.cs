using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TermRelationshipsController : ControllerBase
    {
        ITermRelationshipService _termRelationshipService;

        public TermRelationshipsController(ITermRelationshipService termRelationshipService)
        {
            _termRelationshipService = termRelationshipService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _termRelationshipService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(TermRelationship termRelationship)
        {
            var result = _termRelationshipService.Add(termRelationship);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(TermRelationship termRelationship)
        {
            var result = _termRelationshipService.Update(termRelationship);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
