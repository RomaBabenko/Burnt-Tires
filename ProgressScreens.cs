using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressScreens: MonoBehaviour
{
    [SerializeField] private GameObject _deathScreen;
    [SerializeField] private GameObject _finishScreen;

    public void GameOver()
    {
        if (!_deathScreen.activeSelf)
        {
            Invoke("EndScreen", 2f);
        }
    }

    public void PassedLevel()
    {
        if (!_finishScreen.activeSelf)
        {
            Invoke("FinishScreen", 2f);
        }
    }

    private void EndScreen()
    {
        _deathScreen.SetActive(true);
    }

    private void FinishScreen()
    {
        _finishScreen.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
