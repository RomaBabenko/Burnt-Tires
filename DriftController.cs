using UnityEngine;

public class DriftController : MonoBehaviour//переименовать DriftAnimation
{
    [SerializeField] private Animator _anim;
    [SerializeField] private Score _score;


    public void DriftAnimationOff()
    {
        _anim.SetBool("drift right", false);
        _anim.SetBool("drift left", false);
    }

    public void DriftLeft()
    {
        _anim.SetBool("drift left", true);
        _anim.SetBool("drift right", false);
        _score.ScoreFirst();
    }

    public void DriftRight()
    {
        _anim.SetBool("drift right", true);
        _anim.SetBool("drift left", false);
        _score.ScoreFirst();
    }
}
