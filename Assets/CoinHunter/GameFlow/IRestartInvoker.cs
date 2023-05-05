using System;

namespace CoinHunter.GameFlow
{
    public interface IRestartInvoker
    {
        event Action Restart;
    }
}

