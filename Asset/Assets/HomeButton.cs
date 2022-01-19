using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HomeButton : MonoBehaviour
{
    public void MenuScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void RestartScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
}
