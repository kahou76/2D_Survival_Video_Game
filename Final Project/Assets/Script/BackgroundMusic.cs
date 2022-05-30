using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    [SerializeField] private AudioClip backgroundOverSound;

    public void Start()
    {
        SoundManager.instance.PlaySound(backgroundOverSound);
    }

    public void SetupBackGround()
    {
        gameObject.SetActive(false);
        SoundManager.instance.PauseSound();
        GetComponent<BackgroundMusic>().enabled = false;
    }
}
