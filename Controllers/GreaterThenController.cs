using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOneApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterThenController : ControllerBase
    {
        private readonly GreaterThenServices _greaterThenServices;
        public GreaterThenController(GreaterThenServices greaterThenServices)
        {
            _greaterThenServices = greaterThenServices;
        }

        [HttpGet]
        [Route("GreaterThen/{num1}/{num2}")]

        public string GreaterThen(string num1, string num2)
        {
            return _greaterThenServices.GreaterThen(num1, num2);
        }
    }
    
}