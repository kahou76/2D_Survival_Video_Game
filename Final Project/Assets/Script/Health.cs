using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int health;
    [Header("Death Sound")]
    [SerializeField] private AudioClip deathSound;

    public static int scoreValue = 0;
    public GameObject score;
    public int MAX_HEALTH = 100;
    public BloodBar bloodBar;
    public GameObject textDisplay;
    public int secondsLeft = 10;
    public bool takingAway = false;
    public GameOverScreen GameOverScreen;
    public BackgroundMusic BackgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        health = MAX_HEALTH;
        Time.timeScale = 1f;
        bloodBar.SetMaxHealth(MAX_HEALTH);
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            Heal(10);
        }

        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        score.GetComponent<Text>().text = "Score: " + scoreValue;
    }

    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }

    // Added for Visual Indicators
    private IEnumerator VisualIndicator(Color color)
    {
        GetComponent<SpriteRenderer>().color = color;
        yield return new WaitForSeconds(0.15f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    public void Damage(int amount){

        if(amount <0){
            throw new System.ArgumentOutOfRangeException("Cannot have negative damage");
        }
        this.health -= amount;

        bloodBar.SetHealth(health);

        StartCoroutine(VisualIndicator(Color.red)); // Added for Visual Indicators

        if(health <= 0){
            Die();
        }
    }

    public void Heal(int amount){
        if(amount < 0){
            throw new System.ArgumentOutOfRangeException("Cannot have negative healing");
        }

        bool WouldBeOverMAXHEALTH = health + amount > MAX_HEALTH;
        StartCoroutine(VisualIndicator(Color.green)); // Added for Visual Indicators

        if(WouldBeOverMAXHEALTH){
            this.health = MAX_HEALTH;
        }else{
            this.health += amount;
        }    
    }

    private void Die(){
        Debug.Log("DEAD!!");
        Destroy(gameObject);
        SoundManager.instance.PlaySound(deathSound);
        GameOver();
        
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        BackgroundMusic.SetupBackGround();
        GameOverScreen.Setup();
    }

    public void Reset()
    {
        scoreValue = 0;
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if(secondsLeft < 10)
        {
            textDisplay.GetComponent<Text>().text = "00:0"+ secondsLeft;
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        }
        takingAway = false;

        if (secondsLeft == 0)
        {
            GameOver();
            Time.timeScale = 0f;
        }
    }
}