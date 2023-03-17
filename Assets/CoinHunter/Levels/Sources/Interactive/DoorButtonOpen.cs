using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Levels.Interactive
{
    public class DoorButtonOpen : MonoBehaviour
    {
        [SerializeField] private Door _door;
        [SerializeField] private bool _closeOnButtonReset;

        private List<IButtonPress> _interactors = new List<IButtonPress>();

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<IButtonPress>(out IButtonPress buttonPress))
            {
                if (!_interactors.Contains(buttonPress))
                    _interactors.Add(buttonPress);
                
                _door.SetOpened(true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (!_closeOnButtonReset)
                return;

            if (collision.TryGetComponent<IButtonPress>(out IButtonPress buttonBlock))
            {
                if (_interactors.Contains(buttonBlock))
                    _interactors.Remove(buttonBlock);
                
                if (_interactors.Count == 0)
                    _door.SetOpened(false);
            }
        }
    }

}
