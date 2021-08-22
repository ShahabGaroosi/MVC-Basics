using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MVC_Basics.Models
{
    public class GuessingGame
    {
        public static string checkGuess(int number, int guess)
        {
            if (number > guess)
            {
                return $"Too low guess: {guess}.";
            }
            else if (number < guess)
            {
                return $"Too high guess: {guess}.";
            }
            return $"Congratulation! Right guess: {guess}!";
        }
        
    }
}
