using AllForOneApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloServices _sayHelloServices;

        public SayHelloController(SayHelloServices sayHelloServices){
            _sayHelloServices = sayHelloServices;
        }

        [HttpGet]
        [Route("SayHello/{userName}")]
        public string SayHello(string userName)
        {
            return _sayHelloServices.SayHello(userName);
        }
    }
}