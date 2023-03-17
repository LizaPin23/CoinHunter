using System;
using UnityEngine;

namespace CoinHunter.Levels.Collectables
{
    public class LevelHearts : MonoBehaviour
    {
        [SerializeField] private Heart[] _hearts;
        [SerializeField] private UITextView _heartsView;
        [SerializeField] private int _startLives = 3;
        [SerializeField] private int _maxLives = 3;

        private int _inGameLives;

        public event Action RunOutOfLives;


        public void Initialize()
        {
            _inGameLives = _startLives;
            _heartsView.ShowValue(_inGameLives);

            for (int i = 0; i < _hearts.Length; i++)
            {
                _hearts[i].Collected += OnHeartCollected;
            }
        }

        private void OnHeartCollected(Heart collectedHeart)
        {
            int currentLives = _inGameLives;
            currentLives += collectedHeart.Value;

            if (currentLives > _maxLives)
            {
                return;
            }
            
            _inGameLives = currentLives;
            collectedHeart.Hide();
            _heartsView.ShowValue(_inGameLives);
        }

        private void OnHeartConsumed(int value)
        {
            _inGameLives -= value;
            _heartsView.ShowValue(_inGameLives);
            
            if (_inGameLives == 0)
            {
                RunOutOfLives?.Invoke();
            }

        }
    }
}

