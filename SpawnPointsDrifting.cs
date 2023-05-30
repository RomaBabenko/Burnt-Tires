using UnityEngine;
using UnityEngine.AI;

public class SpawnPointsDrifting : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject[] _driftPointPrefab;
    [SerializeField] private GameObject _progressBar;
    private string _groundTag = "Ground";
    private NavMeshAgent _agent;
    private RaycastHit _hit;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    public void MoveToPoint()
    {
        DisablingForwardMovement();
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out _hit, Mathf.Infinity))
        {
            if (_hit.collider.CompareTag(_groundTag))
            {
                _agent.SetDestination(_hit.point);
                CreateDriftPoint(Random.Range(0, _driftPointPrefab.Length));
            }
        }
    }

    private void CreateDriftPoint(int index)
    {
        Instantiate(_driftPointPrefab[index], _hit.point, Quaternion.identity);
        Instantiate(_progressBar, _hit.point, Quaternion.identity);
    }

    private void DisablingForwardMovement()
    {
        GetComponent<CarMoverForward>().enabled = false;
    }
}
