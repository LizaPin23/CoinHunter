using UnityEngine;

namespace CoinHunter.MainMenu
{
    [CreateAssetMenu(menuName = "Levels/LevelData")]
    public class LevelData : ScriptableObject 
    {
        [SerializeField] private string _levelName;
        [SerializeField] private string _sceneName;
        [SerializeField] private Sprite _prevSprite;
        [SerializeField] private string _levelID;
        public string LevelName => _levelName;
        public string SceneName => _sceneName;
        public Sprite PrevSprite => _prevSprite;
        public string LevelID => _levelID;
    }
}

