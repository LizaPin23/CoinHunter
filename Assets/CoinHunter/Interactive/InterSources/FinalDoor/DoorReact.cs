using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoinHunter.Player;

namespace CoinHunter.Levels.Interactive
{
    public class DoorReact : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent<PlayerInteractive>(out PlayerInteractive platerInteractive))
            {
                Debug.Log("Уровень пройден");
            }
        }
        
    }

}

