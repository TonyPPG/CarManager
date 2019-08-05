using System.Threading.Tasks;
using CarManager.Data;
using CarManager.Request.Car;
using CarManager.Response;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarManager.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors]
    public class CarsController : Controller
    {
        private readonly IMediator _mediator;

        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/cars/
        [HttpGet]
        public async Task<IActionResult>  GetCars()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = _mediator.Send(new FetchCarsRequest(0));

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response.Result);
        }

        // GET: api/cars/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar([FromRoute]string Id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _mediator.Send(new FetchCarRequest(Id));

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        // POST api/cars/add-car
        [HttpPost("add-car")]
        public async Task<IActionResult> Post([FromBody]Car car)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _mediator.Send(new CreateCarRequest(car));

            return CreatedAtAction("GetCar", new { id = response.Id }, response);
        }

        // PUT api/cars/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCar([FromRoute]string id, [FromBody]Car car)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _mediator.Send(new UpdateCarRequest(id, car));

            if (response == null)
                return NotFound();

            return Ok(new GeneralResponse(response));
        }

        // DELETE api/cars/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]string id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _mediator.Send(new DeleteCarRequest(id));

            return Ok(new GeneralResponse(response));
        }

        // SEARCH api/cars/search
        [HttpPost("search")]
        public async Task<IActionResult> Search([FromBody]SearchRequest search )
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _mediator.Send(new SearchCarRequest(search));

            return Ok(response);
        }
    }
}
