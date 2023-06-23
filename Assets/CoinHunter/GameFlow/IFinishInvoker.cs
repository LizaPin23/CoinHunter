using System;

namespace CoinHunter.GameFlow
{
    public interface IFinishInvoker
    {
        event Action FinishGame;
    }
}

