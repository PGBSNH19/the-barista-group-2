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
            var espresso = new FluentEspresso().AddWater(20).AddBeans(new Bean {Weight= 20,Sort= "arabica" }).ToBeverage();
            var latte = new FluentEspresso().AddWater(20).AddMilk(20).AddBeans(new Bean { Weight = 30, Sort = "skånerost" }).ToBeverage();
            
            Console.WriteLine(espresso);
        }
    }


    public class Water
    {
        public int Weight { get; set; }
    }

    public class Bean
    {
        public int Weight { get; set; }
        public string Sort { get; set; }
    }

    public class FluentEspresso : IFluentEspresso
    {   
        public Bean _bean { get; set; }
        public IFluentEspresso AddBeans(Bean bean)
        {
            _bean = bean;
            return this;
        }       

        public IFluentEspresso AddMilk(int weight)
        {
          
            return this;
        }

        public IBeverage ToBeverage()
        {
            
            if(this._bean.Sort == "skånerost") 
            {
                return new Espresso();
            } 
         
            else
            {
                return new Latte();
            }
            
        }

        public IFluentEspresso AddWater(int weight)
        {
            return this;
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
