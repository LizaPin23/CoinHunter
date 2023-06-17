using UnityEngine;

namespace CoinHunter.Shared
{
    public class SaveSystem : MonoBehaviour
    {
        public int CoinsAmount => _data.CoinsAmount;
        public string[] CompletedLevels => _data.CompletedLevels;

        private UserData _data = new UserData();

        private const string prefsKey = "Save";
        
        public void Save()
        {
            string jsonData = JsonUtility.ToJson(_data);

            if (string.IsNullOrEmpty(jsonData))
            {
                Debug.LogError("Save error");
                return;
            }

            PlayerPrefs.SetString(prefsKey, jsonData);
            PlayerPrefs.Save();
        }

        public void Load()
        {
            string jsonData = PlayerPrefs.GetString(prefsKey);

            if (string.IsNullOrEmpty(jsonData))
            {
                _data = new UserData();
                return;
            }

            _data = JsonUtility.FromJson<UserData>(jsonData);

            if (_data == null)
                _data = new UserData();
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

