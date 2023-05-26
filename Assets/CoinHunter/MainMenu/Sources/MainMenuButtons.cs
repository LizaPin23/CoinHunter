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

        public void OnStartButtonPressed()
        {
            _levelLoader.LoadLevelFromSave();
        }

        public void OnSelectLevelButtonPressed()
        {
            
        }

        public void OnExitButtonPressed()
        {
            Application.Quit();
        }
    }
}

