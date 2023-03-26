using System;

namespace CoinHunter.GameFlow
{
    public interface IGameOverInvoker
    {
        event Action GameOver;
    }
}

