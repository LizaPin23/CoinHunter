using System;
using CoinHunter.Levels.Collectables;
using UnityEngine;
using CoinHunter.Levels.Interactive;
using CoinHunter.Levels.Interactive.Traps;


namespace CoinHunter.Player
{
    public class PlayerInteractive : MonoBehaviour, IWaterReaction, IButtonPress
    {
        public event Action FallInWater;
        
        public void ReactWater()
        {
            FallInWater?.Invoke();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<ICollectable>(out ICollectable collectable))
            {
                collectable.Collect();
            }

            if (collision.gameObject.TryGetComponent<ITrap>(out ITrap trap))
            {
                trap.Activate();
            }
        }
    }
}

