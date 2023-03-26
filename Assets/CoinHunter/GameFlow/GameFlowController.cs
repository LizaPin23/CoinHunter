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

        public GameFlowController(IGameStateListener[] listeners, IPauseInvoker[] pauseInvokers,
            IGameOverInvoker[] gameOverInvokers)
        {
            _listeners = new List<IGameStateListener>(listeners);
            _gameOverInvokers = new List<IGameOverInvoker>(gameOverInvokers);
            
            foreach (var invoker in _gameOverInvokers)
            {
                invoker.GameOver += OnGameOver;
            }
            
            _pauseInvokers = new List<IPauseInvoker>(pauseInvokers);
            
            foreach (var invoker in _pauseInvokers)
            {
                invoker.Pause += OnPause;
            }
        }

        public void StartGame()
        {
            SetGameState(GameState.RestartGame);
        }

        private void OnGameOver()
        {
            SetGameState(GameState.GameOver);
        }

        private void OnPause()
        {
            SetGameState(GameState.Pause);
        }
        
        private void SetGameState(GameState state)
        {
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
    }
}

