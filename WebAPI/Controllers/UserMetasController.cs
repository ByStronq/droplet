using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMetasController : ControllerBase
    {
        IUserMetaService _userMetaService;

        public UserMetasController(IUserMetaService userMetaService)
        {
            _userMetaService = userMetaService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userMetaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(UserMeta userMeta)
        {
            var result = _userMetaService.Add(userMeta);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(UserMeta userMeta)
        {
            var result = _userMetaService.Update(userMeta);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
