using EspressoG2.Models;
using System;
using System.Linq;

namespace EspressoG2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bean = new Bean();
            var coffee = new Coffee().BeanBlend(20, x => x.Sort("arabica").ToCup("Small");

            Console.WriteLine(coffee);

        }
    }
}
