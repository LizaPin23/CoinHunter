using System;
using UnityEngine;
using UnityEngine.UI;

namespace CoinHunter.MainMenu
{
    public class MainMenuButtons : MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        [SerializeField] private Button _selectLevelButton;
        [SerializeField] private Button _exitButton;
        public event Action StartButtonPressed;
        public event Action SelectLevelButtonPressed;

        private void OnEnable()
        {
            _startButton.onClick.AddListener(OnStartButtonPressed);
            _selectLevelButton.onClick.AddListener(OnSelectLevelButtonPressed);
            _exitButton.onClick.AddListener(OnExitButtonPressed);
        }

        private void OnDisable()
        {
            _startButton.onClick.RemoveListener(OnStartButtonPressed);
            _selectLevelButton.onClick.RemoveListener(OnSelectLevelButtonPressed);
            _exitButton.onClick.RemoveListener(OnExitButtonPressed);
        }


        private void OnStartButtonPressed()
        {
            StartButtonPressed?.Invoke();
        }

        private void OnSelectLevelButtonPressed()
        {
            SelectLevelButtonPressed?.Invoke();
        }

        private void OnExitButtonPressed()
        {
            Application.Quit();
        }
    }
}

