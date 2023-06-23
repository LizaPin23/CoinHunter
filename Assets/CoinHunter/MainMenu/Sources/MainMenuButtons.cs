using UnityEngine;
using UnityEngine.UI;
using System;

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


        public void OnStartButtonPressed()
        {
            StartButtonPressed?.Invoke();
        }

        public void OnSelectLevelButtonPressed()
        {
            SelectLevelButtonPressed?.Invoke();
        }

        public void OnExitButtonPressed()
        {
            Application.Quit();
        }
    }
}

