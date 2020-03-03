using EspressoG2.Models;
using System;

namespace EspressoG2
{
    class Program
    {
        static void Main(string[] args)
        {

            var coffee = new Coffee().BeanBlend(20, "Arabica").ToCup("Small");

            Console.WriteLine(coffee.Size);

        }


   

    }
}
