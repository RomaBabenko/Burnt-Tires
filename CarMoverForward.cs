using UnityEngine;

public class CarMoverForward : MonoBehaviour
{
    public Transform SelfTransform;
    private Vector3 _direction;
    [SerializeField] private float _speed;

    private void Start()
    {
        _direction = new Vector3(_speed, 0, 0) * Time.deltaTime;
    }

    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        SelfTransform.position += _direction;
    }
}


