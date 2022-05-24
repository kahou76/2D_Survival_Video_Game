using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 20;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<BotHealth>() != null)
        {
            BotHealth health = collider.GetComponent<BotHealth>();
            health.Damage(damage);
        }
    }
}