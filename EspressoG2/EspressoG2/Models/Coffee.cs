using System;
using System.Collections.Generic;
using System.Text;

namespace EspressoG2.Models
{
    public class Coffee
    {
        public Bean BeanBlend(int amount, List<string> sort)
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
