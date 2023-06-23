using UnityEngine;

namespace CoinHunter.MainMenu
{
    [CreateAssetMenu(menuName = "Levels/LevelsDataBase")]
    public class LevelsDatabase : ScriptableObject
    {
        [SerializeField] private LevelData _defaultLevel;
        [SerializeField] private LevelData[] _levelDatas;
        public LevelData[] LevelDatas => _levelDatas;
    
        public LevelData GetLevelByID(string ID)
        {
            for(int i = 0; i < _levelDatas.Length; i++)
            {
                LevelData level = _levelDatas[i];

                if (level.LevelID == ID)
                    return level;
            }
        
            Debug.LogError($"Level with ID {ID} not found");
            return _defaultLevel;
        }

        public LevelData GetNextLevelByCurrentID(string ID)
        {
            int currentIndex = 0;
            for (int i = 0; i < _levelDatas.Length; i++)
            {
                if (_levelDatas[i].LevelID == ID)
                {
                    currentIndex = i;
                    break;
                }
            }

            LevelData nextLevel;

            if (currentIndex == 0)
            {
                nextLevel = _defaultLevel;
            }
            else
            {
                int nextIndex = currentIndex + 1;
                if (nextIndex >= _levelDatas.Length)
                    nextIndex = 0;
                
                nextLevel = _levelDatas[nextIndex];
            }

            return nextLevel;
        }

    }
}

