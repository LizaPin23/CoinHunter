using System;
using CoinHunter.GameFlow;
using UnityEngine;
using UnityEngine.UI;

namespace CoinHunter.Shared
{
    public class LevelUI : MonoBehaviour, IContinueInvoker, IRestartInvoker, IQuitInvoker
    {
        [SerializeField] private Button _continueButton;
        [SerializeField] private Button[] _restartButtons;
        [SerializeField] private Button[] _quitButtonsButton;
        
        public event Action Continue;
        public event Action Restart;
        public event Action Quit;

        private void Awake()
        {
            _continueButton.onClick.AddListener(OnContinueButtonPressed);

            foreach (var button in _restartButtons)
            {
                button.onClick.AddListener(OnRestartButtonPressed);
            }
            
            foreach (var button in _quitButtonsButton)
            {
                button.onClick.AddListener(OnQuitButtonPressed);
            }
        }

        private void OnContinueButtonPressed()
        {
            Continue?.Invoke();
        }
        
        private void OnRestartButtonPressed()
        {
            Restart?.Invoke();
        }

        private void OnQuitButtonPressed()
        {
            Quit?.Invoke();
        }
    }
}

