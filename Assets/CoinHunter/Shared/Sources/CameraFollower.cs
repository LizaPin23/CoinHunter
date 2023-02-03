﻿using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private float _speed = 3f;

    private const float _z = -10f;

    void Update()
    {
        Vector3 difference = _targetTransform.position - transform.position;
        Vector3 movement = _speed * difference;
        movement.z = _z;

        transform.Translate(movement * Time.deltaTime);
    }
}
