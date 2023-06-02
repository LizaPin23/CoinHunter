using UnityEngine;

namespace CoinHunter.Shared
{
    public class SaveSystem : MonoBehaviour
    {
        public int CoinsAmount => _data.CoinsAmount;
        public string[] CompletedLevels => _data.CompletedLevels;
        
        private UserData _data;
        
        private const string prefsKey = "Save";
        
        public void Save()
        {
            string jsonData = JsonUtility.ToJson(_data);
            PlayerPrefs.SetString(prefsKey, jsonData);
        }

        public void Load()
        {
            string jsonData = PlayerPrefs.GetString(prefsKey);
            _data = JsonUtility.FromJson<UserData>(jsonData);
        }

        public void AddCoinsAmount(int coinsAmount)
        {
            _data.CoinsAmount += coinsAmount;
            Save();
        }

        public void SetLevelCompleted(string level)
        {
            //_data.CompletedLevels
        }
    }
}

