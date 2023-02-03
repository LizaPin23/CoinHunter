using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    private const float _z = -10f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(_transform.position.x, _transform.position.y, _z);
    }
}
