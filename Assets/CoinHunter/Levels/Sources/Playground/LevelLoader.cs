using CoinHunter.MainMenu;
using UnityEngine;

namespace CoinHunter.Levels
{
    public class LevelLoader : MonoBehaviour
    {
        public void LoadNextLevel()
        {
            ScenesLoader.Instance.LoadNextLevel();
        }

        public void LoadMainMenu()
        {
            ScenesLoader.Instance.LoadMainMenu();
        }
    }
}

