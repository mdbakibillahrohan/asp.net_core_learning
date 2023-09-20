using LearningWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningWebAPI.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController:ControllerBase
    {
        [HttpGet]
        public ActionResult<List<CityDto>> GetCities()
        {
            var citiesToReturn = CitiesDataStore.Current.Cities;
            if(citiesToReturn==null){
                return new NotFoundResult();
            }
            return Ok(citiesToReturn);
        }

        [HttpPost]
        public JsonResult InsertCities()
        {
            return new JsonResult("success");
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c=>c.Id==id);
            if(cityToReturn==null){
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}