using UnityEngine;
using UnityEngine.UI;

public class DriftPerformance : MonoBehaviour
{
    [SerializeField] private float _speedRot;
    [SerializeField] private DriftController _driftController;//переименовать

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Drift Point Left")
        {
            _driftController.DriftLeft();
            transform.Rotate(0, _speedRot, 0);
        }

        if (collision.gameObject.tag == "Drift Point Right")
        {
            _driftController.DriftRight();
            transform.Rotate(0, -_speedRot, 0);
        }
    }
}
