using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFence : MonoBehaviour
{
    [SerializeField] private ProgressScreens _gameOverScreen;
    [SerializeField] private GameObject _car;
    [SerializeField] private ParticleSystem _explosion;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Car")
        {
            _gameOverScreen.GameOver();
            Destroy(_car, 2f);
            _explosion.Play();
        }
    }
}
