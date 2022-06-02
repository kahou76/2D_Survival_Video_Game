using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Background : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void StartGameMonsterSpawner()
    {
        SceneManager.LoadScene("2vsbots");
    }

    public void StartGameHealth()
    {
        SceneManager.LoadScene("1v1 version02");
    }

    public void StartGameMonsters()
    {
        SceneManager.LoadScene("1vsbots");
    }
}
