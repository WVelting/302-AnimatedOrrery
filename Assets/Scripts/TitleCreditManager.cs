using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleCreditManager : MonoBehaviour
{
    void Start(){
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void OnClickStart(){
        SceneManager.LoadScene("Planets");

    }

    public void OnClickCredits(){
        SceneManager.LoadScene("Credits");

    }

    public void OnClickTitle(){
        SceneManager.LoadScene("Title");

    }

    public void OnClickQuit(){
        Application.Quit();

    }
}
