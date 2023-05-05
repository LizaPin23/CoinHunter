using System;

namespace CoinHunter.GameFlow
{
    public interface IContinueInvoker
    {
        event Action Continue;
    }
}

