using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int damage = 10;
    [SerializeField]
    private float speed = 1.5f;

    [SerializeField]
    private EnemyData data;

    private GameObject player;
    private float stunTimer = 0f;
    public BotHealth bothealth;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SetEnemyValues();
    }

    // Update is called once per frame
    void Update()
    {
        Swarm();
    }

    private void SetEnemyValues()
    {
        GetComponent<Health>().SetHealth(data.hp, data.hp);
        damage = data.damage;
        speed = data.speed;
    }

    private void Swarm()
    {

            if(stunTimer <= 0) {
                // Normal Behaviour
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            }
            else {
                stunTimer -= Time.deltaTime;
                // I am stunned.
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * 0);
            }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            if(collider.GetComponent<Health>() != null)
            {
                collider.GetComponent<Health>().Damage(damage);
                this.GetComponent<BotHealth>().Damage(10000);
            }
        }
    }
    public void StunMe(float duration) {
        stunTimer = duration;
    }
}

// private float stunTimer;

// private void Update() {

//     if(stunTimer <= 0) {
//         // Normal Behaviour
//     }
//     else {
//         stunTimer -= Time.deltaTime;
//         // I am stunned.
//     }
// }
// public void StunMe(float duration) {
//     stunTimer = duration;
// }