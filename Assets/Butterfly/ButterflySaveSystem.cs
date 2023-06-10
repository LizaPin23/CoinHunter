using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflySaveSystem : MonoBehaviour
{
    private Butterflies _butter;
    public int ButterfliesAmount => _butter.ButterfliesAmount;
    public string ButterflyColor => _butter.ButterflyColor;
    public int YellowButterflies => _butter.YellowButterflies;

    private const string prefsKey = "Save";


    public void Save()
    {
        string jsonData = JsonUtility.ToJson(_butter);
        PlayerPrefs.SetString(prefsKey, jsonData);
    }

    public void Load()
    {
        
    }
}
