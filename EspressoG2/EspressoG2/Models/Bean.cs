using System;
using System.Collections.Generic;
using System.Text;

namespace EspressoG2.Models
{
    public class Bean
    {
        public int AmountInGrams { get; set; }
        public string Sort { get; set; }

        public Cup ToCup(string size)
        {

            var cup = new Cup
            {
                Size = size
            };

            return cup;
        }

    }
}
