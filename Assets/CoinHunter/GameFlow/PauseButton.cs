using System;
using UnityEngine;
using UnityEngine.UI;

namespace CoinHunter.GameFlow
{
    [RequireComponent(typeof(Button))]
    public class PauseButton : MonoBehaviour, IPauseInvoker
    {
        public event Action Pause;

        private void Awake()
        {
            Button button = GetComponent<Button>();
            button.onClick.AddListener(OnPress);
        }

        public void OnPress()
        {
            Pause?.Invoke();
        }
    }
}

