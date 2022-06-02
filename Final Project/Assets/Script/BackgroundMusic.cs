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
        SoundManager.instance.PlayBackground(backgroundOverSound);
    }

    public void SetupBackGround()
    {
        SoundManager.instance.PauseSound();
        gameObject.SetActive(false); 
        GetComponent<BackgroundMusic>().enabled = false;
    }
}
