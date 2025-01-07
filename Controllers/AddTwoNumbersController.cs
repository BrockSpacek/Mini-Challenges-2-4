
using Microsoft.AspNetCore.Mvc;
using SpacekBMiniChallenge2Through4.services;

namespace SpacekBMiniChallenge2Through4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {

        private readonly AddTwoNumbersServices _addTwoNumbersServices;

        public AddTwoNumbersController(AddTwoNumbersServices addTwoNumbersServices)
        {
          _addTwoNumbersServices = addTwoNumbersServices;
        }
        
         [HttpPost]
         [Route("Adding")]
         public string addTwoNumbers(int num1, int num2)
        {
            return _addTwoNumbersServices.addTwoNumbers(num1, num2);
        }
    }
}