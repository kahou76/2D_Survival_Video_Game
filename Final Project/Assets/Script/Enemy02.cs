using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy02 : MonoBehaviour
{
    [SerializeField]
    private int damage = 10;
    [SerializeField]
    private float speed = 1.5f;

    [SerializeField]
    private EnemyData data;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player002");
        SetEnemyValues();
    }

    // Update is called once per frame
    void Update()
    {
        Swarm();
    }

    private void SetEnemyValues()
    {
        GetComponent<Health02>().SetHealth(data.hp, data.hp);
        damage = data.damage;
        speed = data.speed;
    }

    private void Swarm()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player002"))
        {
            if(collider.GetComponent<Health02>() != null)
            {
                collider.GetComponent<Health02>().Damage(damage);
                this.GetComponent<Health02>().Damage(10000);
            }
        }
    }
}