using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tests
{
    public class Brush : MonoBehaviour, IUseably
    {
        public int Speed => 2;

        public void Use()
        {
            Debug.Log("Рисует со скоростью" + Speed);
        }
    }
}

