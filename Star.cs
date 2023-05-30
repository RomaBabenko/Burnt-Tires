using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    private Score _score;

    private void Start()
    {
        _score = FindObjectOfType<Score>();
    }

    private void FixedUpdate()
    {
        Quaternion rotationY = Quaternion.AngleAxis(1, Vector3.up);
        transform.rotation *= rotationY; 
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Car")
        {
            DestroyStar();
            Destroy(gameObject, 0.7f);
        }
    }

    public void DestroyStar()
    {
        GetComponent<Animator>().Play("hide star");
        _particleSystem.Play();
        _score.BonusDrift();
    }
}
