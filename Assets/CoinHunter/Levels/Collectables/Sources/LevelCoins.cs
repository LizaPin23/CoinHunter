using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Levels.Collectables
{
    public class LevelCoins : MonoBehaviour
    {
        [SerializeField] private Coin[] _coins;

        private int _money;

        public void Initialize()
        {
            _money = 0;

            for (int i = 0; i < _coins.Length; i++)
            {
                _coins[i].Collected += OnCoinCollected;
            }
        }

        private void OnCoinCollected(int value)
        {
            _money += value;
            Debug.Log("Собрано монет: " + _money);
        }
    }
}

