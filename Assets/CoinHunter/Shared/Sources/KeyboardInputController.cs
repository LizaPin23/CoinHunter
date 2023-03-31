using System;
using CoinHunter.GameFlow;
using UnityEngine;

namespace CoinHunter.Shared
{
    public class KeyboardInputController : MonoBehaviour, IPauseInvoker
    {
        public event Action Pause;
        public event Action SpacePressed;
        public event Action<float> Movement;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpacePressed?.Invoke();
            }
            
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Pause?.Invoke();
            }

            CatchMovementButtons();
        }

        private void CatchMovementButtons()
        {
            float movementX = Input.GetAxis("Horizontal");

            Movement?.Invoke(movementX);
        }

    }
}

