using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : MonoBehaviour
{
    public GameObject text;
    public GameObject particle;

    private bool isMobile;
    public static bool tapMade;

    void Start()
    {
        tapMade = false;
        isMobile = Application.isMobilePlatform;
        Time.timeScale = 1;

        text.SetActive(true);
        particle.SetActive(false);
    }


    void Update()
    {
        if (!tapMade)
        {
            if (isMobile)
            {
                if (Input.touchCount > 0)
                {
                    Time.timeScale = 1;
                    text.SetActive(false);
                    particle.SetActive(true);
                    tapMade = true;

                }
            }
            else
            {
                if (Input.GetMouseButton(0))
                {
                    Time.timeScale = 1;
                    text.SetActive(false);
                    particle.SetActive(true);
                    tapMade = true;
                }
            }
        }
    }
}
