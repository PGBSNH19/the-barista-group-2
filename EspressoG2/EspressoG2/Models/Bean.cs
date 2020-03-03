using System;
using System.Collections.Generic;
using System.Text;

namespace EspressoG2.Models
{
    public class Bean
    {
        public int AmountInGrams { get; set; }
        public string Sort { get; set; }

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
