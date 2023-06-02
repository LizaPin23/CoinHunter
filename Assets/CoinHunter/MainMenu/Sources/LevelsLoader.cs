using UnityEngine;
using UnityEngine.SceneManagement;

namespace CoinHunter.MainMenu
{
    public class LevelsLoader : MonoBehaviour
    {
        [SerializeField] private LevelsDatabase _levelsDatabase;

        public void LoadLevelFromSave()
        {
            string ID = "Test";
            LoadLevelById(ID);
        }

        public void LoadLevelById(string ID)
        {
            LevelData levelData = _levelsDatabase.GetLevelByID(ID);
            SceneManager.LoadScene(levelData.SceneName);
        }
    }
}

