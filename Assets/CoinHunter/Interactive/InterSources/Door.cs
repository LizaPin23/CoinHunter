using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Levels.Interactive
{
    public class Door : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _doorBool = "DoorBool";

        public void SetOpened(bool value)
        {
            _animator.SetBool(_doorBool, value);
        }
    }
}

