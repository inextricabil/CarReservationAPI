using CarReservationAPI.Domain;
using CarReservationAPI.Interfaces;
using CarReservationAPI.Requests;
using CarReservationAPI.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CarReservationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        // GET: api/GetAvailable
        [HttpGet]
        [Produces(typeof(GetCarsResponse))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<IEnumerable<Car>>> GetAvailableCars(GetAvailableCarsRequest getAvailableCarsRequest)
        {
            var cars = await _carService.GetAllAsync(getAvailableCarsRequest.StartTime, getAvailableCarsRequest.EndTime);

            if (cars == null)
            {
                return NoContent();
            }

            var getCarsResponse = new GetCarsResponse
            {
                Cars = cars
            };

            return Ok(getCarsResponse);
        }

        // GET: api/GetAllCars
        [HttpGet]
        [Produces(typeof(GetCarsResponse))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<GetCarsResponse>> GetAllCars()
        {
            var cars = await _carService.GetAllAsync();

            if (cars == null)
            {
                return NoContent();
            }

            return Ok(new GetCarsResponse { Cars = cars });
        }

        // POST: api/Cars
        [HttpPost]
        [Produces(typeof(IEnumerable<Car>))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Car>> Create(PostCarRequest postCarRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var car = await _carService.AddAsync(postCarRequest);

            //Same id?

            return CreatedAtAction(nameof(Create), new { id = car.Id }, car);
        }

        // PUT: api/Cars/
        [Produces(typeof(Car))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(UpdateCarRequest updateCarRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _carService.UpdateAsync(updateCarRequest);

            if (result != null) {
                return Ok(result);
            }

            return NotFound();
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var carDeleted = await _carService.DeleteAsync(id);

            return carDeleted ? Ok() : NotFound();
        }
    }
}
