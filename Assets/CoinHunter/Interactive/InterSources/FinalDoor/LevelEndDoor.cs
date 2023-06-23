using System;
using CoinHunter.GameFlow;
using CoinHunter.Player;
using UnityEngine;

namespace CoinHunter.Levels.Interactive
{
    public class LevelEndDoor : MonoBehaviour, IFinishInvoker
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent<PlayerInteractive>(out PlayerInteractive platerInteractive))
            {
                FinishGame?.Invoke();
            }
        }

        public event Action FinishGame;
    }

}

