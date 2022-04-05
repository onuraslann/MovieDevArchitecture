using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Business.Services.Abstract;
using Movies.Entities.Concrete;

namespace Movies.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        IDirectorService _directorService;

        public DirectorsController(IDirectorService directorService)
        {
            _directorService = directorService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _directorService.GetAll();
            if (result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Director director)
        {
            var result = _directorService.Add(director);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
