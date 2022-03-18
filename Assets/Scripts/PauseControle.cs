using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseControle : MonoBehaviour
{
    public GameObject pause;
    public GameObject panel;


    public static bool pauseIsActive;

    void Start()
    {
        Time.timeScale = 1;
        pauseIsActive = false;
        pause.SetActive(false);
        panel.SetActive(false);
    }

    private void Update()
    {
        if (StartPanel.tapMade)
            pause.SetActive(true);
    }

    public void PauseBtn()
    {
        Time.timeScale = 0;
        pauseIsActive = true;
        pause.SetActive(false);
        panel.SetActive(true);
    }

    public void RestartBtn()
    {
        Time.timeScale = 1;
        pauseIsActive = false;
        pause.SetActive(false);
        panel.SetActive(false);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);

    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseIsActive = false;
        pause.SetActive(true);
        panel.SetActive(false);
    }

    public void GoToMenu()
    {
        pauseIsActive = false;
        StartPanel.tapMade = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1, LoadSceneMode.Single);
    }
}
