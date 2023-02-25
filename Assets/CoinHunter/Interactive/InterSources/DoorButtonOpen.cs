using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Levels.Interactive
{
    public class DoorButtonOpen : MonoBehaviour
    {
        [SerializeField] private Door _door;
        [SerializeField] private bool _closeOnButtonReset;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<ButtonBlock>(out ButtonBlock buttonBlock))
            {
                _door.SetOpened(true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (!_closeOnButtonReset)
                return;

            if (collision.TryGetComponent<ButtonBlock>(out ButtonBlock buttonBlock))
            {
                _door.SetOpened(false);
            }
        }
    }

}
