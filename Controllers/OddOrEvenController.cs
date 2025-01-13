using AllForOneApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;

        public OddOrEvenController(OddOrEvenServices oddOrEvenServices)
        {
            _oddOrEvenServices = oddOrEvenServices;
        }

        [HttpGet]
        [Route("OddOrEven/{input}")]
        public string OddOrEven(string input)
        {
            return _oddOrEvenServices.OddOrEven(input);
        }
    }
}