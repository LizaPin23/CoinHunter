using System;

namespace CoinHunter.GameFlow
{
    public interface IPauseInvoker
    {
        event Action Pause;
    }
}

