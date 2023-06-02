using UnityEngine;
using UnityEngine.UI;

namespace CoinHunter.MainMenu
{
    public class MainMenuButtons : MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        [SerializeField] private Button _selectLevelButton;
        [SerializeField] private Button _exitButton;
        [SerializeField] private LevelsLoader _levelLoader;
          
        private void Awake()
        {
            _startButton.onClick.AddListener(OnStartButtonPressed);
            _selectLevelButton.onClick.AddListener(OnSelectLevelButtonPressed);
            _exitButton.onClick.AddListener(OnExitButtonPressed);
        }

        public void OnStartButtonPressed()
        {
            Debug.Log("Кнопка старт нажата");
            _levelLoader.LoadLevelFromSave();
            
        }

        public void OnSelectLevelButtonPressed()
        {
            Debug.Log("Кнопка выбор уровня нажата");
        }

        public void OnExitButtonPressed()
        {
            Application.Quit();
        }
    }
}

