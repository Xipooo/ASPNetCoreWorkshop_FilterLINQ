using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreWorkshop_FilterLINQ.Controllers
{
    [Route("api/actors")]
    public class ActorsController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            //TODO: Add code for get all actors
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(ushort id)
        {
            //TODO: Add code for single actor result found by Id
            return Ok();
        }

        [HttpGet]
        public IActionResult GetByLastName([FromQuery] string lastName){
            //TODO: Add code for actors with last name
            return Ok();
        }

        [HttpGet("{id}/movies")]
        public IActionResult GetActorMovies(ushort id){
            //TODO: Add code to return movies actor stared in.
            return Ok();
        } 
    }
}