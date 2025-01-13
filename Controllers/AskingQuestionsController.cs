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
    public class AskingQuestionsController : ControllerBase
    {
        private readonly AskingQuestionsServices _askingQuestionsServices;

        public AskingQuestionsController(AskingQuestionsServices askingQuestionsServices)
        {
            _askingQuestionsServices = askingQuestionsServices;
        }

        [HttpGet]
        [Route("AskingQuestions/{userName}/{wakeUpTime}")]

        public string AskingQuestions(string userName, string wakeUpTime)
        {
            return _askingQuestionsServices.AskingQuestions(userName, wakeUpTime);
        }
    }
}