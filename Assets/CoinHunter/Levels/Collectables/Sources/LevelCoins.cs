﻿
using UnityEngine;

namespace CoinHunter.Levels.Collectables
{
    public class LevelCoins : MonoBehaviour
    {
        [SerializeField] private Coin[] _coins;
        [SerializeField] private UITextView _coinsView;

        private int _money;

        public void Initialize()
        {
            _money = 0;

            _coinsView.ShowValue(_money);

            for (int i = 0; i < _coins.Length; i++)
            {
                _coins[i].Collected += OnCoinCollected;
            }
        }

        private void OnCoinCollected(int value)
        {
            _money += value;
            _coinsView.ShowValue(_money);

        }
    }
}

