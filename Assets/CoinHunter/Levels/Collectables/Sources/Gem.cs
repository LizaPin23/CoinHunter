using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Levels.Collectables
{
    public class Gem : MonoBehaviour, ICollectable
    {
        public void Collect()
        {
            Debug.Log("Ты собрал камешек");
        }
    }
}
