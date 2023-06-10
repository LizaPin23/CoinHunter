using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyTest : MonoBehaviour
{
    [SerializeField] private ButterflySaveSystem _saveSystem;

    private void Awake()
    {
        LoadTest();
        ShowData();
    }

    private void SaveTest()
    {
        _saveSystem.SetTestData();
        _saveSystem.Save();
    }

    private void ShowData()
    {
        Debug.Log(_saveSystem.ButterfliesAmount);
        Debug.Log(_saveSystem.LastButterflyColor);
        Debug.Log(_saveSystem.YellowButterflies);
    }

    private void LoadTest()
    {
        _saveSystem.Load();
    }
}
