using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Levels/LevelsDataBase")]
public class LevelsDatabase : ScriptableObject 
{
    [SerializeField] private LevelData[] _levelDatas;
    public LevelData[] LevelDatas => _levelDatas;

    //public LevelData GetLevelByID(string ID)
    //{
    //   // цикл который сравнивает айди с айди и находит нужный
    //    //for(int i = 0; i < _levelDatas.Length; i++)
    //    //{ 

    //   // }
    //}

}
