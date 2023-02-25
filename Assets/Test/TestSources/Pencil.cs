using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tests
{
    public class Pencil : MonoBehaviour, IUseably
    {
        public int Speed => 4;

        public void Use()
        {
            Debug.Log("Пишет со скоростью" + Speed);
        }
    }
}
