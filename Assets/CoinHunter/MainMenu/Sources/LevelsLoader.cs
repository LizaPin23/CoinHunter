using UnityEngine;

namespace CoinHunter.MainMenu
{
    public class LevelsLoader : MonoBehaviour
    {
        [SerializeField] private LevelsDatabase _levelsDatabase;

        public void LoadLevelFromSave()
        {
            string ID = "Test";
            //взять уровень из базы и загрузить его сцену
            //_levelsDatabase.GetLevelByID();
            //SceneManager.LoadScene();
        }

        public void LoadLevelById(string ID)
        {
            
            
        }
    }
}

