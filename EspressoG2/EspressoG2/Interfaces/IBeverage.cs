using System.Collections.Generic;

namespace EspressoG2.Interfaces
{
    public interface IBeverage
    {
        List<string> Ingredients { get; }
        string CupType { get; }
    }
}