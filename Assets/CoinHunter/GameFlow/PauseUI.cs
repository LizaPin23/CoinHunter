using UnityEngine.UI;
using UnityEngine;
using System;

namespace CoinHunter.GameFlow
{
    public class PauseUI : MonoBehaviour, IContinueInvoker
    {
        [SerializeField] private Button _continueButton;

        public event Action Continue;

        private void Awake()
        {
            _continueButton.onClick.AddListener(OnContinuePressed);
        }

        private void OnContinuePressed()
        {
            Continue?.Invoke();
        }
    }
}

