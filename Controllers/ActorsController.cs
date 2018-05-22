using System.Linq;
using ASPNetCoreWorkshop_FilterLINQ.Sakila;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreWorkshop_FilterLINQ.Controllers
{
    [Route("api/actors")]
    public class ActorsController : Controller
    {
        private readonly sakilaContext context = new sakilaContext();

        [HttpGet]
        public IActionResult GetAll()
        {
            //TODO: Add code for get all actors
            var result = context.Actor.ToList();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(ushort id)
        {
            //TODO: Add code for single actor result found by Id
            var result = context.Actor.FirstOrDefault(a => a.ActorId == id);
            return Ok(result);
        }

        [HttpGet("[action]")]
        public IActionResult GetByLastName([FromQuery] string lastName){
            //TODO: Add code for actors with last name
            var result = context.Actor.Where(a => a.LastName.Contains(lastName));
            return Ok(result);
        }

        [HttpGet("{id}/movies")]
        public IActionResult GetActorMovies(ushort id){
            //TODO: Add code to return movies actor stared in.
            var result = context
                            .Actor
                            .Include(a => a.FilmActor)
                            .ThenInclude(fa => fa.Film)
                            .FirstOrDefault(a => a.ActorId == id)
                            .FilmActor
                            .Select(fa => new {fa.Film.Title, fa.Film.Description });
            return Ok(result);
        } 
    }
}