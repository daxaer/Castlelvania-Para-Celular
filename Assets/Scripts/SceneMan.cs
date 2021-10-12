using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Options()
    {
        SceneManager.LoadScene(2);
    }
    public void Credits()
    {
        SceneManager.LoadScene(3);
    }
    public void Exit()
    {
        Application.Quit();
    }

}