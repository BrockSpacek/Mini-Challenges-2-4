using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpacekBMiniChallenge2Through4.services
{
    public class AcceptsTwoInputsServices
    {
         public string AcceptsTwoInputs(string yourName, string timeYouWokeUp)
        {
            return $"Hello {yourName}, You woke up at {timeYouWokeUp}!";
        }
    }
}