using System.Collections.Generic;
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

        private GameState _currentState;

        public GameFlowController(IGameStateListener[] listeners, IPauseInvoker[] pauseInvokers,
            IGameOverInvoker[] gameOverInvokers, IContinueInvoker[] continueInvokers)
        {
            _listeners = new List<IGameStateListener>(listeners);
            _gameOverInvokers = new List<IGameOverInvoker>(gameOverInvokers);
            _continueInvokers = new List<IContinueInvoker>(continueInvokers);
            
            foreach (var invoker in _gameOverInvokers)
            {
                invoker.GameOver += OnGameOver;
            }
            
            _pauseInvokers = new List<IPauseInvoker>(pauseInvokers);
            
            foreach (var invoker in _pauseInvokers)
            {
                invoker.Pause += OnPause;
            }
            
            foreach (var invoker in _continueInvokers)
            {
                invoker.Continue += OnContinue;
            }
        }

        private void OnContinue()
        {
            if (_currentState != GameState.Pause)
                return;
            
            StartGame();
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

