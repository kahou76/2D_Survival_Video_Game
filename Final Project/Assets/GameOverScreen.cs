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
        SceneManager.LoadScene("Health");
    }
    public void restartMonsterSpawnhScence()
    {
        SceneManager.LoadScene("MonsterSpawner");
    }
    public void exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
