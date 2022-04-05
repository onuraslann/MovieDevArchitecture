using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Business.Services.Abstract;
using Movies.Entities.Concrete;

namespace Movies.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        IActorService _actorService;

        public ActorsController(IActorService actorService)
        {
            _actorService = actorService;
        }
        [HttpGet("getbymovies")]
       
        public IActionResult GetByActorMovies()
        {
            var result = _actorService.GetAllActorsMovies();
            if (result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Actor actor)
        {
            var result = _actorService.Add(actor);
            if (result!=null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Actor   actor)
        {
            var result = _actorService.Update(actor);
            if (result!=null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _actorService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
