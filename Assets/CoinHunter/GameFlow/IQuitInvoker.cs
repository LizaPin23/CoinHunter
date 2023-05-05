using System;

namespace CoinHunter.GameFlow
{
    public interface IQuitInvoker
    {
        event Action Quit;
    }

}
