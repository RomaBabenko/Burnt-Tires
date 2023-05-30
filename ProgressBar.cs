using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image HealthBarPlayer;
    [SerializeField] private Score _score;

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Driver")
        {
            HealthBarPlayer.fillAmount -= (0.25f * Time.deltaTime);
            _score.ScoreFirst();

            if (HealthBarPlayer.fillAmount <= 0)
            {
                _score.AccountReset();
            }

        }
    }
}


