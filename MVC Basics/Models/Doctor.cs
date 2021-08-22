using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Models
{
    public static class Doctor
    {
        public static string feverCheck(double temperature)
        {
            string feverCheck = "";
            if (temperature > 40)
            {
                feverCheck = "You have fever!";
            }
            return feverCheck;
        }
    }
}
