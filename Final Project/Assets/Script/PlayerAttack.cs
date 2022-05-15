using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAttack : MonoBehaviour
{
    private GameObject attackArea = default;

    private bool attacking = false;
    private float timeToAttack = 0.25f;
    private float timer = 0f;
    public Animator animator;
    public UnityEvent StopAttack;
    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("f"))
        {
            Attack();
            animator.SetBool("IsAttack",true);
        }

        if(attacking)
        {
            timer += Time.deltaTime;

            if(timer >= timeToAttack)
            {
                timer = 0;
                attacking = false;
                animator.SetBool("IsAttack",false);
                attackArea.SetActive(attacking);
            }

        }
    }

    public void NoAttack(){
        animator.SetBool("IsAttack",false);
    }

    private void Attack()
    {
        attacking = true;
        attackArea.SetActive(attacking);
    }
}