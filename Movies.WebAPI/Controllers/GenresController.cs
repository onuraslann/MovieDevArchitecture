using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Business.Services.Abstract;
using Movies.Entities.Concrete;

namespace Movies.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _genreService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Genre genre)
        {
            var result = _genreService.Add(genre);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("transactionScope")]
        public IActionResult TransactionScope(Genre genre)
        {
            var result = _genreService.TransactionalTest(genre);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Genre genre)
        {
            var result = _genreService.Update(genre);
            if (result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
