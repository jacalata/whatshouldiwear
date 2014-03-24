using System;

namespace Wardrobe.Models
{
    [Flags]
    public enum Temperature
    {
        Mild = 0,
        Hot = 1,
        Scorching = 2,
        Cold = 4,
        Freezing = 8,
        Any = Mild | Hot | Scorching | Cold | Freezing
    }
}