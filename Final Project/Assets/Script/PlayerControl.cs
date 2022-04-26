using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private bool isMoving;
    private Vector2 input;
    private Vector2 moveDirection;


    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
            // if(!isMoving){
            //     input.x = Input.GetAxisRaw("Horizontal");
            //     input.y = Input.GetAxisRaw("Vertical");

            //     if( input != Vector2.zero){
            //         var targetPos = transform.position;
            //         targetPos.x += input.x;
            //         targetPos.y += input.y;

            //         StartCoroutine(Move(targetPos));
            //     }

            // }
        ProcessInputs();
        
    }

    // IEnumerator Move(Vector3 targetPos){

    //     isMoving = true;

    //     while((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon){
    //         transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
    //         yield return null;
    //     }
    //     transform.position = targetPos;
    // }

    void FixedUpdate() {
        //physics calculations
        Move();
    }

    void ProcessInputs(){
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX,moveY);
    }


    void Move(){
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    
}
