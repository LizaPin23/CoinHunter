﻿using UnityEngine;

namespace CoinHunter.Levels.Interactive
{
    public class FallInWater : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<IWaterReaction>(out IWaterReaction iWaterReaction))
            {
                iWaterReaction.ReactWater();
            }
        }
    }
}

