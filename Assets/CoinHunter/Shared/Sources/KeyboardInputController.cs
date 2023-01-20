using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Shared
{
    public class KeyboardInputController : MonoBehaviour
    {
        public event Action SpacePressed;
        public event Action<float> Movement;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpacePressed?.Invoke();
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

