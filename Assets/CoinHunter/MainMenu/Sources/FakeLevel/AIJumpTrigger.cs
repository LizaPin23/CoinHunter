using System;
using CoinHunter.Player;
using UnityEngine;

namespace CoinHunter.MainMenu.FakeLevel
{
    public class AIJumpTrigger : MonoBehaviour
    {
        public event Action PlayerEntered;
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent<PlayerInteractive>(out PlayerInteractive player))
            {
                PlayerEntered?.Invoke();
            }
        }
    }
}

