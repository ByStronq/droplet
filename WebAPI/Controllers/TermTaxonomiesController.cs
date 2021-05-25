using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TermTaxonomiesController : ControllerBase
    {
        ITermTaxonomyService _termTaxonomyService;

        public TermTaxonomiesController(ITermTaxonomyService termTaxonomyService)
        {
            _termTaxonomyService = termTaxonomyService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _termTaxonomyService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(TermTaxonomy termTaxonomy)
        {
            var result = _termTaxonomyService.Add(termTaxonomy);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(TermTaxonomy termTaxonomy)
        {
            var result = _termTaxonomyService.Update(termTaxonomy);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
