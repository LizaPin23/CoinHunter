using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsLoader : MonoBehaviour
{
    [SerializeField] private LevelsDatabase _levelsDatabase;

    public void LoadLevel()
    {
        string ID = "Test";
        //взять уровень из базы и загрузить его сцену
        //_levelsDatabase.GetLevelByID();
        //SceneManager.LoadScene();
    }
}
