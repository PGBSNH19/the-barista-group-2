using System;
using System.Collections.Generic;
using System.Text;

namespace EspressoG2.Interfaces
{
    public interface IFluentEspresso
    {
        IFluentEspresso AddWater(int weight);
        IFluentEspresso AddMilk(int weight);

        IFluentEspresso AddBeans(Bean bean);
        IBeverage ToBeverage();
    }
}
