using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private ProgressScreens _nextLevelScreen;
    [SerializeField] private ParticleSystem _explosion;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Car")
        {
            _nextLevelScreen.PassedLevel();
            _explosion.Play();
        }
    }
}
