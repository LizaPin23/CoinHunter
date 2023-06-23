using CoinHunter.Shared;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CoinHunter.MainMenu
{
    public class ScenesLoader : MonoBehaviour
    {
        [SerializeField] private string _mainMenuSceneName = "MainMenu";
        public static ScenesLoader Instance { get; private set; }

        private LevelsDatabase _database;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }

        public void Initialize(LevelsDatabase database)
        {
            _database = database;
        }

        public void LoadLevelBySceneName(string name)
        {
            SceneManager.LoadScene(name);
        }

        public void LoadNextLevel()
        {
            string currentLevelId = SaveSystem.Instance.CurrentLevel;

            LevelData data = _database.GetNextLevelByCurrentID(currentLevelId);
            SceneManager.LoadScene(data.SceneName);
        }

        public void LoadMainMenu()
        {
            SceneManager.LoadScene(_mainMenuSceneName);
        }
    }
}

