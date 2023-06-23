using System;
using CoinHunter.Shared;
using UnityEngine;

namespace CoinHunter.MainMenu
{
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField] private MainMenuButtons _mainMenuBattons;
        [SerializeField] private LevelsDatabase _database;
        [SerializeField] private LevelsSelector _selector;
        [SerializeField] private ScenesLoader _loader;
        [SerializeField] private SaveSystem _saveSystem;
        [SerializeField] private GameObject _servicesContainer;

        private void Awake()
        {
            _selector.Initialize(_database);
            _loader.Initialize(_database);
            DontDestroyOnLoad(_servicesContainer);
        }

        private void OnEnable()
        {
            _mainMenuBattons.StartButtonPressed += OnStartButtonPressed;
            _mainMenuBattons.SelectLevelButtonPressed += OnSelectLevelButtonPressed;
            _selector.LevelChosen += OnLevelChosen;
            Debug.Log("Main menu enable");
        }

        private void OnDisable()
        {
            _mainMenuBattons.StartButtonPressed -= OnStartButtonPressed;
            _mainMenuBattons.SelectLevelButtonPressed -= OnSelectLevelButtonPressed;
            _selector.LevelChosen -= OnLevelChosen;
        }

        private void OnStartButtonPressed()
        {
            LevelData levelData = _database.GetLevelByID(_saveSystem.CurrentLevel);
            Clear();
            _loader.LoadLevelBySceneName(levelData.SceneName);
        }

        private void OnSelectLevelButtonPressed()
        {
            _selector.Show();
        }
        
        private void OnLevelChosen(LevelData data)
        {
            _saveSystem.SetCurrentLevel(data.LevelID);
            Clear();
            _loader.LoadLevelBySceneName(data.SceneName);
        }

        private void Clear()
        {
            _selector.Clear();
        }
    }
}

