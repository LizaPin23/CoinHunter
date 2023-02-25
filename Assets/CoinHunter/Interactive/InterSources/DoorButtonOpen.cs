using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Levels.Interactive
{
    public class DoorButtonOpen : MonoBehaviour
    {
        [SerializeField] private DoorOpen _doorOpen;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<ButtonBlock>(out ButtonBlock buttonBlock))
            {
                _doorOpen.Open();
            }
        }
    }

}
