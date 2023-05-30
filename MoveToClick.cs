using UnityEngine;

public class MoveToClick : MonoBehaviour
{
    [SerializeField] private SpawnPointsDrifting _spawnPointsDrifting;
    [SerializeField] private DriftController _driftController;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _spawnPointsDrifting.MoveToPoint();
            _driftController.DriftAnimationOff();
        }
    }
}
