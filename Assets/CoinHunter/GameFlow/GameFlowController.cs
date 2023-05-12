using System.Collections.Generic;
using System;
using UnityEngine;

namespace CoinHunter.GameFlow
{
    public class GameFlowController
    {
        private GameState _state;
        private readonly List<IGameStateListener> _listeners;

        private readonly List<IGameOverInvoker> _gameOverInvokers;
        private readonly List<IPauseInvoker> _pauseInvokers;
        private readonly List<IContinueInvoker> _continueInvokers;
        private readonly List<IQuitInvoker> _quitInvokers;
        private readonly List<IRestartInvoker> _restartInvokers;

        public Action<> Restart;


        private GameState _currentState;

        public GameFlowController(IGameStateListener[] listeners, IPauseInvoker[] pauseInvokers,
            IGameOverInvoker[] gameOverInvokers, IContinueInvoker[] continueInvokers,
            IQuitInvoker[] quitInvokers, IRestartInvoker[] restartInvokers)
        {
            _listeners = new List<IGameStateListener>(listeners);
            _gameOverInvokers = new List<IGameOverInvoker>(gameOverInvokers);
            _continueInvokers = new List<IContinueInvoker>(continueInvokers);
            _pauseInvokers = new List<IPauseInvoker>(pauseInvokers);
            _quitInvokers = new List<IQuitInvoker>(quitInvokers);
            _restartInvokers = new List<IRestartInvoker>(restartInvokers);

            foreach (var invoker in _gameOverInvokers)
            {
                invoker.GameOver += OnGameOver;
            }

            foreach (var invoker in _pauseInvokers)
            {
                invoker.Pause += OnPause;
            }
            
            foreach (var invoker in _continueInvokers)
            {
                invoker.Continue += OnContinue;
            }

            foreach (var invoker in _quitInvokers)
            {
                invoker.Quit += QuitGame;
            }

            foreach (var invoker in _restartInvokers)
            {
                invoker.Restart += OnRestart;
            }
        }

        private void OnContinue()
        {
            if (_currentState != GameState.Pause)
                return;
            
            StartGame();
        }

        private void OnRestart()
        {
            if (_currentState != GameState.GameOver)
                return;

            // добавить тут листенеры
        }

        public void StartGame()
        {
            SetGameState(GameState.InGame);
            TimeScaleActive(true);
        }

        private void OnGameOver()
        {
            SetGameState(GameState.GameOver);
            TimeScaleActive(false);

        }

        private void OnPause()
        {
            SetGameState(GameState.Pause);
            TimeScaleActive(false);
        }
        
        private void SetGameState(GameState state)
        {
            _currentState = state;
            
            foreach (var listener in _listeners)
            {
                listener.OnGameStateChanged(state);
            }
        }

        public void QuitGame()
        {
            Application.Quit();
            Debug.Log("Конец игры");
        }

        private void OnDestroy()
        {
            foreach (var invoker in _gameOverInvokers)
            {
                invoker.GameOver -= OnGameOver;
            }
            
            foreach (var invoker in _pauseInvokers)
            {
                invoker.Pause -= OnPause;
            }
        }

        private void TimeScaleActive(bool result)
        {
            if (result == true)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
        }
    }
}

