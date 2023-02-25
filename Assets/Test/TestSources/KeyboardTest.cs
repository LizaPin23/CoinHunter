using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tests
{
    public class KeyboardTest : MonoBehaviour, IUseably
    {
        public int Speed => 7;

        public void Use()
        {
            Debug.Log("Печатает со скоростью" + Speed);
        }
    }
}

