using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Browar.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.Binding;

namespace Browar.WebApi.Controllers
{
    [Route("Beer")]//ścieżka do controllera
    public class BeerController : Controller // tu wpadaja zapytania
    {
        private readonly IBeerService _beerService;

        public BeerController(IBeerService beerService)
        {
            _beerService = beerService;
        }

        [HttpPost] //http://localhost:port/Beer
        public IActionResult AddBeer([FromBody]AddBeer addBeer)
        {
            if(!ModelState.IsValid) // jesli jest blad w addBeer
            {
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors));
            }

            _beerService.AddBeer(addBeer);
            return Ok();
        }

        [HttpGet("{id}")] //tak sie robi get'a
        public IActionResult Get(long id) // ze sciezki localhost:port/Beer/{id} bedzie id
        {
            return Ok(); //w service dodac metode
            //ktora pobiera piwo
            //zwrocic piwo
            //var piwo = _beerService.GetBeer(id);
            //return Ok(piwo); cos w tym stylu w repo ejst juz metoda
            //w serwisie bedzie:
            //return _beerRepository.Get(id) w uproszczoenj wersji
        }
    }
}