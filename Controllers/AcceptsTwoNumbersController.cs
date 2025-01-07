
using Microsoft.AspNetCore.Mvc;
using SpacekBMiniChallenge2Through4.services;

namespace SpacekBMiniChallenge2Through4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcceptsTwoNumbersController : ControllerBase
    {
        private readonly AcceptsTwoNumbersServices _acceptsTwoNumbersServices;

        public AcceptsTwoNumbersController(AcceptsTwoNumbersServices acceptsTwoNumbersServices)
        {
            _acceptsTwoNumbersServices = acceptsTwoNumbersServices;
        }

        [HttpPost]
        [Route("GreaterOrLessThan")]

        public string acceptsTwoNumbers(int numberOne, int numberTwo)
        {
            return _acceptsTwoNumbersServices.acceptsTwoNumbers(numberOne, numberTwo);
        }
    }
}