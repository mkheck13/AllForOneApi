using AllForOneApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllForOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MabLibController : ControllerBase
    {
        private readonly MabLibServices _mabLibServices;

        public MabLibController(MabLibServices mabLibServices)
        {
            _mabLibServices = mabLibServices;
        }

        [HttpGet]
        [Route("MabLib/{age}/{familyRelation}/{job}/{stageOfLife}/{thing}/{size}/{humanSettlment}/{toyBrand}/{profession}/{celestialBody}")]
        public string MabLib(string age, string familyRelation, string job, string stageOfLife, string thing, string size, string humanSettlment, string toyBrand, string profession, string celestialBody)
        {
            return _mabLibServices.MabLib(age, familyRelation, job, stageOfLife, thing, size, humanSettlment, toyBrand, profession, celestialBody);
        }
    }
}