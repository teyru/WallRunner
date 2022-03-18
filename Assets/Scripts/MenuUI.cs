using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{

    public Text score;
    void Start()
    {
        Time.timeScale = 0;
        score.text = PlayerPrefs.GetInt("BestScore").ToString();
    }

    public void StartBtnDown()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }

    public void ExitBtnDown()
    {
        Application.Quit();
    }
}
