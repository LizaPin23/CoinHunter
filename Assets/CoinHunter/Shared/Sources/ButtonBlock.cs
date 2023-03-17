using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinHunter.Levels.Interactive
{
    public class ButtonBlock : MonoBehaviour, IWaterReaction
    {
        [SerializeField] private Transform _transform;
        public void ReactWater()
        {
            _transform.localPosition = new Vector3(0, 0, 0);
        }

    }
}
