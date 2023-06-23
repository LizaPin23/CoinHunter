using System;
using CoinHunter.GameFlow;
using UnityEngine;
using UnityEngine.UI;

namespace CoinHunter.Shared
{
    public class LevelUI : MonoBehaviour, IContinueInvoker, IRestartInvoker, IQuitInvoker, ISaveInvoker
    {
        [SerializeField] private Button _continueButton;
        [SerializeField] private Button[] _restartButtons;
        [SerializeField] private Button[] _quitButtons;
        [SerializeField] private Button _finishQuitButton;
        [SerializeField] private Button _nextLevelButton;
        
        public event Action Continue;
        public event Action Restart;
        public event Action Quit;
        public event Action NextLevelLoad;
        
        private void OnEnable()
        {
            _continueButton.onClick.AddListener(OnContinueButtonPressed);

            foreach (var button in _restartButtons)
            {
                button.onClick.AddListener(OnRestartButtonPressed);
            }
            
            foreach (var button in _quitButtons)
            {
                button.onClick.AddListener(OnQuitButtonPressed);
            }
            
            _nextLevelButton.onClick.AddListener(OnNextLevelClicked);
            _finishQuitButton.onClick.AddListener(OnFinishQuitButtonClicked);
        }

        private void OnFinishQuitButtonClicked()
        {
            SaveLevel?.Invoke();
            Quit?.Invoke();
        }

        private void OnDisable()
        {
            _continueButton.onClick.RemoveListener(OnContinueButtonPressed);

            foreach (var button in _restartButtons)
            {
                button.onClick.RemoveListener(OnRestartButtonPressed);
            }
            
            foreach (var button in _quitButtons)
            {
                button.onClick.RemoveListener(OnQuitButtonPressed);
            }
            
            _nextLevelButton.onClick.RemoveListener(OnNextLevelClicked);
            _finishQuitButton.onClick.RemoveListener(OnFinishQuitButtonClicked);
        }

        private void OnNextLevelClicked()
        {
            SaveLevel?.Invoke();
            NextLevelLoad?.Invoke();
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

        public event Action SaveLevel;
    }
}

