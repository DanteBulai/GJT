using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] float _speed = 4f;
    [SerializeField] Transform _targetPosition;
    private Vector3 _currentPosition;

    private void Start()
    {
        _currentPosition = _targetPosition.position - transform.position;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _targetPosition.position - _currentPosition, _speed * Time.deltaTime);
    }
}
