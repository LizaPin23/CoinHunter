using System;

namespace CoinHunter.GameFlow
{
    public interface ISaveInvoker
    {
        event Action SaveLevel;
    }
}

