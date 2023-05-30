using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int _scoreFirst;
    private int _scoreSecond;
    [SerializeField] private Text _scoreDisplayFirst;
    [SerializeField] private Text _scoreDisplaySecond;


    private void Update()
    {
        _scoreDisplayFirst.text = _scoreFirst.ToString();
    }

    public void ScoreFirst()
    {
        //_scoreFirst += _scoreSecond;
        _scoreFirst++;
    }

    public void ScoreSecond()
    {
        _scoreSecond++;
        // _scoreDisplaySecond.text = _scoreSecond.ToString();
    }

    public void BonusDrift()
    {
        _scoreFirst *= 2;
    }

    public void AccountReset()
    {
        _scoreSecond = 0;
    }
}
