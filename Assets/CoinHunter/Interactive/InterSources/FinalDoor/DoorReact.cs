using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoinHunter.Player;

namespace CoinHunter.Levels.Interactive
{
    public class DoorReact : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<IWaterReaction>(out IWaterReaction iWaterReaction))
            {
                Debug.Log("Уровень пройден");
            }
        }
    }

}

