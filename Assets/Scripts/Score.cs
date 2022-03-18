using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Transform playerPos;

    public Text score;

    void Start()
    {
        score.enabled = false;
    }
    
    void Update()
    {
        if (StartPanel.tapMade)
        {
            score.enabled = true;
        }
        if (playerPos != null)
        {
            score.text = (playerPos.position.z < 0 ? "0" : ((int)playerPos.position.z / 2).ToString());
        }
    }
}
