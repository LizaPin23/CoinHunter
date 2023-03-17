using CoinHunter.Levels.Collectables;
using UnityEngine;
using CoinHunter.Levels.Interactive;

namespace CoinHunter.Player
{
    public class PlayerInteractive : MonoBehaviour, IWaterReaction, IButtonPress
    {
        public void ReactWater()
        {
            Debug.Log("GameOver");
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<ICollectable>(out ICollectable collectable))
            {
                collectable.Collect();
            }
        }
    }
}

