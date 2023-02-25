using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Levels.Interactive
{
    public class DoorOpen : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        //[SerializeField] private string _movingBool = "Moving";
        [SerializeField] private string _doorBool = "DoorBool";



        public void Open()
        {
            _animator.SetBool(_doorBool, true);
        }
    }
}

