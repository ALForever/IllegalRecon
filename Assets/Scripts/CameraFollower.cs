using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private float _smoothing;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private Transform _targetTransform;
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 nextPosition = Vector3.Lerp(transform.position, _targetTransform.position + _offset, Time.fixedDeltaTime * _smoothing);

        transform.position = nextPosition;
    }
}
