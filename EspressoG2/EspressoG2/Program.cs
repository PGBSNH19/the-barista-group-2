using EspressoG2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EspressoG2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Bean
    {

        public Bean(int weight, string sort)
        {
            Weight = weight;
            Sort = sort;
        }

        public int Weight { get; set; }
        public string Sort { get; set; }
    }

    public class FluentEspresso : IFluentEspresso
    {
        public IFluentEspresso AddBeans(Bean bean)
        {
            return this;
        }

        public IFluentEspresso AddMilk()
        {
            throw new NotImplementedException();
        }

        public IBeverage ToBeverage()
        {
            throw new NotImplementedException();
        }
    }

    public class Espresso : IBeverage
    {
        public List<string> Ingredients => new List<string> { "espresso" };

        public string CupType => "small";
    }

    public class Latte : IBeverage
    {
        public List<string> Ingredients => new List<string> { "espresso", "milk" };

        public string CupType => "large";
    }
}
