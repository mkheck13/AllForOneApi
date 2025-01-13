using AllForOneApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MagicEightBallController : ControllerBase
    {
        private readonly MagicEightBallServices _magicEightBallServices;

        public MagicEightBallController(MagicEightBallServices magicEightBallServices)
        {
            _magicEightBallServices = magicEightBallServices;
        }

        [HttpGet]
        [Route("Question")]
        public string Question()
        {
            return _magicEightBallServices.Question();
        }
    }
}