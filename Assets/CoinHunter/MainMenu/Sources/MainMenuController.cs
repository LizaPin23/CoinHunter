using CoinHunter.Shared;
using UnityEngine;

namespace CoinHunter.MainMenu
{
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField] private MainMenuButtons _mainMenuBattons;
        [SerializeField] private LevelsDatabase _database;
        [SerializeField] private LevelsSelector _selector;
        [SerializeField] private LevelsLoader _loader;
        [SerializeField] private SaveSystem _saveSystem;

        private void OnEnable()
        {
            _mainMenuBattons.StartButtonPressed += OnStartButtonPressed;
            _mainMenuBattons.SelectLevelButtonPressed += OnSelectLevelButtonPressed;

        }

        private void OnDisable()
        {
            _mainMenuBattons.StartButtonPressed -= OnStartButtonPressed;
            _mainMenuBattons.SelectLevelButtonPressed -= OnSelectLevelButtonPressed;
        }

        private void OnStartButtonPressed()
        {
            LevelData levelData = _database.GetLevelByID(_saveSystem.CurrentLevel);
            _loader.LoadLevelByName(levelData.SceneName);
        }

        private void OnSelectLevelButtonPressed()
        {
         //   LevelData levelData = _database
            _selector.Initialize();
            //открывается селект левел

        }
    }
}

