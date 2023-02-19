﻿using CoinHunter.Levels.Collectables;
using UnityEngine;

namespace CoinHunter.Player
{
    public class PlayerCollectables : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<ICollectable>(out ICollectable collectable))
            {
                collectable.Collect();
            }
        }
    }
}

