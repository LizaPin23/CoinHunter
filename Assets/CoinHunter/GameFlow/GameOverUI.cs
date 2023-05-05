using UnityEngine.UI;
using UnityEngine;
using System;

namespace CoinHunter.GameFlow
{
    public class GameOverUI : MonoBehaviour, IRestartInvoker
    {
        [SerializeField] private Button _restartButton;

        public event Action Restart;

        private void Awake()
        {
            _restartButton.onClick.AddListener(OnRestartPressed);
        }

        private void OnRestartPressed()
        {
            Restart?.Invoke();
        }
    }
}

