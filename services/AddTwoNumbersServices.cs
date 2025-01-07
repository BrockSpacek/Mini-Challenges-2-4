using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpacekBMiniChallenge2Through4.services
{
    public class AddTwoNumbersServices
    {
         public string addTwoNumbers(int num1, int num2)
        {
            return $"If you add {num1} + {num2}, it will equal {num1 + num2}.";
        }
    }
}