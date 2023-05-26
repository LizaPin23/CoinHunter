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

    }
}

