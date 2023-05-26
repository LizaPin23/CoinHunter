using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuBattons : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _selectLevelButton;
    [SerializeField] private Button _exitButton;
    //обратиться к левелс лоадеру и загрузить у него этот метод
    [SerializeField] private LevelsLoader _levelLoader;

    public void OnStartButtonPressed()
    {
        _levelLoader.LoadLevel();
    }

    public void OnSelectLevelButtonPressed()
    {

    }

    public void OnExitButtonPressed()
    {
        Application.Quit();
    }
}
