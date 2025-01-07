using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpacekBMiniChallenge2Through4.services
{
    public class AcceptsTwoNumbersServices
    {
         public string acceptsTwoNumbers(int numberOne, int numberTwo)
         {
            if(numberOne > numberTwo)
            {
                return $"{numberOne} is greater than {numberTwo}\n{numberTwo} is less than {numberOne}";
            }
            else if(numberOne < numberTwo)
            {
                return $"{numberOne} is less than {numberTwo}\n{numberTwo} is greater than {numberOne}";
            }
            else
            {
                return $"{numberOne} is equal to {numberTwo}\n{numberTwo} is equal to {numberOne}";
            }
            
         }
    }
}