using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace Regular_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Snehasis";
            string mob = "182911010";
            string m = "[a-zA-Z]*$";



           if (Regex.IsMatch(mob, @"^\d{10,10}$"))
            {
                Console.WriteLine("number is Valid");
            }
            else
            {
                Console.WriteLine("number is invalid");
            }
        }
    }
}
