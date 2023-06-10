using UnityEngine;

public class ButterflySaveSystem : MonoBehaviour
{
    private Butterflies _data = new Butterflies();
    public int ButterfliesAmount => _data.ButterfliesAmount;
    public string LastButterflyColor => _data.LastButterflyColor;
    public int YellowButterflies => _data.YellowButterflies;

    private const string prefsKey = "Save";

    public void SetTestData()
    {
        _data = new Butterflies();
        _data.ButterfliesAmount = 4;
        _data.LastButterflyColor = "Blue";
        _data.YellowButterflies = 3;
    }
    
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
            _data = new Butterflies();
            return;
        }
        
        _data = JsonUtility.FromJson<Butterflies>(jsonData);

        if (_data == null)
            _data = new Butterflies();
    }
}
