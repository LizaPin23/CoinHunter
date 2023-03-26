
using System;
using UnityEngine;

public class Controller : MonoBehaviour
{

    [SerializeField] private PauseMenu _pauseMenu;
    [SerializeField] private PauseButton _pauseButton;

    public event Action<bool> OnPauseChanged;

    private bool _pause;

    private void Awake()
    {

        _pauseMenu.QuitButtonPressed += OnQuitButtonPressed;
        _pauseMenu.ContinueButtonPressed += OnContinueButtonPressed;
        _pauseMenu.PauseButtonPressed += OnPausePressed;

        _pauseButton.Pressed += OnPausePressed;
    }

    private void Start()
    {
        DoPause(false);
        StartGame();
    }

    private void OnPausePressed()
    {
        DoPause(!_pause);
    }

    private void DoPause(bool value)
    {
        SetPaused(value);
        _pauseButton.SetVisible(!_pause);
        _pauseMenu.SetVisible(_pause);
    }

    private void SetPaused(bool value)
    {
        _pause = value;

        if (_pause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

        OnPauseChanged?.Invoke(_pause);
    }


    private void OnQuitButtonPressed()
    {
        Application.Quit();
    }


    private void OnContinueButtonPressed()
    {
        DoPause(false);
    }

    private void StartGame()
    {
        //запуск игры
    }
}
