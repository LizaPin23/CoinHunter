
using UnityEngine;

namespace CoinHunter.GameFlow
{
    public class Pause : MonoBehaviour
    {
        // [SerializeField] private PauseMenu _pauseMenu;
        // [SerializeField] private PauseButton _pauseButton;
        //
        // private bool _pause;
        // private List<IGameStateListener> _listeners = new List<IGameStateListener>();
        //
        // private void Awake()
        // {
        //     _pauseMenu.QuitButtonPressed += OnQuitButtonPressed;
        //     _pauseMenu.ContinueButtonPressed += OnContinueButtonPressed;
        //
        //     _pauseButton.Pressed += OnPausePressed;
        // }
        //
        // public void AddPauseListener(IGameStateListener listener)
        // {
        //     _listeners.Add(listener);
        // }
        //
        // private void Start()
        // {
        //     DoPause(false);
        //     StartGame();
        // }
        //
        // public void ChangePauseState()
        // {
        //     DoPause(!_pause);
        // }
        //
        // private void OnPausePressed()
        // {
        //     DoPause(true);
        // }
        //
        // private void DoPause(bool value)
        // {
        //     SetPaused(value);
        //     //TODO turn off game UI
        //     //_pauseButton.SetVisible(!_pause);
        //     _pauseMenu.SetVisible(_pause);
        // }
        //
        // private void SetPaused(bool value)
        // {
        //     _pause = value;
        //
        //     if (_pause)
        //     {
        //         Time.timeScale = 0;
        //     }
        //     else
        //     {
        //         Time.timeScale = 1;
        //     }
        //
        //     foreach (var listener in _listeners)
        //     {
        //         listener.OnGameStateChanged(_pause);
        //     }
        // }
        //
        // private void OnQuitButtonPressed()
        // {
        //     Application.Quit();
        // }
        //
        //
        // private void OnContinueButtonPressed()
        // {
        //     DoPause(false);
        // }
        //
        // private void StartGame()
        // {
        //     //запуск игры
        // }
    }
}

