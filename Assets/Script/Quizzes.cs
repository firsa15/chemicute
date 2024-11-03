using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quizzes : MonoBehaviour
{
    [SerializeField] AudioSource WrongAnswer;
    [SerializeField] AudioSource RightAnswer;
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ClickButton()
    {
        AudioManager.instance.ClickButtonEffect();
    }

    public void wrong()
    {
        WrongAnswer.Play();
    }

    public void right()
    {
        RightAnswer.Play();
    }
    //public void RightAnswer()
    //{
    //    AudioManager.instance.RightAnswerSound();
    //}

    //public void WrongAnswer()
    //{
    //    AudioManager.instance.WrongAnswerSound();
    //}
}
