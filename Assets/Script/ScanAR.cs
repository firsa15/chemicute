using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScanAR : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Play()
    {
        SceneManager.LoadScene("QuizMainMenu");
    }

    public void ClickButton()
    {
        AudioManager.instance.ClickButtonEffect();
    }
}
