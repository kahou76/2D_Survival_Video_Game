using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
   public void Setup()
    {
        gameObject.SetActive(true);
    }
    public void restartHealthScence()
    {
        SceneManager.LoadScene("Health");
    }

    public void exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
