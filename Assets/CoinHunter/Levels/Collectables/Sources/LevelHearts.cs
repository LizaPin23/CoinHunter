﻿using System;
using CoinHunter.GameFlow;
using UnityEngine;

namespace CoinHunter.Levels.Collectables
{
    public class LevelHearts : MonoBehaviour, IGameOverInvoker
    {
        [SerializeField] private Heart[] _hearts;
        [SerializeField] private UITextView _heartsView;
        [SerializeField] private int _startLives = 3;
        [SerializeField] private int _maxLives = 3;

        private int _inGameLives;
        
        public event Action GameOver;


        public void Initialize()
        {
            _inGameLives = _startLives;
            ControlHeartsCollider();
            _heartsView.ShowValue(_inGameLives);

            for (int i = 0; i < _hearts.Length; i++)
            {
                _hearts[i].Collected += OnHeartCollected;
            }
        }

        private void ControlHeartsCollider()
        {
            for (int i = 0; i < _hearts.Length; i++)
            {
                bool result = _inGameLives >= _maxLives;
                _hearts[i].SetColliderActive(!result);
            }

        }

        private void OnHeartCollected(Heart collectedHeart)
        {


            _inGameLives += collectedHeart.Value;
            ControlHeartsCollider();
            collectedHeart.Hide();
            _heartsView.ShowValue(_inGameLives);
        }

        public void OnHeartConsumed(int value)
        {
            _inGameLives -= value;
            ControlHeartsCollider();
            _heartsView.ShowValue(_inGameLives);
            
            if (_inGameLives == 0)
            {
                GameOver?.Invoke();
            }

            Debug.Log("Вызывается");
        }
    }
}

