
using Microsoft.AspNetCore.Mvc;
using SpacekBMiniChallenge2Through4.services;

namespace SpacekBMiniChallenge2Through4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcceptsTwoInputsController : ControllerBase
    {

        private readonly AcceptsTwoInputsServices _acceptsTwoInputsServices;

        public AcceptsTwoInputsController(AcceptsTwoInputsServices acceptsTwoInputsServices)
        {
            _acceptsTwoInputsServices = acceptsTwoInputsServices;
        }

        [HttpPost]
        [Route("AddTwoInputs")]

         public string AcceptsTwoInputs(string yourName, string timeYouWokeUp)
        {
            return _acceptsTwoInputsServices.AcceptsTwoInputs(yourName, timeYouWokeUp
            );
        }
    }
}