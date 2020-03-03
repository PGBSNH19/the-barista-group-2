using System;
using System.Collections.Generic;
using System.Text;

namespace EspressoG2.Models
{
    public class Coffee
    {
        public Coffee Type { get; set; }

        public Coffee CoffeeName(Coffee coffee)
        {
            var choosenCoffe = new Coffee
            {
                Type = coffee
            };

            return choosenCoffe;
        }

        

        public Bean BeanBlend(int amount, string sort)
        {
            var bean = new Bean
            {
                AmountInGrams = amount,
                Sort = sort
            };
            return bean;
        }

    }
}
