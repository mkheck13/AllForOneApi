using AllForOneApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumController : ControllerBase
    {
         private readonly ReverseItNumServices _reverseItNumServices;

        public ReverseItNumController(ReverseItNumServices reverseItNumServices)
        {
            _reverseItNumServices = reverseItNumServices;
        }

        [HttpGet]
        [Route("ReverseItNum/{userNum}")]
        public string ReverseItNum(string userNum)
        {
            return _reverseItNumServices.ReverseItNum(userNum);
        }
    }
}