using UnityEngine;
using UnityEngine.SceneManagement;

namespace CoinHunter.MainMenu
{
    public class LevelsLoader : MonoBehaviour
    {
        public void LoadLevelByName(string name)
        {
            SceneManager.LoadScene(name);
        }
    }
}

