using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizMainMenu : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Play()
    {
        SceneManager.LoadScene("Quizzes");
    }

    public void ClickButton()
    {
        AudioManager.instance.ClickButtonEffect();
    }
}
