using System;
using System.Collections.Generic;
using System.Text;

namespace EspressoG2.Interfaces
{
    public interface IFluentEspresso
    {
        IFluentEspresso AddMilk();
        IFluentEspresso AddBeans(Bean bean);
        IBeverage ToBeverage();
    }
}
