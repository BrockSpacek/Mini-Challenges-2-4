using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpacekBMiniChallenge2Through4.services
{
    public class AcceptsTwoInputsServices
    {
         public string AcceptsTwoInputs(string name, string time)
        {
            return $"Hello {name}, You woke up at {time}!";
        }
    }
}