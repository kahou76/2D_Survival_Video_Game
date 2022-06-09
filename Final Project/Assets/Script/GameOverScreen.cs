using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private AudioClip gameOverSound;

    public void Setup()
    {
        gameObject.SetActive(true);
        SoundManager.instance.PlaySound(gameOverSound);
    }
    public void restartHealthScence()
    {
        SceneManager.LoadScene("1v1 version02");
    }
    public void restartMonsterSpawnhScence()
    {
        SceneManager.LoadScene("2vsbots02");
    }

    public void restartMonsterScence()
    {
        SceneManager.LoadScene("1vsbots002");
    }
    public void exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
