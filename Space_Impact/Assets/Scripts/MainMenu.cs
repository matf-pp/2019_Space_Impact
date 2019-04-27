using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Ucitava sledecu scenu koja je queue
    }

    public void QuitGame()
    {
        Debug.Log("Izasoo iz igricu!");
        Application.Quit();
    }
}
