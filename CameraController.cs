using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _player.position;
    }

    private void Update()
    {
        Vector3 newPosition = new Vector3(_offset.x + _player.position.x, transform.position.y, transform.position.z);
        transform.position = newPosition;
    }
}
