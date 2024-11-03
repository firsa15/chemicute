using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   // public GameObject infoPopUp;
    //public bool aktif;

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game telah keluar");
    }
    //public void Info()
    //{
    //   infoPopUp.SetActive(aktif);
    //}
    public void Play()
    {
        SceneManager.LoadScene("ScanAR");
    }
    public void ClickButton()
    {
        AudioManager.instance.ClickButtonEffect();
    }
}
