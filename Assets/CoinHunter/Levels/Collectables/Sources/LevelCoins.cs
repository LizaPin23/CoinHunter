
using CoinHunter.GameFlow;
using UnityEngine;

namespace CoinHunter.Levels.Collectables
{
    public class LevelCoins : MonoBehaviour, IRestartListener
    {
        [SerializeField] private Coin[] _coins;
        [SerializeField] private UITextView _coinsView;
        private GameFlowController _controller;

        private int _money;

        //private void Awake()
        //{
        //    _controller.Restart += OnGameRestart()
        //}

        public void Initialize()
        {
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

        public void OnGameRestart()
        {
            _money = 0;
            _coinsView.ShowValue(_money);
            
            for (int i = 0; i < _coins.Length; i++)
            {
                _coins[i].Show();
            }
        }
    }
}

