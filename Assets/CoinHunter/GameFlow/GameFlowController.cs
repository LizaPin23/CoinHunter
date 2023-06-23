using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.GameFlow
{
    public class GameFlowController
    {
        private GameState _state;
        private readonly List<IGameStateListener> _gameStatelisteners;

        private readonly List<IGameOverInvoker> _gameOverInvokers;
        private readonly List<IPauseInvoker> _pauseInvokers;
        private readonly List<IFinishInvoker> _finishInvokers;
        private readonly List<IContinueInvoker> _continueInvokers;
        private readonly List<IRestartInvoker> _restartInvokers;
        private readonly List<IRestartListener> _restartListeners;


        private GameState _currentState;

        public GameFlowController(IGameStateListener[] listeners, IPauseInvoker[] pauseInvokers,
            IGameOverInvoker[] gameOverInvokers, IContinueInvoker[] continueInvokers,
            IRestartInvoker[] restartInvokers, IRestartListener[] restartListeners, IFinishInvoker[] finishInvokers)
        {
            _gameStatelisteners = new List<IGameStateListener>(listeners);
            _gameOverInvokers = new List<IGameOverInvoker>(gameOverInvokers);
            _continueInvokers = new List<IContinueInvoker>(continueInvokers);
            _pauseInvokers = new List<IPauseInvoker>(pauseInvokers);
            _restartInvokers = new List<IRestartInvoker>(restartInvokers);
            _restartListeners = new List<IRestartListener>(restartListeners);
            _finishInvokers = new List<IFinishInvoker>(finishInvokers);


            foreach (var invoker in _gameOverInvokers)
            {
                invoker.GameOver += OnGameOver;
            }
            
            foreach (var invoker in _finishInvokers)
            {
                invoker.FinishGame += FinishGame;
            }

            foreach (var invoker in _pauseInvokers)
            {
                invoker.Pause += OnPause;
            }
            
            foreach (var invoker in _continueInvokers)
            {
                invoker.Continue += OnContinue;
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
            
            ContinueGame();
        }

        public void OnRestart()
        {
            
            foreach (var listener in _restartListeners)
            {
                listener.OnGameRestart();
            }

            ContinueGame();
        }

        private void ContinueGame()
        {
            SetGameState(GameState.InGame);
            TimeScaleActive(true);
        }

        private void FinishGame()
        {
            SetGameState(GameState.Finish);
            TimeScaleActive(false);
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
            
            foreach (var listener in _gameStatelisteners)
            {
                listener.OnGameStateChanged(state);
            }
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

