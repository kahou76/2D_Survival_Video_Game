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
        SceneManager.LoadScene("MonsterSpawner");
    }

    public void StartGameHealth()
    {
        SceneManager.LoadScene("Health");
    }

    public void StartGameMonsters()
    {
        SceneManager.LoadScene("Monsters");
    }
}
