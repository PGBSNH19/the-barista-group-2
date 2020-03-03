using System;
using System.Collections.Generic;
using System.Text;

namespace EspressoG2.Models
{
    public class Bean
    {
        public int AmountInGrams { get; set; }
        public List<string> Sort { get; set; } = new List<string> { "arabica", "skånerost","mollbergs blandning" };

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
