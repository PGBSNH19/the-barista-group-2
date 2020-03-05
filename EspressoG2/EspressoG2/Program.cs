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
           // var latte = new FluentEspresso().AddWater(20).AddMilk(20).AddBeans(new Bean { Weight = 30, Sort = "skånerost" }).ToBeverage();
          
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

        Latte latte = new Latte();
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
            
            if(latte.Ingredients.Contains("milk")) 
            {
                return new Latte();
            } 
         
            else if(latte.Ingredients.Contains("noMilk"))
            {
                return new Espresso();
            }

            else
            {
                return null;
            }
            
        }

        public IFluentEspresso AddWater(int weight)
        {
            return this;
        }
    }

    public class Espresso : IBeverage
    {
        public List<string> Ingredients => new List<string> { "espresso", "noMilk" };

        public string CupType => "small";
    }

    public class Latte : IBeverage
    {
        public List<string> Ingredients => new List<string> { "espresso", "milk" };

        public string CupType => "large";
    }
}
