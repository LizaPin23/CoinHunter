using System;
using System.Collections;
using UnityEngine;

namespace CoinHunter.MainMenu.FakeLevel
{
    public class AIInput : MonoBehaviour
    {
        [SerializeField] private AIJumpTrigger[] _jumpTriggers;
        [SerializeField] private AILevelEndTrigger _levelEndTrigger;
        
        public event Action JumpInput;
        public event Action<float> Movement;
        public event Action LevelEnded;

        private void Awake()
        {
            foreach (var jumpTrigger in _jumpTriggers)
            {
                jumpTrigger.PlayerEntered += JumpTriggerOnPlayerEntered;
            }
            
            _levelEndTrigger.PlayerEntered += LevelEndTriggerOnPlayerEntered;
        }

        private void LevelEndTriggerOnPlayerEntered()
        {
            LevelEnded?.Invoke();
        }

        private void JumpTriggerOnPlayerEntered()
        {
            JumpInput?.Invoke();
        }

        public void StartMovementRight()
        {
            StartCoroutine(MovementCoroutine(1));
        }

        public void StopAllActions()
        {
            StopAllCoroutines();
        }

        private IEnumerator MovementCoroutine(float movement)
        {
            while (true)
            {
                Movement?.Invoke(movement);
                yield return null;
            }
        }
    }
}

