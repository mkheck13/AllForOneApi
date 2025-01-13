using AllForOneApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;

        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
            _restaurantPickerServices = restaurantPickerServices;
        }

        [HttpGet]
        [Route("RestaurantPicker/{pizzaMexicanFastFood}")]
        public string RestaurantPicker(string pizzaMexicanFastFood)
        {
            return _restaurantPickerServices.RestaurantPicker(pizzaMexicanFastFood);
        }
    }
}