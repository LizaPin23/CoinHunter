﻿using System;
using System.Collections.Generic;
using CoinHunter.GameFlow;
using CoinHunter.Levels.Collectables;
using CoinHunter.Shared;
using UnityEngine;

namespace CoinHunter.Levels.Playground
{
    public class LevelsPlaygroundBootstrap : MonoBehaviour
    {
        [SerializeField] private KeyboardInputController _input;
        [SerializeField] private Player.Player _player;
        [SerializeField] private LevelCoins _coins;
        [SerializeField] private LevelHearts _hearts;
        [SerializeField] private UIStateSwitcher _uiStateSwitcher;

        private GameFlowController _gameFlowController;

        private void Awake()
        {
            _input.Movement += _player.OnMovementKeyPressed;
            _input.SpacePressed += _player.OnJumpKeyPressed;

            _coins.Initialize();
            _hearts.Initialize();

            IGameStateListener[] gameStateListeners = CreateGameStateListeners();
            IPauseInvoker[] pauseInvokers = CreatePauseInvokers();
            IGameOverInvoker[] gameOverInvokers = CreateGameOverInvokers();
            
            _gameFlowController = new GameFlowController(gameStateListeners, pauseInvokers, gameOverInvokers);
        }

        private void Start()
        {
            _gameFlowController.StartGame();
        }

        private IGameStateListener[] CreateGameStateListeners()
        {
            List<IGameStateListener> result = new List<IGameStateListener>();
            result.Add(_uiStateSwitcher);
            result.Add(_player);

            return result.ToArray();
        }

        private IPauseInvoker[] CreatePauseInvokers()
        {
            IPauseInvoker[] result = new[]
            {
                _input
            };

            return result;
        }
        
        private IGameOverInvoker[] CreateGameOverInvokers()
        {
            IGameOverInvoker[] result = new[]
            {
                _hearts
            };

            return result;
        }
        
    }
}

