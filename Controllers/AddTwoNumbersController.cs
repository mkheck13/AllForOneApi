using AllForOneApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersServices _addTwoNumbersServices;
        public AddTwoNumbersController(AddTwoNumbersServices addTwoNumbersServices)
        {
            _addTwoNumbersServices = addTwoNumbersServices;
        }

        [HttpGet]
        [Route("AddTwoNumbers/{num1}/{num2}")]

        public string AddTwoNumbers(string num1, string num2)
        {
            return _addTwoNumbersServices.AddTwoNumbers(num1, num2);
        }
    }
}