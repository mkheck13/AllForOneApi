using AllForOneApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItAlphaController : ControllerBase
    {
        private readonly ReverseItAlphaServices _reverseItAlphaServices;

        public ReverseItAlphaController(ReverseItAlphaServices reverseItAlphaServices)
        {
            _reverseItAlphaServices = reverseItAlphaServices;
        }

        [HttpGet]
        [Route("ReverseAlpha/{input}")]
        public string ReverseItAlpha(string input)
        {
            return _reverseItAlphaServices.ReverseItAlpha(input);
        }
    }
}